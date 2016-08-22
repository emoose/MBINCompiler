using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using MBINCompiler.Models.Structs;
using MBINCompiler.Models;

namespace MBINCompiler
{
    internal static class Shared
    {
        public static void Align(this BinaryReader reader, int alignBy, long templateStartOffset)
        {
            long offset = reader.BaseStream.Position - templateStartOffset;
            long mod = offset % alignBy;
            if (mod != 0)
                reader.BaseStream.Position += (alignBy - mod);
        }
        
        public static void Align(this BinaryWriter writer, int alignBy, long templateStartOffset)
        {
            long offset = writer.BaseStream.Position - templateStartOffset;
            long mod = offset % alignBy;
            if (mod != 0)
                writer.Write(new byte[alignBy - mod]); // :)
        }

        public static string ReadString(this BinaryReader reader, Encoding encoding, int size, bool nullTerminated = false)
        {
            byte[] stringData = reader.ReadBytes(size);
            string stringValue = encoding.GetString(stringData);
            if (nullTerminated)
            {
                int nullIndex = stringValue.IndexOf("\0", StringComparison.Ordinal);
                if (nullIndex >= 0)
                {
                    stringValue = stringValue.Remove(nullIndex);
                }
            }

            return stringValue;
        }

        public static void WriteString(this BinaryWriter writer, string str, Encoding encoding = null, int? size = null, bool nullTerminated = false)
        {
            if (encoding == null)
                encoding = Encoding.ASCII;

            int bufferSize = encoding.GetBytes(str).Length;
            if (size != null)
                bufferSize = size.Value;

            int encodingSize = encoding.GetMaxByteCount(1);

            if (nullTerminated && size == null)
                bufferSize += 1; // add space for null terminator

            byte[] stringBytes = encoding.GetBytes(str);
            Array.Resize(ref stringBytes, bufferSize);

            if (nullTerminated && bufferSize > 0)
            {
                var trimmedStringBytes = encoding.GetBytes(encoding.GetString(stringBytes));
                if (trimmedStringBytes.Length > stringBytes.Length)
                    trimmedStringBytes = stringBytes; // .NET failed to reencode the trimmed string properly?

                int nullOffset = trimmedStringBytes.Length;
                if (nullOffset == bufferSize)
                    nullOffset -= 1;

                stringBytes[nullOffset] = 0; // atm this might add a null in the middle of a character!
            }

            writer.Write(stringBytes);
        }
    }
}