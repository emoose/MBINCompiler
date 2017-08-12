namespace MBINCompiler.Models.Structs
{
    public class GcExternalObjectListOptions : NMSTemplate      // size: 0x230
    {
        [NMS(Size = 0x10)]
        /* 0x000 */ public string Name;
		[NMS(Size = 0x10)]
		/* 0x010 */ public string ResourceHint;
        /* 0x020 */ public float Probability;
        /* 0x024 */ public GcTerrainTileType TileType;
        [NMS(Size = 4, EnumValue = new[] { "Dead", "Low", "Mid", "Full" })]
        /* 0x028 */ public NMSString0x80[] Options;
        /* 0x228 */ public bool AllowLimiting;
        [NMS(Size = 7, Ignore = true)]
        public byte[] Padding;
    }
}
