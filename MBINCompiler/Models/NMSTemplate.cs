using System;
using System.Linq;
using System.Collections;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;

using MBINCompiler.Models.Structs;
using System.Runtime.InteropServices;

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

        public static object DeserializeValue(BinaryReader reader, Type field, NMSAttribute settings, long templatePosition, FieldInfo fieldInfo, NMSTemplate parent)
        {
            var template = parent.CustomDeserialize(reader, field, settings, templatePosition, fieldInfo);
            if (template != null)
                return template;

            var fieldType = field.Name;
            switch (fieldType)
            {
                case "String":
                case "Byte[]":
                    int size = settings?.Size ?? 0;
                    MarshalAsAttribute legacySettings = fieldInfo.GetCustomAttribute<MarshalAsAttribute>();
                    if(legacySettings != null)
                    {
                        size = legacySettings.SizeConst;
                    }

                    if (fieldType == "String")
                    {
                        // reader.Align(0x4, templatePosition);
                        var str = reader.ReadString(Encoding.UTF8, size, true);
                        return str;
                    }
                    else
                    {
                        var str = reader.ReadBytes(size);
                        return str;
                    }
                case "Single":
                    reader.Align(4, 0);
                    return reader.ReadSingle();
                case "Boolean":
                    return reader.ReadByte() != 0;
                case "Int16":
                case "UInt16":
                    reader.Align(2, 0);
                    return fieldType == "Int16" ? (object)reader.ReadInt16() : (object)reader.ReadUInt16();
                case "Int32":
                case "UInt32":
                    reader.Align(4, 0);
                    return fieldType == "Int32" ? (object)reader.ReadInt32() : (object)reader.ReadUInt32();
                case "Int64":
                case "UInt64":
                    reader.Align(8, 0);
                    return fieldType == "Int64" ? (object)reader.ReadInt64() : (object)reader.ReadUInt64();
                case "List`1":
                    reader.Align(8, 0);
                    if (field.IsGenericType && field.GetGenericTypeDefinition() == typeof(List<>))
                    {
                        Type itemType = field.GetGenericArguments()[0];
                        if (itemType == typeof(NMSTemplate))
                            return DeserializeGenericList(reader, templatePosition, parent);
                        else
                        {
                            // todo: get rid of this nastiness
                            MethodInfo method = typeof(NMSTemplate).GetMethod("DeserializeList", BindingFlags.Static | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                                                         .MakeGenericMethod(new Type[] { itemType });
                            var list = method.Invoke(null, new object[] { reader, fieldInfo, settings, templatePosition, parent });
                            return list;
                        }
                    }
                    return null;
                case "NMSTemplate":
                    reader.Align(8, 0);
                    long startPos = reader.BaseStream.Position;
                    long offset = reader.ReadInt64();
                    string name = reader.ReadString(Encoding.ASCII, 0x40, true);
                    long endPos = reader.BaseStream.Position;
                    NMSTemplate val = null;
                    if (offset != 0 && !String.IsNullOrEmpty(name))
                    {
                        reader.BaseStream.Position = startPos + offset;
                        val = DeserializeBinaryTemplate(reader, name);
                        if (val == null)
                            throw new Exception("Failed to deserialize template " + name + "!");
                    }
                    reader.BaseStream.Position = endPos;
                    return val;
                default:
                    if (fieldType == "Colour") // unsure if this is needed?
                        reader.Align(0x10, 0);
                    // todo: align for VariableSizeString?
                    if (field.IsArray)
                    {
                        var arrayType = field.GetElementType();
                        Array array = Array.CreateInstance(arrayType, settings.Size);
                        for (int i = 0; i < settings.Size; ++i)
                        {
                            array.SetValue(DeserializeValue(reader, field.GetElementType(), settings, templatePosition, fieldInfo, parent), i);
                        }
                        return array;
                    }
                    else
                    {
                        var data = DeserializeBinaryTemplate(reader, fieldType);
                        return data;
                    }
            }
        }

        public static NMSTemplate DeserializeBinaryTemplate(BinaryReader reader, string templateName)
        {
            if (templateName.StartsWith("c") && templateName.Length > 1)
                templateName = templateName.Substring(1);

            NMSTemplate obj = TemplateFromName(templateName);

            if (obj == null)
                return null;

            long templatePosition = reader.BaseStream.Position;
            Debug.WriteLine($"{templateName} position: 0x{templatePosition:X}");

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
                field.SetValue(obj, DeserializeValue(reader, field.FieldType, settings, templatePosition, field, obj));
            }

            return obj;
        }

        public static List<NMSTemplate> DeserializeGenericList(BinaryReader reader, long templateStartOffset, NMSTemplate parent)
        {
            long listPosition = reader.BaseStream.Position;
            Debug.WriteLine($"DeserializeGenericList start 0x{listPosition:X}");

            long templateNamesOffset = reader.ReadInt64();
            int numTemplates = reader.ReadInt32();
            uint listMagic = reader.ReadUInt32();
            if (listMagic != 0xAAAAAA01 && listMagic != 1)
                throw new Exception($"Invalid generic list read, magic 0x{listMagic:X} expected 0xAAAAAA01 / 0x1");

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
                        throw new Exception($"Failed to deserialize template {templateInfo.Value}!");

                    list.Add(template);
                }
            }

            reader.BaseStream.Position = listEndPosition;
            reader.Align(0x8, 0);

            return list;
        }

        public static List<T> DeserializeList<T>(BinaryReader reader, FieldInfo field, NMSAttribute settings, long templateStartOffset, NMSTemplate parent)
        {
            long listPosition = reader.BaseStream.Position;
            Debug.WriteLine($"DeserializeList start 0x{listPosition:X}");

            long listStartOffset = reader.ReadInt64();
            int numEntries = reader.ReadInt32();
            uint listMagic = reader.ReadUInt32();
            if (listMagic != 0xAAAAAA01 && listMagic != 1)
                throw new Exception($"Invalid list read, magic 0x{listMagic:X} expected 0xAAAAAA01 / 0x1");

            long listEndPosition = reader.BaseStream.Position;

            reader.BaseStream.Position = listPosition + listStartOffset;
            var list = new List<T>();
            for (int i = 0; i < numEntries; i++)
            {
                // todo: get rid of DeserializeGenericList? this seems like it would work fine with List<NMSTemplate>
                var template = DeserializeValue(reader, field.FieldType.GetGenericArguments()[0], settings, templateStartOffset, field, parent);
                if (template == null)
                    throw new Exception($"Failed to deserialize type {typeof(T).Name}!");

                list.Add((T)template);
            }

            reader.BaseStream.Position = listEndPosition;
            reader.Align(0x8, 0);

            return list;
        }

        public void SerializeMBIN(BinaryWriter writer, Type fieldType, object fieldData, NMSAttribute settings, FieldInfo field, ref List<Tuple<long, object>> additionalData)
        {
            switch (fieldType.Name)
            {
                case "String":
                case "Byte[]":
                    int size = settings?.Size ?? 0;
                    MarshalAsAttribute legacySettings = field?.GetCustomAttribute<MarshalAsAttribute>();
                    if (legacySettings != null)
                    {
                        size = legacySettings.SizeConst;
                    }

                    if (fieldType.Name == "String")
                    {
                        writer.WriteString((string)fieldData, Encoding.UTF8, size);
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
                    var value = (bool)fieldData;
                    writer.Write(value ? (byte)1 : (byte)0);
                    break;
                case "Int16":
                case "UInt16":
                    writer.Align(2, 0);
                    if (fieldType.Name == "Int16")
                        writer.Write((Int16)fieldData);
                    else
                        writer.Write((UInt16)fieldData);
                    break;
                case "Int32":
                case "UInt32":
                    writer.Align(4, 0);
                    if (fieldType.Name == "Int32")
                        writer.Write((Int32)fieldData);
                    else
                        writer.Write((UInt32)fieldData);
                    break;
                case "Int64":
                case "UInt64":
                    writer.Align(8, 0);
                    if (fieldType.Name == "Int64")
                        writer.Write((Int64)fieldData);
                    else
                        writer.Write((UInt64)fieldData);
                    break;
                case "List`1":
                    writer.Align(8, 0);
                    if (field != null && field.FieldType.IsGenericType && field.FieldType.GetGenericTypeDefinition() == typeof(List<>))
                    {
                        // write empty list header
                        long listPos = writer.BaseStream.Position;
                        writer.Write((Int64)0); // listPosition
                        writer.Write((Int32)0); // listCount
                        writer.Write((UInt32)0xAAAAAA01);

                        var list = (IList)fieldData;
                        additionalData.Add(new Tuple<long, object>(listPos, list));
                    }

                    break;
                case "NMSTemplate":
                    writer.Align(8, 0);
                    long refPos = writer.BaseStream.Position;
                    writer.Write((Int64)0); // listPosition
                    var template = (NMSTemplate)fieldData;
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

                    if (fieldType.Name == "Colour") // unsure if this is needed?
                        writer.Align(0x10, 0);

                    // todo: align for VariableSizeString?
                    if (fieldType.Name == "VariableSizeString")
                    {
                        // write empty DynamicString header
                        long fieldPos = writer.BaseStream.Position;
                        writer.Write((Int64)0); // listPosition
                        writer.Write((Int32)0); // listCount
                        writer.Write((UInt32)0xAAAAAA01);

                        var fieldValue = (VariableSizeString)fieldData;
                        additionalData.Add(new Tuple<long, object>(fieldPos, fieldValue));
                    }
                    else if (fieldType.IsArray)
                    {
                        var arrayType = fieldType.GetElementType();
                        Array array = (Array)fieldData;
                        foreach (var obj in array)
                        {
                            SerializeMBIN(writer, obj.GetType(), obj, settings, field, ref additionalData);
                        }
                    }
                    else
                    {
                        if (fieldType.BaseType == typeof(NMSTemplate))
                            ((NMSTemplate)fieldData).AppendToWriter(writer, ref additionalData);
                        else
                            throw new Exception($"[C] Unknown type {fieldType} not NMSTemplate" + (field != null ? $" for {field.Name}" : ""));
                    }

                    break;
            }
        }
        
        public void AppendToWriter(BinaryWriter writer, ref List<Tuple<long, object>> additionalData)
        {
            long templatePosition = writer.BaseStream.Position;
            Debug.WriteLine($"[C] writing {GetType().Name} to offset 0x{templatePosition:X}");

            var type = GetType();
            var fields = type.GetFields().OrderBy(field => field.MetadataToken); // hack to get fields in order of declaration (todo: use something less hacky, this might break mono?)

            foreach (var field in fields)
            {
                var fieldAddr = writer.BaseStream.Position - templatePosition;
                var fieldData = field.GetValue(this);
                NMSAttribute settings = field.GetCustomAttribute<NMSAttribute>();
                SerializeMBIN(writer, field.FieldType, fieldData, settings, field, ref additionalData);
            }
        }

        public void SerializeGenericList(BinaryWriter writer, IList list, long listHeaderPosition, ref List<Tuple<long, object>> additionalData)
        {
            long listPosition = writer.BaseStream.Position;
            Debug.WriteLine($"SerializeList start 0x{listPosition:X}, header 0x{listHeaderPosition:X}");

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
            Debug.WriteLine($"SerializeList start 0x{listPosition:X}, header 0x{listHeaderPosition:X}");

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
                SerializeMBIN(writer, entry.GetType(), entry, null, null, ref additionalData);
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
        public EXmlBase SerializeEXmlValue(Type fieldType, FieldInfo field, NMSAttribute settings, object value)
        {
            string t = fieldType.Name;
            int i = 0;
            switch (fieldType.Name)
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
                    var valueStr = value.ToString();
                    if (fieldType.Name == "Int32")
                    {
                        var valuesMethod = GetType().GetMethod(field.Name + "Values"); // if we have an "xxxValues()" method in the struct, use that to get the value name
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
                        else if (settings?.EnumValue != null)
                        {
                            if (((int)value) == -1)
                                valueStr = "";
                            else
                            {
                                valueStr = settings.EnumValue[(int)value];
                            }
                        }
                    }

                    return new EXmlProperty
                    {
                        Name = field.Name,
                        Value = valueStr
                    };
                case "Byte[]":
                    byte[] bytes = (byte[])value;
                    string base64Value = bytes == null ? null : Convert.ToBase64String(bytes);

                    return new EXmlProperty
                    {
                        Name = field.Name,
                        Value = base64Value
                    };
                case "List`1":
                    var listType = field.FieldType.GetGenericArguments()[0];
                    EXmlProperty listProperty = new EXmlProperty
                    {
                        Name = field.Name
                    };

                    IList templates = (IList)value;
                    i = 0;
                    foreach (var template in templates)
                    {
                        EXmlBase data = SerializeEXmlValue(listType, field, settings, template);
                        if (settings?.EnumValue != null)
                        {
                            data.Name = settings.EnumValue[i];
                            i++;
                        }
                        else
                            data.Name = null;

                        listProperty.Elements.Add(data);
                    }

                    return listProperty;
                case "NMSTemplate":
                    if (value != null)
                    {
                        NMSTemplate template = (NMSTemplate)value;

                        EXmlData templateXmlData = template.SerializeEXml();
                        templateXmlData.Name = field.Name;

                        return templateXmlData;
                    }
                    return null;
                default:
                    if (fieldType.BaseType.Name == "NMSTemplate")
                    {
                        NMSTemplate template = (NMSTemplate)value;

                        EXmlData templateXmlData = template.SerializeEXml();
                        templateXmlData.Name = field.Name;

                        return templateXmlData;
                    }
                    else if (fieldType.IsArray)
                    {
                        var arrayType = field.FieldType.GetElementType();
                        EXmlProperty arrayProperty = new EXmlProperty
                        {
                            Name = field.Name
                        };

                        Array array = (Array)value;
                        i = 0;
                        foreach (var template in array)
                        {
                            EXmlBase data = SerializeEXmlValue(arrayType, field, settings, template);
                            if (settings?.EnumValue != null)
                            {
                                data.Name = settings.EnumValue[i];
                                i++;
                            }
                            else
                                data.Name = null;

                            arrayProperty.Elements.Add(data);
                        }

                        return arrayProperty;
                    }
                    else
                    {
                        throw new Exception(string.Format("Unable to encode {0} to EXml!", field));
                    }
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
                xmlData.Elements.Add(SerializeEXmlValue(field.FieldType, field, settings, field.GetValue(this)));
            }

            return xmlData;
        }

        public static object DeserializeEXmlValue(NMSTemplate template, Type fieldType, FieldInfo field, EXmlProperty xmlProperty, Type templateType, NMSAttribute settings)
        {
            switch (fieldType.Name)
            {
                case "String":
                    return xmlProperty.Value;
                case "Single":
                    return float.Parse(xmlProperty.Value);
                case "Boolean":
                    return bool.Parse(xmlProperty.Value);
                case "Int16":
                    return short.Parse(xmlProperty.Value);
                case "UInt16":
                    return ushort.Parse(xmlProperty.Value);
                case "Int32":
                    var valuesMethod = templateType.GetMethod(field.Name + "Values");
                    if (valuesMethod != null)
                    {
                        if (String.IsNullOrEmpty(xmlProperty.Value))
                            return -1;
                        else
                        {
                            string[] values = (string[])valuesMethod.Invoke(template, null);
                            return Array.FindIndex(values, v => v == xmlProperty.Value);
                        }
                    }
                    else if (settings?.EnumValue != null)
                    {
                        if (String.IsNullOrEmpty(xmlProperty.Value))
                            return -1;
                        else
                            return Array.FindIndex(settings.EnumValue, v => v == xmlProperty.Value);
                    }
                    else
                    {
                        return int.Parse(xmlProperty.Value);
                    }
                case "UInt32":
                    return uint.Parse(xmlProperty.Value);
                case "Int64":
                    return long.Parse(xmlProperty.Value);
                case "UInt64":
                    return ulong.Parse(xmlProperty.Value);
                case "Byte[]":
                    return xmlProperty.Value == null ? null : Convert.FromBase64String(xmlProperty.Value);
                case "List`1":
                    Type elementType = fieldType.GetGenericArguments()[0];
                    Type listType = typeof(List<>).MakeGenericType(elementType);
                    IList list = (IList)Activator.CreateInstance(listType);
                    foreach (EXmlData innerXmlData in xmlProperty.Elements.OfType<EXmlData>()) // child templates
                    {
                        NMSTemplate element = DeserializeEXml(innerXmlData);
                        list.Add(element);
                    }
                    foreach(EXmlProperty innerXmlData in xmlProperty.Elements.OfType<EXmlProperty>()) // primitive types
                    {
                        object element = DeserializeEXmlValue(template, elementType, field, innerXmlData, templateType, settings);
                        list.Add(element);
                    }
                    return list;
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

                         return array;
                    }
                    else if (field.FieldType.IsArray)
                    {
                        Array array = Array.CreateInstance(field.FieldType.GetElementType(), settings.Size);
                        List<EXmlProperty> data = xmlProperty.Elements.OfType<EXmlProperty>().ToList();
                        for (int i = 0; i < data.Count; ++i)
                        {
                            object element = DeserializeEXmlValue(template, field.FieldType.GetElementType(), field, data[i], templateType, settings);
                            array.SetValue(element, i);
                        }

                        return array;
                    }
                    else
                    {
                        return fieldType.IsValueType ? Activator.CreateInstance(fieldType) : null;
                    }
            }
        }

        public static NMSTemplate DeserializeEXml(EXmlData xmlData)
        {
            NMSTemplate template = TemplateFromName(xmlData.Template);
            Type templateType = template.GetType();
            var templateFields = templateType.GetFields().OrderBy(field => field.MetadataToken); // hack to get fields in order of declaration (todo: use something less hacky, this might break mono?)

            foreach(var templateField in templateFields)
            {
                NMSAttribute settings = templateField.GetCustomAttribute<NMSAttribute>();
                if(settings?.DefaultValue != null)
                    templateField.SetValue(template, settings.DefaultValue);
            }

            foreach (var xmlProperty in xmlData.Elements.OfType<EXmlProperty>())
            {
                FieldInfo field = templateType.GetField(xmlProperty.Name);
                Type fieldType = field.FieldType;
                NMSAttribute settings = field.GetCustomAttribute<NMSAttribute>();
                object fieldValue = DeserializeEXmlValue(template, fieldType, field, xmlProperty, templateType, settings);
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

        public virtual object CustomDeserialize(BinaryReader reader, Type field, NMSAttribute settings, long templatePosition, FieldInfo fieldInfo)
        {
            return null;
        }
    }
}
