using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcGeneratedShipCounts : NMSTemplate
    {
        [NMS(Size = 0x5)]
        public int[] Counts;
    }
}