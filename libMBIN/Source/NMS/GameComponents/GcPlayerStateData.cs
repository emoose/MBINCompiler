using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x29DF0, GUID = 0x7F144E183A5EF79F, NameHash = 0x6C4510BB243EFA64)]
    public class GcPlayerStateData : NMSTemplate
    {
        /* 0x00000 */ public GcUniverseAddressData UniverseAddress;
        /* 0x00018 */ public int HomeRealityIteration;

        [NMS(Size = 0x4, Ignore = true)]
        /* 0x0001C */ public byte[] Padding1C;

        /* 0x00020 */ public GcInventoryContainer Inventory;
        /* 0x00180 */ public GcInventoryContainer Inventory_TechOnly;
        /* 0x002E0 */ public GcInventoryContainer Inventory_Cargo;
        /* 0x00440 */ public GcInventoryContainer ShipInventory;
        /* 0x005A0 */ public GcInventoryContainer WeaponInventory;
        [NMS(Size = 0x3)]
        /* 0x00700 */ public GcMultitoolData[] MultiTools;
        /* 0x00C40 */ public int ActiveMultioolIndex;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x00C44 */ public byte[] PaddingC44;
        /* 0x00C48 */ public GcInventoryContainer GraveInventory;

        /* 0x00DA8 */ public bool SpawnGrave;
        /* 0x00DA9 */ public bool SpaceGrave;
        [NMS(Size = 2, Ignore = true)]
        /* 0x00DAA */ public byte[] PaddingDAA;

        /* 0x00DAC */ public GcUniverseAddressData GraveUniverseAddress;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x00DC4 */ public byte[] PaddingDC4;

        /* 0x00DD0 */ public Vector4f GravePosition;
        /* 0x00DE0 */ public Vector4f GraveMatrixLookAt;
        /* 0x00DF0 */ public Vector4f GraveMatrixUp;
        /* 0x00E00 */ public GcInventoryLayout ShipLayout;
        /* 0x00E20 */ public GcInventoryLayout WeaponLayout;
        /* 0x00E40 */ public GcResourceElement CurrentShip;
        /* 0x010E8 */ public GcExactResource CurrentWeapon;
        /* 0x01178 */ public List<NMSString0x10> KnownTech;
        /* 0x01188 */ public List<NMSString0x10> KnownProducts;
        /* 0x01198 */ public List<NMSString0x10> KnownSpecials;
        /* 0x011A8 */ public List<NMSString0x20> KnownRefinerRecipes;
        /* 0x011B8 */ public List<GcWordKnowledge> KnownWords;
        /* 0x011C8 */ public List<GcWordGroupKnowledge> KnownWordGroups;
        /* 0x011D8 */ public List<GcPlayerMissionProgress> MissionProgress;

        /* 0x011E8 */ public int PostMissionIndex;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x011EC */ public byte[] Padding11EC;
        [NMS(Size = 0x10)]
        /* 0x011F0 */ public string CurrentMissionID;
        /* 0x01200 */ public ulong CurrentMissionSeed;
        [NMS(Size = 0x10)]
        /* 0x01208 */ public string PreviousMissionID;
        /* 0x01218 */ public ulong PreviousMissionSeed;
        /* 0x01220 */ public int MissionVersion;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x01224 */ public byte[] Padding1224;
        /* 0x01228 */ public List<GcMissionIDEpochPair> MissionRecurrences;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x01238 */ public byte[] Padding1238;
        /* 0x01240 */ public GcInteractionData HoloExplorerInteraction;
        /* 0x01260 */ public GcInteractionData HoloScepticInteraction;
        /* 0x01280 */ public GcInteractionData HoloNooneInteraction;
        /* 0x012A0 */ public int Health;
		/* 0x012A4 */ public int ShipHealth;
        /* 0x012A8 */ public int Shield;
		/* 0x012AC */ public int ShipShield;
		/* 0x012B0 */ public int Energy;
        /* 0x012B4 */ public int Units;
        /* 0x012B8 */ public int Nanites;
        /* 0x012BC */ public int Specials;
        /* 0x012C0 */ public bool ThirdPersonShip;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x012C1 */ public byte[] Padding12C1;
        /* 0x012C8 */ public ulong TimeAlive;
        /* 0x012D0 */ public ulong TotalPlayTime;

        /* 0x012D8 */ public List<GcScanEventSave> MarkerStack;
        /* 0x012E8 */ public List<GcScanEventSave> NewMPMarkerStack;

        /* 0x012F8 */ public List<GcPlayerStatsGroup> Stats;
        /* 0x01308 */ public List<GcTelemetryStat> TelemetryStats;

        [NMS(Size = 0xB, EnumType = typeof(GcInteractionBufferType.InterationBufferTypeEnum))]
        /* 0x01318 */ public GcInteractionBuffer[] StoredInteractions;

        /* 0x01420 */ public List<GcMaintenanceContainer> MaintenanceInteractions;
        /* 0x01430 */ public List<GcMaintenanceContainer> PersonalMaintenanceInteractions;
        /* 0x01440 */ public List<ulong> VisitedSystems;        // probably technically the 8 byte hex used to denote systems...

        [NMS(Size = 6, EnumType = typeof(GcPlayerHazardType.HazardEnum))]
        /* 0x01450 */ public float[] Hazard;

        /* 0x01468 */ public int BoltAmmo;
        /* 0x0146C */ public int ScatterAmmo;
        /* 0x01470 */ public int PulseAmmo;
        /* 0x01474 */ public int LaserAmmo;

        /* 0x01480 */ public Vector4f FirstSpawnPosition;

        [NMS(Size = 0x65, EnumType = typeof(GcInteractionType.InteractionTypeEnum))]
        /* 0x01490 */ public GcSavedInteractionRaceData[] SavedInteractionIndicies;

        /* 0x02130 */ public List<GcSavedInteractionDialogData> SavedInteractionDialogTable;
        /* 0x02140 */ public List<NMSString0x20> InteractionProgressTable;

        [NMS(Size = 0xA)]
        /* 0x02150 */ public GcUniverseAddressData[] AtlasStationAdressData;
        [NMS(Size = 0xB)]
        /* 0x02240 */ public GcUniverseAddressData[] NewAtlasStationAdressData;

        /* 0x02348 */ public List<GcUniverseAddressData> VisitedAtlasStationsData;

        /* 0x02358 */ public bool FirstAtlasStationDiscovered;
        /* 0x02359 */ public bool UsesThirdPersonCharacterCam;
        /* 0x0235C */ public int ProgressionLevel;
        /* 0x02360 */ public int ProcTechIndex;
        /* 0x02364 */ public bool IsNew;
        /* 0x02365 */ public bool UseSmallerBlackholeJumps;

        [NMS(Size = 0x2, Ignore = true)]
        /* 0x02366 */ public byte[] Padding2366;

        /* 0x02368 */ public List<GcSavedEntitlement> UsedEntitlements;

        [NMS(Size = 0x10)]
        /* 0x02380 */ public Vector4f[] PlanetPositions;

        [NMS(Size = 0x10)]
        /* 0x02480 */ public GcSeed[] PlanetSeeds;

        /* 0x02580 */ public int PrimaryPlanet;
        [NMS(Size = 4, Ignore = true)]
        /* 0x02584 */ public byte[] Padding2584;

        /* 0x02588 */ public ulong TimeLastSpaceBattle;
        /* 0x02590 */ public int WarpsLastSpaceBattle;
        [NMS(Size = 4, Ignore = true)]
        /* 0x02594 */ public byte[] Padding2594;

        /* 0x02598 */ public ulong ActiveSpaceBattleUA;
        /* 0x025A0 */ public ulong TimeLastMiniStation;
        /* 0x025A8 */ public int WarpsLastMiniStation;
        [NMS(Size = 4, Ignore = true)]
        /* 0x025AC */ public byte[] Padding25AC;

        /* 0x025B0 */ public ulong MiniStationUA;
        [NMS(Size = 8, Ignore = true)]
        /* 0x025B8 */ public byte[] Padding25B8;
        /* 0x025C0 */ public Vector4f AnomalyPositionOverride;

        /* 0x025D0 */ public GcUniverseAddressData GameStartAddress1;
        /* 0x025E8 */ public GcUniverseAddressData GameStartAddress2;

        [NMS(Size = 0x10)]
        /* 0x02600 */ public bool[] GalacticMapRequests;

        /* 0x02610 */ public Vector4f FirstShipPosition;

        /* 0x02620 */ public ulong HazardTimeAlive;

        /* 0x02628 */ public bool RevealBlackHoles;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x02629 */ public byte[] Padding2629;
        /* 0x02630 */ public GcSeed CurrentFreighterHomeSystemSeed;

        /* 0x02640 */ public GcResourceElement CurrentFreighter;
        /* 0x028E8 */ public GcInventoryLayout FreighterLayout;
        /* 0x02908 */ public GcInventoryContainer FreighterInventory;
        /* 0x02A68 */ public GcInventoryContainer FreighterInventory_TechOnly;
        /* 0x02BC8 */ public GcUniverseAddressData FreighterUniverseAddress;
        /* 0x02BE0 */ public Vector3f FreighterMatrixAt;
        /* 0x02BF0 */ public Vector3f FreighterMatrixUp;
        /* 0x02C00 */ public Vector3f FreighterMatrixPos;
        /* 0x02C10 */ public List<GcPersistentBBObjectData> BaseBuildingObjects;
        /* 0x02C20 */ public GcTerrainEditsBuffer TerrainEditData;
        [NMS(Size = 0x5, EnumType = typeof(GcNPCHabitationType.NPCHabitationTypeEnum))]
        /* 0x21EE0 */ public GcNPCWorkerData[] NPCWorkers;
        /* 0x22D40 */ public List<GcPersistentBase> PersistentPlayerBases;
        /* 0x22D50 */ public List<GcTeleportEndpoint> TeleportEndpoints;

        /* 0x22D60 */ public GcInventoryLayout Chest1Layout;
        /* 0x22D80 */ public GcInventoryContainer Chest1Inventory;
        /* 0x22EE0 */ public GcInventoryLayout Chest2Layout;
        /* 0x22F00 */ public GcInventoryContainer Chest2Inventory;
        /* 0x23060 */ public GcInventoryLayout Chest3Layout;
        /* 0x23080 */ public GcInventoryContainer Chest3Inventory;
        /* 0x231E0 */ public GcInventoryLayout Chest4Layout;
        /* 0x23200 */ public GcInventoryContainer Chest4Inventory;
        /* 0x23360 */ public GcInventoryLayout Chest5Layout;
        /* 0x23380 */ public GcInventoryContainer Chest5Inventory;
        /* 0x234E0 */ public GcInventoryLayout Chest6Layout;
        /* 0x23500 */ public GcInventoryContainer Chest6Inventory;
        /* 0x23660 */ public GcInventoryLayout Chest7Layout;
        /* 0x23680 */ public GcInventoryContainer Chest7Inventory;
        /* 0x237E0 */ public GcInventoryLayout Chest8Layout;
        /* 0x23800 */ public GcInventoryContainer Chest8Inventory;
        /* 0x23960 */ public GcInventoryLayout Chest9Layout;
        /* 0x23980 */ public GcInventoryContainer Chest9Inventory;
        /* 0x23AE0 */ public GcInventoryLayout Chest10Layout;
        /* 0x23B00 */ public GcInventoryContainer Chest10Inventory;
        /* 0x23C60 */ public GcInventoryLayout ChestMagicLayout;
        /* 0x23C80 */ public GcInventoryContainer ChestMagicInventory;
        /* 0x23DE0 */ public GcInventoryLayout ChestMagic2Layout;
        /* 0x23E00 */ public GcInventoryContainer ChestMagic2Inventory;
        /* 0x23F60 */ public GcInventoryLayout CookingIngredientsLayout;
        /* 0x23F80 */ public GcInventoryContainer CookingIngredientsInventory;
        /* 0x240E0 */ public GcResourceElement CurrentFreighterNPC;

        [NMS(Size = 0x8, Ignore = true)]
        /* 0x24388 */ public byte[] Padding24388;

        [NMS(Size = 0x7, EnumType = typeof(GcVehicleType.VehicleTypeEnum))]
        /* 0x24390 */ public GcPlayerOwnershipData[] VehicleOwnership;
        /* 0x26C40 */ public int PrimaryVehicle;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x26C44 */ public byte[] Padding26C44;
        [NMS(Size = 0x6)]
        /* 0x26C50 */ public GcPlayerOwnershipData[] ShipOwnership;
        /* 0x28F30 */ public int PrimaryShip;

        /* 0x28F34 */ public bool MultiShipEnabled;
        [NMS(Size = 0x20)]
        /* 0x28F35 */ public string PlayerWeaponName;
        [NMS(Size = 0xB, Ignore = true)]
        /* 0x28F55 */ public byte[] Padding28F55;
        /* 0x28F60 */ public Vector4f StartGameShipPosition;
        /* 0x28F70 */ public bool ShipNeedsTerrainPositioning;
        /* 0x28F74 */ public int TradingSupplyDataIndex;
        /* 0x28F78 */ public List<GcTradingSupplyData> TradingSupplyData;
        /* 0x28F88 */ public List<GcPortalData> LastPortal;
        /* 0x28F98 */ public GcPortalSaveData VisitedPortal;
        /* 0x28FB0 */ public int KnownPortalRunes;
        /* 0x28FB4 */ public bool OnOtherSideOfPortal;
        [NMS(Size = 0xB, Ignore = true)]
        /* 0x28FB5 */ public byte[] Padding28FB5;
        /* 0x28FC0 */ public GcTeleportEndpoint OtherSideOfPortalReturnBase;
        /* 0x29050 */ public Vector4f PortalMarkerPosition_Local;
        /* 0x29060 */ public Vector4f PortalMarkerPosition_Offset;
        /* 0x29070 */ public GcPlayerWeapons StartingPrimaryWeapon;
        /* 0x29074 */ public GcPlayerWeapons StartingSecondaryWeapon;
        [NMS(Size = 0xF, EnumType = typeof(GcCustomisationComponentData.CustomisationDataTypeEnum))]
        /* 0x29078 */ public GcCharacterCustomisationSaveData[] CharacterCustomisationData;
        [NMS(Size = 0x6)]
        /* 0x295A0 */ public bool[] ShipUsesLegacyColours;

        [NMS(Size = 0x2, Ignore = true)]
        /* 0x295A6 */ public byte[] Padding295A6;

        [NMS(Size = 0x3)]
        /* 0x295A8 */ public GcCharacterCustomisationData[] Outfits;
        [NMS(Size = 0x10)]
        /* 0x29680 */ public string JetpackEffect;
        /* 0x29690 */ public GcSeed FleetSeed;
        /* 0x296A0 */ public List<GcFleetFrigateSaveData> FleetFrigates;
        /* 0x296B0 */ public List<GcFleetExpeditionSaveData> FleetExpeditions;
        /* 0x296C0 */ public List<long> ExpeditionSeedsSelectedToday;
        /* 0x296D0 */ public ulong LastKnownDay;
        /* 0x296D8 */ public ulong SunTimer;
        /* 0x296E0 */ public ulong MultiplayerLobbyID;
        /* 0x296E8 */ public GcUniverseAddressData MultiplayerUA;
        /* 0x29700 */ public GcPlayerSpawnStateData MultiplayerSpawn;
        /* 0x29780 */ public List<GcRepairTechData> RepairTechBuffer;
        /* 0x29790 */ public ulong MultiplayerPrivileges;
        [NMS(Size = 0x3, EnumType = typeof(GcHotActionMenuTypes.HotActionMenuTypesEnum))]
        /* 0x29798 */ public GcHotActionsSaveData[] HotActions;
        /* 0x29C48 */ public ulong LastUABeforePortalWarp;
        /* 0x29C50 */ public ulong StoryPortalSeed;
        /* 0x29C58 */ public uint ShopNumber;
        /* 0x29C5A */ public uint ShopTier;
        /* 0x29C5C */ public bool HasAccessToNexus;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x29C5D */ public byte[] Padding29C5D;
        /* 0x29C60 */ public GcUniverseAddressData NexusUniverseAddress;
        /* 0x29C80 */ public Vector3f NexusMatrixAt;
        /* 0x29C90 */ public Vector3f NexusMatrixUp;
        /* 0x29CA0 */ public Vector3f NexusMatrixPos;
        /* 0x29CB0 */ public GcPhotoModeSettings PhotoModeSettings;
        /* 0x29CF0 */ public int BannerIcon;
        /* 0x29CF4 */ public int BannerMainColour;
        /* 0x29CF8 */ public int BannerBackgroundColour;
        /* 0x29CFC */ public int TelemetryUploadVersion;
        /* 0x29D00 */ public bool UsesThirdPersonVehicleCam;
        /* 0x29D04 */ public float VRCameraOffset;
        /* 0x29D08 */ public GcSeasonalGameModeData SeasonalData;
    }
}
