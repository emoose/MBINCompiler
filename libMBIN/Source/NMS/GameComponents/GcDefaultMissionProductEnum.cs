namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x666451205CCD88E3, NameHash = 0x20AE1E70418EDA80)]
    public class GcDefaultMissionProductEnum : NMSTemplate
    {
        // size: 0x3
        public enum DefaultProductTypeEnum : uint {
            None,
            PrimaryProduct,
            SecondaryProduct,
        }
        /* 0x0 */ public DefaultProductTypeEnum DefaultProductType;
    }
}
