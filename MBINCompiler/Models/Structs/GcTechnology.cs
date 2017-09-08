using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    [NMS(Size = 0x2E0)]
    public class GcTechnology : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x000 */ public string ID; // 0x10

        [NMS(Size = 0x80)]
        /* 0x010 */ public string Name; // 0x80

        [NMS(Size = 0x80)]
        /* 0x090 */ public string NameLower; // 0x80

        /* 0x110 */ public VariableSizeString Subtitle;
        /* 0x120 */ public VariableSizeString Description;
        /* 0x130 */ public bool Teach;

        [NMS(Size = 0x7, Ignore = true)]
        /* 0x131 */ public byte[] Padding131;

        [NMS(Size = 0x20)]
        /* 0x138 */ public string HintStart;

        [NMS(Size = 0x20)]
        /* 0x158 */ public string HintEnd;

        /* 0x178 */ public TkTextureResource Icon;

        /* 0x200 */ public Colour Colour;
        /* 0x210 */ public int Level;
        /* 0x214 */ public bool Chargeable;
        /* 0x218 */ public int ChargeAmount;

        ///* 0x21C */ public Unknown0x4 ChargeType;

        /* 0x21C */ public GcRealitySubstanceCategory SubstanceCategory;        // should be ChargeType??
        /* 0x220 */ public List<NMSString0x10> ChargeBy;
        /* 0x230 */ public bool BuildFullyCharged;
        /* 0x231 */ public bool Upgrade;
        /* 0x232 */ public bool Core;
        /* 0x234 */ public GcTechnologyCategory TechnologyCategory;

        /* 0x238 */ public GcTechnologyRarity TechnologyRarity;

        /* 0x23C */ public float Value;
        /* 0x240 */ public List<GcTechnologyRequirement> Requirements;
        /* 0x250 */ public GcStatsTypes BaseStat;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x254 */ public byte[] Padding254;
        /* 0x258 */ public List<GcStatsBonus> StatBonuses;

        [NMS(Size = 0x10)]
        /* 0x268 */ public string RequiredTech;

        /* 0x278 */ public int RequiredLevel;

        [NMS(Size = 0x4, Ignore = true)]
        /* 0x27C */ public byte[] Padding27C;

        /* 0x280 */ public Colour UpgradeColour;
        /* 0x290 */ public Colour LinkColour;

        [NMS(Size = 0x10)]
        /* 0x2A0 */ public string RewardGroup;

        /* 0x2B0 */ public int BaseValue;
        /* 0x2B4 */ public GcItemPriceModifiers Cost;
        /* 0x2C8 */ public int RequiredRank;
        /* 0x2CC */ public GcAlienRace DispensingRace;
        /* 0x2D0 */ public int FragmentCost;
        /* 0x2D4 */ public GcTechnologyRarity TechShopRarity;
        /* 0x2D8 */ public bool WikiEnabled;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x2D9 */ public byte[] Padding2D9;
    }
}
