namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x37E3329384123D4E, NameHash = 0x9748B93C)]
    public class GcDroneTypes : NMSTemplate
    {
        // size: 0x3
        public enum DroneTypeEnum : uint {
            Patrol,
            Combat,
            Corrupted,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public DroneTypeEnum DroneType;
    }
}
