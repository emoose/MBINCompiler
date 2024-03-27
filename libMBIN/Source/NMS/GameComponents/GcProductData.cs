using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x268CAA7D7CCCB649, NameHash = 0xE831C8A241FD8276)]
    public class GcProductData : NMSTemplate
    {
        /* 0x000 */ public NMSString0x10 ID;
        /* 0x010 */ public NMSString0x80 Name;
        /* 0x090 */ public NMSString0x80 NameLower;
        /* 0x110 */ public VariableSizeString Subtitle;
        /* 0x120 */ public VariableSizeString Description;
        /* 0x130 */ public NMSString0x20A Hint;
        /* 0x150 */ public NMSString0x10 GroupID;
        /* 0x160 */ public TkModelResource DebrisFile;
        /* 0x1E4 */ public int BaseValue;
        /* 0x1E8 */ public int Level;
        /* 0x1EC */ public TkTextureResource Icon;
        /* 0x270 */ public TkTextureResource HeroIcon;
        /* 0x300 */ public Colour Colour;
        /* 0x310 */ public GcRealitySubstanceCategory Category;
        /* 0x314 */ public GcProductCategory Type;
        /* 0x318 */ public GcRarity Rarity;
        /* 0x31C */ public GcLegality Legality;
        /* 0x320 */ public bool Consumable;
        /* 0x324 */ public int ChargeValue;
        /* 0x328 */ public int StackMultiplier;
        /* 0x32C */ public int DefaultCraftAmount;
        /* 0x330 */ public int CraftAmountStepSize;
        /* 0x334 */ public int CraftAmountMultiplier;
        /* 0x338 */ public List<GcTechnologyRequirement> Requirements;
        /* 0x348 */ public List<GcTechnologyRequirement> AltRequirements;
        /* 0x358 */ public GcItemPriceModifiers Cost;
        /* 0x36C */ public int RecipeCost;
        /* 0x370 */ public bool SpecificChargeOnly;
        /* 0x374 */ public float NormalisedValueOnWorld;
        /* 0x378 */ public float NormalisedValueOffWorld;
        /* 0x37C */ public GcTradeCategory TradeCategory;
        // size: 0x7
        public enum WikiCategoryEnum : uint {
            NotEnabled,
            Crafting,
            Tech,
            Construction,
            Trade,
            Curio,
            Cooking,
        }
        /* 0x380 */ public WikiCategoryEnum WikiCategory;
        /* 0x384 */ public bool IsCraftable;
        /* 0x388 */ public NMSString0x10 DeploysInto;
        /* 0x398 */ public float EconomyInfluenceMultiplier;
        /* 0x3A0 */ public NMSString0x20A PinObjective;
        /* 0x3C0 */ public NMSString0x20A PinObjectiveTip;
        /* 0x3E0 */ public NMSString0x20A PinObjectiveMessage;
        /* 0x400 */ public GcScannerIconTypes PinObjectiveScannableType;
        /* 0x404 */ public bool PinObjectiveEasyToRefine;
        /* 0x405 */ public bool CookingIngredient;
        /* 0x408 */ public float CookingValue;
        /* 0x40C */ public bool GoodForSelling;
        /* 0x410 */ public NMSString0x10 GiveRewardOnSpecialPurchase;
        /* 0x420 */ public bool EggModifierIngredient;
        /* 0x421 */ public bool IsTechbox;
        /* 0x422 */ public bool CanSendToOtherPlayers;
    }
}
