namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x7E4E65828F6560A7)]
    public class GcFactionSelectOptions : NMSTemplate
    {
		public enum FactionOptionEnum { DataDefined, CurrentMission, CurrentSystem }
		public FactionOptionEnum FactionOption;
        public GcMissionFaction Faction;
    }
}
