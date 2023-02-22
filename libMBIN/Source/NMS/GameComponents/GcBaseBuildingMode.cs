namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2848B4C77540110D, NameHash = 0xC3799C08BEEDFEF6)]
    public class GcBaseBuildingMode : NMSTemplate
    {
        // size: 0x5
        public enum BaseBuildingModeEnum {
            Inactive,
            Selection,
            Placement,
            Browse,
            Relatives,
        }
        /* 0x0 */ public BaseBuildingModeEnum BaseBuildingMode;
    }
}
