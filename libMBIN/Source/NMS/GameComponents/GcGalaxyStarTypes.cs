namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x59E2DEC5B8592EA3, NameHash = 0x737DC36BC0894840)]
    public class GcGalaxyStarTypes : NMSTemplate
    {
        // size: 0x4
        public enum GalaxyStarTypeEnum {
            Yellow,
            Green,
            Blue,
            Red
        }
        /* 0x0 */ public GalaxyStarTypeEnum GalaxyStarType;
    }
}
