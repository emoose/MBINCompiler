namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x98A8088CCBCB2360, NameHash = 0x748605335FA1C427)]
    public class GcMissionConditionNearObject : NMSTemplate
    {
        // size: 0x4
        public enum MissionObjectEnum : uint {
            PlayerShip,
            PlayerVehicle,
            StoryPortal,
            OpenStandardPortal,
        }
        /* 0x0 */ public MissionObjectEnum MissionObject;
        /* 0x4 */ public float Distance;
    }
}
