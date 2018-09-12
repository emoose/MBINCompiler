using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x76842D5545DF5D3F)]
    public class GcRewardDestructRarities : NMSTemplate
    {
        public GcRewardDestructEntry Common;
        public GcRewardDestructEntry Uncommon;
        public GcRewardDestructEntry Rare;
    }
}
