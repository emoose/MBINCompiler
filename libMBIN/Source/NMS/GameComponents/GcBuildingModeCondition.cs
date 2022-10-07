namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9BA8DB2D80F3B645, NameHash = 0x307D1ADF8E3AA83B)]
    public class GcBuildingModeCondition : NMSTemplate
    {
        // size: 0x5
        public enum ValidBuildingModesEnum {
            Inactive,
            Selection,
            Placement,
            Browse,
            Relatives
        }
        [NMS(Size = 0x5, EnumType = typeof(ValidBuildingModesEnum))]
        /* 0x0 */ public int[] ValidBuildingModes;
    }
}
