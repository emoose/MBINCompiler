namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6CF221F07C634A01, NameHash = 0xCBF38A24719D032E)]
    public class GcBaseBuildingObjectDecorationTypes : NMSTemplate
    {
        // size: 0x7
        public enum BaseBuildingDecorationTypeEnum {
            Normal,
            SurfaceNormal,
            Ceiling,
            Terrain,
            Substance,
            Plant,
            BuildingSurfaceNormal
        }
        /* 0x0 */ public BaseBuildingDecorationTypeEnum BaseBuildingDecorationType;
    }
}
