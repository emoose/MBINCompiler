using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NMSDecompressor
{
    class Program
    {
        static void HelpText()
        {
            Console.WriteLine(@"Usage: NMSDecompressor [-s:NMSSourcePath] | [-i] | [-r] | [-g]");
            Console.WriteLine(@"Requires the Decompressor\ dir which should have appeared on project compile.");
            Console.WriteLine(@"runs the psarc.exe decompressor on the build located in .\pre.");
            Console.WriteLine(@"all decompressed files will be located in the .\post");
            Console.WriteLine(@"   -g   runs application with default configuration.");
            Console.WriteLine(@"   -i   ignores the NMSSourcePath as well as doing the manual copy.");
            Console.WriteLine(@"        assumes that .\pre already contains pack files.");
            Console.WriteLine(@"   -s   redirects auto-pull from the standard path to the specified location.");
            Console.WriteLine(@"        This is from the common steam route to NMS's PCBANKS dir.");
            Console.WriteLine(@"   -r   This runs the recompress command.");
            Console.WriteLine(@"        final .pak files can be located in .\recomp.");
        }

        static void Main(string[] args)
        {
            Directory.SetCurrentDirectory("Decompressor");

            if (!Directory.Exists("pre"))
            {
                Directory.CreateDirectory("pre");
            }
            if (!Directory.Exists("post"))
            {
                Directory.CreateDirectory("post");
            }
            if (!Directory.Exists("bak"))
            {
                Directory.CreateDirectory("bak");
            }
            if (!Directory.Exists("recomp"))
            {
                Directory.CreateDirectory("recomp");
            }

            string pathToNMS = @"C:\Program Files (x86)\Steam\steamapps\common\No Man's Sky\GAMEDATA\PCBANKS";

            if (args.Length < 1)
            {
                HelpText();
                pause();
                return;
            }

            var input = args[0];

            if (input.ToLower() == "-r")
            {
                recompress();
                return;
            }

            if (input.ToLower() == "-i")
            {
                extract();
                return;
            }

            if (input.StartsWith("-s"))
            {
                int results = input.IndexOf(':');

                if(results == -1 || input.Length-1 == results)
                {
                    Console.WriteLine("command impropperly formatted...");
                    return;
                }

                pathToNMS = input.Substring(results+1);
                process(pathToNMS);
            }

            if (input.StartsWith("-g"))
            {
                process(pathToNMS);
            }
        }

        static void pause() {
            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }

        static void process(string pathToNMS)
        {
            Console.WriteLine("Copying files to local file...");
            pullSource(pathToNMS);
            Console.WriteLine("Begin Extraction...");
            extract();
        }

        static void extract()
        {
            Process.Start("_Extract.bat");
        }

        static void recompress()
        {
            Process.Start("_Compress.bat");
        }

        static void pullSource(string pathToNMS)
        {
            string[] Files = Directory.GetFiles(pathToNMS);
            
            foreach(string file in Files)
            {
                string fileName = Path.GetFileName(file);
                File.Copy(file, Path.GetFullPath(@".\pre\" + fileName), true);
                Console.WriteLine("Copying: " + file);
            }
        }
    }
}
