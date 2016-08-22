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
    static class Shared
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

        public static void WriteString(this BinaryWriter writer, string str, Encoding encoding = null, int size = 0, bool nullTerminated = false)
        {
            if (encoding == null)
                encoding = Encoding.ASCII;
            if (size == 0)
                size = str.Length;
            int encodingSize = encoding.GetMaxByteCount(1);

            byte[] stringData = encoding.GetBytes(str);
            Array.Resize(ref stringData, size); // does this work with UTF16 encoded chars?
            if (nullTerminated)
            {
                int nullOffset = encoding.GetBytes(str).Length;
                for (int i = 0; i < encodingSize && nullOffset + i < size; i++)
                    stringData[nullOffset + i] = 0;
            }
            writer.Write(stringData);
        }
    }
}