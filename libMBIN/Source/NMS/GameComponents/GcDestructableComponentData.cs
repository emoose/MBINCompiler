using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4014343A9EF34D90, NameHash = 0xE24B3D78ED0634BD)]
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
        /* 0x049 */ public bool DamagesParentWhenDestroyed;
        /* 0x050 */ public NMSString0x10 LootReward;
        /* 0x060 */ public int LootRewardAmountMin;
        /* 0x064 */ public int LootRewardAmountMax;
        /* 0x068 */ public bool CanDestroyFromStoredInteraction;
        /* 0x070 */ public List<GcSubstanceAmount> GivesSubstances;
        /* 0x080 */ public GcStatsEnum StatToTrack;
        /* 0x088 */ public NMSString0x10 GivesReward;
        /* 0x098 */ public bool BlockDestructionIfRewardFails;
        /* 0x09C */ public int OverrideChipAmount;
        /* 0x0A0 */ public NMSString0x10 PirateSystemAltReward;
        /* 0x0B0 */ public bool RewardIfDestroyedByOther;
        /* 0x0B1 */ public bool NoConsequencesDuringPirateBattle;
        /* 0x0B2 */ public bool HideReward;
        /* 0x0B8 */ public NMSString0x20A OverrideRewardLoc;
        /* 0x0D8 */ public List<GcRewardMissionOverride> RewardOverrideTable;
        /* 0x0E8 */ public bool ActivateLocatorsFromRarity;
        [NMS(Size = 0x3, EnumType = typeof(GcRarity.RarityEnum))]
        /* 0x0F0 */ public NMSString0x10[] RarityLocators;
        [NMS(Size = 0xA, EnumType = typeof(GcMissionFaction.MissionFactionEnum))]
        /* 0x120 */ public int[] StandingChangeOnDeath;
        /* 0x148 */ public bool UseSystemColorsForTexture;
        /* 0x149 */ public bool RemoveModel;
        /* 0x14A */ public bool HideModel;
        /* 0x14C */ public TkModelResource DestroyedModel;
        /* 0x1D0 */ public bool DestroyedModelUsesScale;
        /* 0x1D1 */ public bool DestroyedModelCollidesWithEverything;
        /* 0x1D4 */ public float DestroyForce;
        /* 0x1D8 */ public float DestroyForceRadius;
        /* 0x1E0 */ public NMSString0x10 DestroyEffect;
        /* 0x1F0 */ public bool DestroyEffectOnSurface;
        /* 0x1F8 */ public NMSString0x10 DestroyEffectPoint;
        /* 0x208 */ public float DestroyEffectTime;
        /* 0x20C */ public bool DestroyEffectMatrices;
        /* 0x210 */ public NMSString0x10 AreaDamage;
        /* 0x220 */ public bool ShowInteract;
        /* 0x221 */ public bool HideInteractWhenAllArmourDestroyed;
        /* 0x224 */ public float ShowInteractRange;
        /* 0x228 */ public bool HideInteractWhenShielded;
        /* 0x229 */ public bool GrenadeSingleHit;
        /* 0x230 */ public List<GcLootProbability> LootItems;
    }
}
