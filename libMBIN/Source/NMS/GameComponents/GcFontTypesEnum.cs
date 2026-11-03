namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5249B653B50F281E, NameHash = 0x853286CF)]
    public class GcFontTypesEnum : NMSTemplate
    {
        // size: 0x8
        public enum FontEnum : uint {
            Impact,
            Bebas,
            GeosansLightWide,
            GeosansLight,
            GeosansLightMedium,
            GeosansLightSmall,
            Segoeuib,
            Segoeui32,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public FontEnum Font;
    }
}
