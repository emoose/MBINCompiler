namespace MBINCompiler.Models.Structs
{
    public class GcTileTypeSet : NMSTemplate        // size: 0x64
    {
        public float Probability;

        [NMS(Size = 0xC)]
        public TkPaletteTexture[] Colours;
    }
}
