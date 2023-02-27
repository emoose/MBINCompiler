namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5721A97130AFD54E, NameHash = 0x1D300E2AA74F7BA7)]
    public class GcMissionFaction : NMSTemplate
    {
        // size: 0x9
        public enum MissionFactionEnum : uint {
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
