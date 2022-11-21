using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x24B8F01541C7E2F3, NameHash = 0xFD6B0BE30E218605)]
    public class GcSeasonalGameModeData : NMSTemplate
    {
        /* 0x0000 */ public int SeasonId;
        /* 0x0008 */ public ulong StartTimeUTC;
        /* 0x0010 */ public ulong EndTimeUTC;
        /* 0x0018 */ public ulong Hash;
        /* 0x0020 */ public NMSString0x20 Title;
        /* 0x0040 */ public NMSString0x20 Subtitle;
        /* 0x0060 */ public NMSString0x20 Description;
        /* 0x0080 */ public NMSString0x20A FinalStageTitle;
        /* 0x00A0 */ public NMSString0x20A MilestoneWithStageLocId;
        /* 0x00C0 */ public GcGameMode GameMode;
        /* 0x00C4 */ public GcDifficultyPresetType DifficultySettingPreset;
        /* 0x00C8 */ public GcDifficultySettingsData DifficultyMinimums;
        /* 0x0120 */ public NMSString0x20 SeasonalUAOverride;
        /* 0x0140 */ public ulong UAOverrideValue;
        /* 0x0148 */ public NMSString0x10 FinalReward;
        /* 0x0158 */ public NMSString0x10 FinalRewardSwitchAlt;
        /* 0x0168 */ public NMSString0x20A FinalCantRewardMessage;
        /* 0x0188 */ public NMSString0x200 FinalRewardDescription;
        /* 0x0388 */ public TkTextureResource MainIcon;
        /* 0x040C */ public int SeasonNumber;
        /* 0x0410 */ public int RemixNumber;
        /* 0x0414 */ public int DisplayNumber;
        /* 0x0418 */ public NMSString0x20A SeasonName;
        /* 0x0438 */ public NMSString0x20A SeasonNameUpper;
        /* 0x0458 */ public NMSString0x20A MainMissionTitle;
        /* 0x0478 */ public NMSString0x20A MainMissionMessage;
        /* 0x0498 */ public bool DoCommunityMissionTextSubstitutions;
        /* 0x0499 */ public bool DefaultToPvPOff;
        /* 0x04A0 */ public List<NMSString0x10> AdditionalTradeProducts;
        /* 0x04B0 */ public List<NMSString0x10> NeverTradeProducts;
        /* 0x04C0 */ public int StartingSuitSlots;
        /* 0x04C4 */ public int StartingSuitTechSlots;
        /* 0x04C8 */ public int StartingSuitCargoSlots;
        /* 0x04D0 */ public GcSeed WeaponSeed;
        /* 0x04E0 */ public GcSeed ShipSeed;
        /* 0x04F0 */ public GcSpaceshipClasses ShipType;
        /* 0x04F4 */ public bool StartWithFreighter;
        /* 0x04F5 */ public NMSString0x80 FreighterBaseOverrideFilename;
        /* 0x0578 */ public GcAlienRace FreighterRace;
        /* 0x057C */ public bool StartAboardFreighter;
        /* 0x0580 */ public List<GcBuildingClassification> ValidSpawnBuildings;
        /* 0x0590 */ public GcInventoryLayout WeaponInventoryLayout;
        /* 0x05B0 */ public GcInventoryLayout ShipInventoryLayout;
        /* 0x05D0 */ public GcInventoryLayout ShipTechInventoryLayout;
        /* 0x05F0 */ public bool UseDefaultAppearance;
        /* 0x05F8 */ public GcInventoryContainer Inventory;
        /* 0x0750 */ public GcInventoryContainer Inventory_TechOnly;
        /* 0x08A8 */ public GcInventoryContainer Inventory_Cargo;
        /* 0x0A00 */ public GcInventoryContainer ShipInventory;
        /* 0x0B58 */ public GcInventoryContainer WeaponInventory;
        /* 0x0CB0 */ public bool UseRandomPet;
        /* 0x0CB8 */ public List<GcSeasonPetConstraints> RandomPetConstraints;
        [NMS(Size = 0x12)]
        /* 0x0CC8 */ public GcPetData[] SpecificPets;
        /* 0x3308 */ public List<GcSandwormTimerAndFrequencyOverride> SandwormOverrides;
        /* 0x3318 */ public bool SandwormGlobalOverride;
        /* 0x331C */ public float SandwormGlobalOverrideTimer;
        /* 0x3320 */ public float SandwormGlobalOverrideSpawnChance;
        /* 0x3324 */ public bool StartNextToShip;
        /* 0x3328 */ public float DistanceFromShipAtStartOfGame;
        /* 0x332C */ public bool ShipStartsDamaged;
        /* 0x332D */ public bool AllowMissionDetailMessages;
        /* 0x332E */ public bool UseStartPlanetObjectListOverrides;
        /* 0x3330 */ public NMSString0x10 StartPlanetRareSubstanceOverride;
        /* 0x3340 */ public bool TrashInventoryOnGalaxyTravel;
        /* 0x3344 */ public int FreighterBattleEarlyWarpsOverride;
        /* 0x3348 */ public bool ForceDeepSpaceAmbientFrigatesOnInfested;
        /* 0x334C */ public int TechCostMultiplier;
        /* 0x3350 */ public List<NMSString0x10> NeverLearnableTech;
        /* 0x3360 */ public List<NMSString0x10> ForgottenProducts;
        /* 0x3370 */ public bool IncreaseXClassTechOddsWithCommTier;
        /* 0x3374 */ public float AbandonedFreighterHazardProtectionMul;
        /* 0x3378 */ public float HazardProtectionDrainMultiplier;
        /* 0x337C */ public float EnergyDrainMultiplier;
        /* 0x3380 */ public int QuestSubstanceReducer;
        /* 0x3388 */ public List<GcSeasonalStage> Stages;
        /* 0x3398 */ public GcScanEventTable ScanEventTable;
        /* 0x33A8 */ public bool ResetSaveOnDeath;
        /* 0x33B0 */ public List<GcPersistedStatData> StatsToPersistOnReset;
        /* 0x33C0 */ public bool CompatibleWithState;
        /* 0x33C1 */ public bool HasBeenConverted;
        /* 0x33C8 */ public List<GcTechnology> TechnologyTable;
        /* 0x33D8 */ public List<GcProductData> ProductTable;
        /* 0x33E8 */ public List<GcRealitySubstanceData> SubstanceTable;
    }
}
