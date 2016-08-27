namespace MBINCompiler.Models.Structs
{
    public class GcPlanetColourData : NMSTemplate
    {
        [NMS(Size = 0x26)]
        public GcColourPaletteData[] Palettes;
    }
}
