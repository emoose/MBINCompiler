using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x8, GUID = 0x6CEB89D0BE94C755, NameHash = 0x748605335FA1C427)]
    public class GcMissionConditionNearObject : NMSTemplate
    {
		public enum MissionObjectEnum { PlayerShip, PlayerVehicle, StoryPortal, OpenStandardPortal }
		public MissionObjectEnum MissionObject;
        public float Distance;
    }
}
