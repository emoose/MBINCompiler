using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0xC, GUID = 0xB31D50FB41FDFFC1, NameHash = 0xF9B9838B50251311)]
    public class GcPlanetTerrainColour : NMSTemplate
    {
        /* 0x0 */ public TkPaletteTexture Palette;
        /* 0x8 */ public int Index;
    }
}