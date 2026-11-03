namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7BE583A7497DAD4D, NameHash = 0xC0EE4DA3)]
    public class GcProductTableType : NMSTemplate
    {
        // size: 0x3
        public enum ProductTableTypeEnum : uint {
            Main,
            BaseParts,
            ModularCustomisation,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public ProductTableTypeEnum ProductTableType;
    }
}
