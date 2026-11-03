using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1AF9F767691CCB2B, NameHash = 0xFD06FE17)]
    public class GcTextPreset : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public Colour Colour;
        [NMS(Index = 1)]
        /* 0x10 */ public NMSTemplate Style;
        [NMS(Index = 0)]
        /* 0x20 */ public GcFontTypesEnum Font;
        [NMS(Index = 2)]
        /* 0x24 */ public float Height;
    }
}
