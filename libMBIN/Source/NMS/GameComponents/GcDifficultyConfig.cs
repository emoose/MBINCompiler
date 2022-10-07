using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x65E2E832089B57A2, NameHash = 0xA688E4255C8FED76)]
    public class GcDifficultyConfig : NMSTemplate
    {
        /* 0x0000 */ public NMSString0x20A PresetLocId;
        // size: 0x7
        public enum PresetOptionLocIdsEnum {
            Invalid,
            Custom,
            Normal,
            Creative,
            Relaxed,
            Survival,
            Permadeath
        }
        [NMS(Size = 0x7, EnumType = typeof(PresetOptionLocIdsEnum))]
        /* 0x0020 */ public NMSString0x20A[] PresetOptionLocIds;
        // size: 0x7
        public enum PresetsEnum {
            Invalid,
            Custom,
            Normal,
            Creative,
            Relaxed,
            Survival,
            Permadeath
        }
        [NMS(Size = 0x7, EnumType = typeof(PresetsEnum))]
        /* 0x0100 */ public GcDifficultySettingsData[] Presets;
        /* 0x0368 */ public GcDifficultySettingsData PermadeathMinSettings;
        // size: 0x4
        public enum UILayoutEnum {
            Survival,
            Crafting,
            Combat,
            Ease
        }
        [NMS(Size = 0x4, EnumType = typeof(UILayoutEnum))]
        /* 0x03C0 */ public GcDifficultyOptionUIGroup[] UILayout;
        // size: 0x1B
        public enum CommonSettingsDataEnum {
            InventoriesAlwaysInRange,
            AllSlotsUnlocked,
            WarpDriveRequirements,
            CraftingIsFree,
            TutorialEnabled,
            StartWithAllItemsKnown,
            BaseAutoPower,
            DeathConsequences,
            DamageReceived,
            DamageGiven,
            ActiveSurvivalBars,
            HazardDrain,
            EnergyDrain,
            SubstanceCollection,
            InventoryStackLimits,
            ChargingRequirements,
            FuelUse,
            LaunchFuelCost,
            CurrencyCost,
            ScannerRecharge,
            ReputationGain,
            CreatureHostility,
            SpaceCombat,
            GroundCombat,
            ItemShopAvailablity,
            SprintingCost,
            BreakTechOnDamage
        }
        [NMS(Size = 0x1B, EnumType = typeof(CommonSettingsDataEnum))]
        /* 0x0480 */ public GcDifficultySettingCommonData[] CommonSettingsData;
        /* 0x13B0 */ public GcDifficultyStartWithAllItemsKnownOptionData StartWithAllItemsKnownDisabledData;
        /* 0x16C0 */ public GcDifficultyStartWithAllItemsKnownOptionData StartWithAllItemsKnownEnabledData;
        // size: 0x3
        public enum CreatureHostilityOptionLocIdsEnum {
            NeverAttack,
            AttackIfProvoked,
            FullEcosystem
        }
        [NMS(Size = 0x3, EnumType = typeof(CreatureHostilityOptionLocIdsEnum))]
        /* 0x19D0 */ public NMSString0x20A[] CreatureHostilityOptionLocIds;
        // size: 0x4
        public enum DeathConsequencesOptionLocIdsEnum {
            None,
            ItemGrave,
            DestroyItems,
            DestroySave
        }
        [NMS(Size = 0x4, EnumType = typeof(DeathConsequencesOptionLocIdsEnum))]
        /* 0x1A30 */ public NMSString0x20A[] DeathConsequencesOptionLocIds;
        // size: 0x4
        public enum DamageReceivedOptionLocIdsEnum {
            None,
            Low,
            Normal,
            High
        }
        [NMS(Size = 0x4, EnumType = typeof(DamageReceivedOptionLocIdsEnum))]
        /* 0x1AB0 */ public NMSString0x20A[] DamageReceivedOptionLocIds;
        // size: 0x4
        public enum DamageReceivedMultipliersEnum {
            None,
            Low,
            Normal,
            High
        }
        [NMS(Size = 0x4, EnumType = typeof(DamageReceivedMultipliersEnum))]
        /* 0x1B30 */ public float[] DamageReceivedMultipliers;
        // size: 0x3
        public enum DamageGivenOptionLocIdsEnum {
            High,
            Normal,
            Low
        }
        [NMS(Size = 0x3, EnumType = typeof(DamageGivenOptionLocIdsEnum))]
        /* 0x1B40 */ public NMSString0x20A[] DamageGivenOptionLocIds;
        // size: 0x3
        public enum DamageGivenMultipliersEnum {
            High,
            Normal,
            Low
        }
        [NMS(Size = 0x3, EnumType = typeof(DamageGivenMultipliersEnum))]
        /* 0x1BA0 */ public float[] DamageGivenMultipliers;
        // size: 0x4
        public enum ActiveSurvivalBarsOptionLocIdsEnum {
            None,
            HealthOnly,
            HealthAndHazard,
            All
        }
        [NMS(Size = 0x4, EnumType = typeof(ActiveSurvivalBarsOptionLocIdsEnum))]
        /* 0x1BB0 */ public NMSString0x20A[] ActiveSurvivalBarsOptionLocIds;
        // size: 0x3
        public enum HazardDrainOptionLocIdsEnum {
            Slow,
            Normal,
            Fast
        }
        [NMS(Size = 0x3, EnumType = typeof(HazardDrainOptionLocIdsEnum))]
        /* 0x1C30 */ public NMSString0x20A[] HazardDrainOptionLocIds;
        // size: 0x3
        public enum HazardDrainMultipliersEnum {
            Slow,
            Normal,
            Fast
        }
        [NMS(Size = 0x3, EnumType = typeof(HazardDrainMultipliersEnum))]
        /* 0x1C90 */ public float[] HazardDrainMultipliers;
        // size: 0x3
        public enum EnergyDrainOptionLocIdsEnum {
            Slow,
            Normal,
            Fast
        }
        [NMS(Size = 0x3, EnumType = typeof(EnergyDrainOptionLocIdsEnum))]
        /* 0x1CA0 */ public NMSString0x20A[] EnergyDrainOptionLocIds;
        // size: 0x3
        public enum EnergyDrainMultipliersEnum {
            Slow,
            Normal,
            Fast
        }
        [NMS(Size = 0x3, EnumType = typeof(EnergyDrainMultipliersEnum))]
        /* 0x1D00 */ public float[] EnergyDrainMultipliers;
        // size: 0x3
        public enum SubstanceCollectionOptionLocIdsEnum {
            High,
            Normal,
            Low
        }
        [NMS(Size = 0x3, EnumType = typeof(SubstanceCollectionOptionLocIdsEnum))]
        /* 0x1D10 */ public NMSString0x20A[] SubstanceCollectionOptionLocIds;
        // size: 0x3
        public enum SubstanceCollectionMultipliersEnum {
            High,
            Normal,
            Low
        }
        [NMS(Size = 0x3, EnumType = typeof(SubstanceCollectionMultipliersEnum))]
        /* 0x1D70 */ public float[] SubstanceCollectionMultipliers;
        // size: 0x3
        public enum SubstanceCollectionLaserAmountEnum {
            High,
            Normal,
            Low
        }
        [NMS(Size = 0x3, EnumType = typeof(SubstanceCollectionLaserAmountEnum))]
        /* 0x1D7C */ public int[] SubstanceCollectionLaserAmount;
        // size: 0x3
        public enum InventoryStackLimitsOptionLocIdsEnum {
            High,
            Normal,
            Low
        }
        [NMS(Size = 0x3, EnumType = typeof(InventoryStackLimitsOptionLocIdsEnum))]
        /* 0x1D88 */ public NMSString0x20A[] InventoryStackLimitsOptionLocIds;
        // size: 0x3
        public enum InventoryStackLimitsOptionDataEnum {
            High,
            Normal,
            Low
        }
        [NMS(Size = 0x3, EnumType = typeof(InventoryStackLimitsOptionDataEnum))]
        /* 0x1DE8 */ public GcDifficultyInventoryStackSizeOptionData[] InventoryStackLimitsOptionData;
        // size: 0x4
        public enum ChargingRequirementsOptionLocIdsEnum {
            None,
            Low,
            Normal,
            High
        }
        [NMS(Size = 0x4, EnumType = typeof(ChargingRequirementsOptionLocIdsEnum))]
        /* 0x1F20 */ public NMSString0x20A[] ChargingRequirementsOptionLocIds;
        // size: 0x4
        public enum ChargingRequirementsMultipliersEnum {
            None,
            Low,
            Normal,
            High
        }
        [NMS(Size = 0x4, EnumType = typeof(ChargingRequirementsMultipliersEnum))]
        /* 0x1FA0 */ public float[] ChargingRequirementsMultipliers;
        // size: 0x4
        public enum FuelUseOptionLocIdsEnum {
            Free,
            Cheap,
            Normal,
            Expensive
        }
        [NMS(Size = 0x4, EnumType = typeof(FuelUseOptionLocIdsEnum))]
        /* 0x1FB0 */ public NMSString0x20A[] FuelUseOptionLocIds;
        // size: 0x4
        public enum FuelUseOptionDataEnum {
            Free,
            Cheap,
            Normal,
            Expensive
        }
        [NMS(Size = 0x4, EnumType = typeof(FuelUseOptionDataEnum))]
        /* 0x2030 */ public GcDifficultyFuelUseOptionData[] FuelUseOptionData;
        // size: 0x4
        public enum LaunchFuelCostOptionLocIdsEnum {
            Free,
            Low,
            Normal,
            High
        }
        [NMS(Size = 0x4, EnumType = typeof(LaunchFuelCostOptionLocIdsEnum))]
        /* 0x2090 */ public NMSString0x20A[] LaunchFuelCostOptionLocIds;
        // size: 0x4
        public enum LaunchFuelCostMultipliersEnum {
            Free,
            Low,
            Normal,
            High
        }
        [NMS(Size = 0x4, EnumType = typeof(LaunchFuelCostMultipliersEnum))]
        /* 0x2110 */ public float[] LaunchFuelCostMultipliers;
        // size: 0x4
        public enum ShipSummoningFuelCostMultipliersEnum {
            Free,
            Low,
            Normal,
            High
        }
        [NMS(Size = 0x4, EnumType = typeof(ShipSummoningFuelCostMultipliersEnum))]
        /* 0x2120 */ public float[] ShipSummoningFuelCostMultipliers;
        // size: 0x4
        public enum CurrencyCostOptionLocIdsEnum {
            Free,
            Cheap,
            Normal,
            Expensive
        }
        [NMS(Size = 0x4, EnumType = typeof(CurrencyCostOptionLocIdsEnum))]
        /* 0x2130 */ public NMSString0x20A[] CurrencyCostOptionLocIds;
        // size: 0x4
        public enum CurrencyCostOptionDataEnum {
            Free,
            Cheap,
            Normal,
            Expensive
        }
        [NMS(Size = 0x4, EnumType = typeof(CurrencyCostOptionDataEnum))]
        /* 0x21B0 */ public GcDifficultyCurrencyCostOptionData[] CurrencyCostOptionData;
        // size: 0x3
        public enum ItemShopAvailabilityOptionLocIdsEnum {
            High,
            Normal,
            Low
        }
        [NMS(Size = 0x3, EnumType = typeof(ItemShopAvailabilityOptionLocIdsEnum))]
        /* 0x2210 */ public NMSString0x20A[] ItemShopAvailabilityOptionLocIds;
        // size: 0x3
        public enum ItemShopAvailabilityOptionDataEnum {
            High,
            Normal,
            Low
        }
        [NMS(Size = 0x3, EnumType = typeof(ItemShopAvailabilityOptionDataEnum))]
        /* 0x2270 */ public GcItemShopAvailabilityDifficultyOptionData[] ItemShopAvailabilityOptionData;
        // size: 0x4
        public enum ScannerRechargeOptionLocIdsEnum {
            VeryFast,
            Fast,
            Normal,
            Slow
        }
        [NMS(Size = 0x4, EnumType = typeof(ScannerRechargeOptionLocIdsEnum))]
        /* 0x22A0 */ public NMSString0x20A[] ScannerRechargeOptionLocIds;
        // size: 0x4
        public enum ScannerRechargeMultipliersEnum {
            VeryFast,
            Fast,
            Normal,
            Slow
        }
        [NMS(Size = 0x4, EnumType = typeof(ScannerRechargeMultipliersEnum))]
        /* 0x2320 */ public float[] ScannerRechargeMultipliers;
        // size: 0x4
        public enum ReputationGainOptionLocIdsEnum {
            VeryFast,
            Fast,
            Normal,
            Slow
        }
        [NMS(Size = 0x4, EnumType = typeof(ReputationGainOptionLocIdsEnum))]
        /* 0x2330 */ public NMSString0x20A[] ReputationGainOptionLocIds;
        // size: 0x4
        public enum ReputationGainMultipliersEnum {
            VeryFast,
            Fast,
            Normal,
            Slow
        }
        [NMS(Size = 0x4, EnumType = typeof(ReputationGainMultipliersEnum))]
        /* 0x23B0 */ public float[] ReputationGainMultipliers;
        // size: 0x4
        public enum SpaceCombatOptionLocIdsEnum {
            Off,
            Slow,
            Normal,
            Fast
        }
        [NMS(Size = 0x4, EnumType = typeof(SpaceCombatOptionLocIdsEnum))]
        /* 0x23C0 */ public NMSString0x20A[] SpaceCombatOptionLocIds;
        // size: 0x4
        public enum SpaceCombatMultipliersEnum {
            Off,
            Slow,
            Normal,
            Fast
        }
        [NMS(Size = 0x4, EnumType = typeof(SpaceCombatMultipliersEnum))]
        /* 0x2440 */ public float[] SpaceCombatMultipliers;
        // size: 0x4
        public enum GroundCombatOptionLocIdsEnum {
            Off,
            Slow,
            Normal,
            Fast
        }
        [NMS(Size = 0x4, EnumType = typeof(GroundCombatOptionLocIdsEnum))]
        /* 0x2450 */ public NMSString0x20A[] GroundCombatOptionLocIds;
        // size: 0x4
        public enum GroundCombatMultipliersEnum {
            Off,
            Slow,
            Normal,
            Fast
        }
        [NMS(Size = 0x4, EnumType = typeof(GroundCombatMultipliersEnum))]
        /* 0x24D0 */ public float[] GroundCombatMultipliers;
        // size: 0x4
        public enum SentinelTimeOutMultipliersEnum {
            Off,
            Slow,
            Normal,
            Fast
        }
        [NMS(Size = 0x4, EnumType = typeof(SentinelTimeOutMultipliersEnum))]
        /* 0x24E0 */ public float[] SentinelTimeOutMultipliers;
        // size: 0x3
        public enum SprintingOptionLocIdsEnum {
            Free,
            Low,
            Full
        }
        [NMS(Size = 0x3, EnumType = typeof(SprintingOptionLocIdsEnum))]
        /* 0x24F0 */ public NMSString0x20A[] SprintingOptionLocIds;
        // size: 0x3
        public enum SprintingCostMultipliersEnum {
            Free,
            Low,
            Full
        }
        [NMS(Size = 0x3, EnumType = typeof(SprintingCostMultipliersEnum))]
        /* 0x2550 */ public float[] SprintingCostMultipliers;
        // size: 0x3
        public enum BreakTechOnDamageOptionLocIdsEnum {
            None,
            Low,
            High
        }
        [NMS(Size = 0x3, EnumType = typeof(BreakTechOnDamageOptionLocIdsEnum))]
        /* 0x2560 */ public NMSString0x20A[] BreakTechOnDamageOptionLocIds;
        // size: 0x3
        public enum BreakTechOnDamageMultipliersEnum {
            None,
            Low,
            High
        }
        [NMS(Size = 0x3, EnumType = typeof(BreakTechOnDamageMultipliersEnum))]
        /* 0x25C0 */ public float[] BreakTechOnDamageMultipliers;
    }
}
