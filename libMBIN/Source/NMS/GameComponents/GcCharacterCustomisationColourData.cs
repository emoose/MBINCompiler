using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x97D9ED379D60EC3, NameHash = 0x8AC0161286DB6A30)]
    public class GcCharacterCustomisationColourData : NMSTemplate
    {
        /* 0x00 */ public TkPaletteTexture Palette;
        /* 0x10 */ public Colour Colour;
    }
}
