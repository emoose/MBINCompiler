using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MBINCompiler
{
    class Program
    {
        static void ScanMBINs(string path, ref List<string> types)
        {
            foreach(var file in Directory.GetFiles(path, "*.mbin"))
            {
                var mbin = new MBINFile(file);
                mbin.Load();
                types.Add(file + " : " + mbin.Header.GetXMLTemplateName());
            }
            foreach (var folder in Directory.GetDirectories(path))
                ScanMBINs(folder, ref types);
        }

        // todo: align based on offset of the struct (not offset of the reader!)
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

            if(Path.GetExtension(input).ToLower() != ".mbin")
            {
                Console.WriteLine("Unsupported input file extension, only .mbin is currently supported, exiting...");
                return;
            }
            var output = Path.ChangeExtension(input, ".exml"); // emoose XML, because there's no way this XML format is compatible with MXML
            if(File.Exists(output))
            {
                Console.WriteLine("Output file \"" + output + "\" already exists, exiting...");
                return;
            }

            // no error checking ^^ (todo: error checking)
            var file = new MBINFile(input);
            file.Load();
            var xmlString = file.SerializeToXML();
            if(String.IsNullOrEmpty(xmlString))
            {
                Console.WriteLine("Failed to serialize template \"" + file.Header.GetXMLTemplateName() + "\" to XML, template structure might not be supported yet.");
                return;
            }
            File.WriteAllText(output, xmlString);
            Console.WriteLine("XML data written to \"" + output + "\" successfully?");
        }
    }
}
