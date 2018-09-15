using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x10, GUID = 0xDE0E4B894E24695A)]
    public class GcBuildingDensity : NMSTemplate
    {
        public float BuildingSpacing;
        [NMS(Size = 0x3, EnumValue = new[] { "Cluster", "Large", "Small"})]     // need to check
        public float[] BuildingClusterChance;
    }
}
