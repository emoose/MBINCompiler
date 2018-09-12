using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x4DDDBDFBD1267CE7)]
    public class GcCreatureBaitComponentData : NMSTemplate
    {
        public List<NMSString0x10> AttractList;
        public float BaitStrength;
        public float BaitRadius;

        public bool Debug;
        public bool InducesRage;

        [NMS(Size = 6, Ignore = true)]
        public byte[] Padding1A;
    }
}
