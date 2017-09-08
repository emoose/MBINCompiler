namespace MBINCompiler.Models.Structs
{
    [NMS(Size = 0x11F0)]
    public class GcPlanetColourData : NMSTemplate
    {
        [NMS(Size = 0x29)]
        public GcColourPaletteData[] Palettes;
    }
}
