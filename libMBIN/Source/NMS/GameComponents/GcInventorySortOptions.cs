namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAD760FA0C2D899B6, NameHash = 0x2DB31F4F)]
    public class GcInventorySortOptions : NMSTemplate
    {
        // size: 0x5
        public enum InventorySortEnum : uint {
            None,
            Value,
            Type,
            Name,
            Colour,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public InventorySortEnum InventorySort;
    }
}
