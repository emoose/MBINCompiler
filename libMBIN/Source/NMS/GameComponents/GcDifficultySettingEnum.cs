namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCF82836F1D821B6E, NameHash = 0x42FEEB238F6504DE)]
    public class GcDifficultySettingEnum : NMSTemplate
    {
        // size: 0x1B
        public enum DifficultySettingEnum {
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
        /* 0x0 */ public DifficultySettingEnum DifficultySetting;
    }
}
