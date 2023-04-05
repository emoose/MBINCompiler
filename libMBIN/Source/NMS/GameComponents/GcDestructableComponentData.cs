using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4ED3B4198057E11F, NameHash = 0xE24B3D78ED0634BD)]
    public class GcDestructableComponentData : NMSTemplate
    {
        /* 0x000 */ public NMSString0x10 Explosion;
        /* 0x010 */ public float ExplosionScale;
        /* 0x014 */ public bool ExplosionScaleToBounds;
        /* 0x015 */ public bool OnlyExplodeSelf;
        /* 0x018 */ public NMSString0x10 VehicleDestroyEffect;
        /* 0x028 */ public NMSString0x10 TriggerAction;
        /* 0x038 */ public int IncreaseWanted;
        /* 0x03C */ public int IncreaseCorruptSentinelWanted;
        /* 0x040 */ public bool IncreaseFiendWanted;
        /* 0x044 */ public float IncreaseFiendWantedChance;
        /* 0x048 */ public bool NotifyEncounter;
        /* 0x050 */ public NMSString0x10 LootReward;
        /* 0x060 */ public int LootRewardAmountMin;
        /* 0x064 */ public int LootRewardAmountMax;
        /* 0x068 */ public bool CanDestroyFromStoredInteraction;
        /* 0x070 */ public List<GcSubstanceAmount> GivesSubstances;
        /* 0x080 */ public GcStatsEnum StatToTrack;
        /* 0x088 */ public NMSString0x10 GivesReward;
        /* 0x098 */ public int OverrideChipAmount;
        /* 0x0A0 */ public NMSString0x10 PirateSystemAltReward;
        /* 0x0B0 */ public bool RewardIfDestroyedByOther;
        /* 0x0B1 */ public bool HideReward;
        /* 0x0B8 */ public NMSString0x20A OverrideRewardLoc;
        /* 0x0D8 */ public List<GcRewardMissionOverride> RewardOverrideTable;
        /* 0x0E8 */ public bool ActivateLocatorsFromRarity;
        [NMS(Size = 0x3, EnumType = typeof(GcRarity.RarityEnum))]
        /* 0x0F0 */ public NMSString0x10[] RarityLocators;
        /* 0x120 */ public bool UseSystemColorsForTexture;
        /* 0x121 */ public bool RemoveModel;
        /* 0x122 */ public bool HideModel;
        /* 0x124 */ public TkModelResource DestroyedModel;
        /* 0x1A8 */ public bool DestroyedModelUsesScale;
        /* 0x1A9 */ public bool DestroyedModelCollidesWithEverything;
        /* 0x1AC */ public float DestroyForce;
        /* 0x1B0 */ public float DestroyForceRadius;
        /* 0x1B8 */ public NMSString0x10 DestroyEffect;
        /* 0x1C8 */ public bool DestroyEffectOnSurface;
        /* 0x1D0 */ public NMSString0x10 DestroyEffectPoint;
        /* 0x1E0 */ public float DestroyEffectTime;
        /* 0x1E4 */ public bool DestroyEffectMatrices;
        /* 0x1E8 */ public NMSString0x10 AreaDamage;
        /* 0x1F8 */ public bool ShowInteract;
        /* 0x1F9 */ public bool HideInteractWhenAllArmourDestroyed;
        /* 0x1FC */ public float ShowInteractRange;
        /* 0x200 */ public bool GrenadeSingleHit;
        /* 0x208 */ public List<GcLootProbability> LootItems;
    }
}
