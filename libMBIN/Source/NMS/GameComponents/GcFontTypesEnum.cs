namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x392738D0F1DB6A0C, NameHash = 0xDD7598814880C206)]
    public class GcFontTypesEnum : NMSTemplate
    {
        // size: 0x8
        public enum FontEnum {
            Impact,
            Bebas,
            GeosansLightWide,
            GeosansLight,
            GeosansLightMedium,
            GeosansLightSmall,
            Segoeuib,
            Segoeui32
        }
        /* 0x0 */ public FontEnum Font;
    }
}
