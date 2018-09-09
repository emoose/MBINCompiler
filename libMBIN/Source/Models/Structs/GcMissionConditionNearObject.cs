namespace libMBIN.Models.Structs
{
	[NMS(Size = 0x8, GUID = 0x715E0A4778ED054B)]
    public class GcMissionConditionNearObject : NMSTemplate
    {
		public enum MissionObjectEnum { PlayerShip, PlayerVehicle }
		public MissionObjectEnum MissionObject;
        public float Distance;
    }
}
