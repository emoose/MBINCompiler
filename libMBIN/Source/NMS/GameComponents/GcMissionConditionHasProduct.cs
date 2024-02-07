using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAD087AE3B999D1DF, NameHash = 0x9537448E73030512)]
    public class GcMissionConditionHasProduct : NMSTemplate
    {
        /* 0x00 */ public GcDefaultMissionProductEnum Default;
        /* 0x08 */ public NMSString0x10 Product;
        /* 0x18 */ public int Amount;
        /* 0x1C */ public bool UseDefaultAmount;
        /* 0x1D */ public bool SyncWithMissionFireteam;
        /* 0x1E */ public bool MustBeImmediatelyAccessible;
        /* 0x1F */ public bool ForceSearchFreighterAndChests;
        /* 0x20 */ public bool SearchEveryShip;
        /* 0x21 */ public bool SearchGrave;
        /* 0x22 */ public bool SearchCookingIngredients;
        /* 0x23 */ public bool TakeAmountFromSeasonData;
        /* 0x24 */ public bool TakeIdFromSeasonData;
        /* 0x25 */ public bool DependentOnSeasonMilestone;
        /* 0x28 */ public NMSString0x10 UseAmountToAffordRecipe;
        /* 0x38 */ public bool TakeAffordRecipeFromSeasonData;
        /* 0x39 */ public bool UseAffordRecipeForTextFormatting;
        /* 0x3C */ public GcItemNeedPurpose Purpose;
        /* 0x40 */ public bool AllowedToSetInventoryHint;
        /* 0x41 */ public bool ForceInventoryHintAtAllTimes;
        /* 0x42 */ public bool UseProductIconAsMissionIcon;
        /* 0x43 */ public bool DoNotFormatText;
    }
}
