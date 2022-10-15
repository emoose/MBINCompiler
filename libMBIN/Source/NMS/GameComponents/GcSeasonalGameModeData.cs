using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x34841E219CBFD3D4, NameHash = 0xFD6B0BE30E218605)]
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
        /* 0x00C4 */ public GcDifficultySettingsData DifficultySettings;
        /* 0x011C */ public NMSString0x20 SeasonalUAOverride;
        /* 0x0140 */ public ulong UAOverrideValue;
        /* 0x0148 */ public NMSString0x10 FinalReward;
        /* 0x0158 */ public NMSString0x20A FinalCantRewardMessage;
        /* 0x0178 */ public NMSString0x200 FinalRewardDescription;
        /* 0x0378 */ public TkTextureResource MainIcon;
        /* 0x03FC */ public int SeasonNumber;
        /* 0x0400 */ public int RemixNumber;
        /* 0x0404 */ public int DisplayNumber;
        /* 0x0408 */ public NMSString0x20A SeasonName;
        /* 0x0428 */ public NMSString0x20A SeasonNameUpper;
        /* 0x0448 */ public NMSString0x20A MainMissionTitle;
        /* 0x0468 */ public NMSString0x20A MainMissionMessage;
        /* 0x0488 */ public bool DoCommunityMissionTextSubstitutions;
        /* 0x0489 */ public bool DefaultToPvPOff;
        /* 0x0490 */ public List<NMSString0x10> AdditionalTradeProducts;
        /* 0x04A0 */ public List<NMSString0x10> NeverTradeProducts;
        /* 0x04B0 */ public int StartingSuitSlots;
        /* 0x04B4 */ public int StartingSuitTechSlots;
        /* 0x04B8 */ public int StartingSuitCargoSlots;
        /* 0x04C0 */ public GcSeed WeaponSeed;
        /* 0x04D0 */ public GcSeed ShipSeed;
        /* 0x04E0 */ public GcSpaceshipClasses ShipType;
        /* 0x04E4 */ public bool StartWithFreighter;
        /* 0x04E5 */ public NMSString0x80 FreighterBaseOverrideFilename;
        /* 0x0568 */ public GcAlienRace FreighterRace;
        /* 0x056C */ public bool StartAboardFreighter;
        /* 0x0570 */ public List<GcBuildingClassification> ValidSpawnBuildings;
        /* 0x0580 */ public GcInventoryLayout WeaponInventoryLayout;
        /* 0x05A0 */ public GcInventoryLayout ShipInventoryLayout;
        /* 0x05C0 */ public GcInventoryLayout ShipTechInventoryLayout;
        /* 0x05E0 */ public bool UseDefaultAppearance;
        /* 0x05E8 */ public GcInventoryContainer Inventory;
        /* 0x0740 */ public GcInventoryContainer Inventory_TechOnly;
        /* 0x0898 */ public GcInventoryContainer Inventory_Cargo;
        /* 0x09F0 */ public GcInventoryContainer ShipInventory;
        /* 0x0B48 */ public GcInventoryContainer WeaponInventory;
        /* 0x0CA0 */ public bool UseRandomPet;
        /* 0x0CA8 */ public List<GcSeasonPetConstraints> RandomPetConstraints;
        [NMS(Size = 0x12)]
        /* 0x0CB8 */ public GcPetData[] SpecificPets;
        /* 0x32F8 */ public List<GcSandwormTimerAndFrequencyOverride> SandwormOverrides;
        /* 0x3308 */ public bool SandwormGlobalOverride;
        /* 0x330C */ public float SandwormGlobalOverrideTimer;
        /* 0x3310 */ public float SandwormGlobalOverrideSpawnChance;
        /* 0x3314 */ public bool StartNextToShip;
        /* 0x3318 */ public float DistanceFromShipAtStartOfGame;
        /* 0x331C */ public bool ShipStartsDamaged;
        /* 0x331D */ public bool AllowMissionDetailMessages;
        /* 0x331E */ public bool UseStartPlanetObjectListOverrides;
        /* 0x3320 */ public NMSString0x10 StartPlanetRareSubstanceOverride;
        /* 0x3330 */ public bool TrashInventoryOnGalaxyTravel;
        /* 0x3334 */ public int FreighterBattleEarlyWarpsOverride;
        /* 0x3338 */ public bool ForceDeepSpaceAmbientFrigatesOnInfested;
        /* 0x333C */ public int TechCostMultiplier;
        /* 0x3340 */ public List<NMSString0x10> NeverLearnableTech;
        /* 0x3350 */ public List<NMSString0x10> ForgottenProducts;
        /* 0x3360 */ public bool IncreaseXClassTechOddsWithCommTier;
        /* 0x3364 */ public float AbandonedFreighterHazardProtectionMul;
        /* 0x3368 */ public float HazardProtectionDrainMultiplier;
        /* 0x336C */ public float EnergyDrainMultiplier;
        /* 0x3370 */ public int QuestSubstanceReducer;
        /* 0x3378 */ public List<GcSeasonalStage> Stages;
        /* 0x3388 */ public GcScanEventTable ScanEventTable;
        /* 0x3398 */ public bool ResetSaveOnDeath;
        /* 0x33A0 */ public List<GcPersistedStatData> StatsToPersistOnReset;
        /* 0x33B0 */ public bool CompatibleWithState;
        /* 0x33B1 */ public bool HasBeenConverted;
        /* 0x33B8 */ public List<GcTechnology> TechnologyTable;
        /* 0x33C8 */ public List<GcProductData> ProductTable;
        /* 0x33D8 */ public List<GcRealitySubstanceData> SubstanceTable;
    }
}
