namespace libMBIN.Models.Structs
{
    public class GcTerrainControls : NMSTemplate        // size: 0x70
    {
        [NMS(Size = 7, EnumValue = new[] { "Base", "Hill", "Mountain", "Rock", "UnderWater", "Texture", "Elevation" })]
        /* 0x00 */ public float[] NoiseLayers;
        [NMS(Size = 9, EnumValue = new[] { "Small", "Large", "Resources_Heridium", "Resources_Iridium", "Resources_Copper", "Resources_Nickel", "Resources_Aluminium", "Resources_Gold", "Resources_Emeril" })]
        /* 0x1C */ public float[] GridLayers;
        [NMS(Size = 7, EnumValue = new[] { "River", "Crater", "Arches", "ArchesSmall", "Blobs", "BlobsSmall", "Substance" })]
        /* 0x40 */ public float[] Features;
        [NMS(Size = 1, EnumValue = new[] { "Underground" })]
        /* 0x5C */ public float[] Caves;
        public float WaterActiveFrequency;              // 3F4CCCCDh
        public float HighWaterActiveFrequency;          // 3E800000h
        public float RockTileFrequency;                 // 3E800000h
        public float SubstanceTileFrequency;            // 3E800000h
    }
}
