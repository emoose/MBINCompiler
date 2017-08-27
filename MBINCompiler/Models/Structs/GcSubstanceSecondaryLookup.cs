using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcSubstanceSecondaryLookup : NMSTemplate     // size: 0x20
    {
        [NMS(Size = 0x10)]
        public string PrimaryID;
        public List<GcSubstanceSecondary> SecondaryChances;
    }
}
