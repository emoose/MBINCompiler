using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using MBINCompiler.Models.Structs;
using MBINCompiler.Models;

namespace MBINCompiler
{
    static class Shared
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

        public static NMSTemplate DeserializeTemplate(this BinaryReader reader, string templateName)
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
                ((VariableSizeString) obj).Value = reader.ReadString(Encoding.UTF8, stringLength);
                reader.BaseStream.Position = templatePosition + 0x10;
                return obj;
            }

            var type = obj.GetType();
            var fields = type.GetFields();
            foreach (var field in fields)
            {
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
                            reader.Align(0x8, templatePosition);
                            var str = reader.ReadChars(size);
                            field.SetValue(obj, new string(str).TrimEnd(new[] { '\0' }));
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
                                field.SetValue(obj, reader.DeserializeGenericList(templatePosition));
                            else
                            {
                                // todo: get rid of this nasty shit
                                MethodInfo method = typeof(Shared).GetMethod("DeserializeList", BindingFlags.Static | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                                                             .MakeGenericMethod(new Type[] { itemType });
                                var list = method.Invoke(null, new object[] { reader, templatePosition });
                                field.SetValue(obj, list);
                            }
                        }

                        break;
                    default:
                        if (fieldType == "Colour")
                            reader.Align(0x10, templatePosition);

                        var data = reader.DeserializeTemplate(fieldType);
                        if (data != null)
                            field.SetValue(obj, data);
                        break;
                }
            }

            return obj;
        }

        public static void Align(this BinaryReader reader, int alignBy, long templateStartOffset)
        {
            long offset = reader.BaseStream.Position - templateStartOffset;
            long mod = offset % alignBy;
            if (mod != 0)
                reader.BaseStream.Position += (alignBy - mod);
        }

        public static string ReadString(this BinaryReader reader, Encoding encoding, int size, bool nullTerminated = false)
        {
            byte[] stringData = reader.ReadBytes(size);
            string stringValue = encoding.GetString(stringData);
            if (nullTerminated)
            {
                int nullIndex = stringValue.IndexOf("\0", StringComparison.Ordinal);
                if (nullIndex > 0)
                {
                    stringValue = stringValue.Remove(nullIndex);
                }
            }

            return stringValue;
        }

        public static List<NMSTemplate> DeserializeGenericList(this BinaryReader reader, long templateStartOffset)
        {
            long listPosition = reader.BaseStream.Position;
            long templateNamesOffset = reader.ReadInt64(); // TODO: USE THIS!
            int numTemplates = reader.ReadInt32();
            uint listMagic = reader.ReadUInt32();
            if (listMagic != 0xAAAAAA01)
                throw new Exception("Invalid generic list read, magic 0x" + listMagic.ToString("X") + " expected 0xAAAAAA01");

            long listEndPosition = reader.BaseStream.Position;

            System.Diagnostics.Debug.WriteLine("DeserializeGenericList start " + listPosition.ToString("X") + " end " + listEndPosition.ToString("X"));

            reader.BaseStream.Position = listPosition + templateNamesOffset;
            var list = new List<NMSTemplate>();
            if (numTemplates > 0)
            {
                Dictionary<long, string> templates = new Dictionary<long, string>();
                for (int i = 0; i < numTemplates; i++)
                {
                    long nameOffset = reader.BaseStream.Position;
                    long templateOffset = reader.ReadInt64();
                    var name = reader.ReadChars(0x40);
                    templates.Add(nameOffset + templateOffset, new string(name).TrimEnd(new[] { '\0' }));
                }

                long pos = reader.BaseStream.Position;

                foreach (var template in templates)
                {
                    reader.BaseStream.Position = template.Key;
                    list.Add(DeserializeTemplate(reader, template.Value));
                }
            }

            reader.BaseStream.Position = listEndPosition;
            reader.Align(0x10, templateStartOffset);

            return list;
        }

        public static List<T> DeserializeList<T>(this BinaryReader reader, long templateStartOffset)
        {
            long listPosition = reader.BaseStream.Position;
            long listStartOffset = reader.ReadInt64(); // TODO: USE THIS!
            int numEntries = reader.ReadInt32();
            uint listMagic = reader.ReadUInt32();
            if (listMagic != 0xAAAAAA01)
                throw new Exception("Invalid list read, magic 0x" + listMagic.ToString("X") + " expected 0xAAAAAA01");

            long listEndPosition = reader.BaseStream.Position;

            System.Diagnostics.Debug.WriteLine("DeserializeList start " + listPosition.ToString("X") + " end " + listEndPosition.ToString("X"));

            reader.BaseStream.Position = listPosition + listStartOffset;
            var list = new List<T>();
            for (int i = 0; i < numEntries; i++)
            {
                list.Add((T)(object)DeserializeTemplate(reader, typeof(T).Name));
            }

            reader.BaseStream.Position = listEndPosition;
            reader.Align(0x10, templateStartOffset);

            return list;
        }
    }
}
