namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7DC95C6172CA4D67, NameHash = 0xC3799C08BEEDFEF6)]
    public class GcBaseBuildingMode : NMSTemplate
    {
        // size: 0x5
        public enum BaseBuildingModeEnum {
            Inactive,
            Selection,
            Placement,
            Browse,
            Relatives
        }
        /* 0x0 */ public BaseBuildingModeEnum BaseBuildingMode;
    }
}
