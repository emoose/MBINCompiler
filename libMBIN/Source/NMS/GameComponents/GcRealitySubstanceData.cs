using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x241F3A24C8346F91, NameHash = 0xD811F4C9E014843E)]
    public class GcRealitySubstanceData : NMSTemplate
    {
        /* 0x000 */ public NMSString0x20 Name;
        /* 0x020 */ public NMSString0x20 NameLower;
        /* 0x040 */ public NMSString0x10 ID;
        /* 0x050 */ public NMSString0x20 Symbol;
        /* 0x070 */ public TkTextureResource Icon;
        /* 0x0F4 */ public TkModelResource DebrisFile;
        /* 0x178 */ public VariableSizeString Subtitle;
        /* 0x188 */ public VariableSizeString Description;
        /* 0x1A0 */ public Colour Colour;
        /* 0x1B0 */ public Colour WorldColour;
        /* 0x1C0 */ public int BaseValue;
        /* 0x1C4 */ public GcRealitySubstanceCategory Category;
        /* 0x1C8 */ public GcRarity Rarity;
        /* 0x1CC */ public GcLegality Legality;
        /* 0x1D0 */ public int ChargeValue;
        /* 0x1D4 */ public int StackMultiplier;
        /* 0x1D8 */ public GcItemPriceModifiers Cost;
        /* 0x1EC */ public float NormalisedValueOnWorld;
        /* 0x1F0 */ public float NormalisedValueOffWorld;
        /* 0x1F4 */ public GcTradeCategory TradeCategory;
        /* 0x1F8 */ public bool WikiEnabled;
        /* 0x1FC */ public float EconomyInfluenceMultiplier;
        /* 0x200 */ public NMSString0x20A PinObjective;
        /* 0x220 */ public NMSString0x20A PinObjectiveTip;
        /* 0x240 */ public NMSString0x20A PinObjectiveMessage;
        /* 0x260 */ public GcScannerIconTypes PinObjectiveScannableType;
        /* 0x268 */ public NMSString0x10 WikiMissionID;
        /* 0x278 */ public bool CookingIngredient;
        /* 0x279 */ public bool GoodForSelling;
        /* 0x27A */ public bool EasyToRefine;
        /* 0x27B */ public bool EggModifierIngredient;
    }
}
