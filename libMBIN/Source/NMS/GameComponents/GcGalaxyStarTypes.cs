namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x547D9FEA7AD49DE1, NameHash = 0xCFF86E7B)]
    public class GcGalaxyStarTypes : NMSTemplate
    {
        // size: 0x5
        public enum GalaxyStarTypeEnum : uint {
            Yellow,
            Green,
            Blue,
            Red,
            Purple,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public GalaxyStarTypeEnum GalaxyStarType;
    }
}
