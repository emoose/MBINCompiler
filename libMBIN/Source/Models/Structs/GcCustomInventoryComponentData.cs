using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
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
