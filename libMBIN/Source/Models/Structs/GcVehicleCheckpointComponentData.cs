namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x28BD4D157D6849F4)]
    public class GcVehicleCheckpointComponentData : NMSTemplate
    {
		public enum CheckpointTypeEnum { Checkpoint, Start, Finish }
		public CheckpointTypeEnum CheckpointType;
		public enum RaceTypeEnum { Vehicle, Spaceship }
		public RaceTypeEnum RaceType;
        public float Radius;
    }
}
