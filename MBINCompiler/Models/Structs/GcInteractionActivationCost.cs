using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcInteractionActivationCost : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string SubstanceId;
        public List<NMSString0x10> AltIds;

        public int Cost; // might be float
        public bool Repeat;

        [NMS(Size = 3, Ignore = true)]
        public byte[] Padding25;
    }
}
