namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5D26769F05D706AE, NameHash = 0xA1F85E2D)]
    public class GcBaseBuildingMode : NMSTemplate
    {
        // size: 0x5
        public enum BaseBuildingModeEnum : uint {
            Inactive,
            Selection,
            Placement,
            Browse,
            Relatives,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public BaseBuildingModeEnum BaseBuildingMode;
    }
}
