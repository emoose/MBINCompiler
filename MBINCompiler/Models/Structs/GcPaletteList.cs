namespace MBINCompiler.Models.Structs
{
    public class GcPaletteList : NMSTemplate
    {
        [NMS(Size = 0x26)]
        public GcPaletteData[] Palettes;
    }
}
