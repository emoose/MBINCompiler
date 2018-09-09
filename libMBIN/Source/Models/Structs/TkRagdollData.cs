using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x0E1B108BEAEA9229C)]
    public class TkRagdollData : NMSTemplate
    {
        public float Density;
        public float Gravity;
        public List<NMSString0x20> ChainEnds;
        public List<NMSString0x20> ExcludeJoints;
    }
}
