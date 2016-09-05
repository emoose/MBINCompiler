namespace MBINCompiler.Models.Structs
{
    public class GcExternalObjectListOptions : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Name;
        public float Probability;
        public GcTerrainTileType TileType;
        [NMS(Size = 4, EnumValue = new[] { "Dead", "Low", "Mid", "Full" })]
        public NMSString0x80[] Options;
        public bool AllowLimiting;
        [NMS(Size = 7, Ignore = true)]
        public byte[] Padding;
    }
}
