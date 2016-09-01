using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
    public class GcCreatureStupidName : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Id;

        public int Count;
        public List<NMSString0x80> Names;
    }
}
