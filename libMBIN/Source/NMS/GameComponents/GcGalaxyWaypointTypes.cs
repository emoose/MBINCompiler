namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x401F7AD64DEEABD0, NameHash = 0xF808614547AF2B25)]
    public class GcGalaxyWaypointTypes : NMSTemplate
    {
        // size: 0x6
        public enum GalaxyWaypointTypeEnum {
            User,
            Gameplay_AtlasStation,
            Gameplay_DistressBeacon,
            Gameplay_BlackHole,
            Gameplay_Mission,
            Gameplay_SeasonParty,
        }
        /* 0x0 */ public GalaxyWaypointTypeEnum GalaxyWaypointType;
    }
}
