namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x908E72ECB745F017, NameHash = 0x3FBE708907C655EF)]
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
