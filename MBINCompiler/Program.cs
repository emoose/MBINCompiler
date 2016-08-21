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

            if (File.Exists(input))
                File.Delete(input + ".tmp"); // todo: ask for confirmation?

            // no error checking ^^ (todo: error checking)
            File.Copy(input, input + ".tmp");
            var file = new MBINFile(input + ".tmp");
            file.Load();

            var data = file.GetData();
            if (data == null)
            {
                Console.WriteLine("Failed to deserialize template \"" + file.Header.GetXMLTemplateName() + "\", has the structure been mapped yet?");
                return;
            }

            var xmlString = data.SerializeToXml();
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

            if (File.Exists(output))
                File.Delete(output); // todo: ask for confirmation?

            var data = EXmlFile.ReadTemplate(input);
            if (data == null)
            {
                Console.WriteLine("Failed to deserialize EXML file, is it formatted correctly?");
                return;
            }

            using (var file = new MBINFile(output))
            {
                file.Header.SetDefaults();
                file.SetData(data);
                file.Save();
            }

            Console.WriteLine($"MBIN data written to \"{output}\" successfully?");
        }

        static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                Console.WriteLine("Usage: MBINCompiler [InputPath]");
                Console.WriteLine("Will write decompiled output to [InputPath].exml");
                Console.WriteLine("Recompiling .exml back to .mbin will come soon!");
                return;
            }

            var input = args[0];
            var output = args.Length > 1 ? args[1] : String.Empty;
            var inputExtension = Path.GetExtension(input).ToLower();
            if (inputExtension == ".mbin")
                DecompileFile(input, output);
            else if (inputExtension == ".exml")
                CompileFile(input, output);
            else
                Console.WriteLine($"Unsupported file extension {inputExtension}!");
        }
    }
}
