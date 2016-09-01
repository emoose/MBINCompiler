using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
    public class TkProceduralTextureChosenOption : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Layer;
        [NMS(Size = 0x10)]
        public string Group;
        public TkPaletteTexture Palette;
        public bool OverrideColour;
        public Colour Colour;
        [NMS(Size = 0x10)]
        public string OptionName;
    }
}
