using System;
using System.Reflection;
using System.Xml;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using libMBIN;
using libMBIN.NMS.GameComponents;
using libMBIN.NMS.Toolkit;
//using libMBIN.Models.Structs;

namespace MBINCompilerDocs
{
    class Program
    {
        internal static readonly Dictionary<string, string> dtypeMapping = new Dictionary<string, string>
        {
            { "Single", "Float" },
        };

        static string basePath = Path.Combine("..", "..", "docs", "structs");

        //Create a mapping between the full names of tk and gc and the short-hands
        internal static readonly Dictionary<string, string> NMS_dir_mapping = new Dictionary<string, string>
                {
                    { "Toolkit", "tk" },
                    { "GameComponents", "gc" },
                    { "Globals", "globals" },
                    { "NMS", "nms" },
                };

        static void WaitForKeypress()
        {
            Console.WriteLine("Press any key");
            Console.ReadKey();
        }

        static internal void GenerateDirs()
        {
            foreach (var key in NMS_dir_mapping.Values)
            {
                Directory.CreateDirectory(Path.Combine(basePath, key.ToString()));
            }
        }

        static string GetNMSType(Type structType)
        {
            
            var splitname = structType.Namespace.Split('.');
            string last = splitname[splitname.Length - 1];
            if (NMS_dir_mapping.ContainsKey(last)) {
                return NMS_dir_mapping[last];
            } else {
                return null;
            }
        }

        static string ConvertDatatype(Type dtype)
        {
            string dtypeName = dtype.Name;
            if (dtypeMapping.ContainsKey(dtypeName)) {
                return dtypeMapping[dtypeName];
            } else {
                return dtypeName;
            }
        }

        static void export_md(List<Type> classes)
        {
            foreach (var t in classes)
            {
                // Create a stringBuilder object to use for the whole md document
                StringBuilder md = new StringBuilder();

                string name = t.Name;
                string NMSType = GetNMSType(t);
                int? size = t.GetCustomAttribute<NMSAttribute>()?.Size;
                ulong? guid = t.GetCustomAttribute<NMSAttribute>()?.GUID;

                // Write the struct name and GUID
                md.AppendLine($"## [All structs](../../) > [{NMSType}](../) > {name}");
                if (t.Namespace != "libMBIN.NMS") {
                    md.AppendLine($"**Size**: 0x{size:X}, **GUID**: 0x{guid:X}\n");
                }
                md.AppendLine();

                // Let's get any descriptions if we have any...
                string class_desc = t.GetCustomAttribute<NMSDescription>()?.Description;
                if (class_desc != null) {
                    md.AppendLine(class_desc);
                    md.AppendLine();
                }

                // Write the table header
                md.AppendLine("| Name | Data type | Description |");
                md.AppendLine("| -----| --------- | ----------- |");

                // Get fields in order of declaration
                var fields = t.GetFields().OrderBy(field => field.MetadataToken);
                foreach (var field in fields) {
                    var field_attrs = field.GetCustomAttribute<NMSAttribute>();
                    // For each field in the struct, write a row in the table
                    if (!(field.GetCustomAttribute<NMSAttribute>()?.Ignore ?? false)) {
                        var fieldType = field.FieldType;
                        // Write the field name first
                        md.Append($"| {field.Name} |");

                        // If the base type is based on NMSTemplate, then we want to create a hyperlink to the page.
                        string structName = $"{ConvertDatatype(fieldType)}";
                        if (fieldType.BaseType == typeof(NMSTemplate))
                        {
                            var fieldNMSType = GetNMSType(fieldType);
                            if (fieldNMSType != null) {
                                structName = $"[{fieldType.Name}](../../../structs/{fieldNMSType}/{fieldType.Name})";
                            }
                        }

                        // For enums, get the values it can have:
                        if (fieldType.IsEnum) {
                            md.Append("<div class='expandable'>Enum</div><ol class='enumValues' hidden>");
                            foreach (var enumValue in Enum.GetValues(fieldType)) {
                                var enumIndex = Convert.ChangeType(enumValue, Enum.GetUnderlyingType(fieldType));
                                md.Append($"<li val='0x{enumIndex:X}'>{enumValue.ToString()}</li>");
                            }
                            md.Append("</ol>");
                        }
                        // For a string, get its size:
                        else if (fieldType.Equals(typeof(System.String)))
                        {
                            int? strSize = field.GetCustomAttribute<NMSAttribute>()?.Size;
                            md.Append($"String (0x{strSize:X})");
                        }
                        // For an array, get it's size and potential enum values:
                        else if (fieldType.IsArray)
                        {
                            int? arrSize = field.GetCustomAttribute<NMSAttribute>()?.Size;
                            var arrayEnumType = field.GetCustomAttribute<NMSAttribute>()?.EnumType;
                            structName = structName.Substring(0, structName.Length - 2);
                            // For enums, get the values it can have:
                            if (arrayEnumType != null && arrayEnumType.IsEnum) {
                                md.Append($"<div class='expandable'>{structName}[0x{arrSize:X}]</div><ul class='enumValues' hidden>");
                                foreach (var enumValue in Enum.GetValues(arrayEnumType)) {
                                    md.Append($"<li>{enumValue.ToString()}</li>");
                                }
                                md.Append("</ul>");
                            } else {
                                md.Append($"{structName}[0x{arrSize:X}]");
                            }
                        }
                        // For a list, get the list type:
                        else if (fieldType.IsGenericType && fieldType.GetGenericTypeDefinition() == typeof(List<>)) {
                            // TODO: extract the info from within the []'s of fieldType.Name
                            var refType = field.ReflectedType;
                            string dtypeName = ConvertDatatype(refType);
                            string listStructName = $"{dtypeName}";
                            if (refType.BaseType == typeof(NMSTemplate)) {
                                // We need to make sure that the type isn't actually an NMSTemplate itself...
                                if (refType == typeof(NMSTemplate)) {
                                    listStructName = $"[NMSTemplate](../../../structs/nms/NMSTemplate)";
                                } else {
                                    var listNMSType = GetNMSType(refType);
                                    if (listNMSType != null) {
                                        listStructName = $"[{dtypeName}](../../../structs/{listNMSType}/{dtypeName})";
                                    }
                                }
                            }
                            md.Append($"List<{listStructName}\\>");
                        }
                        // This is the case of a NMSTemplate or standard type.
                        // TODO: handle the NMSTemplate case here and above...
                        else {
                            md.Append($"{structName}");
                        }
                        // See if the field has a description
                        string desc = field.GetCustomAttribute<NMSDescription>()?.Description;
                        if (desc != null) {
                            md.AppendLine($" | {desc} |");
                        } else {
                            md.AppendLine(" | |");
                        }
                    }
                }

                // Now, write everything to a file...
                File.WriteAllText(Path.Combine(basePath, NMSType, $"{name}.md"), md.ToString());
            }
        }

        static void export_xml(List<Type> classes, string outName)
        {

            XmlDocument xmlDoc = new XmlDocument();
            XmlElement tkNode = xmlDoc.CreateElement(outName);
            foreach (var t in classes)
            {
                string name = t.Name;
                int? size = t.GetCustomAttribute<NMSAttribute>()?.Size;

                // Write the name and size.
                XmlElement structNode = xmlDoc.CreateElement(name);

                XmlAttribute attribute = xmlDoc.CreateAttribute("size");
                attribute.Value = $"0x{size:X}";
                structNode.Attributes.Append(attribute);

                // Get fields in order of declaration
                var fields = t.GetFields().OrderBy(field => field.MetadataToken);
                foreach (var field in fields)
                {
                    if (!field.Name.Contains("Padding"))
                    {
                        var fieldType = field.FieldType;
                        XmlElement fieldNode = xmlDoc.CreateElement(field.Name);
                        XmlAttribute typeAttr = xmlDoc.CreateAttribute("type");
                        // For enums, get the values it can have:
                        if (fieldType.IsEnum)
                        {
                            foreach (var enumValue in Enum.GetValues(fieldType))
                            {
                                XmlElement valNode = xmlDoc.CreateElement(enumValue.ToString());
                                fieldNode.AppendChild(valNode);
                            }
                        }
                        // For a string, get its size:
                        if (fieldType.Equals(typeof(System.String)))
                        {
                            int? strSize = field.GetCustomAttribute<NMSAttribute>()?.Size;
                            XmlAttribute sizeAttr = xmlDoc.CreateAttribute("size");
                            sizeAttr.Value = $"0x{strSize:X}";
                            fieldNode.Attributes.Append(sizeAttr);
                        }
                        // For an array, get it's size and potential enum values:
                        if (fieldType.IsArray)
                        {
                            int? strSize = field.GetCustomAttribute<NMSAttribute>()?.Size;
                            XmlAttribute sizeAttr = xmlDoc.CreateAttribute("size");
                            sizeAttr.Value = $"0x{strSize:X}";
                            fieldNode.Attributes.Append(sizeAttr);
                            var arrayEnumType = field.GetCustomAttribute<NMSAttribute>()?.EnumType;
                            // For enums, get the values it can have:
                            if (arrayEnumType != null && arrayEnumType.IsEnum)
                            {
                                foreach (var enumValue in Enum.GetValues(arrayEnumType))
                                {
                                    XmlElement valNode = xmlDoc.CreateElement(enumValue.ToString());
                                    fieldNode.AppendChild(valNode);
                                }
                            }
                        }
                        // For a list, get the list type:
                        if (fieldType.IsGenericType && fieldType.GetGenericTypeDefinition() == typeof(List<>))
                        {
                            XmlAttribute listTypeAttr = xmlDoc.CreateAttribute("listType");
                            listTypeAttr.Value = field.ReflectedType.Name;
                            fieldNode.Attributes.Append(listTypeAttr);
                        }

                        typeAttr.Value = fieldType.Name;
                        fieldNode.Attributes.Append(typeAttr);
                        structNode.AppendChild(fieldNode);
                    }
                }
                tkNode.AppendChild(structNode);
                xmlDoc.AppendChild(tkNode);

                xmlDoc.Save($"{outName}_structs.xml");
                Console.WriteLine($"template: {name}, size: 0x{size:X}");
            }
        }

        static void update_struct_list(List<Type> classes, StringBuilder md, bool includeDir = false)
        {
            foreach (var t in classes) {
                //Console.WriteLine(t.Name);
                var classNMSType = GetNMSType(t);
                int? size = t.GetCustomAttribute<NMSAttribute>()?.Size;
                ulong? guid = t.GetCustomAttribute<NMSAttribute>()?.GUID;
                if (classNMSType != null) {
                    if (includeDir == true) {
                        if (t.Namespace != "libMBIN.NMS") {
                            md.AppendLine($"| [{t.Name}]({classNMSType}/{t.Name}) | 0x{guid:X} | 0x{size:X} |");
                        }
                        else {
                            md.AppendLine($"| [{t.Name}]({classNMSType}/{t.Name}) | 0x{size:X} |");
                        }
                    } else {
                        if (t.Namespace != "libMBIN.NMS") {
                            md.AppendLine($"| [{t.Name}]({t.Name}) | 0x{guid:X} | 0x{size:X} |");
                        }
                        else {
                            md.AppendLine($"| [{t.Name}]({t.Name}) | 0x{size:X} |");
                        }
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            // Load the assembly (will be located in the same directory as this binary)
            var asm = Assembly.Load("libMBIN");
            // Load all the classes
            var tk_classes = asm.GetTypes().Where(p =>
                 p.Namespace == "libMBIN.NMS.Toolkit" &&
                 p.IsEnum == false
            ).OrderBy(p => p.Name).ToList();
            var gc_classes = asm.GetTypes().Where(p =>
                 p.Namespace == "libMBIN.NMS.GameComponents" &&
                 p.IsEnum == false
            ).OrderBy(p => p.Name).ToList();
            var globals_classes = asm.GetTypes().Where(p =>
                 p.Namespace == "libMBIN.NMS.Globals" &&
                 p.IsEnum == false
            ).OrderBy(p => p.Name).ToList();
            var base_classes = asm.GetTypes().Where(p =>
                 p.Namespace == "libMBIN.NMS" &&
                 p.IsEnum == false
            ).OrderBy(p => p.Name).ToList();

            // Create the directory if needed
            GenerateDirs();

            // Write all the structs to a single file
            StringBuilder md = new StringBuilder();
            md.AppendLine("# List of all structs");
            md.AppendLine();
            md.AppendLine("### [Base classes](nms)");
            md.AppendLine();
            md.AppendLine(@"These are some base classes which are used all through out. 
                          They are not defined as such in the exe, and are named/defined as required.");
            md.AppendLine();
            md.AppendLine("| Name | Size |");
            md.AppendLine("| ---- | ---- |");
            update_struct_list(base_classes, md, true);
            md.AppendLine();
            md.AppendLine("### [Globals](globals)");
            md.AppendLine();
            md.AppendLine("Globals are structs which are a fixed size and vary many aspects of the game (hence the name!).");
            md.AppendLine();
            md.AppendLine("| Name | GUID | Size |");
            md.AppendLine("| ---- | ---- | ---- |");
            update_struct_list(globals_classes, md, true);
            md.AppendLine();
            md.AppendLine("### [GameComponents (Gc)](gc)");
            md.AppendLine();
            md.AppendLine("| Name | GUID | Size |");
            md.AppendLine("| ---- | ---- | ---- |");
            update_struct_list(gc_classes, md, true);
            md.AppendLine();
            md.AppendLine("### [Toolkits (Tk)](tk)");
            md.AppendLine();
            md.AppendLine("| Name | GUID | Size |");
            md.AppendLine("| ---- | ---- | ---- |");
            update_struct_list(tk_classes, md, true);
            File.WriteAllText(Path.Combine(basePath, "index.md"), md.ToString());

            // Also write each index of classes to its own file
            StringBuilder md_base = new StringBuilder();
            md_base.AppendLine("# [All structs](../) > Base classes");
            md_base.AppendLine();
            md_base.AppendLine("| Name |");
            md_base.AppendLine("| ---- |");
            update_struct_list(base_classes, md_base);
            File.WriteAllText(Path.Combine(basePath, "nms", "index.md"), md_base.ToString());

            StringBuilder md_gc = new StringBuilder();
            md_gc.AppendLine("# [All structs](../) > GameComponent (Gc)");
            md_gc.AppendLine();
            md_gc.AppendLine("| Name | GUID | Size |");
            md_gc.AppendLine("| ---- | ---- | ---- |");
            update_struct_list(gc_classes, md_gc);
            File.WriteAllText(Path.Combine(basePath, "gc", "index.md"), md_gc.ToString());

            StringBuilder md_tk = new StringBuilder();
            md_tk.AppendLine("# [All structs](../) > Tookit (Tk)");
            md_tk.AppendLine();
            md_tk.AppendLine("| Name | GUID | Size |");
            md_tk.AppendLine("| ---- | ---- | ---- |");
            update_struct_list(tk_classes, md_tk);
            File.WriteAllText(Path.Combine(basePath, "tk", "index.md"), md_tk.ToString());

            StringBuilder md_globals = new StringBuilder();
            md_globals.AppendLine("# [All structs](../) > Globals");
            md_globals.AppendLine();
            md_globals.AppendLine("| Name | GUID | Size |");
            md_globals.AppendLine("| ---- | ---- | ---- |");
            update_struct_list(globals_classes, md_globals);
            File.WriteAllText(Path.Combine(basePath, "globals", "index.md"), md_globals.ToString());
            export_md(base_classes);
            export_md(tk_classes);
            export_md(gc_classes);
            export_md(globals_classes);
            //export_xml(tk_classes, "Tk");
            //WaitForKeypress();
        }
    }
}
