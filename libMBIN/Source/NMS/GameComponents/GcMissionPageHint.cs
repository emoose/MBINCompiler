namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC0BFCC224C77B187, NameHash = 0xBC45706D394C0853)]
    public class GcMissionPageHint : NMSTemplate
    {
        // size: 0xC
        public enum MissionPageHintEnum : uint {
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
            Expedition,
        }
        /* 0x0 */ public MissionPageHintEnum MissionPageHint;
    }
}
