namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x33B7FD7A269292F6, NameHash = 0x6CDE5305)]
    public class GcDefaultMissionProductEnum : NMSTemplate
    {
        // size: 0x3
        public enum DefaultProductTypeEnum : uint {
            None,
            PrimaryProduct,
            SecondaryProduct,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public DefaultProductTypeEnum DefaultProductType;
    }
}
