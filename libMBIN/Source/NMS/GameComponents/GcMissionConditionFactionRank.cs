namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x0F4F93A0ED2B84F61)]
    public class GcMissionConditionFactionRank : NMSTemplate
    {
        public GcMissionFaction Faction;        // I think?
        public bool UseSystemRace;
        public int Rank;
    }
}
