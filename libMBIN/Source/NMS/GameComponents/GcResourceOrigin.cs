namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA91CB65809535031, NameHash = 0xA7C99AD4BD0E24FB)]
    public class GcResourceOrigin : NMSTemplate
    {
        // size: 0x5
        public enum ResourceOriginEnum {
            Terrain,
            Crystal,
            Asteroid,
            Robot,
            Depot
        }
        /* 0x0 */ public ResourceOriginEnum ResourceOrigin;
    }
}
