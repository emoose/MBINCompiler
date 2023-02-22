namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCF9B5BDA18D4B041, NameHash = 0x424B3146F5B3FC26)]
    public class GcWarpAction : NMSTemplate
    {
        // size: 0x2
        public enum WarpTypeEnum {
            BlackHole,
            SpacePOI,
        }
        /* 0x0 */ public WarpTypeEnum WarpType;
    }
}
