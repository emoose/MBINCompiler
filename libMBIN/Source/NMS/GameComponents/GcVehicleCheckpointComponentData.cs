namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x998ECAC2D8278FE3, NameHash = 0xF8F75E88F695BE94)]
    public class GcVehicleCheckpointComponentData : NMSTemplate
    {
        // size: 0x2
        public enum CheckpointTypeEnum : uint {
            Checkpoint,
            Start,
        }
        /* 0x0 */ public CheckpointTypeEnum CheckpointType;
        // size: 0x2
        public enum RaceTypeEnum : uint {
            Vehicle,
            Spaceship,
        }
        /* 0x4 */ public RaceTypeEnum RaceType;
        /* 0x8 */ public float Radius;
    }
}
