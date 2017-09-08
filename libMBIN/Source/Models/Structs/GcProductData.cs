using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    public class GcProductData : NMSTemplate		// size: 0x2D0
    {
        [NMS(Size = 0x10)]
        /* 0x000 */ public string Id;
        [NMS(Size = 0x80)]
        /* 0x010 */ public string Name;
        [NMS(Size = 0x80)]
        /* 0x090 */ public string NameLower;
        /* 0x110 */ public VariableSizeString Subtitle;
        /* 0x120 */ public VariableSizeString Description;
        [NMS(Size = 0x20)]
        /* 0x130 */ public string Hint;
        /* 0x150 */ public TkModelResource DebrisFile;
        /* 0x1D4 */ public int BaseValue;
        /* 0x1D8 */ public int Level;
        /* 0x1DC */ public TkModelResource Icon;
        /* 0x260 */ public Colour Colour;
        /* 0x270 */ public GcRealitySubstanceCategory SubstanceCategory;
        /* 0x274 */ public GcProductCategory Category;
        /* 0x278 */ public GcRarity Rarity;
        /* 0x27C */ public GcLegality Legality;
        /* 0x280 */ public bool Consumable;
        /* 0x284 */ public int ChargeValue;
        /* 0x288 */ public List<GcTechnologyRequirement> Requirements;
        /* 0x298 */ public GcItemPriceModifiers Cost;
        /* 0x2AC */ public bool SpecificChargeOnly;
        /* 0x2B0 */ public float NormalisedValueOnWorld;
        /* 0x2B4 */ public float NormalisedValueOffWorld;
        /* 0x2B8 */ public GcTradeCategory TradeCategory;
        /* 0x2BC */ public bool WikiEnabled;
        /* 0x2BD */ public bool IsCraftable;
        /* 0x2C0 */ public float EconomyInfluenceMultiplier;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x2C4 */ public byte[] EndPadding;
    }
}
