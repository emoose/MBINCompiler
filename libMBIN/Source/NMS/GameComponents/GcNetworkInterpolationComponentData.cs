namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2BBCEBCC96798B00, NameHash = 0x1A8AEEF0DF2E3D8A)]
    public class GcNetworkInterpolationComponentData : NMSTemplate
    {
        // size: 0x3
        public enum SynchroniseScaleEnum {
            Never,
            Once,
            Always
        }
        /* 0x0 */ public SynchroniseScaleEnum SynchroniseScale;
        /* 0x4 */ public bool SupportTeleportation;
    }
}
