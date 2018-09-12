using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0x8B752B493C2190FA)]
    public class TkProceduralTextureChosenOption : NMSTemplate      // size: 0x60
    {
        [NMS(Size = 0x10)]
        public string Layer;
        [NMS(Size = 0x10)]
        public string Group;
        public TkPaletteTexture Palette;
        public bool OverrideColour;
        public Colour Colour;
        [NMS(Size = 0x20)]
        public string OptionName;
    }
}
