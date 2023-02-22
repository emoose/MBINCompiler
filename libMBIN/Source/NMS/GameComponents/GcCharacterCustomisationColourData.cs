using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1976F3E0C8D8242A, NameHash = 0x8AC0161286DB6A30)]
    public class GcCharacterCustomisationColourData : NMSTemplate
    {
        /* 0x00 */ public TkPaletteTexture Palette;
        /* 0x10 */ public Colour Colour;
    }
}
