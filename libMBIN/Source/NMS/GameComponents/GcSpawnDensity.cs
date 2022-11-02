namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC609EFB39F93CBC3, NameHash = 0x36320600C6ADE7CA)]
    public class GcSpawnDensity : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Name;
        /* 0x10 */ public bool Active;
        // size: 0x3
        public enum CoverageTypeEnum {
            Total,
            SmoothPatch,
            GridPatch
        }
        /* 0x14 */ public CoverageTypeEnum CoverageType;
        /* 0x18 */ public float PatchSize;
        /* 0x1C */ public float RegionScale;
    }
}
