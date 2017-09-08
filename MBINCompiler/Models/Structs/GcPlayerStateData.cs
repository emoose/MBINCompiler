using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    [NMS(Size = 0x4EA40)]
    public class GcPlayerStateData : NMSTemplate
    {
        /* 0x00000 */ public GcUniverseAddressData UniverseAddress;

        /* 0x00018 */ public GcInventoryContainer Inventory;
        /* 0x00078 */ public GcInventoryContainer Inventory_TechOnly;
        /* 0x000D8 */ public GcInventoryContainer Inventory_Cargo;
        /* 0x00138 */ public GcInventoryContainer ShipInventory;
        /* 0x00198 */ public GcInventoryContainer WeaponInventory;
        /* 0x001F8 */ public GcInventoryContainer GraveInventory;

        /* 0x00258 */ public bool SpawnGrave;
        /* 0x00259 */ public bool SpaceGrave;
        [NMS(Size = 2, Ignore = true)]
        /* 0x0025A */ public byte[] Padding25A;

        /* 0x0025C */ public GcUniverseAddressData GraveUniverseAddress;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x00274 */ public byte[] Padding274;

        /* 0x00280 */ public Vector4f GravePosition;
        /* 0x00290 */ public Vector4f GraveMatrixLookAt;
        /* 0x002A0 */ public Vector4f GraveMatrixUp;

        /* 0x002B0 */ public GcInventoryLayout ShipLayout;
        /* 0x002D0 */ public GcInventoryLayout WeaponLayout;

        /* 0x002F0 */ public GcResourceElement CurrentShip;

        /* 0x00598 */ public GcExactResource CurrentWeapon;

        /* 0x00628 */ public List<NMSString0x10> KnownTech;
        /* 0x00638 */ public List<NMSString0x10> KnownProducts;

        /* 0x00648 */ public List<GcWordKnowledge> KnownWords;

        /* 0x00658 */ public List<GcPlayerMissionProgress> MissionProgress;

        /* 0x00668 */ public int PostMissionIndex;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x0066C */ public byte[] Padding66C;
        [NMS(Size = 0x10)]
        /* 0x00670 */ public string CurrentMissionID;
        /* 0x00680 */ public ulong CurrentMissionSeed;
        [NMS(Size = 0x10)]
        /* 0x00688 */ public string PreviousMissionID;
        /* 0x00698 */ public ulong PreviousMissionSeed;
        /* 0x006A0 */ public GcInteractionData HoloExplorerInteraction;
        /* 0x006C0 */ public GcInteractionData HoloScepticInteraction;
        /* 0x006E0 */ public GcInteractionData HoloNooneInteraction;
        /* 0x00700 */ public int Health;
		/* 0x00704 */ public int ShipHealth;
        /* 0x00708 */ public int Shield;
		/* 0x0070C */ public int ShipShield;
		/* 0x00710 */ public int Energy;
        /* 0x00714 */ public int Units;
        /* 0x00718 */ public ulong TimeAlive;
        /* 0x00720 */ public ulong TotalPlayTime;

        /* 0x00728 */ public List<GcScanEventSave> MarkerStack;
                    //[NMS(Size = 0x3E8)]
                    ///* 0x00738 */ public ulong[] CompletedInteractions;

        /* 0x00738 */ public List<GcPlayerStatsGroup> Stats;

        [NMS(Size = 0x8, Ignore = true)]
        /* 0x00748 */ public byte[] Padding748;

        [NMS(Size = 8, EnumValue = new[] { "Distress_Signal", "Crate", "Destructable", "Terrain", "Cost", "Building", "Creature", "Maintenance" })]
        /* 0x00750 */ public GcInteractionBuffer[] StoredInteractions;

        /* 0x3EF50 */ public List<GcMaintenanceContainer> MaintenanceInteractions;
        /* 0x3EF60 */ public List<ulong> VisitedSystems; // possibly?

        [NMS(Size = 6)]
        /* 0x3EF70 */ public float[] Hazard;

        /* 0x3EF88 */ public int BoltAmmo;
        /* 0x3EF8C */ public int LaserAmmo;
        /* 0x3EF90 */ public int GrenadeAmmo;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x3EF94 */ public byte[] Padding3EF94;

        /* 0x3EFA0 */ public Vector4f FirstSpawnPosition;

        [NMS(Size = 0x3E, EnumValue = new[] {
                "None", "Shop", "NPC", "NPC_Secondary", "NPC_Anomaly", "NPC_Anomaly_Secondary", "Ship", "Outpost",
                "SpaceStation", "RadioTower", "Monolith", "Factory", "AbandonedShip", "Harvester", "Observatory", "TradingPost",
                "DistressBeacon", "Portal", "Plaque", "AtlasStation", "AbandonedBuildings", "WeaponTerminal", "SuitTerminal", "SignalScanner",
                "Teleporter_Base", "Teleporter_Station", "ClaimBase", "NPC_Freighter_Captain", "NPC_HIRE_Weapons", "NPC_HIRE_Weapons_Wait",
                "NPC_HIRE_Farmer", "NPC_HIRE_Farmer_Wait", "NPC_HIRE_Builder", "NPC_HIRE_Builder_Wait", "NPC_HIRE_Vehicles", "NPC_HIRE_Vehicles_Wait",
                "MessageBeacon", "NPC_HIRE_Scientist", "NPC_HIRE_Scientist_Wait", "NPC_Recruit", "NPC_Freighter_Captain_Secondary", "NPC_Recruit_Secondary",
                "Vehicle", "MessageModule", "TechShop", "VehicleRaseStart", "BuildingShop", "MissionGiver", "HoloHub", "HoloExplorer", "HoloSceptic", "HoloNoone",
                "PortalRunEntry", "PortalActivate", "CrashedFreighter", "GraveInCave", "GlitchyStroyBox", "NetworkPlayer", "NetworkMonument",
                "AnomalyComputer", "AtlasPlinth", "Epilogue" })]
        /* 0x3EFB0 */ public GcSavedInteractionRaceData[] SavedInteractionIndicies;

        /* 0x3F678 */ public List<NMSString0x10> InteractionProgressTable;

        [NMS(Size = 0xA)]
        /* 0x3F688 */ public GcUniverseAddressData[] AtlasStationAdressData;
        [NMS(Size = 0xB)]
        /* 0x3F778 */ public GcUniverseAddressData[] NewAtlasStationAdressData;

        /* 0x3F880 */ public List<GcUniverseAddressData> VisitedAtlasStationsData;

        /* 0x3F890 */ public bool FirstAtlasStationDiscovered;
        /* 0x3F894 */ public int ProgressionLevel;
        /* 0x3F898 */ public bool IsNew;
        /* 0x3F899 */ public bool UseSmallerBlackholeJumps;

        [NMS(Size = 0x6, Ignore = true)]
        /* 0x3F89A */ public byte[] Padding3F89A;

        /* 0x3F8A0 */ public List<GcSavedEntitlement> UsedEntitlements;

        [NMS(Size = 0x10)]
        /* 0x3F8B0 */ public Vector4f[] PlanetPositions;

        [NMS(Size = 0x10)]
        /* 0x3F9B0 */ public GcSeed[] PlanetSeeds;

        /* 0x3FAB0 */ public int PrimaryPlanet;
        [NMS(Size = 4, Ignore = true)]
        /* 0x3FAB4 */ public byte[] Padding3FAB4;

        /* 0x3FAB8 */ public ulong TimeLastSpaceBattle;
        /* 0x3FAC0 */ public int WarpsLastSpaceBattle;
        [NMS(Size = 4, Ignore = true)]
        /* 0x3FAC4 */ public byte[] Padding3FAC4;

        /* 0x3FAC8 */ public ulong TimeLastMiniStation;
        /* 0x3FAD0 */ public int WarpsLastMiniStation;
        [NMS(Size = 4, Ignore = true)]
        /* 0x3FAD4 */ public byte[] Padding3FAD4;

        /* 0x3FAD8 */ public ulong MiniStationUA;
        /* 0x3FAE0 */ public Vector4f AnomalyPositionOverride;

        /* 0x3FAF0 */ public GcUniverseAddressData GameStartAddress1;
        /* 0x3FB08 */ public GcUniverseAddressData GameStartAddress2;

        [NMS(Size = 0x10)]
        /* 0x3FB20 */ public bool[] GalacticMapRequests;

        /* 0x3FB30 */ public Vector4f FirstShipPosition;

        /* 0x3FB40 */ public float SavedSunAngle;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x3FB44 */ public byte[] Padding3FB44;

        /* 0x3FB50 */ public Vector4f SavedSunAxis;

        /* 0x3FB60 */ public ulong HazardTimeAlive;

        /* 0x3FB68 */ public bool RevealBlackHoles;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x3FB69 */ public byte[] Padding3FB69;

        /* 0x3FB70 */ public GcResourceElement CurrentFreighter;
        /* 0x3FE18 */ public GcInventoryLayout FreighterLayout;
        /* 0x3FE38 */ public GcInventoryContainer FreighterInventory;
        /* 0x3FE98 */ public GcInventoryContainer FreighterInventory_TechOnly;
        /* 0x3FEF8 */ public GcUniverseAddressData FreighterUniverseAddress;
        /* 0x3FF10 */ public List<GcPersistentBBObjectData> BaseBuildingObjects;
        /* 0x3FF20 */ public GcTerrainEditsBuffer TerrainEditData;
        [NMS(Size = 0x5)]
        /* 0x4ABE0 */ public GcNPCWorkerData[] NPCWorkers;
        [NMS(Size = 0x3)]
        /* 0x4B9A0 */ public GcPersistentBase[] PersistentPlayerBases;
        /* 0x4BE50 */ public List<GcTeleportEndpoint> TeleportEndpoints;
                //[NMS(Size = 0x2F)]
                ///* 0x4BE60 */ public ulong[] SavedInteractionTimes;

        // I am just going to forget about fixing the offsets here... too much effort... The correct offsets will continue afterwards...

        /* 0x4BE60 */ public GcInventoryLayout Chest1Layout;
        /* 0x4BE80 */ public GcInventoryContainer Chest1Inventory;
        /* 0x4BEE0 */ public GcInventoryLayout Chest2Layout;
        /* 0x4BF00 */ public GcInventoryContainer Chest2Inventory;
        /* 0x4BF60 */ public GcInventoryLayout Chest3Layout;
        /* 0x4BF80 */ public GcInventoryContainer Chest3Inventory;
        /* 0x4BFE0 */ public GcInventoryLayout Chest4Layout;
        /* 0x4C000 */ public GcInventoryContainer Chest4Inventory;
        /* 0x4C060 */ public GcInventoryLayout Chest5Layout;
        /* 0x4C080 */ public GcInventoryContainer Chest5Inventory;
        /* 0x4C0E0 */ public GcInventoryLayout Chest6Layout;
        /* 0x4C100 */ public GcInventoryContainer Chest6Inventory;
        /* 0x4C160 */ public GcInventoryLayout Chest7Layout;
        /* 0x4C180 */ public GcInventoryContainer Chest7Inventory;
        /* 0x4C1E0 */ public GcInventoryLayout Chest8Layout;
        /* 0x4C200 */ public GcInventoryContainer Chest8Inventory;
        /* 0x4C260 */ public GcInventoryLayout Chest9Layout;
        /* 0x4C280 */ public GcInventoryContainer Chest9Inventory;
        /* 0x4C2E0 */ public GcInventoryLayout Chest10Layout;
        /* 0x4C300 */ public GcInventoryContainer Chest10Inventory;
        /* 0x4C360 */ public GcInventoryLayout ChestMagicLayout;
        /* 0x4C380 */ public GcInventoryContainer ChestMagicInventory;
        /* 0x4C3E0 */ public GcInventoryLayout ChestMagic2Layout;
        /* 0x4C400 */ public GcInventoryContainer ChestMagic2Inventory;
        /* 0x4C460 */ public GcResourceElement CurrentFreighterNPC;

        [NMS(Size = 0x8, Ignore = true)]
        /* 0x4C708 */ public byte[] Padding4C708;

        [NMS(Size = 0x3)]
        /* 0x4C710 */ public GcPlayerOwnershipData[] VehicleOwnership;
        /* 0x4D280 */ public int PrimaryVehicle;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x4D284 */ public byte[] Padding4D284;
        [NMS(Size = 0x6)]
        /* 0x4D290 */ public GcPlayerOwnershipData[] ShipOwnership;
        /* 0x4E970 */ public int PrimaryShip;

        /* 0x4E974 */ public bool MultiShipEnabled;
        [NMS(Size = 0x20)]
        /* 0x4E975 */ public string PlayerWeaponName;
        [NMS(Size = 0x20)]
        /* 0x4E995 */ public string PlayerFreighterName;
        [NMS(Size = 0xB, Ignore = true)]
        /* 0x4E9B5 */ public byte[] Padding4E9B5;
        /* 0x4E9C0 */ public Vector4f StartGameShipPosition;
        /* 0x4E9D0 */ public int TradingSupplyDataIndex;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x4E9D4 */ public byte[] Padding4E9D4;
        /* 0x4E9D8 */ public List<GcTradingSupplyData> TradingSupplyData;
        /* 0x4E9E8 */ public List<GcPortalData> LastPortal;     // just a guess...
        /* 0x4E9F8 */ public GcPortalSaveData VisitedPortal;
        /* 0x4EA10 */ public int KnownPortalRunes;
        /* 0x4EA14 */ public bool OnOtherSideOfPortal;
        [NMS(Size = 0xB, Ignore = true)]
        /* 0x4EA15 */ public byte[] Padding4EA15;
        /* 0x4EA20 */ public Vector4f PortalMarkerPosition_Local;
        /* 0x4EA30 */ public Vector4f PortalMarkerPosition_Offset;

    }
}
