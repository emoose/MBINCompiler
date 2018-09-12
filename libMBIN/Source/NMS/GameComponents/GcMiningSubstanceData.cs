using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xC, GUID = 0x0DAD738A301DDD6EC)]
    public class GcMiningSubstanceData : NMSTemplate
    {
        public GcRealitySubstanceCategory Category;
        public bool UseRarity;
        public GcRarity Rarity;
    }
}
