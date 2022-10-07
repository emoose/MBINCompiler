using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB9913A609DA490D3, NameHash = 0xD77829A90743F12E)]
    public class GcFontTable : NMSTemplate
    {
        // size: 0x8
        public enum TableEnum {
            Impact,
            Bebas,
            GeosansLightWide,
            GeosansLight,
            GeosansLightMedium,
            GeosansLightSmall,
            Segoeuib,
            Segoeui32
        }
        [NMS(Size = 0x8, EnumType = typeof(TableEnum))]
        /* 0x0 */ public GcFontData[] Table;
    }
}
