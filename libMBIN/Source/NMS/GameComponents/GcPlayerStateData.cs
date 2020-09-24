using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x2A040, GUID = 0xA691972406DCF265, NameHash = 0x6C4510BB243EFA64)]
    public class GcPlayerStateData : NMSTemplate
    {
        /* 0x00000 */ public GcUniverseAddressData UniverseAddress;
        /* 0x00018 */ public GcUniverseAddressData PreviousUniverseAddress;
        /* 0x00030 */ public int HomeRealityIteration;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x00034 */ public byte[] Padding34;
        /* 0x00038 */ public GcInventoryContainer Inventory;
        /* 0x00198 */ public GcInventoryContainer Inventory_TechOnly;
        /* 0x002F8 */ public GcInventoryContainer Inventory_Cargo;
        /* 0x00458 */ public GcInventoryContainer ShipInventory;
        /* 0x005B8 */ public GcInventoryContainer WeaponInventory;
        [NMS(Size = 0x3)]
        /* 0x00718 */ public GcMultitoolData[] MultiTools;
        /* 0x00C58 */ public int ActiveMultioolIndex;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x00C5C */ public byte[] PaddingC5C;
        /* 0x00C60 */ public GcInventoryContainer GraveInventory;
        /* 0x00DC0 */ public bool SpawnGrave;
        /* 0x00DC1 */ public bool SpaceGrave;
        [NMS(Size = 2, Ignore = true)]
        /* 0x00DC2 */ public byte[] PaddingDC2;
        /* 0x00DC4 */ public GcUniverseAddressData GraveUniverseAddress;
        /* 0x00DE0 */ public Vector4f GravePosition;
        /* 0x00DF0 */ public Vector4f GraveMatrixLookAt;
        /* 0x00E00 */ public Vector4f GraveMatrixUp;
        /* 0x00E10 */ public GcInventoryLayout ShipLayout;
        /* 0x00E30 */ public GcInventoryLayout WeaponLayout;
        /* 0x00E50 */ public GcResourceElement CurrentShip;
        /* 0x010F8 */ public GcExactResource CurrentWeapon;
        /* 0x01188 */ public List<NMSString0x10> KnownTech;
        /* 0x01198 */ public List<NMSString0x10> KnownProducts;
        /* 0x011A8 */ public List<NMSString0x10> KnownSpecials;
        /* 0x011B8 */ public List<NMSString0x20> KnownRefinerRecipes;
        /* 0x011C8 */ public List<GcWordKnowledge> KnownWords;
        /* 0x011D8 */ public List<GcWordGroupKnowledge> KnownWordGroups;
        /* 0x011E8 */ public List<GcPlayerMissionProgress> MissionProgress;
        /* 0x011F8 */ public int PostMissionIndex;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x011FC */ public byte[] Padding11FC;
        [NMS(Size = 0x10)]
        /* 0x01200 */ public string CurrentMissionID;
        /* 0x01210 */ public ulong CurrentMissionSeed;
        [NMS(Size = 0x10)]
        /* 0x01218 */ public string PreviousMissionID;
        /* 0x01228 */ public ulong PreviousMissionSeed;
        /* 0x01230 */ public int MissionVersion;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x01234 */ public byte[] Padding1234;
        /* 0x01238 */ public List<GcMissionIDEpochPair> MissionRecurrences;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x01248 */ public byte[] Padding1248;
        /* 0x01250 */ public GcInteractionData HoloExplorerInteraction;
        /* 0x01270 */ public GcInteractionData HoloScepticInteraction;
        /* 0x01290 */ public GcInteractionData HoloNooneInteraction;
        /* 0x012B0 */ public int Health;
		/* 0x012B4 */ public int ShipHealth;
        /* 0x012B8 */ public int Shield;
		/* 0x012BC */ public int ShipShield;
		/* 0x012C0 */ public int Energy;
        /* 0x012C4 */ public int Units;
        /* 0x012C8 */ public int Nanites;
        /* 0x012CC */ public int Specials;
        /* 0x012D0 */ public bool ThirdPersonShip;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x012D1 */ public byte[] Padding12D1;
        /* 0x012D8 */ public ulong TimeAlive;
        /* 0x012E0 */ public ulong TotalPlayTime;
        /* 0x012E8 */ public List<GcScanEventSave> MarkerStack;
        /* 0x012F8 */ public List<GcScanEventSave> NewMPMarkerStack;
        /* 0x01308 */ public List<Vector4f> SurveyedEventPositions;
        /* 0x01318 */ public int NextSurveyedEventPositionIndex;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x0131C */ public byte[] Padding131C;
        /* 0x01320 */ public List<GcPlayerStatsGroup> Stats;
        /* 0x01330 */ public List<GcTelemetryStat> TelemetryStats;
        [NMS(Size = 0xB, EnumType = typeof(GcInteractionBufferType.InterationBufferTypeEnum))]
        /* 0x01340 */ public GcInteractionBuffer[] StoredInteractions;
        /* 0x01448 */ public List<GcMaintenanceContainer> MaintenanceInteractions;
        /* 0x01458 */ public List<GcMaintenanceContainer> PersonalMaintenanceInteractions;
        /* 0x01468 */ public List<ulong> VisitedSystems;        // probably technically the 8 byte hex used to denote systems...
        [NMS(Size = 6, EnumType = typeof(GcPlayerHazardType.HazardEnum))]
        /* 0x01478 */ public float[] Hazard;
        /* 0x01490 */ public int BoltAmmo;
        /* 0x01494 */ public int ScatterAmmo;
        /* 0x01498 */ public int PulseAmmo;
        /* 0x0149C */ public int LaserAmmo;
        /* 0x014A0 */ public Vector4f FirstSpawnPosition;
        [NMS(Size = 0x70, EnumType = typeof(GcInteractionType.InteractionTypeEnum))]
        /* 0x014B0 */ public GcSavedInteractionRaceData[] SavedInteractionIndicies;
        /* 0x022B0 */ public List<GcSavedInteractionDialogData> SavedInteractionDialogTable;
        /* 0x022C0 */ public List<NMSString0x20> InteractionProgressTable;
        [NMS(Size = 0xA)]
        /* 0x022D0 */ public GcUniverseAddressData[] AtlasStationAdressData;
        [NMS(Size = 0xB)]
        /* 0x023C0 */ public GcUniverseAddressData[] NewAtlasStationAdressData;
        /* 0x024C8 */ public List<GcUniverseAddressData> VisitedAtlasStationsData;
        /* 0x024D8 */ public bool FirstAtlasStationDiscovered;
        /* 0x024D9 */ public bool UsesThirdPersonCharacterCam;
        /* 0x024DC */ public int ProgressionLevel;
        /* 0x024E0 */ public int ProcTechIndex;
        /* 0x024E4 */ public bool IsNew;
        /* 0x024E5 */ public bool UseSmallerBlackholeJumps;
        [NMS(Size = 0x2, Ignore = true)]
        /* 0x024E6 */ public byte[] Padding24E6;
        /* 0x024E8 */ public List<GcSavedEntitlement> UsedEntitlements;
        [NMS(Size = 0x10)]
        /* 0x02500 */ public Vector4f[] PlanetPositions;
        [NMS(Size = 0x10)]
        /* 0x02600 */ public GcSeed[] PlanetSeeds;
        /* 0x02700 */ public int PrimaryPlanet;
        [NMS(Size = 4, Ignore = true)]
        /* 0x02704 */ public byte[] Padding2704;
        /* 0x02708 */ public ulong TimeLastSpaceBattle;
        /* 0x02710 */ public int WarpsLastSpaceBattle;
        [NMS(Size = 4, Ignore = true)]
        /* 0x02714 */ public byte[] Padding2714;
        /* 0x02718 */ public ulong ActiveSpaceBattleUA;
        /* 0x02720 */ public ulong TimeLastMiniStation;
        /* 0x02728 */ public int WarpsLastMiniStation;
        [NMS(Size = 4, Ignore = true)]
        /* 0x0272C */ public byte[] Padding272C;
        /* 0x02730 */ public ulong MiniStationUA;
        [NMS(Size = 8, Ignore = true)]
        /* 0x02738 */ public byte[] Padding2738;
        /* 0x02740 */ public Vector4f AnomalyPositionOverride;
        /* 0x02750 */ public GcUniverseAddressData GameStartAddress1;
        /* 0x02768 */ public GcUniverseAddressData GameStartAddress2;
        [NMS(Size = 0x10)]
        /* 0x02780 */ public bool[] GalacticMapRequests;
        /* 0x02790 */ public Vector4f FirstShipPosition;
        /* 0x027A0 */ public ulong HazardTimeAlive;
        /* 0x027A8 */ public bool RevealBlackHoles;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x027A9 */ public byte[] Padding27A9;
        /* 0x027B0 */ public GcSeed CurrentFreighterHomeSystemSeed;
        /* 0x027C0 */ public GcResourceElement CurrentFreighter;
        /* 0x02A68 */ public GcInventoryLayout FreighterLayout;
        /* 0x02A88 */ public GcInventoryContainer FreighterInventory;
        /* 0x02BE8 */ public GcInventoryContainer FreighterInventory_TechOnly;
        /* 0x02D48 */ public GcUniverseAddressData FreighterUniverseAddress;
        /* 0x02D60 */ public Vector3f FreighterMatrixAt;
        /* 0x02D70 */ public Vector3f FreighterMatrixUp;
        /* 0x02D80 */ public Vector3f FreighterMatrixPos;
        /* 0x02D90 */ public List<GcPersistentBBObjectData> BaseBuildingObjects;
        /* 0x02DA0 */ public GcTerrainEditsBuffer TerrainEditData;
        [NMS(Size = 0x5, EnumType = typeof(GcNPCHabitationType.NPCHabitationTypeEnum))]
        /* 0x22060 */ public GcNPCWorkerData[] NPCWorkers;
        /* 0x22EC0 */ public List<GcPersistentBase> PersistentPlayerBases;
        /* 0x22ED0 */ public List<GcTeleportEndpoint> TeleportEndpoints;
        /* 0x22EE0 */ public GcInventoryLayout Chest1Layout;
        /* 0x22F00 */ public GcInventoryContainer Chest1Inventory;
        /* 0x23060 */ public GcInventoryLayout Chest2Layout;
        /* 0x23080 */ public GcInventoryContainer Chest2Inventory;
        /* 0x231E0 */ public GcInventoryLayout Chest3Layout;
        /* 0x23200 */ public GcInventoryContainer Chest3Inventory;
        /* 0x23360 */ public GcInventoryLayout Chest4Layout;
        /* 0x23380 */ public GcInventoryContainer Chest4Inventory;
        /* 0x234E0 */ public GcInventoryLayout Chest5Layout;
        /* 0x23500 */ public GcInventoryContainer Chest5Inventory;
        /* 0x23660 */ public GcInventoryLayout Chest6Layout;
        /* 0x23680 */ public GcInventoryContainer Chest6Inventory;
        /* 0x237E0 */ public GcInventoryLayout Chest7Layout;
        /* 0x23800 */ public GcInventoryContainer Chest7Inventory;
        /* 0x23960 */ public GcInventoryLayout Chest8Layout;
        /* 0x23980 */ public GcInventoryContainer Chest8Inventory;
        /* 0x23AE0 */ public GcInventoryLayout Chest9Layout;
        /* 0x23B00 */ public GcInventoryContainer Chest9Inventory;
        /* 0x23C60 */ public GcInventoryLayout Chest10Layout;
        /* 0x23C80 */ public GcInventoryContainer Chest10Inventory;
        /* 0x23DE0 */ public GcInventoryLayout ChestMagicLayout;
        /* 0x23E00 */ public GcInventoryContainer ChestMagicInventory;
        /* 0x23F60 */ public GcInventoryLayout ChestMagic2Layout;
        /* 0x23F80 */ public GcInventoryContainer ChestMagic2Inventory;
        /* 0x240E0 */ public GcInventoryLayout CookingIngredientsLayout;
        /* 0x24100 */ public GcInventoryContainer CookingIngredientsInventory;
        /* 0x24260 */ public GcResourceElement CurrentFreighterNPC;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x24508 */ public byte[] Padding24508;
        [NMS(Size = 0x7, EnumType = typeof(GcVehicleType.VehicleTypeEnum))]
        /* 0x24510 */ public GcPlayerOwnershipData[] VehicleOwnership;
        /* 0x26DC0 */ public int PrimaryVehicle;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x26DC4 */ public byte[] Padding26DC4;
        [NMS(Size = 0x6)]
        /* 0x26DD0 */ public GcPlayerOwnershipData[] ShipOwnership;
        /* 0x290B0 */ public int PrimaryShip;
        /* 0x290B4 */ public bool MultiShipEnabled;
        [NMS(Size = 0x20)]
        /* 0x290B5 */ public string PlayerFreighterName;
        [NMS(Size = 0xB, Ignore = true)]
        /* 0x290D5 */ public byte[] Padding290D5;
        /* 0x290E0 */ public Vector4f StartGameShipPosition;
        /* 0x290F0 */ public bool ShipNeedsTerrainPositioning;
        /* 0x290F4 */ public int TradingSupplyDataIndex;
        /* 0x290F8 */ public List<GcTradingSupplyData> TradingSupplyData;
        /* 0x29108 */ public List<GcPortalData> LastPortal;
        /* 0x29118 */ public GcPortalSaveData VisitedPortal;
        /* 0x29130 */ public int KnownPortalRunes;
        /* 0x29134 */ public bool OnOtherSideOfPortal;
        [NMS(Size = 0xB, Ignore = true)]
        /* 0x29135 */ public byte[] Padding29135;
        /* 0x29140 */ public GcTeleportEndpoint OtherSideOfPortalReturnBase;
        /* 0x291D0 */ public Vector4f PortalMarkerPosition_Local;
        /* 0x291E0 */ public Vector4f PortalMarkerPosition_Offset;
        /* 0x291F0 */ public GcPlayerWeapons StartingPrimaryWeapon;
        /* 0x291F4 */ public GcPlayerWeapons StartingSecondaryWeapon;
        [NMS(Size = 0x10, EnumType = typeof(GcCustomisationComponentData.CustomisationDataTypeEnum))]
        /* 0x291F8 */ public GcCharacterCustomisationSaveData[] CharacterCustomisationData;
        [NMS(Size = 0x6)]
        /* 0x29778 */ public bool[] ShipUsesLegacyColours;
        [NMS(Size = 0x2, Ignore = true)]
        /* 0x2977E */ public byte[] Padding2977E;
        [NMS(Size = 0x3)]
        /* 0x29780 */ public GcCharacterCustomisationData[] Outfits;
        [NMS(Size = 0x10)]
        /* 0x29858 */ public string JetpackEffect;
        /* 0x29868 */ public GcSeed FleetSeed;
        /* 0x29878 */ public List<GcFleetFrigateSaveData> FleetFrigates;
        /* 0x29888 */ public List<GcFleetExpeditionSaveData> FleetExpeditions;
        /* 0x29898 */ public List<long> ExpeditionSeedsSelectedToday;
        /* 0x298A8 */ public ulong LastKnownDay;
        /* 0x298B0 */ public ulong SunTimer;
        /* 0x298B8 */ public ulong MultiplayerLobbyID;
        /* 0x298C0 */ public GcUniverseAddressData MultiplayerUA;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x298D8 */ public byte[] Padding298D8;
        /* 0x298E0 */ public GcPlayerSpawnStateData MultiplayerSpawn;
        /* 0x29990 */ public List<GcRepairTechData> RepairTechBuffer;
        /* 0x299A0 */ public ulong MultiplayerPrivileges;
        [NMS(Size = 0x3, EnumType = typeof(GcHotActionMenuTypes.HotActionMenuTypesEnum))]
        /* 0x299A8 */ public GcHotActionsSaveData[] HotActions;
        /* 0x29E58 */ public ulong LastUABeforePortalWarp;
        /* 0x29E60 */ public ulong StoryPortalSeed;
        /* 0x29E68 */ public ushort ShopNumber;
        /* 0x29E6A */ public ushort ShopTier;
        /* 0x29E6C */ public bool HasAccessToNexus;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x29E6D */ public byte[] Padding29E6D;
        /* 0x29E70 */ public GcUniverseAddressData NexusUniverseAddress;
        /* 0x29E90 */ public Vector3f NexusMatrixAt;
        /* 0x29EA0 */ public Vector3f NexusMatrixUp;
        /* 0x29EB0 */ public Vector3f NexusMatrixPos;
        /* 0x29EC0 */ public GcPhotoModeSettings PhotoModeSettings;
        /* 0x29F10 */ public int BannerIcon;
        /* 0x29F14 */ public int BannerMainColour;
        /* 0x29F18 */ public int BannerBackgroundColour;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x29F1C */ public byte[] Padding29F1C;
        [NMS(Size = 0x10)]
        /* 0x29F20 */ public string BannerTitleId;
        /* 0x29F30 */ public int TelemetryUploadVersion;
        /* 0x29F34 */ public bool UsesThirdPersonVehicleCam;
        /* 0x29F38 */ public float VRCameraOffset;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x29F3C */ public byte[] Padding29F3C;
        /* 0x29F40 */ public GcSeasonalGameModeData SeasonalData;
        /* 0x2A028 */ public GcPlanetaryMappingData PlanetaryMappingData;
    }
}
