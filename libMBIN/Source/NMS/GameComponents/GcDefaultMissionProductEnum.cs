namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD6644476448BBF7B, NameHash = 0x20AE1E70418EDA80)]
    public class GcDefaultMissionProductEnum : NMSTemplate
    {
        // size: 0x3
        public enum DefaultProductTypeEnum {
            None,
            PrimaryProduct,
            SecondaryProduct
        }
        /* 0x0 */ public DefaultProductTypeEnum DefaultProductType;
    }
}
