using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x26F84C6D1073784E, NameHash = 0x640D4FDC2A95A771)]
    public class GcDifficultySettingsData : NMSTemplate
    {
        /* 0x00 */ public bool SettingsLocked;
        /* 0x01 */ public bool InventoriesAlwaysInRange;
        /* 0x02 */ public bool AllSlotsUnlocked;
        /* 0x03 */ public bool WarpDriveRequirements;
        /* 0x04 */ public bool CraftingIsFree;
        /* 0x05 */ public bool TutorialEnabled;
        /* 0x06 */ public bool StartWithAllItemsKnown;
        /* 0x07 */ public bool BaseAutoPower;
        /* 0x08 */ public GcDeathConsequencesDifficultyOption DeathConsequences;
        /* 0x0C */ public GcDamageReceivedDifficultyOption DamageReceived;
        /* 0x10 */ public GcDamageGivenDifficultyOption DamageGiven;
        /* 0x14 */ public GcActiveSurvivalBarsDifficultyOption ActiveSurvivalBars;
        /* 0x18 */ public GcHazardDrainDifficultyOption HazardDrain;
        /* 0x1C */ public GcEnergyDrainDifficultyOption EnergyDrain;
        /* 0x20 */ public GcSubstanceCollectionDifficultyOption SubstanceCollection;
        /* 0x24 */ public GcInventoryStackLimitsDifficultyOption InventoryStackLimits;
        /* 0x28 */ public GcChargingRequirementsDifficultyOption ChargingRequirements;
        /* 0x2C */ public GcFuelUseDifficultyOption FuelUse;
        /* 0x30 */ public GcLaunchFuelCostDifficultyOption LaunchFuelCost;
        /* 0x34 */ public GcCurrencyCostDifficultyOption CurrencyCost;
        /* 0x38 */ public GcItemShopAvailabilityDifficultyOption ItemShopAvailability;
        /* 0x3C */ public GcScannerRechargeDifficultyOption ScannerRecharge;
        /* 0x40 */ public GcReputationGainDifficultyOption ReputationGain;
        /* 0x44 */ public GcCreatureHostilityDifficultyOption CreatureHostility;
        /* 0x48 */ public GcCombatTimerDifficultyOption SpaceCombatTimers;
        /* 0x4C */ public GcCombatTimerDifficultyOption GroundCombatTimers;
        /* 0x50 */ public GcSprintingCostDifficultyOption SprintingCost;
        /* 0x54 */ public GcBreakTechOnDamageDifficultyOption BreakTechOnDamage;
    }
}
