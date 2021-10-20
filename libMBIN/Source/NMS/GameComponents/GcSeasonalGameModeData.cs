using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0xBE0, GUID = 0x8258EDE519B5C7EE, NameHash = 0xFD6B0BE30E218605)]
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
        /* 0x368 */ public NMSString0x20A SeasonName;
        /* 0x388 */ public NMSString0x20A SeasonNameUpper;
        /* 0x3A8 */ public NMSString0x20A MainMissionTitle;
        /* 0x3C8 */ public NMSString0x20A MainMissionMessage;
        /* 0x3E8 */ public List<NMSString0x10> AdditionalTradeProducts;
        /* 0x3F8 */ public int StartingSuitSlots;
        /* 0x3FC */ public int StartingSuitTechSlots;
        /* 0x400 */ public int StartingSuitCargoSlots;
        /* 0x408 */ public GcSeed WeaponSeed;
        /* 0x418 */ public GcSeed ShipSeed;
        /* 0x428 */ public GcSpaceshipClasses ShipType;
        /* 0x42C */ public bool StartWithFreighter;
        /* 0x430 */ public GcAlienRace FreighterRace;
        /* 0x438 */ public List<GcBuildingClassification> ValidSpawnBuildings;
        /* 0x448 */ public GcInventoryLayout WeaponInventoryLayout;
        /* 0x468 */ public GcInventoryLayout ShipInventoryLayout;
        /* 0x488 */ public GcInventoryLayout ShipTechInventoryLayout;
        /* 0x4A8 */ public bool UseDefaultAppearance;
        /* 0x4B0 */ public GcInventoryContainer Inventory;
        /* 0x610 */ public GcInventoryContainer Inventory_TechOnly;
        /* 0x770 */ public GcInventoryContainer Inventory_Cargo;
        /* 0x8D0 */ public GcInventoryContainer ShipInventory;
        /* 0xA30 */ public GcInventoryContainer WeaponInventory;
        /* 0xB90 */ public List<GcSandwormTimerAndFrequencyOverride> SandwormOverrides;
        /* 0xBA0 */ public bool SandwormGlobalOverride;
        /* 0xBA4 */ public float SandwormGlobalOverrideTimer;
        /* 0xBA8 */ public float SandwormGlobalOverrideSpawnChance;
        /* 0xBAC */ public bool StartNextToShip;
        /* 0xBB0 */ public float DistanceFromShipAtStartOfGame;
        /* 0xBB4 */ public bool ShipStartsDamaged;
        /* 0xBB5 */ public bool AllowMissionDetailMessages;
        /* 0xBB8 */ public List<GcSeasonalStage> Stages;
        /* 0xBC8 */ public GcScanEventTable ScanEventTable;
        /* 0xBD8 */ public bool CompatibleWithState;
    }
}
