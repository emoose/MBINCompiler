using System;
using System.Linq;
using System.Collections;
using System.Xml;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Reflection;
using System.Diagnostics;

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
            Debug.Print(templateName + " position: " + templatePosition.ToString("X"));

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
                    case "UInt16":
                        reader.Align(2, 0);
                        field.SetValue(obj, fieldType == "Int16" ? reader.ReadInt16() : (object)reader.ReadUInt16());
                        break;
                    case "Int32":
                    case "UInt32":
                        reader.Align(4, 0);
                        field.SetValue(obj, fieldType == "Int32" ? reader.ReadInt32() : (object)reader.ReadUInt32());
                        break;
                    case "Int64":
                    case "UInt64":
                        reader.Align(8, 0);
                        field.SetValue(obj, fieldType == "Int64" ? reader.ReadInt64() : (object)reader.ReadUInt64());
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
            Debug.WriteLine("DeserializeGenericList start 0x" + listPosition.ToString("X"));

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
            Debug.WriteLine("DeserializeList start 0x" + listPosition.ToString("X"));

            long listStartOffset = reader.ReadInt64();
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

        public string SerializeToXml()
        {
            var xmlDoc = new XmlDocument();
            var el = AppendToXml(null, xmlDoc);

            var xmlSettings = new XmlWriterSettings();
            xmlSettings.Indent = true;
            xmlSettings.Encoding = Encoding.UTF8;
            using (var stringWriter = new EncodedStringWriter(Encoding.UTF8))
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
                    case "Int64":
                    case "UInt16":
                    case "UInt32":
                    case "UInt64":
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
                        byte[] bytes = (byte[])field.GetValue(this);
                        string base64Value = bytes == null ? null : Convert.ToBase64String(bytes);
                        var prop2 = (XmlElement)el.AppendChild(document.CreateElement("Property"));
                        prop2.SetAttribute("name", fieldName);
                        prop2.SetAttribute("value", base64Value);
                        break;
                    case "List`1":
                        var prop3 = (XmlElement)el.AppendChild(document.CreateElement("Property"));
                        prop3.SetAttribute("name", fieldName);

                        IList templates = (IList)field.GetValue(this);
                        foreach (var template in templates)
                            ((NMSTemplate)template).AppendToXml(prop3, document);

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

        public static NMSTemplate DeserializeXml(EXmlData xmlData)
        {
            NMSTemplate template = TemplateFromName(xmlData.Template);
            Type templateType = template.GetType();
            foreach (var xmlProperty in xmlData.Properties)
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
                    case "UInt16":
                        fieldValue = fieldType.Name == "Int16" ? short.Parse(xmlProperty.Value) : (object)ushort.Parse(xmlProperty.Value);
                        break;
                    case "Int32":
                    case "UInt32":
                        var valuesMethod = templateType.GetMethod(field.Name + "Values");
                        if (valuesMethod != null)
                        {
                            string[] values = (string[])valuesMethod.Invoke(template, null);
                            fieldValue = Array.FindIndex(values, v => v == xmlProperty.Value);
                        }
                        else
                        {
                            fieldValue = fieldType.Name == "Int32" ? int.Parse(xmlProperty.Value) : (object)uint.Parse(xmlProperty.Value);
                        }
                        break;
                    case "Int64":
                    case "UInt64":
                        fieldValue = fieldType.Name == "Int64" ? long.Parse(xmlProperty.Value) : (object)ulong.Parse(xmlProperty.Value);
                        break;
                    case "Byte[]":
                        fieldValue = xmlProperty.Value == null ? null : Convert.FromBase64String(xmlProperty.Value);
                        break;
                    case "List`1":
                        Type elementType = fieldType.GetGenericArguments()[0];
                        Type listType = typeof(List<>).MakeGenericType(elementType);
                        IList list = (IList)Activator.CreateInstance(listType);
                        foreach (EXmlData innerXmlData in xmlProperty.Data)
                        {
                            NMSTemplate element = DeserializeXml(innerXmlData);
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

            foreach (EXmlData innerXmlData in xmlData.Data)
            {
                FieldInfo field = templateType.GetField(innerXmlData.Name);
                NMSTemplate innerTemplate = DeserializeXml(innerXmlData);
                field.SetValue(template, innerTemplate);
            }

            return template;
        }

        public void SerializeGenericList(BinaryWriter writer, IList list, long listHeaderPosition, ref long additionalDataOffset, ref List<Tuple<long, object>> additionalData)
        {
            long listPosition = writer.BaseStream.Position;
            Debug.WriteLine($"SerializeList start 0x{listPosition.ToString("X")}, header 0x{listHeaderPosition}");

            writer.BaseStream.Position = listHeaderPosition;

            // write the list header into the template
            if (list.Count > 0)
                writer.Write(listPosition - listHeaderPosition);
            else
                writer.Write((long)0); // lists with 0 entries have offset set to 0

            writer.Write((Int32)list.Count);
            writer.Write((UInt32)0xAAAAAA01);

            // reserve space for list offsets+names
            writer.BaseStream.Position = listPosition;
            writer.Write(new byte[list.Count * 0x48]);
            writer.Align(0x10, 0); // why

            var entryOffsetNamePairs = new Dictionary<long, string>();
            foreach (var entry in list)
            {
                entryOffsetNamePairs.Add(writer.BaseStream.Position, entry.GetType().Name);
                var template = (NMSTemplate)entry;
                var addtData = new Dictionary<long, object>();
                template.AppendToWriter(writer, ref additionalDataOffset, ref additionalData);
            }

            long dataEndOffset = writer.BaseStream.Position;

            writer.BaseStream.Position = listPosition;
            foreach (var entry in entryOffsetNamePairs)
            {
                var position = writer.BaseStream.Position;
                var offset = entry.Key - position; // get offset of this entry from the current offset
                writer.Write(offset);
                writer.WriteString("c" + entry.Value, Encoding.UTF8, 0x40);
            }

            writer.BaseStream.Position = dataEndOffset;
        }

        public void SerializeList(BinaryWriter writer, IList list, long listHeaderPosition, ref long additionalDataOffset, ref List<Tuple<long, object>> additionalData)
        {
           /* Type elementType = list.GetType().GetGenericArguments()[0];
            if (elementType == typeof(NMSString0x10) || elementType == typeof(NMSString0x80))
                writer.Align(0x8, 0); // strings are aligned 8 instead of 10, ask sean why
            else
                writer.Align(0x10, 0);*/

            long listPosition = writer.BaseStream.Position;
            Debug.WriteLine($"SerializeList start 0x{listPosition.ToString("X")}, header 0x{listHeaderPosition}");

            writer.BaseStream.Position = listHeaderPosition;

            // write the list header into the template
            if (list.Count > 0)
                writer.Write(listPosition - listHeaderPosition);
            else
                writer.Write((long)0); // lists with 0 entries have offset set to 0
            writer.Write((Int32)list.Count);
            writer.Write((UInt32)0xAAAAAA01);

            writer.BaseStream.Position = listPosition;

            foreach (var entry in list)
            {
                var template = (NMSTemplate)entry;
                template.AppendToWriter(writer, ref additionalDataOffset, ref additionalData);

                /*if (elementType == typeof(NMSString0x10) || elementType == typeof(NMSString0x80))
                    writer = writer;// writer.Align(0x8, 0); // strings are aligned 8 instead of 10, ask sean why
                else
                    writer.Align(0x10, 0);*/
            }
        }

        public byte[] SerializeToBytes()
        {
            using (var stream = new MemoryStream())
            using (var writer = new BinaryWriter(stream, Encoding.ASCII))
            {
                long addtOffset = 0;
                var addtData = new List<Tuple<long, object>>();
                AppendToWriter(writer, ref addtOffset, ref addtData);
                return stream.ToArray();
            }
        }

        public void AppendToWriter(BinaryWriter writer, ref long additionalDataOffset, ref List<Tuple<long, object>> additionalData)
        {
            long templatePosition = writer.BaseStream.Position;
            Debug.Print($"[C] writing {GetType().Name} to offset 0x{templatePosition.ToString("X")}");

            bool writeAddtData = additionalDataOffset == 0;
            additionalDataOffset = 1; // stop child templates from writing addt data

            var type = GetType();
            var fields = type.GetFields();

            foreach (var field in fields)
            {
                var fieldAddr = writer.BaseStream.Position - templatePosition;
                var fieldName = field.Name;
                var fieldType = field.FieldType.Name;
                var fieldData = field.GetValue(this);
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
                            writer.WriteString((string)fieldData, Encoding.UTF8, size, true);
                        }
                        else
                        {
                            byte[] bytes = (byte[])fieldData;
                            Array.Resize(ref bytes, size);
                            writer.Write(bytes);
                        }
                        break;
                    case "Single":
                        writer.Align(4, 0);
                        writer.Write((Single)fieldData);
                        break;
                    case "Boolean":
                        var value = (bool)field.GetValue(this);
                        writer.Write(value ? (byte)1 : (byte)0);
                        break;
                    case "Int16":
                    case "UInt16":
                        writer.Align(2, 0);
                        if (fieldType == "Int16")
                            writer.Write((Int16)fieldData);
                        else
                            writer.Write((UInt16)fieldData);
                        break;
                    case "Int32":
                    case "UInt32":
                        writer.Align(4, 0);
                        if (fieldType == "Int32")
                            writer.Write((Int32)fieldData);
                        else
                            writer.Write((UInt32)fieldData);
                        break;
                    case "Int64":
                    case "UInt64":
                        writer.Align(8, 0);
                        if (fieldType == "Int64")
                            writer.Write((Int64)fieldData);
                        else
                            writer.Write((UInt64)fieldData);
                        break;
                    case "List`1":
                        writer.Align(8, 0);
                        if (field.FieldType.IsGenericType && field.FieldType.GetGenericTypeDefinition() == typeof(List<>))
                        {
                            long listPos = writer.BaseStream.Position;
                            writer.Write((Int64)0); // listPosition
                            writer.Write((Int32)0); // listCount
                            writer.Write((UInt32)0xAAAAAA01);

                            var list = (IList)field.GetValue(this);

                            additionalData.Add(new Tuple<long, object>(listPos, list));
                        }

                        break;
                    default:

                        if (fieldType == "Colour") // unsure if this is needed?
                            writer.Align(0x10, 0);

                        // todo: align for VariableSizeString?
                        if (fieldType == "VariableSizeString")
                        {
                            long fieldPos = writer.BaseStream.Position;
                            writer.Write((Int64)0); // listPosition
                            writer.Write((Int32)0); // listCount
                            writer.Write((UInt32)0xAAAAAA01);
                            var fieldValue = (VariableSizeString)field.GetValue(this);
                            additionalData.Add(new Tuple<long, object>(fieldPos, fieldValue));
                        }
                        else
                        {
                            var obj = field.GetValue(this);
                            if (obj.GetType().BaseType == typeof(NMSTemplate))
                                ((NMSTemplate)obj).AppendToWriter(writer, ref additionalDataOffset, ref additionalData);
                            else
                                throw new Exception($"[C] Unknown type {fieldType} not NMSTemplate for {fieldName}");
                        }

                        break;
                }
            }

            additionalDataOffset = writer.BaseStream.Position;

            if (!writeAddtData) // only primary template will write addt data
                return;

            // now serialize our lists/strings
            for (int i = 0; i < additionalData.Count; i++) // no foreach because this loop might add more to additionalData
            {
                var data = additionalData[i];
                writer.BaseStream.Position = additionalDataOffset; // addtDataOffset gets updated by child templates
                writer.Align(0x8, 0); // todo: check if this alignment is correct

                if (data.Item2.GetType() == typeof(VariableSizeString))
                {
                    var str = (VariableSizeString)data.Item2;

                    var stringPos = writer.BaseStream.Position;
                    writer.WriteString(str.Value, Encoding.UTF8);
                    var stringEndPos = writer.BaseStream.Position;

                    writer.BaseStream.Position = data.Item1;
                    writer.Write(stringPos - data.Item1);
                    writer.Write((Int32)str.Value.Length);
                    writer.Write((UInt32)0xAAAAAA01);

                    writer.BaseStream.Position = stringEndPos;
                }
                else if (data.Item2.GetType().IsGenericType && data.Item2.GetType().GetGenericTypeDefinition() == typeof(List<>))
                {
                    Type itemType = data.Item2.GetType().GetGenericArguments()[0];
                    if (itemType == typeof(NMSTemplate))
                        SerializeGenericList(writer, (IList)data.Item2, data.Item1, ref additionalDataOffset, ref additionalData);
                    else
                        SerializeList(writer, (IList)data.Item2, data.Item1, ref additionalDataOffset, ref additionalData);
                }
                else
                    throw new Exception($"[C] Unknown type {data.Item2.GetType()} in additionalData list!");
            }
        }

        private sealed class EncodedStringWriter : StringWriter
        {
            public EncodedStringWriter(Encoding encoding)
            {
                Encoding = encoding;
            }

            public override Encoding Encoding { get; }
        }
    }
}