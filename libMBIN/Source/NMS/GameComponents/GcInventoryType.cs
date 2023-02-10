namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x488978FD0D4C514A, NameHash = 0xE3C593A400EF084C)]
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
