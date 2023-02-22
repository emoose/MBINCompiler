namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBAB98FBA61916E58, NameHash = 0xDD7598814880C206)]
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
            Segoeui32,
        }
        /* 0x0 */ public FontEnum Font;
    }
}
