using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
    public class TkProceduralTextureChosenOption : NMSTemplate
    {
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x10)]
        public string Layer;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x10)]
        public string Group;
        public TkPaletteTexture Palette;
        public bool OverrideColour;
        public Colour Colour;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 0x10)]
        public string OptionName;
    }
}
