using System;
using System.Linq;
using System.Collections;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Reflection;

using MBINCompiler.Models.Structs;

namespace MBINCompiler.Models
{
    public class NMSTemplate
    {
        private static readonly Dictionary<string, Type> NMSTemplateMap = Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(t => t.BaseType == typeof(NMSTemplate))
                .ToDictionary(t => t.Name);

        public static NMSTemplate TemplateFromName(string templateName)
        {
            Type type;
            if (!NMSTemplateMap.TryGetValue(templateName, out type))
            {
                return null; // Template type doesn't exist
            }

            return Activator.CreateInstance(type) as NMSTemplate;
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
                        reader.Align(4, 0);
                        field.SetValue(obj, reader.ReadSingle());
                        break;
                    case "Boolean":
                        field.SetValue(obj, reader.ReadByte() != 0);
                        break;
                    case "Int16":
                        reader.Align(2, 0);
                        field.SetValue(obj, reader.ReadInt16());
                        break;
                    case "Int32":
                        reader.Align(4, 0);
                        field.SetValue(obj, reader.ReadInt32());
                        break;
                    case "Int64":
                        reader.Align(8, 0);
                        field.SetValue(obj, reader.ReadInt64());
                        break;
                    case "List`1":
                        reader.Align(8, 0);
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
                            reader.Align(0x10, 0);
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
            reader.Align(0x8, 0);

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
                if (template == null)
                    throw new Exception("Failed to deserialize template " + typeof(T).Name + "!");

                list.Add((T)(object)template);
            }

            reader.BaseStream.Position = listEndPosition;
            reader.Align(0x8, 0);

            return list;
        }
        
        public EXmlData SerializeEXml()
        {
            Type type = GetType();
            EXmlData xmlData = new EXmlData
            {
                Template = type.Name
            };

            foreach (var field in type.GetFields())
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
                        var value = field.GetValue(this).ToString();
                        var valuesMethod = type.GetMethod(field.Name + "Values"); // if we have an "xxxValues()" method in the struct, use that to get the value name
                        if (valuesMethod != null)
                        {
                            string[] values = (string[])valuesMethod.Invoke(this, null);
                            value = values[(int)field.GetValue(this)];
                        }

                        xmlData.Elements.Add(new EXmlProperty
                        {
                            Name = fieldName,
                            Value = value
                        });
                        break;

                    case "Byte[]":
                        byte[] bytes = (byte[])field.GetValue(this);
                        string base64Value = bytes == null ? null : Convert.ToBase64String(bytes);
                        
                        xmlData.Elements.Add(new EXmlProperty
                        {
                            Name = fieldName,
                            Value = base64Value
                        });
                        break;
                    case "List`1":
                        EXmlProperty listProperty = new EXmlProperty
                        {
                            Name = fieldName
                        };

                        IList templates = (IList)field.GetValue(this);
                        foreach (var template in templates.Cast<NMSTemplate>())
                        {
                            listProperty.Elements.Add(template.SerializeEXml());
                        }

                        xmlData.Elements.Add(listProperty);
                        break;
                    default:
                        if (field.FieldType.BaseType.Name == "NMSTemplate")
                        {
                            NMSTemplate template = (NMSTemplate)field.GetValue(this);

                            EXmlData templateXmlData = template.SerializeEXml();
                            templateXmlData.Name = fieldName;

                            xmlData.Elements.Add(templateXmlData);
                        }

                        break;
                }
            }

            return xmlData;
        }

        public static NMSTemplate DeserializeEXml(EXmlData xmlData)
        {
            NMSTemplate template = TemplateFromName(xmlData.Template);
            Type templateType = template.GetType();
            foreach (var xmlProperty in xmlData.Elements.OfType<EXmlProperty>())
            {
                FieldInfo field = templateType.GetField(xmlProperty.Name);
                Type fieldType = field.FieldType;
                object fieldValue;
                switch (fieldType.Name)
                {
                    case "String":
                        fieldValue = xmlProperty.Value;
                        break;
                    case "Single":
                        fieldValue = float.Parse(xmlProperty.Value);
                        break;
                    case "Boolean":
                        fieldValue = bool.Parse(xmlProperty.Value);
                        break;
                    case "Int16":
                        fieldValue = short.Parse(xmlProperty.Value);
                        break;
                    case "Int32":
                        var valuesMethod = templateType.GetMethod(field.Name + "Values");
                        if (valuesMethod != null)
                        {
                            string[] values = (string[])valuesMethod.Invoke(template, null);
                            fieldValue = Array.FindIndex(values, v => v == xmlProperty.Value);
                        }
                        else
                        {
                            fieldValue = int.Parse(xmlProperty.Value);
                        }
                        break;
                    case "Int64":
                        fieldValue = long.Parse(xmlProperty.Value);
                        break;
                    case "Byte[]":
                        fieldValue = xmlProperty.Value == null ? null : Convert.FromBase64String(xmlProperty.Value);
                        break;
                    case "List`1":
                        Type elementType = fieldType.GetGenericArguments()[0];
                        Type listType = typeof(List<>).MakeGenericType(elementType);
                        IList list = (IList)Activator.CreateInstance(listType);
                        foreach (EXmlData innerXmlData in xmlProperty.Elements.OfType<EXmlData>())
                        {
                            NMSTemplate element = DeserializeEXml(innerXmlData);
                            list.Add(element);
                        }

                        fieldValue = list;
                        break;
                    default:
                        fieldValue = fieldType.IsValueType ? Activator.CreateInstance(fieldType) : null;
                        break;
                }

                field.SetValue(template, fieldValue);
            }

            foreach (EXmlData innerXmlData in xmlData.Elements.OfType<EXmlData>())
            {
                FieldInfo field = templateType.GetField(innerXmlData.Name);
                NMSTemplate innerTemplate = DeserializeEXml(innerXmlData);
                field.SetValue(template, innerTemplate);
            }

            return template;
        }
    }
}