namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5DB57124D63D870B, NameHash = 0x51CAC22D)]
    public class GcBaseBuildingObjectDecorationTypes : NMSTemplate
    {
        // size: 0x8
        public enum BaseBuildingDecorationTypeEnum : uint {
            Normal,
            SurfaceNormal,
            Ceiling,
            Terrain,
            Substance,
            Plant,
            BuildingSurfaceNormal,
            WaterSurface,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public BaseBuildingDecorationTypeEnum BaseBuildingDecorationType;
    }
}
