using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcCreatureStupidNameTable : NMSTemplate
    {
        [NMS(Size = 0x80)]
        public string StupidUserName;

        public List<GcCreatureStupidName> Table;
    }
}
