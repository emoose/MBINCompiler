using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4AAB441E2210EEBD, NameHash = 0xF9B9838B50251311)]
    public class GcPlanetTerrainColour : NMSTemplate
    {
        /* 0x0 */ public TkPaletteTexture Palette;
        /* 0x8 */ public int Index;
    }
}
