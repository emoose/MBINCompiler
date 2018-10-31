using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x25C50, GUID = 0xDF6444273D333D09)]
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
        /* 0x00648 */ public List<NMSString0x10> KnownSpecials;
        /* 0x00658 */ public List<GcWordKnowledge> KnownWords;
        /* 0x00668 */ public List<GcPlayerMissionProgress> MissionProgress;

        /* 0x00678 */ public int PostMissionIndex;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x0067C */ public byte[] Padding67C;
        [NMS(Size = 0x10)]
        /* 0x00680 */ public string CurrentMissionID;
        /* 0x00690 */ public ulong CurrentMissionSeed;
        [NMS(Size = 0x10)]
        /* 0x00698 */ public string PreviousMissionID;
        /* 0x006A8 */ public ulong PreviousMissionSeed;
        /* 0x006B0 */ public int MissionVersion;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x006B4 */ public byte[] Padding6B4;
        /* 0x006B8 */ public List<GcMissionIDEpochPair> MissionRecurrences;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x006C8 */ public byte[] Padding6C8;
        /* 0x006D0 */ public GcInteractionData HoloExplorerInteraction;
        /* 0x006F0 */ public GcInteractionData HoloScepticInteraction;
        /* 0x006E0 */ public GcInteractionData HoloNooneInteraction;
        /* 0x00730 */ public int Health;
		/* 0x00734 */ public int ShipHealth;
        /* 0x00738 */ public int Shield;
		/* 0x0073C */ public int ShipShield;
		/* 0x00740 */ public int Energy;
        /* 0x00744 */ public int Units;
        /* 0x00748 */ public int Nanites;
        /* 0x0074C */ public int Specials;
        /* 0x00750 */ public bool ThirdPersonShip;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x00751 */ public byte[] Padding751;
        /* 0x00758 */ public ulong TimeAlive;
        /* 0x00760 */ public ulong TotalPlayTime;

        /* 0x00768 */ public List<GcScanEventSave> MarkerStack;
        /* 0x00778 */ public List<GcScanEventData> NewMPMarkerStack;

        /* 0x00788 */ public List<GcPlayerStatsGroup> Stats;
        /* 0x00798 */ public List<GcTelemetryStat> TelemetryStats;

        [NMS(Size = 0xA, EnumValue = new[] { "Distress_Signal", "Crate", "Destructable", "Terrain", "Cost", "Building", "Creature", "Maintenance", "Personal", "Personal_Maintenance" })]
        /* 0x007A8 */ public GcInteractionBuffer[] StoredInteractions;

        /* 0x00848 */ public List<GcMaintenanceContainer> MaintenanceInteractions;
        /* 0x00858 */ public List<GcMaintenanceContainer> PersonalMaintenanceInteractions;
        /* 0x00868 */ public List<ulong> VisitedSystems;        // probably technically the 8 byte hex used to denote systems...

        [NMS(Size = 6)]
        /* 0x00878 */ public float[] Hazard;

        /* 0x00890 */ public int BoltAmmo;
        /* 0x00894 */ public int ScatterAmmo;
        /* 0x00898 */ public int PulseAmmo;
        /* 0x0089C */ public int LaserAmmo;

        /* 0x008A0 */ public Vector4f FirstSpawnPosition;

        [NMS(Size = 0x4D, EnumValue = new[] {
                "None", "Shop", "NPC", "NPC_Secondary", "NPC_Anomaly", "NPC_Anomaly_Secondary", "Ship", "Outpost",
                "SpaceStation", "RadioTower", "Monolith", "Factory", "AbandonedShip", "Harvester", "Observatory", "TradingPost",
                "DistressBeacon", "Portal", "Plaque", "AtlasStation", "AbandonedBuildings", "WeaponTerminal", "SuitTerminal", "SignalScanner",
                "Teleporter_Base", "Teleporter_Station", "ClaimBase", "NPC_Freighter_Captain", "NPC_HIRE_Weapons", "NPC_HIRE_Weapons_Wait",
                "NPC_HIRE_Farmer", "NPC_HIRE_Farmer_Wait", "NPC_HIRE_Builder", "NPC_HIRE_Builder_Wait", "NPC_HIRE_Vehicles", "NPC_HIRE_Vehicles_Wait",
                "MessageBeacon", "NPC_HIRE_Scientist", "NPC_HIRE_Scientist_Wait", "NPC_Recruit", "NPC_Freighter_Captain_Secondary", "NPC_Recruit_Secondary",
                "Vehicle", "MessageModule", "TechShop", "VehicleRaseStart", "BuildingShop", "MissionGiver", "HoloHub", "HoloExplorer", "HoloSceptic", "HoloNoone",
                "PortalRunEntry", "PortalActivate", "CrashedFreighter", "GraveInCave", "GlitchyStroyBox", "NetworkPlayer", "NetworkMonument",
                "AnomalyComputer", "AtlasPlinth", "Epilogue", "GuildEnvoy", "ManageFleet", "ManageExpeditions", "Frigate", "CustomiseCharacter",
                "CustomiseShip", "CustomiseWeapon", "CustomiseVehicle", "ClaimBaseAnywhere", "FleetNavigator", "FleetCommandPost", "StoryUtility",
                "MPMissionGiver", "SpecialsShop", "WaterRuin" })]
        /* 0x008B0 */ public GcSavedInteractionRaceData[] SavedInteractionIndicies;

        [NMS(Size = 0x4, Ignore = true)]
        /* 0x0111C */ public byte[] Padding111C;

        /* 0x01120 */ public List<GcSavedInteractionDialogData> SavedInteractionDialogTable;

        /* 0x01130 */ public List<NMSString0x20> InteractionProgressTable;

        [NMS(Size = 0xA)]
        /* 0x01140 */ public GcUniverseAddressData[] AtlasStationAdressData;
        [NMS(Size = 0xB)]
        /* 0x01230 */ public GcUniverseAddressData[] NewAtlasStationAdressData;

        /* 0x01338 */ public List<GcUniverseAddressData> VisitedAtlasStationsData;

        /* 0x01348 */ public bool FirstAtlasStationDiscovered;
        /* 0x01349 */ public bool UsesThirdPersonCharacterCam;
        /* 0x0134C */ public int ProgressionLevel;
        /* 0x01350 */ public int ProcTechIndex;
        /* 0x01354 */ public bool IsNew;
        /* 0x01355 */ public bool UseSmallerBlackholeJumps;

        [NMS(Size = 0x2, Ignore = true)]
        /* 0x01356 */ public byte[] Padding1356;

        /* 0x01358 */ public List<GcSavedEntitlement> UsedEntitlements;

        [NMS(Size = 0x8, Ignore = true)]
        /* 0x01368 */ public byte[] Padding1368;

        [NMS(Size = 0x10)]
        /* 0x01370 */ public Vector4f[] PlanetPositions;

        [NMS(Size = 0x10)]
        /* 0x01470 */ public GcSeed[] PlanetSeeds;

        /* 0x01570 */ public int PrimaryPlanet;
        [NMS(Size = 4, Ignore = true)]
        /* 0x01574 */ public byte[] Padding1574;

        /* 0x01578 */ public ulong TimeLastSpaceBattle;
        /* 0x01580 */ public int WarpsLastSpaceBattle;
        [NMS(Size = 4, Ignore = true)]
        /* 0x01584 */ public byte[] Padding1584;

        /* 0x01588 */ public ulong ActiveSpaceBattleUA;
        /* 0x01590 */ public ulong TimeLastMiniStation;
        /* 0x01598 */ public int WarpsLastMiniStation;
        [NMS(Size = 4, Ignore = true)]
        /* 0x0159C */ public byte[] Padding159C;

        /* 0x015A0 */ public ulong MiniStationUA;
        [NMS(Size = 8, Ignore = true)]
        /* 0x015A8 */ public byte[] Padding15A8;
        /* 0x015B0 */ public Vector4f AnomalyPositionOverride;

        /* 0x015C0 */ public GcUniverseAddressData GameStartAddress1;
        /* 0x015D8 */ public GcUniverseAddressData GameStartAddress2;

        [NMS(Size = 0x10)]
        /* 0x015F0 */ public bool[] GalacticMapRequests;

        /* 0x01600 */ public Vector4f FirstShipPosition;

        /* 0x01610 */ public ulong HazardTimeAlive;

        /* 0x01618 */ public bool RevealBlackHoles;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x01619 */ public byte[] Padding1619;
        /* 0x01620 */ public GcSeed CurrentFreighterHomeSystemSeed;

        /* 0x01630 */ public GcResourceElement CurrentFreighter;
        /* 0x018D8 */ public GcInventoryLayout FreighterLayout;
        /* 0x018F8 */ public GcInventoryContainer FreighterInventory;
        /* 0x01958 */ public GcInventoryContainer FreighterInventory_TechOnly;
        /* 0x019B8 */ public GcUniverseAddressData FreighterUniverseAddress;
        /* 0x019D0 */ public Vector4f FreighterMatrixAt;
        /* 0x019E0 */ public Vector4f FreighterMatrixUp;
        /* 0x019F0 */ public Vector4f FreighterMatrixPos;
        /* 0x01A00 */ public List<GcPersistentBBObjectData> BaseBuildingObjects;
        /* 0x01A10 */ public GcTerrainEditsBuffer TerrainEditData;
        [NMS(Size = 0x5)]
        /* 0x20BD0 */ public GcNPCWorkerData[] NPCWorkers;
        /* 0x21A30 */ public List<GcPersistentBase> PersistentPlayerBases;
        /* 0x21A40 */ public List<GcTeleportEndpoint> TeleportEndpoints;

        /* 0x21A50 */ public GcInventoryLayout Chest1Layout;
        /* 0x21A70 */ public GcInventoryContainer Chest1Inventory;
        /* 0x21AD0 */ public GcInventoryLayout Chest2Layout;
        /* 0x21AF0 */ public GcInventoryContainer Chest2Inventory;
        /* 0x21B50 */ public GcInventoryLayout Chest3Layout;
        /* 0x21B70 */ public GcInventoryContainer Chest3Inventory;
        /* 0x21BD0 */ public GcInventoryLayout Chest4Layout;
        /* 0x21BF0 */ public GcInventoryContainer Chest4Inventory;
        /* 0x21C50 */ public GcInventoryLayout Chest5Layout;
        /* 0x21C70 */ public GcInventoryContainer Chest5Inventory;
        /* 0x21CD0 */ public GcInventoryLayout Chest6Layout;
        /* 0x21CF0 */ public GcInventoryContainer Chest6Inventory;
        /* 0x21D50 */ public GcInventoryLayout Chest7Layout;
        /* 0x21D70 */ public GcInventoryContainer Chest7Inventory;
        /* 0x21DD0 */ public GcInventoryLayout Chest8Layout;
        /* 0x21DF0 */ public GcInventoryContainer Chest8Inventory;
        /* 0x21E50 */ public GcInventoryLayout Chest9Layout;
        /* 0x21E70 */ public GcInventoryContainer Chest9Inventory;
        /* 0x21ED0 */ public GcInventoryLayout Chest10Layout;
        /* 0x21EF0 */ public GcInventoryContainer Chest10Inventory;
        /* 0x21F50 */ public GcInventoryLayout ChestMagicLayout;
        /* 0x21F70 */ public GcInventoryContainer ChestMagicInventory;
        /* 0x21FD0 */ public GcInventoryLayout ChestMagic2Layout;
        /* 0x21FF0 */ public GcInventoryContainer ChestMagic2Inventory;
        /* 0x22050 */ public GcResourceElement CurrentFreighterNPC;

        [NMS(Size = 0x8, Ignore = true)]
        /* 0x222F8 */ public byte[] Padding222F8;

        // enum struct: GcVehicleType
        [NMS(Size = 0x6, EnumValue = new[] { "Buggy", "Bike", "Truck", "WheeledBike", "Hovercraft", "Submarine" })]
        /* 0x22300 */ public GcPlayerOwnershipData[] VehicleOwnership;
        /* 0x239E0 */ public int PrimaryVehicle;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x239E4 */ public byte[] Padding239E4;
        [NMS(Size = 0x6)]
        /* 0x239F0 */ public GcPlayerOwnershipData[] ShipOwnership;
        /* 0x250D0 */ public int PrimaryShip;

        /* 0x250D4 */ public bool MultiShipEnabled;
        [NMS(Size = 0x20)]
        /* 0x250D5 */ public string PlayerWeaponName;
        [NMS(Size = 0x20)]
        /* 0x250F5 */ public string PlayerFreighterName;
        [NMS(Size = 0xB, Ignore = true)]
        /* 0x25115 */ public byte[] Padding25115;
        /* 0x25120 */ public Vector4f StartGameShipPosition;
        /* 0x25130 */ public int TradingSupplyDataIndex;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x25134 */ public byte[] Padding25134;
        /* 0x25138 */ public List<GcTradingSupplyData> TradingSupplyData;
        /* 0x25148 */ public List<GcPortalData> LastPortal;
        /* 0x25158 */ public GcPortalSaveData VisitedPortal;
        /* 0x25170 */ public int KnownPortalRunes;
        /* 0x25174 */ public bool OnOtherSideOfPortal;
        [NMS(Size = 0xB, Ignore = true)]
        /* 0x25175 */ public byte[] Padding25175;
        /* 0x25180 */ public Vector4f PortalMarkerPosition_Local;
        /* 0x25190 */ public Vector4f PortalMarkerPosition_Offset;
        /* 0x251A0 */ public GcPlayerWeapons StartingPrimaryWeapon;
        /* 0x251A4 */ public GcPlayerWeapons StartingSecondaryWeapon;
        [NMS(Size = 0xE)]
        /* 0x251A8 */ public GcCharacterCustomisationSaveData[] CharacterCustomisationData;
        [NMS(Size = 0x6)]
        /* 0x25678 */ public bool[] ShipUsesLegacyColours;

        [NMS(Size = 0x2, Ignore = true)]
        /* 0x2567E */ public byte[] Padding2567E;

        /* 0x25680 */ public GcSeed FleetSeed;
        /* 0x25690 */ public List<GcFleetFrigateSaveData> FleetFrigates;
        /* 0x256A0 */ public List<GcFleetExpeditionSaveData> FleetExpeditions;
        /* 0x256B0 */ public List<long> ExpeditionSeedsSelectedToday;
        /* 0x256C0 */ public ulong LastKnownDay;
        /* 0x256C8 */ public ulong SunTimer;
        /* 0x256D0 */ public ulong MultiplayerLobbyID;
        /* 0x256D8 */ public GcUniverseAddressData MultiplayerUA;
        /* 0x256F0 */ public GcPlayerSpawnStateData MultiplayerSpawn;
        /* 0x25770 */ public List<GcRepairTechData> RepairTechBuffer;
        /* 0x25780 */ public ulong MultiplayerPrivileges;
        [NMS(Size = 0x3, EnumValue = new[] { "OnFoot", "InShip", "InExocraft" })]
        /* 0x25788 */ public GcHotActionsSaveData[] HotActions;
        /* 0x25C38 */ public ulong LastUABeforePortalWarp;
        /* 0x25C40 */ public ulong StoryPortalSeed;
        /* 0x25C48 */ public uint ShopNumber;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x25C4C */ public byte[] EndPadding;
    }
}
