using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x4EA10)]
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
        /* 0x006A0 */ public GcInteractionData HoloExplorerInteraction;     // size: 0x20
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

        [NMS(Size = 0x3D, EnumValue = new[] {
                "None", "Shop", "NPC", "NPC_Secondary", "NPC_Anomaly", "NPC_Anomaly_Secondary", "Ship", "Outpost",
                "SpaceStation", "RadioTower", "Monolith", "Factory", "AbandonedShip", "Harvester", "Observatory", "TradingPost",
                "DistressBeacon", "Portal", "Plaque", "AtlasStation", "AbandonedBuildings", "WeaponTerminal", "SuitTerminal", "SignalScanner",
                "Teleporter_Base", "Teleporter_Station", "ClaimBase", "NPC_Freighter_Captain", "NPC_HIRE_Weapons", "NPC_HIRE_Weapons_Wait",
                "NPC_HIRE_Farmer", "NPC_HIRE_Farmer_Wait", "NPC_HIRE_Builder", "NPC_HIRE_Builder_Wait", "NPC_HIRE_Vehicles", "NPC_HIRE_Vehicles_Wait",
                "MessageBeacon", "NPC_HIRE_Scientist", "NPC_HIRE_Scientist_Wait", "NPC_Recruit", "NPC_Freighter_Captain_Secondary", "NPC_Recruit_Secondary",
                "Vehicle", "MessageModule", "TechShop", "VehicleRaseStart", "BuildingShop", "MissionGiver", "HoloHub", "HoloExplorer", "HoloSceptic", "HoloNoone",
                "PortalRunEntry", "PortalActivate", "CrashedFreighter", "GraveInCave", "GlitchyStroyBox", "NetworkPlayer", "NetworkMonument",
                "AnomalyComputer", "AtlasPlinth" })]
        /* 0x3EFB0 */ public GcSavedInteractionRaceData[] SavedInteractionIndicies;

        [NMS(Size = 0x4, Ignore = true)]
        /* 0x3F65C */ public byte[] Padding3F65C;

        /* 0x3F660 */ public List<NMSString0x10> InteractionProgressTable;

        [NMS(Size = 0xA)]
        /* 0x3F670 */ public GcUniverseAddressData[] AtlasStationAdressData;
        [NMS(Size = 0xB)]
        /* 0x3F760 */ public GcUniverseAddressData[] NewAtlasStationAdressData;

        /* 0x3F868 */ public List<GcUniverseAddressData> VisitedAtlasStationsData;

        /* 0x3F878 */ public bool FirstAtlasStationDiscovered;
        /* 0x3F87C */ public int ProgressionLevel;
        /* 0x3F880 */ public bool IsNew;
        /* 0x3F881 */ public bool UseSmallerBlackholeJumps;

        [NMS(Size = 0x6, Ignore = true)]
        /* 0x3F882 */ public byte[] Padding3F882;

        /* 0x3F888 */ public List<GcSavedEntitlement> UsedEntitlements;

        [NMS(Size = 0x8, Ignore = true)]
        /* 0x3F989 */ public byte[] Padding3F898;

        [NMS(Size = 0x10)]
        /* 0x3F8A0 */ public Vector4f[] PlanetPositions;

        [NMS(Size = 0x10)]
        /* 0x3F9A0 */ public GcSeed[] PlanetSeeds;

        /* 0x3FAA0 */ public int PrimaryPlanet;
        [NMS(Size = 4, Ignore = true)]
        /* 0x3FAA4 */ public byte[] Padding3FAA4;

        /* 0x3FAA8 */ public ulong TimeLastSpaceBattle;
        /* 0x3FAB0 */ public int WarpsLastSpaceBattle;
        [NMS(Size = 4, Ignore = true)]
        /* 0x3FAB4 */ public byte[] Padding3FAB4;

        /* 0x3FAB8 */ public ulong TimeLastMiniStation;
        /* 0x3FAC0 */ public int WarpsLastMiniStation;
        [NMS(Size = 4, Ignore = true)]
        /* 0x3FAC4 */ public byte[] Padding3FAC4;

        /* 0x3FAC8 */ public ulong MiniStationUA;
        /* 0x3FAD0 */ public Vector4f AnomalyPositionOverride;

        /* 0x3FAE0 */ public GcUniverseAddressData GameStartAddress1;
        /* 0x3FAF8 */ public GcUniverseAddressData GameStartAddress2;

        [NMS(Size = 0x10)]
        /* 0x3FB10 */ public bool[] GalacticMapRequests;

        /* 0x3FB20 */ public Vector4f FirstShipPosition;

        /* 0x3FB30 */ public float SavedSunAngle;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x3FB34 */ public byte[] Padding3FB34;

        /* 0x3FB40 */ public Vector4f SavedSunAxis;

        /* 0x3FB50 */ public ulong HazardTimeAlive;

        /* 0x3FB58 */ public bool RevealBlackHoles;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x3FB59 */ public byte[] Padding3FB59;

        /* 0x3FB60 */ public GcResourceElement CurrentFreighter;
        /* 0x3FE08 */ public GcInventoryLayout FreighterLayout;
        /* 0x3FE28 */ public GcInventoryContainer FreighterInventory;
        /* 0x3FE88 */ public GcInventoryContainer FreighterInventory_TechOnly;
        /* 0x3FEE8 */ public GcUniverseAddressData FreighterUniverseAddress;
        /* 0x3FF00 */ public List<GcPersistentBBObjectData> BaseBuildingObjects;
        /* 0x3FF10 */ public GcTerrainEditsBuffer TerrainEditData;
        [NMS(Size = 0x5)]
        /* 0x4ABD0 */ public GcNPCWorkerData[] NPCWorkers;
        [NMS(Size = 0x3)]
        /* 0x4B990 */ public GcPersistentBase[] PersistentPlayerBases;
        /* 0x4BE40 */ public List<GcTeleportEndpoint> TeleportEndpoints;
                //[NMS(Size = 0x2F)]
                ///* 0x4BE50 */ public ulong[] SavedInteractionTimes;

        // I am just going to forget about fixing the offsets here... too much effort... The correct offsets will continue afterwards...

        /* 0x4BE50 */ public GcInventoryLayout Chest1Layout;
        /* 0x4BE70 */ public GcInventoryContainer Chest1Inventory;
        /* 0x4BED0 */ public GcInventoryLayout Chest2Layout;
        /* 0x4BEF0 */ public GcInventoryContainer Chest2Inventory;
        /* 0x4BF50 */ public GcInventoryLayout Chest3Layout;
        /* 0x4BF70 */ public GcInventoryContainer Chest3Inventory;
        /* 0x4BFD0 */ public GcInventoryLayout Chest4Layout;
        /* 0x4BFF0 */ public GcInventoryContainer Chest4Inventory;
        /* 0x4C050 */ public GcInventoryLayout Chest5Layout;
        /* 0x4C070 */ public GcInventoryContainer Chest5Inventory;
        /* 0x4C0D0 */ public GcInventoryLayout Chest6Layout;
        /* 0x4C0F0 */ public GcInventoryContainer Chest6Inventory;
        /* 0x4C150 */ public GcInventoryLayout Chest7Layout;
        /* 0x4C170 */ public GcInventoryContainer Chest7Inventory;
        /* 0x4C1D0 */ public GcInventoryLayout Chest8Layout;
        /* 0x4C1F0 */ public GcInventoryContainer Chest8Inventory;
        /* 0x4C250 */ public GcInventoryLayout Chest9Layout;
        /* 0x4C270 */ public GcInventoryContainer Chest9Inventory;
        /* 0x4C2D0 */ public GcInventoryLayout Chest10Layout;
        /* 0x4C2F0 */ public GcInventoryContainer Chest10Inventory;
        /* 0x4C350 */ public GcInventoryLayout ChestMagicLayout;
        /* 0x4C370 */ public GcInventoryContainer ChestMagicInventory;
        /* 0x4C3D0 */ public GcInventoryLayout ChestMagic2Layout;
        /* 0x4C3F0 */ public GcInventoryContainer ChestMagic2Inventory;
        /* 0x4C450 */ public GcResourceElement CurrentFreighterNPC;

        [NMS(Size = 0x8, Ignore = true)]
        /* 0x4C6F8 */ public byte[] Padding4C6F8;

        [NMS(Size = 0x3)]
        /* 0x4C700 */ public GcPlayerOwnershipData[] VehicleOwnership;
        /* 0x4D270 */ public int PrimaryVehicle;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x4D274 */ public byte[] Padding4D274;
        [NMS(Size = 0x6)]
        /* 0x4D280 */ public GcPlayerOwnershipData[] ShipOwnership;
        /* 0x4E960 */ public int PrimaryShip;

        /* 0x4E964 */ public bool MultiShipEnabled;
        [NMS(Size = 0x20)]
        /* 0x4E965 */ public string PlayerWeaponName;
        [NMS(Size = 0x20)]
        /* 0x4E985 */ public string PlayerFreighterName;
        [NMS(Size = 0xB, Ignore = true)]
        /* 0x4E9A5 */ public byte[] Padding4E9A5;
        /* 0x4E9B0 */ public Vector4f StartGameShipPosition;
        /* 0x4E9C0 */ public int TradingSupplyDataIndex;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x4E9C4 */ public byte[] Padding4E9C4;
        /* 0x4E9C8 */ public List<GcTradingSupplyData> TradingSupplyData;
        /* 0x4E9D8 */ public List<GcPortalData> LastPortal;     // just a guess...
        /* 0x4E9E8 */ public GcPortalSaveData VisitedPortal;
        /* 0x4EA00 */ public int KnownPortalRunes;
        /* 0x4EA04 */ public bool OnOtherSideOfPortal;
        [NMS(Size = 0xB, Ignore = true)]
        /* 0x4EA05 */ public byte[] Padding4EA05;
        /* 0x4EA10 */ public Vector4f PortalMarkerPosition_Local;
        /* 0x4EA20 */ public Vector4f PortalMarkerPosition_Offset;

    }
}
