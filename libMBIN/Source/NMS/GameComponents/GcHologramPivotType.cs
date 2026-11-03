namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD55229B2E133A382, NameHash = 0xDFDA9771)]
    public class GcHologramPivotType : NMSTemplate
    {
        // size: 0x2
        public enum HologramPivotTypeEnum : uint {
            Origin,
            CentreBounds,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public HologramPivotTypeEnum HologramPivotType;
    }
}
