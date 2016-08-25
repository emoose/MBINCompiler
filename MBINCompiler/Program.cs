using System;
using System.Collections.Generic;
using System.IO;

namespace MBINCompiler
{
    class Program
    {
        static void ScanMBINs(string path, ref List<string> types)
        {
            foreach (var file in Directory.GetFiles(path, "*.mbin"))
            {
                var mbin = new MBINFile(file);
                mbin.Load();
                types.Add(file + " : " + mbin.Header.GetXMLTemplateName());
            }
            foreach (var folder in Directory.GetDirectories(path))
                ScanMBINs(folder, ref types);
        }

        static void DecompileFile(string input, string output)
        {
            if (String.IsNullOrEmpty(output))
                output = Path.ChangeExtension(input, ".exml"); // emoose XML, because there's no way this XML format is compatible with MXML

            if (File.Exists(output))
                File.Delete(output); // todo: ask for confirmation?

            // no error checking ^^ (todo: error checking)
            var file = new MBINFile(input);
            file.Load();

            var data = file.GetData();
            if (data == null)
            {
                Console.WriteLine("Failed to deserialize template \"" + file.Header.GetXMLTemplateName() + "\", has the structure been mapped yet?");
                return;
            }

            var xmlString = EXmlFile.WriteTemplate(data);
            if (string.IsNullOrEmpty(xmlString))
            {
                Console.WriteLine("Error serializing template \"" + file.Header.GetXMLTemplateName() + "\" to XML!");
                return;
            }

            File.WriteAllText(output, xmlString);
            Console.WriteLine("XML data written to \"" + output + "\" successfully?");
        }

        static void CompileFile(string input, string output)
        {
            if (String.IsNullOrEmpty(output))
                output = Path.ChangeExtension(input, ".MBIN");

            var data = EXmlFile.ReadTemplate(input);
            if (data == null)
            {
                Console.WriteLine("Failed to deserialize EXML file, is it formatted correctly?");
                return;
            }

            if (data.GetType().Name == "TkGeometryData") // todo: change to typeof(TkGeometryData) when we've mapped that template
                output = Path.ChangeExtension(input, ".MBIN.PC");

            if (File.Exists(output))
                File.Delete(output); // todo: ask for confirmation?

            using (var file = new MBINFile(output))
            {
                file.Header = new Models.MBINHeader();
                file.Header.SetDefaults();
                if (data.GetType().Name == "TkGeometryData")
                    file.Header.Magic = 0xDDDDDDDD; // only used by TkGeometryData / .MBIN.PC files, maybe used to signal the file is PC only?

                file.SetData(data);
                file.Save();
            }

            Console.WriteLine($"MBIN data written to \"{output}\" successfully?");
        }

        static void decompileFolder(string folderPath)
        {
            foreach(var file in Directory.GetFiles(folderPath, "*.mbin*"))
            {
                if (file.Contains("LANGUAGE") || file.Contains("language"))
                    continue;

                if (!file.EndsWith(".mbin", StringComparison.InvariantCultureIgnoreCase) && !file.EndsWith(".mbin.pc", StringComparison.InvariantCultureIgnoreCase))
                    continue;

                var output = file.Replace("C:\\NMS\\", "D:\\NMSOUT\\");
                if (!Directory.Exists(Path.GetDirectoryName(output)))
                    Directory.CreateDirectory(Path.GetDirectoryName(output));

                try
                {
                    DecompileFile(file, output);
                }
                catch { }
            }

            foreach (var dir in Directory.GetDirectories(folderPath))
                decompileFolder(dir);
        }

        static void Main(string[] args)
        {
           /* Directory.CreateDirectory("D:\\NMSOUT\\");
            decompileFolder("C:\\NMS\\");
            return;*/

            if (args.Length < 1)
            {
                Console.WriteLine("Usage: MBINCompiler [InputPath]");
                Console.WriteLine("Will write decompiled output to [InputPath].exml");
                Console.WriteLine("Recompiling .exml back to .mbin will come soon!");
                return;
            }

            var input = args[0];
            var output = args.Length > 1 ? args[1] : String.Empty;
            var inputExtension = Path.GetExtension(input) ?? String.Empty;
            if (inputExtension.Equals(".mbin", StringComparison.OrdinalIgnoreCase))
                DecompileFile(input, output);
            else if (inputExtension.Equals(".exml", StringComparison.OrdinalIgnoreCase)) 
                CompileFile(input, output);
            else
            {
                bool isMBin = false;
                if(File.Exists(input) && new FileInfo(input).Length > 0x60)
                {
                    using (var stream = File.OpenRead(input))
                    using (var reader = new BinaryReader(stream))
                    {
                        isMBin = reader.ReadUInt32() == 0xCCCCCCCC && reader.ReadUInt32() == 2500; // CC CC CC CC C4 09 00 00
                    }
                }

                if (isMBin)
                    DecompileFile(input, output);
                else
                    Console.WriteLine($"Unsupported file extension {inputExtension}!");
            }
                
        }
    }
}