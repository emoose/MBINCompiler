namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE1C9A1AD5AE2D4DC, NameHash = 0x142D5809)]
    public class GcBuilderPadType : NMSTemplate
    {
        // size: 0x3
        public enum BuilderPadTypeEnum : uint {
            NoBuild,
            ExclusivelyBuild,
            Hybrid,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public BuilderPadTypeEnum BuilderPadType;
    }
}
