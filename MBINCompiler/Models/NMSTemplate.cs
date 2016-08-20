using System;
using System.Linq;
using System.Collections;
using System.Xml;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Reflection;

using MBINCompiler.Models.Structs;

namespace MBINCompiler.Models
{
    public class NMSTemplate
    {
        private static Type[] NMSTemplateTypes;

        public static NMSTemplate TemplateFromName(string templateName)
        {
            if (NMSTemplateTypes == null || NMSTemplateTypes.Length <= 0)
            {
                NMSTemplateTypes = Assembly.GetExecutingAssembly()
                    .GetTypes()
                    .Where(t => t.BaseType == typeof(NMSTemplate))
                    .ToArray();
            }


            var type = NMSTemplateTypes.FirstOrDefault(t => t.Name == templateName);

            if (type == null)
                return null; // Template type doesn't exist

            var ctor = type.GetConstructors().First();

            return ctor.Invoke(null) as NMSTemplate;
        }

        public static NMSTemplate DeserializeBinaryTemplate(BinaryReader reader, string templateName)
        {
            if (templateName.StartsWith("c") && templateName.Length > 1)
                templateName = templateName.Substring(1);

            NMSTemplate obj = TemplateFromName(templateName);

            if (obj == null)
                return null;

            long templatePosition = reader.BaseStream.Position;
            System.Diagnostics.Debug.Print(templateName + " position: " + templatePosition.ToString("X"));

            if (templateName == "VariableSizeString")
            {
                long stringPos = reader.ReadInt64();
                int stringLength = reader.ReadInt32();
                int unkC = reader.ReadInt32();
                reader.BaseStream.Position = templatePosition + stringPos;
                ((VariableSizeString)obj).Value = reader.ReadString(Encoding.UTF8, stringLength);
                reader.BaseStream.Position = templatePosition + 0x10;
                return obj;
            }

            var type = obj.GetType();
            var fields = type.GetFields();
            foreach (var field in fields)
            {
                var fieldAddr = reader.BaseStream.Position - templatePosition;
                var fieldName = field.Name;
                var fieldType = field.FieldType.Name;
                switch (fieldType)
                {
                    case "String":
                    case "Byte[]":
                        int size = 0;
                        foreach (var attr in field.CustomAttributes)
                        {
                            if (attr.AttributeType.Name != "MarshalAsAttribute")
                                continue;
                            foreach (var named in attr.NamedArguments)
                            {
                                if (named.MemberName != "SizeConst")
                                    continue;
                                size = (int)named.TypedValue.Value;
                            }
                        }

                        if (fieldType == "String")
                        {
                           // reader.Align(0x4, templatePosition);
                            var str = reader.ReadString(Encoding.UTF8, size, true);
                            field.SetValue(obj, str);
                        }
                        else
                        {
                            var str = reader.ReadBytes(size);
                            field.SetValue(obj, str);
                        }
                        break;
                    case "Single":
                        reader.Align(4, templatePosition);
                        field.SetValue(obj, reader.ReadSingle());
                        break;
                    case "Boolean":
                        field.SetValue(obj, reader.ReadByte() != 0);
                        break;
                    case "Int16":
                        reader.Align(2, templatePosition);
                        field.SetValue(obj, reader.ReadInt16());
                        break;
                    case "Int32":
                        reader.Align(4, templatePosition);
                        field.SetValue(obj, reader.ReadInt32());
                        break;
                    case "Int64":
                        reader.Align(8, templatePosition);
                        field.SetValue(obj, reader.ReadInt64());
                        break;
                    case "List`1":
                        reader.Align(8, templatePosition);
                        if (field.FieldType.IsGenericType && field.FieldType.GetGenericTypeDefinition() == typeof(List<>))
                        {
                            Type itemType = field.FieldType.GetGenericArguments()[0]; // use this...
                            if (itemType == typeof(NMSTemplate))
                                field.SetValue(obj, DeserializeGenericList(reader, templatePosition));
                            else
                            {
                                // todo: get rid of this nastiness
                                MethodInfo method = typeof(NMSTemplate).GetMethod("DeserializeList", BindingFlags.Static | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                                                             .MakeGenericMethod(new Type[] { itemType });
                                var list = method.Invoke(null, new object[] { reader, templatePosition });
                                field.SetValue(obj, list);
                            }
                        }

                        break;
                    default:
                        if (fieldType == "Colour") // unsure if this is needed?
                            reader.Align(0x10, templatePosition);
                        // todo: align for VariableSizeString?

                        var data = DeserializeBinaryTemplate(reader, fieldType);
                        if (data != null)
                            field.SetValue(obj, data);
                        break;
                }
            }

            return obj;
        }

        public static List<NMSTemplate> DeserializeGenericList(BinaryReader reader, long templateStartOffset)
        {
            long listPosition = reader.BaseStream.Position;
            System.Diagnostics.Debug.WriteLine("DeserializeGenericList start 0x" + listPosition.ToString("X"));

            long templateNamesOffset = reader.ReadInt64(); // TODO: USE THIS!
            int numTemplates = reader.ReadInt32();
            uint listMagic = reader.ReadUInt32();
            if (listMagic != 0xAAAAAA01)
                throw new Exception("Invalid generic list read, magic 0x" + listMagic.ToString("X") + " expected 0xAAAAAA01");

            long listEndPosition = reader.BaseStream.Position;

            reader.BaseStream.Position = listPosition + templateNamesOffset;
            var list = new List<NMSTemplate>();
            if (numTemplates > 0)
            {
                Dictionary<long, string> templates = new Dictionary<long, string>();
                for (int i = 0; i < numTemplates; i++)
                {
                    long nameOffset = reader.BaseStream.Position;
                    long templateOffset = reader.ReadInt64();
                    var name = reader.ReadString(Encoding.UTF8, 0x40, true);
                    if (templateOffset == 0)
                        continue; // wtf? seen in METADATA\UI\HUD\WEAPONS\LASER.MBIN @ 0x2A8, numTemplates = 4 but only 1 is set?

                    templates.Add(nameOffset + templateOffset, name);
                }

                long pos = reader.BaseStream.Position;

                foreach (var templateInfo in templates)
                {
                    reader.BaseStream.Position = templateInfo.Key;
                    var template = DeserializeBinaryTemplate(reader, templateInfo.Value);
                    if (template == null)
                        throw new Exception("Failed to deserialize template " + templateInfo.Value + "!");

                    list.Add(template);
                }
            }

            reader.BaseStream.Position = listEndPosition;
            reader.Align(0x8, templateStartOffset);

            return list;
        }

        public static List<T> DeserializeList<T>(BinaryReader reader, long templateStartOffset)
        {
            long listPosition = reader.BaseStream.Position;
            System.Diagnostics.Debug.WriteLine("DeserializeList start 0x" + listPosition.ToString("X"));

            long listStartOffset = reader.ReadInt64(); // TODO: USE THIS!
            int numEntries = reader.ReadInt32();
            uint listMagic = reader.ReadUInt32();
            if (listMagic != 0xAAAAAA01)
                throw new Exception("Invalid list read, magic 0x" + listMagic.ToString("X") + " expected 0xAAAAAA01");

            long listEndPosition = reader.BaseStream.Position;

            reader.BaseStream.Position = listPosition + listStartOffset;
            var list = new List<T>();
            for (int i = 0; i < numEntries; i++)
            {
                var template = DeserializeBinaryTemplate(reader, typeof(T).Name);
                if(template == null)
                    throw new Exception("Failed to deserialize template " + typeof(T).Name + "!");

                list.Add((T)(object)template);
            }

            reader.BaseStream.Position = listEndPosition;
            reader.Align(0x8, templateStartOffset);

            return list;
        }

        public string SerializeToXml()
        {
            var xmlDoc = new XmlDocument();
            var el = AppendToXml(null, xmlDoc);

            var xmlSettings = new XmlWriterSettings();
            xmlSettings.Indent = true;
            using (var stringWriter = new StringWriter())
            using (var xmlTextWriter = XmlWriter.Create(stringWriter, xmlSettings))
            {
                xmlDoc.WriteTo(xmlTextWriter);
                xmlTextWriter.Flush();
                return stringWriter.GetStringBuilder().ToString();
            }
        }
        
        public XmlElement AppendToXml(XmlElement parentElement, XmlDocument document)
        {
            XmlElement el = null;
            if (parentElement != null)
                el = (XmlElement)parentElement.AppendChild(document.CreateElement("Data"));
            else
                el = (XmlElement)document.AppendChild(document.CreateElement("Data"));

            var type = GetType();
            el.SetAttribute("template", type.Name);

            var fields = type.GetFields();
            foreach (var field in fields)
            {
                if (field.Name.StartsWith("Padding"))
                    continue;
                var fieldName = field.Name;
                var fieldType = field.FieldType.Name;

                switch (fieldType)
                {
                    case "String":
                    case "Single":
                    case "Boolean":
                    case "Int16":
                    case "Int32":
                        var prop = (XmlElement)el.AppendChild(document.CreateElement("Property"));
                        prop.SetAttribute("name", fieldName);
                        var value = field.GetValue(this).ToString();
                        var valuesMethod = type.GetMethod(field.Name + "Values"); // if we have an "xxxValues()" method in the struct, use that to get the value name
                        if (valuesMethod != null)
                        {
                            string[] values = (string[])valuesMethod.Invoke(this, null);
                            value = values[(int)field.GetValue(this)];
                        }
                        prop.SetAttribute("value", value);
                        break;

                    case "Byte[]":
                        break; // todo
                    case "List`1":
                        var prop2 = (XmlElement)el.AppendChild(document.CreateElement("Property"));
                        prop2.SetAttribute("name", fieldName);

                        IList templates = (IList)field.GetValue(this);
                        foreach (var template in templates)
                            ((NMSTemplate)template).AppendToXml(prop2, document);

                        break;

                    default:
                        if (field.FieldType.BaseType.Name == "NMSTemplate")
                        {
                            NMSTemplate template = (NMSTemplate)field.GetValue(this);
                            var element = template.AppendToXml(el, document);
                            element.SetAttribute("name", fieldName);
                        }
                        break;
                }
            }

            return el;
        }
    }
}