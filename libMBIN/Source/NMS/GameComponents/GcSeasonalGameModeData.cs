using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x3258, GUID = 0x57AE69416F4C74FD, NameHash = 0xFD6B0BE30E218605)]
    public class GcSeasonalGameModeData : NMSTemplate
    {
        /* 0x0000 */ public int SeasonId;
        /* 0x0008 */ public ulong StartTimeUTC;
        /* 0x0010 */ public ulong EndTimeUTC;
        /* 0x0018 */ public ulong Hash;
        /* 0x0020 */ public NMSString0x20 Title;
        /* 0x0040 */ public NMSString0x20 Subtitle;
        /* 0x0060 */ public NMSString0x20 Description;
        /* 0x0080 */ public GcGameMode GameMode;
        /* 0x0084 */ public NMSString0x20 SeasonalUAOverride;
        /* 0x00A8 */ public ulong UAOverrideValue;
        /* 0x00B0 */ public NMSString0x10 FinalReward;
        /* 0x00C0 */ public NMSString0x20A FinalCantRewardMessage;
        /* 0x00E0 */ public NMSString0x200 FinalRewardDescription;
        /* 0x02E0 */ public TkTextureResource MainIcon;
        /* 0x0364 */ public int SeasonNumber;
        /* 0x0368 */ public int RemixNumber;
        /* 0x036C */ public int DisplayNumber;
        /* 0x0370 */ public NMSString0x20A SeasonName;
        /* 0x0390 */ public NMSString0x20A SeasonNameUpper;
        /* 0x03B0 */ public NMSString0x20A MainMissionTitle;
        /* 0x03D0 */ public NMSString0x20A MainMissionMessage;
        /* 0x03F0 */ public List<NMSString0x10> AdditionalTradeProducts;
        /* 0x0400 */ public int StartingSuitSlots;
        /* 0x0404 */ public int StartingSuitTechSlots;
        /* 0x0408 */ public int StartingSuitCargoSlots;
        /* 0x0410 */ public GcSeed WeaponSeed;
        /* 0x0420 */ public GcSeed ShipSeed;
        /* 0x0430 */ public GcSpaceshipClasses ShipType;
        /* 0x0434 */ public bool StartWithFreighter;
        /* 0x0438 */ public GcAlienRace FreighterRace;
        /* 0x0440 */ public List<GcBuildingClassification> ValidSpawnBuildings;
        /* 0x0450 */ public GcInventoryLayout WeaponInventoryLayout;
        /* 0x0470 */ public GcInventoryLayout ShipInventoryLayout;
        /* 0x0490 */ public GcInventoryLayout ShipTechInventoryLayout;
        /* 0x04B0 */ public bool UseDefaultAppearance;
        /* 0x04B8 */ public GcInventoryContainer Inventory;
        /* 0x0618 */ public GcInventoryContainer Inventory_TechOnly;
        /* 0x0778 */ public GcInventoryContainer Inventory_Cargo;
        /* 0x08D8 */ public GcInventoryContainer ShipInventory;
        /* 0x0A38 */ public GcInventoryContainer WeaponInventory;
        /* 0x0B98 */ public bool UseRandomPet;
        /* 0x0BA0 */ public List<GcSeasonPetConstraints> RandomPetConstraints;
        [NMS(Size = 0x12)]
        /* 0x0BB0 */ public GcPetData[] SpecificPets;
        /* 0x31F0 */ public List<GcSandwormTimerAndFrequencyOverride> SandwormOverrides;
        /* 0x3200 */ public bool SandwormGlobalOverride;
        /* 0x3204 */ public float SandwormGlobalOverrideTimer;
        /* 0x3208 */ public float SandwormGlobalOverrideSpawnChance;
        /* 0x320C */ public bool StartNextToShip;
        /* 0x3210 */ public float DistanceFromShipAtStartOfGame;
        /* 0x3214 */ public bool ShipStartsDamaged;
        /* 0x3215 */ public bool AllowMissionDetailMessages;
        /* 0x3216 */ public bool UseStartPlanetObjectListOverrides;
        /* 0x3218 */ public NMSString0x10 StartPlanetRareSubstanceOverride;
        /* 0x3228 */ public bool TrashInventoryOnGalaxyTravel;
        /* 0x322C */ public int FreighterBattleEarlyWarpsOverride;
        /* 0x3230 */ public List<GcSeasonalStage> Stages;
        /* 0x3240 */ public GcScanEventTable ScanEventTable;
        /* 0x3250 */ public bool CompatibleWithState;
    }
}
