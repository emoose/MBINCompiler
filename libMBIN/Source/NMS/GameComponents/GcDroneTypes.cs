namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x53E7F3172D15E9BC, NameHash = 0x3FBE708907C655EF)]
    public class GcDroneTypes : NMSTemplate
    {
        // size: 0x3
        public enum DroneTypeEnum {
            Patrol,
            Combat,
            Corrupted
        }
        /* 0x0 */ public DroneTypeEnum DroneType;
    }
}
