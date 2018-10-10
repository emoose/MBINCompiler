using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xC, GUID = 0x76842D5545DF5D3F)]
    public class GcRewardDestructRarities : NMSTemplate
    {
        [NMS(Size = 3, EnumValue = new string[3] { "Common", "Uncommon", "Rare"})]
        public GcRewardDestructEntry[] Rarities;
    }
}
