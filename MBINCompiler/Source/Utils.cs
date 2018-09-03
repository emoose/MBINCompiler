using System;
using System.IO;

namespace MBINCompiler
{

    internal enum FormatType { Unknown, MBIN, EXML }

    internal enum OverwriteMode { Prompt, Always, Never }

    internal class Utils
    {

        public static string GetExecutableName() => Path.GetFileNameWithoutExtension( Environment.GetCommandLineArgs()[0] );

        public static FormatType PromptInputFormat()
        {
            CommandLine.WriteLine(  "\nPlease specify the input file format:" );
            CommandLine.WriteLine(  "\nValid options are:" );

            string[] names = Enum.GetNames( typeof( FormatType ) );
            string validFormats = String.Join( ", ", names, 1, names.Length - 2 );
            if ( names.Length > 2 ) validFormats += " or ";
            if ( names.Length > 1 ) validFormats += names[names.Length - 1];
            CommandLine.WriteLine( $"    {validFormats}" );

            string result;
            while ( true ) {
                CommandLine.Write( "\n--input-format=" );
                result = CommandLine.ReadLine().ToUpper();
                if ( result == "MBIN" ) break;
                if ( result == "EXML" ) break;
            }

            return ( result == "MBIN" ) ? FormatType.MBIN : FormatType.EXML;
        }

        public static bool PromptOverwrite( string fileOut, ref OverwriteMode overwrite )
        {
            CommandLine.WriteLine( $"File already exists!\n\"{fileOut}\"\n" );
            CommandLine.WriteLine( "Options:\n" +
                               "  [y]es\n" +
                               "  [n]o\n" +
                               "  [O]verwrite all existing files.\n" +
                               "  [K]eep all existing files." );
            char key;
            while (true) {
                CommandLine.Write( "\nOverwrite this file? " );
                key = CommandLine.ReadKey().KeyChar;
                key = ( key >= 'a' ) ? (char) (key - 32) : key;
                CommandLine.WriteLine();
                if ( key == 'O' ) overwrite = OverwriteMode.Always;
                if ( key == 'K' ) overwrite = OverwriteMode.Never;
                if ( ( key == 'Y' ) || ( key == 'O' ) ) return true;
                if ( ( key == 'N' ) || ( key == 'K' ) ) return false;
            }
        }
    }

}
