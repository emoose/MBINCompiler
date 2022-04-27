using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x76B10, GUID = 0x98C18F97236AC977, NameHash = 0x6C4510BB243EFA64)]
    public class GcPlayerStateData : NMSTemplate
    {
        /* 0x00000 */ public GcUniverseAddressData UniverseAddress;
        /* 0x00018 */ public GcUniverseAddressData PreviousUniverseAddress;
        /* 0x00030 */ public int HomeRealityIteration;
        /* 0x00038 */ public GcInventoryContainer Inventory;
        /* 0x00198 */ public GcInventoryContainer Inventory_TechOnly;
        /* 0x002F8 */ public GcInventoryContainer Inventory_Cargo;
        /* 0x00458 */ public GcInventoryContainer ShipInventory;
        /* 0x005B8 */ public GcInventoryContainer WeaponInventory;
        [NMS(Size = 0x6)]
        /* 0x00718 */ public GcMultitoolData[] Multitools;
        /* 0x02188 */ public int ActiveMultioolIndex;
        /* 0x02190 */ public GcByteBeatLibraryData ByteBeatLibrary;
        [NMS(Size = 0x12)]
        /* 0x03B98 */ public GcPetData[] Pets;
        [NMS(Size = 0x12)]
        /* 0x061D8 */ public GcPetData[] Eggs;
        [NMS(Size = 0x12)]
        /* 0x08818 */ public GcPetCustomisationData[] PetAccessoryCustomisation;
        [NMS(Size = 0x12)]
        /* 0x09AA8 */ public bool[] UnlockedPetSlots;
        /* 0x09AC0 */ public GcInventoryContainer GraveInventory;
        /* 0x09C20 */ public bool SpawnGrave;
        /* 0x09C21 */ public bool SpaceGrave;
        /* 0x09C24 */ public GcUniverseAddressData GraveUniverseAddress;
        /* 0x09C40 */ public Vector4f GravePosition;
        /* 0x09C50 */ public Vector4f GraveMatrixLookAt;
        /* 0x09C60 */ public Vector4f GraveMatrixUp;
        /* 0x09C70 */ public GcInventoryLayout ShipLayout;
        /* 0x09C90 */ public GcInventoryLayout WeaponLayout;
        /* 0x09CB0 */ public GcResourceElement CurrentShip;
        /* 0x09F58 */ public GcExactResource CurrentWeapon;
        /* 0x09FE8 */ public List<NMSString0x10> KnownTech;
        /* 0x09FF8 */ public List<NMSString0x10> KnownProducts;
        /* 0x0A008 */ public List<NMSString0x10> KnownSpecials;
        /* 0x0A018 */ public List<NMSString0x20A> KnownRefinerRecipes;
        /* 0x0A028 */ public List<GcWordKnowledge> KnownWords;
        /* 0x0A038 */ public List<GcWordGroupKnowledge> KnownWordGroups;
        /* 0x0A048 */ public List<GcPlayerMissionProgress> MissionProgress;
        /* 0x0A058 */ public int PostMissionIndex;
        /* 0x0A060 */ public NMSString0x10 CurrentMissionID;
        /* 0x0A070 */ public ulong CurrentMissionSeed;
        /* 0x0A078 */ public NMSString0x10 PreviousMissionID;
        /* 0x0A088 */ public ulong PreviousMissionSeed;
        /* 0x0A090 */ public int MissionVersion;
        /* 0x0A098 */ public List<GcMissionIDEpochPair> MissionRecurrences;
        /* 0x0A0B0 */ public GcInteractionData HoloExplorerInteraction;
        /* 0x0A0D0 */ public GcInteractionData HoloScepticInteraction;
        /* 0x0A0F0 */ public GcInteractionData HoloNooneInteraction;
        /* 0x0A110 */ public int Health;
        /* 0x0A114 */ public int ShipHealth;
        /* 0x0A118 */ public int Shield;
        /* 0x0A11C */ public int ShipShield;
        /* 0x0A120 */ public int Energy;
        /* 0x0A124 */ public int Units;
        /* 0x0A128 */ public int Nanites;
        /* 0x0A12C */ public int Specials;
        /* 0x0A130 */ public bool ThirdPersonShip;
        /* 0x0A138 */ public ulong TimeAlive;
        /* 0x0A140 */ public ulong TotalPlayTime;
        /* 0x0A148 */ public List<GcScanEventSave> MarkerStack;
        /* 0x0A158 */ public List<GcScanEventSave> NewMPMarkerStack;
        /* 0x0A168 */ public List<Vector3f> SurveyedEventPositions;
        /* 0x0A178 */ public int NextSurveyedEventPositionIndex;
        /* 0x0A180 */ public List<GcPlayerStatsGroup> Stats;
        /* 0x0A190 */ public List<GcTelemetryStat> TelemetryStats;
        [NMS(Size = 0xB, EnumType = typeof(GcInteractionBufferType.InterationBufferTypeEnum))]
        /* 0x0A1A0 */ public GcInteractionBuffer[] StoredInteractions;
        /* 0x0A2A8 */ public List<GcMaintenanceContainer> MaintenanceInteractions;
        /* 0x0A2B8 */ public List<GcMaintenanceContainer> PersonalMaintenanceInteractions;
        /* 0x0A2C8 */ public List<ulong> VisitedSystems;        // probably technically the 8 byte hex used to denote systems...
        [NMS(Size = 0x6, EnumType = typeof(GcPlayerHazardType.HazardEnum))]
        /* 0x0A2D8 */ public float[] Hazard;
        /* 0x0A2F0 */ public int BoltAmmo;
        /* 0x0A2F4 */ public int ScatterAmmo;
        /* 0x0A2F8 */ public int PulseAmmo;
        /* 0x0A2FC */ public int LaserAmmo;
        /* 0x0A300 */ public Vector4f FirstSpawnPosition;
        [NMS(Size = 0x7F, EnumType = typeof(GcInteractionType.InteractionTypeEnum))]
        /* 0x0A310 */ public GcSavedInteractionRaceData[] SavedInteractionIndicies;
        /* 0x0B2F0 */ public List<GcSavedInteractionDialogData> SavedInteractionDialogTable;
        /* 0x0B300 */ public List<NMSString0x20A> InteractionProgressTable;
        [NMS(Size = 0xA)]
        /* 0x0B310 */ public GcUniverseAddressData[] AtlasStationAdressData;
        [NMS(Size = 0xB)]
        /* 0x0B400 */ public GcUniverseAddressData[] NewAtlasStationAdressData;
        /* 0x0B508 */ public List<GcUniverseAddressData> VisitedAtlasStationsData;
        /* 0x0B518 */ public bool FirstAtlasStationDiscovered;
        /* 0x0B519 */ public bool UsesThirdPersonCharacterCam;
        /* 0x0B51C */ public int ProgressionLevel;
        /* 0x0B520 */ public int ProcTechIndex;
        /* 0x0B524 */ public bool IsNew;
        /* 0x0B525 */ public bool UseSmallerBlackholeJumps;
        /* 0x0B528 */ public List<GcSavedEntitlement> UsedEntitlements;
        [NMS(Size = 0x10)]
        /* 0x0B540 */ public Vector3f[] PlanetPositions;
        [NMS(Size = 0x10)]
        /* 0x0B640 */ public GcSeed[] PlanetSeeds;
        /* 0x0B740 */ public int PrimaryPlanet;
        /* 0x0B748 */ public ulong TimeLastSpaceBattle;
        /* 0x0B750 */ public int WarpsLastSpaceBattle;
        /* 0x0B758 */ public ulong ActiveSpaceBattleUA;
        /* 0x0B760 */ public ulong TimeLastMiniStation;
        /* 0x0B768 */ public int WarpsLastMiniStation;
        /* 0x0B770 */ public ulong MiniStationUA;
        /* 0x0B780 */ public Vector4f AnomalyPositionOverride;
        /* 0x0B790 */ public GcUniverseAddressData GameStartAddress1;
        /* 0x0B7A8 */ public GcUniverseAddressData GameStartAddress2;
        [NMS(Size = 0x10)]
        /* 0x0B7C0 */ public bool[] GalacticMapRequests;
        /* 0x0B7D0 */ public Vector4f FirstShipPosition;
        /* 0x0B7E0 */ public ulong HazardTimeAlive;
        /* 0x0B7E8 */ public bool RevealBlackHoles;
        /* 0x0B7F0 */ public GcSeed CurrentFreighterHomeSystemSeed;
        /* 0x0B800 */ public GcResourceElement CurrentFreighter;
        /* 0x0BAA8 */ public GcInventoryLayout FreighterLayout;
        /* 0x0BAC8 */ public GcInventoryContainer FreighterInventory;
        /* 0x0BC28 */ public GcInventoryContainer FreighterInventory_TechOnly;
        /* 0x0BD88 */ public GcUniverseAddressData FreighterUniverseAddress;
        /* 0x0BDA0 */ public Vector3f FreighterMatrixAt;
        /* 0x0BDB0 */ public Vector3f FreighterMatrixUp;
        /* 0x0BDC0 */ public Vector3f FreighterMatrixPos;
        [NMS(Size = 0x4)]
        /* 0x0BDD0 */ public bool[] SquadronUnlockedPilotSlots;
        [NMS(Size = 0x4)]
        /* 0x0BDD8 */ public GcSquadronPilotData[] SquadronPilots;
        /* 0x0D358 */ public List<NMSString0x10> SeenBaseBuildingObjects;
        /* 0x0D368 */ public List<GcPersistentBBObjectData> BaseBuildingObjects;
        /* 0x0D380 */ public GcTerrainEditsBuffer TerrainEditData;
        [NMS(Size = 0x5, EnumType = typeof(GcNPCHabitationType.NPCHabitationTypeEnum))]
        /* 0x49B00 */ public GcNPCWorkerData[] NPCWorkers;
        /* 0x4A960 */ public List<GcPersistentBase> PersistentPlayerBases;
        /* 0x4A970 */ public List<GcTeleportEndpoint> TeleportEndpoints;
        /* 0x4A980 */ public GcInventoryLayout Chest1Layout;
        /* 0x4A9A0 */ public GcInventoryContainer Chest1Inventory;
        /* 0x4AB00 */ public GcInventoryLayout Chest2Layout;
        /* 0x4AB20 */ public GcInventoryContainer Chest2Inventory;
        /* 0x4AC80 */ public GcInventoryLayout Chest3Layout;
        /* 0x4ACA0 */ public GcInventoryContainer Chest3Inventory;
        /* 0x4AE00 */ public GcInventoryLayout Chest4Layout;
        /* 0x4AE20 */ public GcInventoryContainer Chest4Inventory;
        /* 0x4AF80 */ public GcInventoryLayout Chest5Layout;
        /* 0x4AFA0 */ public GcInventoryContainer Chest5Inventory;
        /* 0x4B100 */ public GcInventoryLayout Chest6Layout;
        /* 0x4B120 */ public GcInventoryContainer Chest6Inventory;
        /* 0x4B280 */ public GcInventoryLayout Chest7Layout;
        /* 0x4B2A0 */ public GcInventoryContainer Chest7Inventory;
        /* 0x4B400 */ public GcInventoryLayout Chest8Layout;
        /* 0x4B420 */ public GcInventoryContainer Chest8Inventory;
        /* 0x4B580 */ public GcInventoryLayout Chest9Layout;
        /* 0x4B5A0 */ public GcInventoryContainer Chest9Inventory;
        /* 0x4B700 */ public GcInventoryLayout Chest10Layout;
        /* 0x4B720 */ public GcInventoryContainer Chest10Inventory;
        /* 0x4B880 */ public GcInventoryLayout ChestMagicLayout;
        /* 0x4B8A0 */ public GcInventoryContainer ChestMagicInventory;
        /* 0x4BA00 */ public GcInventoryLayout ChestMagic2Layout;
        /* 0x4BA20 */ public GcInventoryContainer ChestMagic2Inventory;
        /* 0x4BB80 */ public GcInventoryLayout CookingIngredientsLayout;
        /* 0x4BBA0 */ public GcInventoryContainer CookingIngredientsInventory;
        /* 0x4BD00 */ public GcInventoryLayout RocketLockerLayout;
        /* 0x4BD20 */ public GcInventoryContainer RocketLockerInventory;
        /* 0x4BE80 */ public GcResourceElement CurrentFreighterNPC;
        [NMS(Size = 0x7, EnumType = typeof(GcVehicleType.VehicleTypeEnum))]
        /* 0x4C130 */ public GcPlayerOwnershipData[] VehicleOwnership;
        /* 0x4F380 */ public int PrimaryVehicle;
        [NMS(Size = 0x9)]
        /* 0x4F390 */ public GcPlayerOwnershipData[] ShipOwnership;
        /* 0x53440 */ public int PrimaryShip;
        /* 0x53444 */ public bool MultiShipEnabled;
        /* 0x53445 */ public bool VehicleAIControlEnabled;
        /* 0x53446 */ public NMSString0x20 PlayerFreighterName;
        /* 0x53470 */ public Vector4f StartGameShipPosition;
        /* 0x53480 */ public bool ShipNeedsTerrainPositioning;
        /* 0x53484 */ public int TradingSupplyDataIndex;
        /* 0x53488 */ public List<GcTradingSupplyData> TradingSupplyData;
        /* 0x53498 */ public List<GcPortalSaveData> LastPortal;
        /* 0x534A8 */ public GcPortalSaveData VisitedPortal;
        /* 0x534C8 */ public int KnownPortalRunes;
        /* 0x534CC */ public bool OnOtherSideOfPortal;
        /* 0x534D0 */ public GcTeleportEndpoint OtherSideOfPortalReturnBase;
        /* 0x53560 */ public Vector4f PortalMarkerPosition_Local;
        /* 0x53570 */ public Vector4f PortalMarkerPosition_Offset;
        /* 0x53580 */ public GcPlayerWeapons StartingPrimaryWeapon;
        /* 0x53584 */ public GcPlayerWeapons StartingSecondaryWeapon;
        [NMS(Size = 0x14, EnumType = typeof(GcCustomisationComponentData.CustomisationDataTypeEnum))]
        /* 0x53588 */ public GcCharacterCustomisationSaveData[] CharacterCustomisationData;
        [NMS(Size = 0x9)]
        /* 0x53C68 */ public bool[] ShipUsesLegacyColours;
        [NMS(Size = 0x3)]
        /* 0x53C78 */ public GcCharacterCustomisationData[] Outfits;
        /* 0x53D50 */ public NMSString0x10 JetpackEffect;
        /* 0x53D60 */ public GcSeed FleetSeed;
        /* 0x53D70 */ public List<GcFleetFrigateSaveData> FleetFrigates;
        /* 0x53D80 */ public List<GcFleetExpeditionSaveData> FleetExpeditions;
        /* 0x53D90 */ public List<ulong> ExpeditionSeedsSelectedToday;
        /* 0x53DA0 */ public ulong LastKnownDay;
        /* 0x53DA8 */ public ulong SunTimer;
        /* 0x53DB0 */ public ulong MultiplayerLobbyID;
        /* 0x53DB8 */ public GcUniverseAddressData MultiplayerUA;
        /* 0x53DD0 */ public GcPlayerSpawnStateData MultiplayerSpawn;
        /* 0x53E80 */ public List<GcRepairTechData> RepairTechBuffer;
        /* 0x53E90 */ public ulong MultiplayerPrivileges;
        [NMS(Size = 0x3, EnumType = typeof(GcHotActionMenuTypes.HotActionMenuTypesEnum))]
        /* 0x53E98 */ public GcHotActionsSaveData[] HotActions;
        /* 0x54348 */ public ulong LastUABeforePortalWarp;
        /* 0x54350 */ public ulong StoryPortalSeed;
        /* 0x54358 */ public ushort ShopNumber;
        /* 0x5435A */ public ushort ShopTier;
        /* 0x5435C */ public bool HasAccessToNexus;
        /* 0x54360 */ public GcUniverseAddressData NexusUniverseAddress;
        /* 0x54380 */ public Vector3f NexusMatrixAt;
        /* 0x54390 */ public Vector3f NexusMatrixUp;
        /* 0x543A0 */ public Vector3f NexusMatrixPos;
        /* 0x543B0 */ public GcPhotoModeSettings PhotoModeSettings;
        /* 0x54400 */ public int BannerIcon;
        /* 0x54404 */ public int BannerMainColour;
        /* 0x54408 */ public int BannerBackgroundColour;
        /* 0x54410 */ public NMSString0x10 BannerTitleId;
        /* 0x54420 */ public int TelemetryUploadVersion;
        /* 0x54424 */ public bool UsesThirdPersonVehicleCam;
        /* 0x54428 */ public float VRCameraOffset;
        /* 0x54430 */ public GcSeasonalGameModeData SeasonData;
        /* 0x57688 */ public GcSeasonStateData SeasonState;
        /* 0x576D8 */ public bool RestartAllInactiveSeasonalMissions;
        /* 0x576E0 */ public List<NMSString0x10> RedeemedSeasonRewards;
        /* 0x576F0 */ public List<NMSString0x10> RedeemedTwitchRewards;
        [NMS(Size = 0x64)]
        /* 0x57700 */ public GcSettlementState[] SettlementStatesV2;
        /* 0x76B00 */ public int SettlementStateRingBufferIndexV2;
    }
}
