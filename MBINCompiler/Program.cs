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
        // todo: align based on offset of the struct (not offset of the reader!)
        static void Main(string[] args)
        {
            var tests = new string[] // all of these should decompile fine
            {
                @"C:\NMS\METADATA\UI\HUD\SHIPHUD.MBIN", 
                @"C:\NMS\METADATA\ENTITLEMENTS\GCENTITLEMENTREWARDTABLE.MBIN",
                @"C:\NMS\SCENES\DEMOS\PS4TEST\MAINSETTINGSPS4TEST.MBIN",
                @"C:\NMS\METADATA\REALITY\TABLES\NMS_REALITY_GCTECHNOLOGYTABLE.MBIN",
                @"C:\NMS\METADATA\REALITY\TABLES\NMS_DIALOG_GCALIENSPEECHTABLE.MBIN",
                @"C:\NMS\METADATA\SIMULATION\SOLARSYSTEM\WEATHER\CLEARWEATHER.MBIN",
                @"C:\NMS\METADATA\SIMULATION\SOLARSYSTEM\WEATHER\SKYSETTINGS\DAYSKYCOLOURS.MBIN",
                @"C:\NMS\LANGUAGE\NMS_LOC1_ENGLISH.MBIN"
            };

            var penaltyBox = new string[]
            {
                @"C:\NMS\METADATA\REALITY\TABLES\NMS_DIALOG_GCALIENPUZZLETABLE.MBIN" // wtf? why don't you decompile properly
            };

            /*foreach(var test in tests)
            {
                var file2 = new MBINFile(test);
                file2.Load();
                var wew = file2.SerializeToXML();
                wew = wew;
            }

            foreach (var test in penaltyBox)
            {
                var file2 = new MBINFile(test);
                file2.Load();
                var wew = file2.SerializeToXML();
                wew = wew;
            }*/

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
