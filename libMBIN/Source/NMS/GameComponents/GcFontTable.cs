using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7D4BA3739DBA48F0, NameHash = 0xD77829A90743F12E)]
    public class GcFontTable : NMSTemplate
    {
        [NMS(Size = 0x8, EnumType = typeof(GcFontTypesEnum.FontEnum))]
        /* 0x0 */ public GcFontData[] Table;
    }
}
