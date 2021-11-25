using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0xBF8, GUID = 0x0FA39679EE602D48, NameHash = 0xFD6B0BE30E218605)]
    public class GcSeasonalGameModeData : NMSTemplate
    {
        /* 0x000 */ public int SeasonId;
        /* 0x008 */ public ulong StartTimeUTC;
        /* 0x010 */ public ulong EndTimeUTC;
        /* 0x018 */ public ulong Hash;
        /* 0x020 */ public NMSString0x20 Title;
        /* 0x040 */ public NMSString0x20 Subtitle;
        /* 0x060 */ public NMSString0x20 Description;
        /* 0x080 */ public GcGameMode GameMode;
        /* 0x084 */ public NMSString0x20 SeasonalUAOverride;
        /* 0x0A8 */ public ulong UAOverrideValue;
        /* 0x0B0 */ public NMSString0x10 FinalReward;
        /* 0x0C0 */ public NMSString0x20A FinalCantRewardMessage;
        /* 0x0E0 */ public NMSString0x200 FinalRewardDescription;
        /* 0x2E0 */ public TkTextureResource MainIcon;
        /* 0x364 */ public int SeasonNumber;
        /* 0x368 */ public int RemixNumber;
        /* 0x370 */ public NMSString0x20A SeasonName;
        /* 0x390 */ public NMSString0x20A SeasonNameUpper;
        /* 0x3B0 */ public NMSString0x20A MainMissionTitle;
        /* 0x3D0 */ public NMSString0x20A MainMissionMessage;
        /* 0x3F0 */ public List<NMSString0x10> AdditionalTradeProducts;
        /* 0x400 */ public int StartingSuitSlots;
        /* 0x404 */ public int StartingSuitTechSlots;
        /* 0x408 */ public int StartingSuitCargoSlots;
        /* 0x410 */ public GcSeed WeaponSeed;
        /* 0x420 */ public GcSeed ShipSeed;
        /* 0x430 */ public GcSpaceshipClasses ShipType;
        /* 0x434 */ public bool StartWithFreighter;
        /* 0x438 */ public GcAlienRace FreighterRace;
        /* 0x440 */ public List<GcBuildingClassification> ValidSpawnBuildings;
        /* 0x450 */ public GcInventoryLayout WeaponInventoryLayout;
        /* 0x470 */ public GcInventoryLayout ShipInventoryLayout;
        /* 0x490 */ public GcInventoryLayout ShipTechInventoryLayout;
        /* 0x4B0 */ public bool UseDefaultAppearance;
        /* 0x4B8 */ public GcInventoryContainer Inventory;
        /* 0x618 */ public GcInventoryContainer Inventory_TechOnly;
        /* 0x778 */ public GcInventoryContainer Inventory_Cargo;
        /* 0x8D8 */ public GcInventoryContainer ShipInventory;
        /* 0xA38 */ public GcInventoryContainer WeaponInventory;
        /* 0xB98 */ public List<GcSandwormTimerAndFrequencyOverride> SandwormOverrides;
        /* 0xBA8 */ public bool SandwormGlobalOverride;
        /* 0xBAC */ public float SandwormGlobalOverrideTimer;
        /* 0xBB0 */ public float SandwormGlobalOverrideSpawnChance;
        /* 0xBB4 */ public bool StartNextToShip;
        /* 0xBB8 */ public float DistanceFromShipAtStartOfGame;
        /* 0xBBC */ public bool ShipStartsDamaged;
        /* 0xBBD */ public bool AllowMissionDetailMessages;
        /* 0xBBE */ public bool UseStartPlanetObjectListOverrides;
        /* 0xBC0 */ public NMSString0x10 StartPlanetRareSubstanceOverride;
        /* 0xBD0 */ public List<GcSeasonalStage> Stages;
        /* 0xBE0 */ public GcScanEventTable ScanEventTable;
        /* 0xBF0 */ public bool CompatibleWithState;
    }
}
