namespace MBINCompiler.Models.Structs
{
    public class GcRealitySubstanceData : NMSTemplate       // size: 0x200
    {
        [NMS(Size = 0x20)]
        /* 0x000 */ public string Name;
        [NMS(Size = 0x20)]
        /* 0x020 */ public string NameLower;
        [NMS(Size = 0x10)]
        /* 0x040 */ public string ID;
        [NMS(Size = 0x20)]
        /* 0x050 */ public string Symbol;
        /* 0x070 */ public TkTextureResource Icon;
        /* 0x0F4 */ public TkTextureResource DebrisFile;
        /* 0x178 */ public VariableSizeString Subtitle;
        /* 0x188 */ public VariableSizeString Description;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x198 */ public byte[] Padding198;
        /* 0x1A0 */ public Colour Colour;
        /* 0x1B0 */ public Colour WorldColour;
        /* 0x1C0 */ public int BaseValue;
        /* 0x1C4 */ public GcRealitySubstanceCategory Category;
        /* 0x1C8 */ public GcRarity Rarity;
        /* 0x1CC */ public GcLegality Legality;
        /* 0x1D0 */ public int ChargeValue;
        /* 0x1D4 */ public GcItemPriceModifiers Cost;
        /* 0x1E8 */ public float NormalisedValueOnWorld;
        /* 0x1EC */ public float NormalisedValueOffWorld;
        /* 0x1F0 */ public GcTradeCategory tradeCategory;
        /* 0x1F4 */ public bool WikiEnabled;
        /* 0x1F8 */ public float EconomyInfluenceMultiplier;
    }
}
