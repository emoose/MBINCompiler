using System;
using System.Linq;
using System.Collections;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Diagnostics;
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
            var fields = type.GetFields().OrderBy(field => field.MetadataToken); // hack to get fields in order of declaration (todo: use something less hacky, this might break mono?)
            foreach (var field in fields)
            {
                NMSAttribute settings = field.GetCustomAttribute<NMSAttribute>();
                if (settings == null)
                {
                    settings = new NMSAttribute();
                }
                var fieldAddr = reader.BaseStream.Position - templatePosition;
                var fieldName = field.Name;
                var fieldType = field.FieldType.Name;
                switch (fieldType)
                {
                    case "String":
                    case "Byte[]":
                        int size = settings.Size;

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
                    case "NMSTemplate":
                        reader.Align(8, 0);
                        long startPos = reader.BaseStream.Position;
                        long offset = reader.ReadInt64();
                        string name = reader.ReadString(Encoding.ASCII, 0x40, true);
                        long endPos = reader.BaseStream.Position;

                        if (offset != 0 && !String.IsNullOrEmpty(name))
                        {
                            reader.BaseStream.Position = startPos + offset;
                            NMSTemplate val = DeserializeBinaryTemplate(reader, name);
                            if (val == null)
                                throw new Exception("Failed to deserialize template " + name + "!");

                            field.SetValue(obj, val);
                        }
                        reader.BaseStream.Position = endPos;
                        break;
                    default:
                        if (fieldType == "Colour") // unsure if this is needed?
                            reader.Align(0x10, 0);
                        // todo: align for VariableSizeString?
                        if (field.FieldType.IsArray && field.FieldType.GetElementType().BaseType.Name == "NMSTemplate") 
                        {
                            var arrayType = field.FieldType.GetElementType();
                            Array array = Array.CreateInstance(arrayType, settings.Size);
                            for (int i = 0; i < settings.Size; ++i)
                            {
                                array.SetValue(DeserializeBinaryTemplate(reader, field.FieldType.GetElementType().Name), i);
                            }
                            field.SetValue(obj, array);
                        } 
                        else 
                        {
                            var data = DeserializeBinaryTemplate(reader, fieldType);
                            if (data != null)
                                field.SetValue(obj, data);
                        }
                        break;
                }
            }

            return obj;
        }

        public static List<NMSTemplate> DeserializeGenericList(BinaryReader reader, long templateStartOffset)
        {
            long listPosition = reader.BaseStream.Position;
            System.Diagnostics.Debug.WriteLine("DeserializeGenericList start 0x" + listPosition.ToString("X"));

            long templateNamesOffset = reader.ReadInt64();
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
        
        public void AppendToWriter(BinaryWriter writer, ref List<Tuple<long, object>> additionalData)
        {
            long templatePosition = writer.BaseStream.Position;
            Debug.Print($"[C] writing {GetType().Name} to offset 0x{templatePosition.ToString("X")}");

            var type = GetType();
            var fields = type.GetFields().OrderBy(field => field.MetadataToken); // hack to get fields in order of declaration (todo: use something less hacky, this might break mono?)

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
                            // write empty list header
                            long listPos = writer.BaseStream.Position;
                            writer.Write((Int64)0); // listPosition
                            writer.Write((Int32)0); // listCount
                            writer.Write((UInt32)0xAAAAAA01);

                            var list = (IList)field.GetValue(this);
                            additionalData.Add(new Tuple<long, object>(listPos, list));
                        }

                        break;
                    case "NMSTemplate":
                        writer.Align(8, 0);
                        long refPos = writer.BaseStream.Position;
                        writer.Write((Int64)0); // listPosition
                        var template = (NMSTemplate)field.GetValue(this);
                        if (template == null)
                        {
                            writer.WriteString("", Encoding.UTF8, 0x40);
                        } 
                        else 
                        {
                            writer.WriteString("c" + template.GetType().Name, Encoding.UTF8, 0x40);
                            additionalData.Add(new Tuple<long, object>(refPos, template));
                        }
                        break;
                    default:

                        if (fieldType == "Colour") // unsure if this is needed?
                            writer.Align(0x10, 0);

                        // todo: align for VariableSizeString?
                        if (fieldType == "VariableSizeString")
                        {
                            // write empty DynamicString header
                            long fieldPos = writer.BaseStream.Position;
                            writer.Write((Int64)0); // listPosition
                            writer.Write((Int32)0); // listCount
                            writer.Write((UInt32)0xAAAAAA01);

                            var fieldValue = (VariableSizeString)field.GetValue(this);
                            additionalData.Add(new Tuple<long, object>(fieldPos, fieldValue));
                        }
                        else if (field.FieldType.IsArray && field.FieldType.GetElementType().BaseType.Name == "NMSTemplate") 
                        {
                            var arrayType = field.FieldType.GetElementType();
                            Array array = (Array)field.GetValue(this);
                            foreach (var obj in array)
                            {
                                ((NMSTemplate)obj).AppendToWriter(writer, ref additionalData);
                            }
                        }
                        else
                        {
                            var obj = field.GetValue(this);
                            if (obj.GetType().BaseType == typeof(NMSTemplate))
                                ((NMSTemplate)obj).AppendToWriter(writer, ref additionalData);
                            else
                                throw new Exception($"[C] Unknown type {fieldType} not NMSTemplate for {fieldName}");
                        }

                        break;
                }
            }
        }

        public void SerializeGenericList(BinaryWriter writer, IList list, long listHeaderPosition, ref List<Tuple<long, object>> additionalData)
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
                template.AppendToWriter(writer, ref additionalData);
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

        public void SerializeList(BinaryWriter writer, IList list, long listHeaderPosition, ref List<Tuple<long, object>> additionalData)
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

            writer.BaseStream.Position = listPosition;

            foreach (var entry in list)
            {
                var template = (NMSTemplate)entry;
                template.AppendToWriter(writer, ref additionalData);
            }
        }

        public byte[] SerializeBytes()
        {
            using (var stream = new MemoryStream())
            using (var writer = new BinaryWriter(stream, Encoding.ASCII))
            {
                var additionalData = new List<Tuple<long, object>>();

                // write primary template + any embedded templates
                AppendToWriter(writer, ref additionalData);

                // now write values of lists etc
                for(int i = 0; i < additionalData.Count; i++)
                {
                    var data = additionalData[i];
                    //writer.BaseStream.Position = additionalDataOffset; // addtDataOffset gets updated by child templates
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
                    else if (data.Item2.GetType().BaseType == typeof(NMSTemplate)) 
                    {
                        var pos = writer.BaseStream.Position;
                        var template = (NMSTemplate)data.Item2;
                        template.AppendToWriter(writer, ref additionalData);
                        var endPos = writer.BaseStream.Position;
                        writer.BaseStream.Position = data.Item1;
                        writer.Write(pos - data.Item1);
                        writer.WriteString(template.GetType().Name, Encoding.UTF8, 0x40);
                        writer.BaseStream.Position = endPos;
                    }
                    else if (data.Item2.GetType().IsGenericType && data.Item2.GetType().GetGenericTypeDefinition() == typeof(List<>))
                    {
                        Type itemType = data.Item2.GetType().GetGenericArguments()[0];
                        if (itemType == typeof(NMSTemplate))
                            SerializeGenericList(writer, (IList)data.Item2, data.Item1, ref additionalData);
                        else
                            SerializeList(writer, (IList)data.Item2, data.Item1, ref additionalData);
                    }
                    else
                        throw new Exception($"[C] Unknown type {data.Item2.GetType()} in additionalData list!");
                }

                return stream.ToArray();
            }
        }
        public EXmlData SerializeEXml()
        {
            Type type = GetType();
            EXmlData xmlData = new EXmlData
            {
                Template = type.Name
            };

            var fields = type.GetFields().OrderBy(field => field.MetadataToken); // hack to get fields in order of declaration (todo: use something less hacky, this might break mono?)

            foreach (var field in fields)
            {
                NMSAttribute settings = field.GetCustomAttribute<NMSAttribute>();
                if (settings == null)
                {
                    settings = new NMSAttribute();
                }
                if (settings.Ignore)
                    continue;
                var fieldName = field.Name;
                var fieldType = field.FieldType.Name;

                switch (fieldType)
                {
                    case "String":
                    case "Single":
                    case "Boolean":
                    case "Int16":
                    case "UInt16":
                    case "Int32":
                    case "UInt32":
                    case "Int64":
                    case "UInt64":
                        var value = field.GetValue(this);
                        var valueStr = value.ToString();
                        var valuesMethod = type.GetMethod(field.Name + "Values"); // if we have an "xxxValues()" method in the struct, use that to get the value name
                        if (valuesMethod != null)
                        {
                            if (((int)value) == -1)
                                valueStr = "";
                            else
                            {
                                string[] values = (string[])valuesMethod.Invoke(this, null);
                                valueStr = values[(int)value];
                            }
                        }
                        else if (settings.EnumValue != null)
                        {
                            if (((int)value) == -1)
                                valueStr = "";
                            else
                            {
                                valueStr = settings.EnumValue[(int)value];
                            }
                        }

                        xmlData.Elements.Add(new EXmlProperty
                        {
                            Name = fieldName,
                            Value = valueStr
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
                    case "NMSTemplate":
                        if (field.GetValue(this) != null)
                        {
                            NMSTemplate template = (NMSTemplate)field.GetValue(this);

                            EXmlData templateXmlData = template.SerializeEXml();
                            templateXmlData.Name = fieldName;

                            xmlData.Elements.Add(templateXmlData);
                        }
                        break;
                    default:
                        if (field.FieldType.BaseType.Name == "NMSTemplate") 
                        {
                            NMSTemplate template = (NMSTemplate)field.GetValue(this);

                            EXmlData templateXmlData = template.SerializeEXml();
                            templateXmlData.Name = fieldName;

                            xmlData.Elements.Add(templateXmlData);
                        } 
                        else if (field.FieldType.IsArray && field.FieldType.GetElementType().BaseType.Name == "NMSTemplate") 
                        {
                            var arrayType = field.FieldType.GetElementType();
                            EXmlProperty arrayProperty = new EXmlProperty
                            {
                                Name = fieldName
                            };

                            Array array = (Array)field.GetValue(this);
                            int i = 0;
                            foreach (var template in array)
                            {
                                EXmlData data = ((NMSTemplate)template).SerializeEXml();
                                if (settings.EnumValue != null)
                                {
                                    data.Name = settings.EnumValue[i];
                                    i++;
                                }
                                arrayProperty.Elements.Add(data);
                            }

                            xmlData.Elements.Add(arrayProperty);
                        }
                        else 
                        {
                            throw new Exception(string.Format("Unable to encode {0} to EXml!", field));
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
            var templateFields = templateType.GetFields().OrderBy(field => field.MetadataToken); // hack to get fields in order of declaration (todo: use something less hacky, this might break mono?)

            foreach(var templateField in templateFields)
            {
                NMSAttribute settings = templateField.GetCustomAttribute<NMSAttribute>();
                if(settings == null)
                    break;
                if(settings.DefaultValue != null)
                    templateField.SetValue(template, settings.DefaultValue);
            }

            foreach (var xmlProperty in xmlData.Elements.OfType<EXmlProperty>())
            {
                FieldInfo field = templateType.GetField(xmlProperty.Name);
                Type fieldType = field.FieldType;
                NMSAttribute settings = field.GetCustomAttribute<NMSAttribute>();
                if (settings == null)
                  settings = new NMSAttribute();
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
                            if (String.IsNullOrEmpty(xmlProperty.Value))
                                fieldValue = (int)-1;
                            else
                            {
                                string[] values = (string[])valuesMethod.Invoke(template, null);
                                fieldValue = Array.FindIndex(values, v => v == xmlProperty.Value);
                            }
                        }
                        else if(settings.EnumValue != null)
                        {
                            if (String.IsNullOrEmpty(xmlProperty.Value))
                                fieldValue = (int)-1;
                            else
                            {
                                fieldValue = Array.FindIndex(settings.EnumValue, v => v == xmlProperty.Value);
                            }
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
                        if (field.FieldType.IsArray && field.FieldType.GetElementType().BaseType.Name == "NMSTemplate")
                        {
                            Array array = Array.CreateInstance(field.FieldType.GetElementType(), settings.Size);
                            List<EXmlData> data = xmlProperty.Elements.OfType<EXmlData>().ToList();
                            for (int i = 0; i < data.Count; ++i) 
                            {
                                NMSTemplate element = DeserializeEXml(data[i]);
                                array.SetValue(element, i);
                            }

                            fieldValue = array;
                        } 
                        else 
                        {
                            fieldValue = fieldType.IsValueType ? Activator.CreateInstance(fieldType) : null;
                        }
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
