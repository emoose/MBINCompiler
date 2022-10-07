namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCD68389CFE1154FA, NameHash = 0xE637310E185BAB51)]
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
