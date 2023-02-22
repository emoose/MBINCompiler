namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x90414A9C85C8CA73, NameHash = 0x1D300E2AA74F7BA7)]
    public class GcMissionFaction : NMSTemplate
    {
        // size: 0x9
        public enum MissionFactionEnum {
            Gek,
            Korvax,
            Vykeen,
            TradeGuild,
            WarriorGuild,
            ExplorerGuild,
            Nexus,
            Pirates,
            None,
        }
        /* 0x0 */ public MissionFactionEnum MissionFaction;
    }
}
