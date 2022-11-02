using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDABB8860B4AA557F, NameHash = 0x49D48E5A22491956)]
    public class GcFactionSelectOptions : NMSTemplate
    {
        // size: 0x3
        public enum FactionOptionEnum {
            DataDefined,
            CurrentMission,
            CurrentSystem
        }
        /* 0x0 */ public FactionOptionEnum FactionOption;
        /* 0x4 */ public GcMissionFaction Faction;
    }
}
