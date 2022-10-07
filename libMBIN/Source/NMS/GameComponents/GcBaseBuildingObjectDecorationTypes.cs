namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x48FADD6F70304AF4, NameHash = 0xCBF38A24719D032E)]
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
