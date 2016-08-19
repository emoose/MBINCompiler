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

        public static string ReadString(this BinaryReader reader, Encoding encoding, int size, bool nullTerminated = false)
        {
            byte[] stringData = reader.ReadBytes(size);
            string stringValue = encoding.GetString(stringData);
            if (nullTerminated)
            {
                int nullIndex = stringValue.IndexOf("\0", StringComparison.Ordinal);
                if (nullIndex > 0)
                {
                    stringValue = stringValue.Remove(nullIndex);
                }
            }

            return stringValue;
        }
    }
}
