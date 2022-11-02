namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8A2D9C63D30BAF86, NameHash = 0xF8F75E88F695BE94)]
    public class GcVehicleCheckpointComponentData : NMSTemplate
    {
        // size: 0x2
        public enum CheckpointTypeEnum {
            Checkpoint,
            Start
        }
        /* 0x0 */ public CheckpointTypeEnum CheckpointType;
        // size: 0x2
        public enum RaceTypeEnum {
            Vehicle,
            Spaceship
        }
        /* 0x4 */ public RaceTypeEnum RaceType;
        /* 0x8 */ public float Radius;
    }
}
