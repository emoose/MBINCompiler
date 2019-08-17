using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x7E4E65828F6560A7, SubGUID = 0x49D48E5A22491956)]
    public class GcFactionSelectOptions : NMSTemplate
    {
		public enum FactionOptionEnum { DataDefined, CurrentMission, CurrentSystem }
		public FactionOptionEnum FactionOption;
        public GcMissionFaction Faction;
    }
}
