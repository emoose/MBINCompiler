using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents {
	[NMS(GUID = 0x0BC49B47A2E8920B6)]
    public class GcRewardFactionStanding : NMSTemplate
    {
        public GcMissionFaction Faction;
        public int AmountMin;
        public int AmountMax;
    }
}
