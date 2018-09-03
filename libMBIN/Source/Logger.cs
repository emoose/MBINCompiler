using System.Collections.Generic;
using System.IO;

namespace libMBIN
{
    internal static class Logger
    {

        private static List<StreamWriter> streams = new List<StreamWriter>();

        public static int StreamCount => streams.Count;
        public static StreamWriter GetStream( int index ) => streams[index];

        public static List<StreamWriter> GetStreams() => streams;

        public static void AddStream( Stream stream ) => AddStream( new StreamWriter( stream ) );
        public static void AddStream( StreamWriter stream ) => InsertStream( streams.Count, stream );

        public static void InsertStream( int index, Stream stream ) => InsertStream( index, new StreamWriter( stream ) );
        public static void InsertStream( int index, StreamWriter stream ) {
            if ( stream == null ) return;
            stream.AutoFlush = true;
            streams.Insert( index, stream );
        }

        public static bool RemoveStream( StreamWriter stream ) => streams.Remove( stream );

        public static StreamWriter RemoveStream( int index ) {
            var stream = (index < StreamCount) ? streams[index] : null;
            streams.RemoveAt( index );
            return stream;
        }

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
