namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x45119BD09851A673, NameHash = 0xE3C593A400EF084C)]
    public class GcInventoryType : NMSTemplate
    {
        // size: 0x3
        public enum InventoryTypeEnum {
            Substance,
            Technology,
            Product,
        }
        /* 0x0 */ public InventoryTypeEnum InventoryType;
    }
}
