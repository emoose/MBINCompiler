using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBINCompilerTests {

    public static class Utils {

        public static string NormalizePath( string path ) {
            return path.Trim( new char[] { Path.DirectorySeparatorChar, Path.AltDirectorySeparatorChar } );
        }

        public static string AbsoluteToRelativePath( string baseDir, string path ) {
            path = NormalizePath( path );
            if ( !Path.IsPathRooted( path ) ) return path; // already a relative path
            baseDir = NormalizePath( baseDir );
            if ( path.StartsWith( baseDir, true, System.Globalization.CultureInfo.CurrentCulture ) ) {
                path = path.Substring( baseDir.Length + 1 );
            }
            return path;
        }

        public static string RelativeToAbsolutePath( string baseDir, string path ) {
            path = NormalizePath( path );
            if ( Path.IsPathRooted( path ) ) return path; // already an absolute path
            baseDir = NormalizePath( baseDir );
            return Path.Combine( baseDir, path );
        }

        public static void SetFileReadOnly( string path, bool isReadOnly = true ) {
            if ( !File.Exists( path ) ) return;
            FileAttributes attributes = File.GetAttributes( path ) & ~FileAttributes.ReadOnly;
            File.SetAttributes( path, attributes | (isReadOnly ? FileAttributes.ReadOnly : 0) );
        }

        public static char NibbleToHexChar( int nibble ) => (char) (nibble + ((nibble < 0x0A) ? '0' : 'A' - 0x0A));
        public static byte HexCharToNibble( char hex )   => (byte) (hex    - ((hex    < 'A')  ? '0' : 'A' - 0x0A));

        public static string BytesToHexString( byte[] bytes ) {
            char[] chars = new char[bytes.Length * 2];
            int i = 0;
            for (int j = 0; j < bytes.Length; j++) {
                chars[i++] = NibbleToHexChar( (bytes[j] & 0xF0) >> 4);
                chars[i++] = NibbleToHexChar( (bytes[j] & 0x0F) >> 0);
            }
            return new string( chars );
        }

        public static byte[] HexStringToBytes( string hex ) {
            byte[] bytes = new byte[hex.Length / 2];
            int i = 0;
            char[] chars = hex.ToCharArray();
            for ( int j = 0; j < chars.Length; j += 2 ) {
                byte b  = (byte) (HexCharToNibble( chars[j + 0] ) << 4);
                     b += (byte) (HexCharToNibble( chars[j + 1] ) << 0);
                bytes[i] = b;
            }
            return bytes;
        }

        public static string Hash( Stream stream ) {
            using (var sha = System.Security.Cryptography.SHA1.Create()) {
                stream.Position = 0;
                return BytesToHexString( sha.ComputeHash( stream ) );
            }
        }

    }

}
