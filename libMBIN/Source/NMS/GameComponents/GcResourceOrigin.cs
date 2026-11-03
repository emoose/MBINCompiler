namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF3643A996EC168F8, NameHash = 0x484E53FC)]
    public class GcResourceOrigin : NMSTemplate
    {
        // size: 0x5
        public enum ResourceOriginEnum : uint {
            Terrain,
            Crystal,
            Asteroid,
            Robot,
            Depot,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public ResourceOriginEnum ResourceOrigin;
    }
}
