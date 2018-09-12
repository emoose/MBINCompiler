using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x9A9C381629097F2D)]
    public class GcCustomInventoryComponentData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Size;
        public List<GcInventoryTechProbability> DesiredTechs;

        public bool Cool;

        [NMS(Size = 7, Ignore = true)]
        public byte[] Padding21;
    }
}
