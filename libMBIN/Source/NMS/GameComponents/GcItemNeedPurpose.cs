namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFB55812CCBEAFD4D, NameHash = 0xE637310E185BAB51)]
    public class GcItemNeedPurpose : NMSTemplate
    {
        // size: 0x6
        public enum ItemPurposeEnum {
            None,
            Crafting,
            Building,
            Repairing,
            Charging,
            Paying
        }
        /* 0x0 */ public ItemPurposeEnum ItemPurpose;
    }
}
