using System.IO;

namespace libMBIN
{
    internal static class Logger
    {

        private static StreamWriter logWriter;
        public static bool Quiet { get; set; }

        public static void Open( string file, bool quiet = false ) => SetStream( new FileStream( file, FileMode.Create ), quiet );

        public static void SetStream( Stream stream, bool quiet = false )
        {
            logWriter?.Dispose();
            logWriter = new StreamWriter( stream ) { AutoFlush = true };
            Quiet = quiet;
        }

        public static Stream GetStream() => logWriter?.BaseStream;

        public static void Write( string msg )
        {
            if (!Quiet) System.Console.Write( msg );
            logWriter?.Write( msg );
        }

        public static void WriteLine( string msg )
        {
            if (!Quiet) System.Console.WriteLine( msg );
            logWriter?.WriteLine( msg );
        }

    }
}
