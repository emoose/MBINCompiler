using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x20, GUID = 0x5E7EC2D347D72B80)]
    public class GcCharacterCustomisationColourData : NMSTemplate
    {
        public TkPaletteTexture Palette;
        public Colour Colour;
    }
}
