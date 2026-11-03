namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAD17FABC01813327, NameHash = 0xAD6353A8)]
    public class GcInventoryType : NMSTemplate
    {
        // size: 0x3
        public enum InventoryTypeEnum : uint {
            Substance,
            Technology,
            Product,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public InventoryTypeEnum InventoryType;
    }
}
