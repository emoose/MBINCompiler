using System.Collections.Generic;
using System.IO;

namespace libMBIN
{
    internal static class Logger
    {

        private static List<StreamWriter> streams = new List<StreamWriter>();

        public static void AddStream( Stream stream ) => AddStream( new StreamWriter( stream ) );
        public static void AddStream( StreamWriter stream )
        {
            stream.AutoFlush = true;
            streams.Add( stream );
        }

        public static List<StreamWriter> GetStreams() => streams;

        public static void Write( string msg )
        {
            foreach ( var stream in streams ) stream.Write( msg );
        }

        public static void WriteLine( string msg )
        {
            foreach ( var stream in streams ) stream.WriteLine( msg );
        }

    }
}
