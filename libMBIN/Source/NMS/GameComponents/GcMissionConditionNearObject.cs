namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x450C3B881FF849F0, NameHash = 0x748605335FA1C427)]
    public class GcMissionConditionNearObject : NMSTemplate
    {
        // size: 0x5
        public enum MissionObjectEnum : uint {
            PlayerShip,
            PlayerVehicle,
            StoryPortal,
            OpenStoryPortal,
            OpenStandardPortal,
        }
        /* 0x0 */ public MissionObjectEnum MissionObject;
        /* 0x4 */ public float Distance;
    }
}
