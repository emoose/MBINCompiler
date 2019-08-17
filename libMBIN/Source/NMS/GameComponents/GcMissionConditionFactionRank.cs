using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xF4F93A0ED2B84F61, SubGUID = 0x986E86EA3EB2C57C)]
    public class GcMissionConditionFactionRank : NMSTemplate
    {
        public GcMissionFaction Faction;        // I think?
        public bool UseSystemRace;
        public int Rank;
    }
}
