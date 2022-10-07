namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBAADE82FFF5952D4, NameHash = 0xBC45706D394C0853)]
    public class GcMissionPageHint : NMSTemplate
    {
        // size: 0xC
        public enum MissionPageHintEnum {
            None,
            Suit,
            Ship,
            Weapon,
            Vehicle,
            Freighter,
            Wiki,
            Catalogue,
            MissionLog,
            Discovery,
            Journey,
            Expedition
        }
        /* 0x0 */ public MissionPageHintEnum MissionPageHint;
    }
}
