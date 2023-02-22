using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEBEFF3A4D2A4DE2B, NameHash = 0x8D353F7BD3E655C5)]
    public class GcCustomisationColourPalettes : NMSTemplate
    {
        [NMS(Size = 0x17, EnumType = typeof(GcCustomisationComponentData.CustomisationDataTypeEnum))]
        /* 0x0000 */ public GcPaletteData[] ColourPalettes;
        [NMS(Size = 0x17, EnumType = typeof(GcCustomisationComponentData.CustomisationDataTypeEnum))]
        /* 0x5D70 */ public GcCustomisationColourPaletteExtraData[] ExtraData;
    }
}
