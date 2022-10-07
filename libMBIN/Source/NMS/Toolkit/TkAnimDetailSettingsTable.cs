using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x4B3E272ACB25859F, NameHash = 0xC1032FBFB34EDA05)]
    public class TkAnimDetailSettingsTable : NMSTemplate
    {
        // size: 0x4
        public enum TableEnum {
            Low,
            Medium,
            High,
            Ultra
        }
        [NMS(Size = 0x4, EnumType = typeof(TableEnum))]
        /* 0x0 */ public TkAnimDetailSettings[] Table;
    }
}
