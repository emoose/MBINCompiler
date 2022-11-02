using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDC014ACA9851D84C, NameHash = 0x4CF465C68C10EBB4)]
    public class GcTextPreset : NMSTemplate
    {
        /* 0x00 */ public GcFontTypesEnum Font;
        /* 0x08 */ public NMSTemplate Style;
        /* 0x58 */ public float Height;
        /* 0x60 */ public Colour Colour;
    }
}
