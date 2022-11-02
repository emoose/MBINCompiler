using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xA242C96B0FEE358, NameHash = 0xC1032FBFB34EDA05)]
    public class TkAnimDetailSettingsTable : NMSTemplate
    {
        [NMS(Size = 0x4, EnumType = typeof(TkGraphicsDetailTypes.GraphicDetailEnum))]
        /* 0x0 */ public TkAnimDetailSettings[] Table;
    }
}
