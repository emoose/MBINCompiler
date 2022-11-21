using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7F3472783DCEB892, NameHash = 0x6C4510BB243EFA64)]
    public class GcPlayerStateData : NMSTemplate
    {
        /* 0x00000 */ public GcUniverseAddressData UniverseAddress;
        /* 0x00018 */ public GcUniverseAddressData PreviousUniverseAddress;
        /* 0x00030 */ public int HomeRealityIteration;
        /* 0x00034 */ public NMSString0x80 SaveName;
        /* 0x000B4 */ public NMSString0x80 SaveSummary;
        /* 0x00134 */ public GcDifficultyStateData DifficultyState;
        /* 0x00198 */ public GcInventoryContainer Inventory;
        /* 0x002F0 */ public GcInventoryContainer Inventory_TechOnly;
        /* 0x00448 */ public GcInventoryContainer Inventory_Cargo;
        /* 0x005A0 */ public GcInventoryContainer ShipInventory;
        /* 0x006F8 */ public GcInventoryContainer WeaponInventory;
        [NMS(Size = 0x6)]
        /* 0x00850 */ public GcMultitoolData[] Multitools;
        /* 0x02290 */ public int ActiveMultioolIndex;
        /* 0x02298 */ public GcByteBeatLibraryData ByteBeatLibrary;
        [NMS(Size = 0x12)]
        /* 0x03CA0 */ public GcPetData[] Pets;
        [NMS(Size = 0x12)]
        /* 0x062E0 */ public GcPetData[] Eggs;
        [NMS(Size = 0x12)]
        /* 0x08920 */ public GcPetCustomisationData[] PetAccessoryCustomisation;
        [NMS(Size = 0x12)]
        /* 0x09BB0 */ public bool[] UnlockedPetSlots;
        /* 0x09BC8 */ public GcInventoryContainer GraveInventory;
        /* 0x09D20 */ public bool SpawnGrave;
        /* 0x09D21 */ public bool SpaceGrave;
        /* 0x09D24 */ public GcUniverseAddressData GraveUniverseAddress;
        /* 0x09D40 */ public Vector4f GravePosition;
        /* 0x09D50 */ public Vector4f GraveMatrixLookAt;
        /* 0x09D60 */ public Vector4f GraveMatrixUp;
        /* 0x09D70 */ public GcInventoryLayout ShipLayout;
        /* 0x09D90 */ public GcInventoryLayout WeaponLayout;
        /* 0x09DB0 */ public GcResourceElement CurrentShip;
        /* 0x0A058 */ public GcExactResource CurrentWeapon;
        /* 0x0A0E8 */ public List<NMSString0x10> KnownTech;
        /* 0x0A0F8 */ public List<NMSString0x10> KnownProducts;
        /* 0x0A108 */ public List<NMSString0x10> KnownSpecials;
        /* 0x0A118 */ public List<NMSString0x20A> KnownRefinerRecipes;
        /* 0x0A128 */ public List<GcWordKnowledge> KnownWords;
        /* 0x0A138 */ public List<GcWordGroupKnowledge> KnownWordGroups;
        /* 0x0A148 */ public List<GcPlayerMissionProgress> MissionProgress;
        /* 0x0A158 */ public int PostMissionIndex;
        /* 0x0A160 */ public NMSString0x10 CurrentMissionID;
        /* 0x0A170 */ public ulong CurrentMissionSeed;
        /* 0x0A178 */ public NMSString0x10 PreviousMissionID;
        /* 0x0A188 */ public ulong PreviousMissionSeed;
        /* 0x0A190 */ public int MissionVersion;
        /* 0x0A198 */ public List<GcMissionIDEpochPair> MissionRecurrences;
        /* 0x0A1B0 */ public GcInteractionData HoloExplorerInteraction;
        /* 0x0A1D0 */ public GcInteractionData HoloScepticInteraction;
        /* 0x0A1F0 */ public GcInteractionData HoloNooneInteraction;
        /* 0x0A210 */ public int Health;
        /* 0x0A214 */ public int ShipHealth;
        /* 0x0A218 */ public int Shield;
        /* 0x0A21C */ public int ShipShield;
        /* 0x0A220 */ public int Energy;
        /* 0x0A224 */ public int Units;
        /* 0x0A228 */ public int Nanites;
        /* 0x0A22C */ public int Specials;
        /* 0x0A230 */ public bool ThirdPersonShip;
        /* 0x0A238 */ public ulong TimeAlive;
        /* 0x0A240 */ public ulong TotalPlayTime;
        /* 0x0A248 */ public List<GcScanEventSave> MarkerStack;
        /* 0x0A258 */ public List<GcScanEventSave> NewMPMarkerStack;
        /* 0x0A268 */ public List<Vector3f> SurveyedEventPositions;
        /* 0x0A278 */ public int NextSurveyedEventPositionIndex;
        /* 0x0A280 */ public List<GcPlayerStatsGroup> Stats;
        /* 0x0A290 */ public List<GcTelemetryStat> TelemetryStats;
        [NMS(Size = 0xB, EnumType = typeof(GcInteractionBufferType.InteractionBufferTypeEnum))]
        /* 0x0A2A0 */ public GcInteractionBuffer[] StoredInteractions;
        /* 0x0A3A8 */ public List<GcMaintenanceContainer> MaintenanceInteractions;
        /* 0x0A3B8 */ public List<GcMaintenanceContainer> PersonalMaintenanceInteractions;
        /* 0x0A3C8 */ public List<ulong> VisitedSystems;
        [NMS(Size = 0x6, EnumType = typeof(GcPlayerHazardType.HazardEnum))]
        /* 0x0A3D8 */ public float[] Hazard;
        /* 0x0A3F0 */ public int BoltAmmo;
        /* 0x0A3F4 */ public int ScatterAmmo;
        /* 0x0A3F8 */ public int PulseAmmo;
        /* 0x0A3FC */ public int LaserAmmo;
        /* 0x0A400 */ public Vector4f FirstSpawnPosition;
        [NMS(Size = 0x83, EnumType = typeof(GcInteractionType.InteractionTypeEnum))]
        /* 0x0A410 */ public GcSavedInteractionRaceData[] SavedInteractionIndicies;
        /* 0x0B888 */ public List<GcSavedInteractionDialogData> SavedInteractionDialogTable;
        /* 0x0B898 */ public List<NMSString0x20A> InteractionProgressTable;
        [NMS(Size = 0xA)]
        /* 0x0B8A8 */ public GcUniverseAddressData[] AtlasStationAdressData;
        [NMS(Size = 0xB)]
        /* 0x0B998 */ public GcUniverseAddressData[] NewAtlasStationAdressData;
        /* 0x0BAA0 */ public List<GcUniverseAddressData> VisitedAtlasStationsData;
        /* 0x0BAB0 */ public bool FirstAtlasStationDiscovered;
        /* 0x0BAB1 */ public bool UsesThirdPersonCharacterCam;
        /* 0x0BAB4 */ public int ProgressionLevel;
        /* 0x0BAB8 */ public int ProcTechIndex;
        /* 0x0BABC */ public bool IsNew;
        /* 0x0BABD */ public bool UseSmallerBlackholeJumps;
        /* 0x0BAC0 */ public List<GcSavedEntitlement> UsedEntitlements;
        [NMS(Size = 0x10)]
        /* 0x0BAD0 */ public Vector3f[] PlanetPositions;
        [NMS(Size = 0x10)]
        /* 0x0BBD0 */ public GcSeed[] PlanetSeeds;
        /* 0x0BCD0 */ public int PrimaryPlanet;
        /* 0x0BCD8 */ public ulong TimeLastSpaceBattle;
        /* 0x0BCE0 */ public int WarpsLastSpaceBattle;
        /* 0x0BCE8 */ public ulong ActiveSpaceBattleUA;
        /* 0x0BCF0 */ public ulong TimeLastMiniStation;
        /* 0x0BCF8 */ public int WarpsLastMiniStation;
        /* 0x0BD00 */ public ulong MiniStationUA;
        /* 0x0BD10 */ public Vector4f AnomalyPositionOverride;
        /* 0x0BD20 */ public GcUniverseAddressData GameStartAddress1;
        /* 0x0BD38 */ public GcUniverseAddressData GameStartAddress2;
        [NMS(Size = 0x10)]
        /* 0x0BD50 */ public bool[] GalacticMapRequests;
        /* 0x0BD60 */ public Vector4f FirstShipPosition;
        /* 0x0BD70 */ public ulong HazardTimeAlive;
        /* 0x0BD78 */ public bool RevealBlackHoles;
        /* 0x0BD80 */ public GcSeed CurrentFreighterHomeSystemSeed;
        /* 0x0BD90 */ public GcResourceElement CurrentFreighter;
        /* 0x0C038 */ public GcInventoryLayout FreighterLayout;
        /* 0x0C058 */ public GcInventoryLayout FreighterCargoLayout;
        /* 0x0C078 */ public GcInventoryContainer FreighterInventory;
        /* 0x0C1D0 */ public GcInventoryContainer FreighterInventory_TechOnly;
        /* 0x0C328 */ public GcInventoryContainer FreighterInventory_Cargo;
        /* 0x0C480 */ public ulong FreighterLastSpawnTime;
        /* 0x0C488 */ public GcUniverseAddressData FreighterUniverseAddress;
        /* 0x0C4A0 */ public bool FreighterDismissed;
        /* 0x0C4B0 */ public Vector3f FreighterMatrixAt;
        /* 0x0C4C0 */ public Vector3f FreighterMatrixUp;
        /* 0x0C4D0 */ public Vector3f FreighterMatrixPos;
        [NMS(Size = 0x4)]
        /* 0x0C4E0 */ public bool[] SquadronUnlockedPilotSlots;
        [NMS(Size = 0x4)]
        /* 0x0C4E8 */ public GcSquadronPilotData[] SquadronPilots;
        /* 0x0DA68 */ public List<NMSString0x10> SeenBaseBuildingObjects;
        /* 0x0DA78 */ public List<GcPersistentBBObjectData> BaseBuildingObjects;
        /* 0x0DA90 */ public GcTerrainEditsBuffer TerrainEditData;
        [NMS(Size = 0x5, EnumType = typeof(GcNPCHabitationType.NPCHabitationTypeEnum))]
        /* 0x4A210 */ public GcNPCWorkerData[] NPCWorkers;
        /* 0x4B070 */ public List<GcPersistentBase> PersistentPlayerBases;
        /* 0x4B080 */ public List<GcTeleportEndpoint> TeleportEndpoints;
        /* 0x4B090 */ public GcInventoryLayout Chest1Layout;
        /* 0x4B0B0 */ public GcInventoryContainer Chest1Inventory;
        /* 0x4B208 */ public GcInventoryLayout Chest2Layout;
        /* 0x4B228 */ public GcInventoryContainer Chest2Inventory;
        /* 0x4B380 */ public GcInventoryLayout Chest3Layout;
        /* 0x4B3A0 */ public GcInventoryContainer Chest3Inventory;
        /* 0x4B4F8 */ public GcInventoryLayout Chest4Layout;
        /* 0x4B518 */ public GcInventoryContainer Chest4Inventory;
        /* 0x4B670 */ public GcInventoryLayout Chest5Layout;
        /* 0x4B690 */ public GcInventoryContainer Chest5Inventory;
        /* 0x4B7E8 */ public GcInventoryLayout Chest6Layout;
        /* 0x4B808 */ public GcInventoryContainer Chest6Inventory;
        /* 0x4B960 */ public GcInventoryLayout Chest7Layout;
        /* 0x4B980 */ public GcInventoryContainer Chest7Inventory;
        /* 0x4BAD8 */ public GcInventoryLayout Chest8Layout;
        /* 0x4BAF8 */ public GcInventoryContainer Chest8Inventory;
        /* 0x4BC50 */ public GcInventoryLayout Chest9Layout;
        /* 0x4BC70 */ public GcInventoryContainer Chest9Inventory;
        /* 0x4BDC8 */ public GcInventoryLayout Chest10Layout;
        /* 0x4BDE8 */ public GcInventoryContainer Chest10Inventory;
        /* 0x4BF40 */ public GcInventoryLayout ChestMagicLayout;
        /* 0x4BF60 */ public GcInventoryContainer ChestMagicInventory;
        /* 0x4C0B8 */ public GcInventoryLayout ChestMagic2Layout;
        /* 0x4C0D8 */ public GcInventoryContainer ChestMagic2Inventory;
        /* 0x4C230 */ public GcInventoryLayout CookingIngredientsLayout;
        /* 0x4C250 */ public GcInventoryContainer CookingIngredientsInventory;
        /* 0x4C3A8 */ public GcInventoryLayout RocketLockerLayout;
        /* 0x4C3C8 */ public GcInventoryContainer RocketLockerInventory;
        /* 0x4C520 */ public GcResourceElement CurrentFreighterNPC;
        [NMS(Size = 0x7, EnumType = typeof(GcVehicleType.VehicleTypeEnum))]
        /* 0x4C7D0 */ public GcPlayerOwnershipData[] VehicleOwnership;
        /* 0x4F9B0 */ public int PrimaryVehicle;
        [NMS(Size = 0x9)]
        /* 0x4F9C0 */ public GcPlayerOwnershipData[] ShipOwnership;
        /* 0x539E0 */ public int PrimaryShip;
        /* 0x539E4 */ public bool MultiShipEnabled;
        /* 0x539E5 */ public bool VehicleAIControlEnabled;
        /* 0x539E6 */ public NMSString0x20 PlayerFreighterName;
        /* 0x53A10 */ public Vector4f StartGameShipPosition;
        /* 0x53A20 */ public bool ShipNeedsTerrainPositioning;
        /* 0x53A24 */ public int TradingSupplyDataIndex;
        /* 0x53A28 */ public List<GcTradingSupplyData> TradingSupplyData;
        /* 0x53A38 */ public List<GcPortalSaveData> LastPortal;
        /* 0x53A48 */ public GcPortalSaveData VisitedPortal;
        /* 0x53A68 */ public int KnownPortalRunes;
        /* 0x53A6C */ public bool OnOtherSideOfPortal;
        /* 0x53A70 */ public GcTeleportEndpoint OtherSideOfPortalReturnBase;
        /* 0x53B00 */ public Vector4f PortalMarkerPosition_Local;
        /* 0x53B10 */ public Vector4f PortalMarkerPosition_Offset;
        /* 0x53B20 */ public GcPlayerWeapons StartingPrimaryWeapon;
        /* 0x53B24 */ public GcPlayerWeapons StartingSecondaryWeapon;
        [NMS(Size = 0x14, EnumType = typeof(GcCustomisationComponentData.CustomisationDataTypeEnum))]
        /* 0x53B28 */ public GcCharacterCustomisationSaveData[] CharacterCustomisationData;
        [NMS(Size = 0x9)]
        /* 0x54208 */ public bool[] ShipUsesLegacyColours;
        [NMS(Size = 0x3)]
        /* 0x54218 */ public GcCharacterCustomisationData[] Outfits;
        /* 0x542F0 */ public NMSString0x10 JetpackEffect;
        /* 0x54300 */ public NMSString0x10 FreighterEngineEffect;
        /* 0x54310 */ public GcSeed FleetSeed;
        /* 0x54320 */ public List<GcFleetFrigateSaveData> FleetFrigates;
        /* 0x54330 */ public List<GcFleetExpeditionSaveData> FleetExpeditions;
        /* 0x54340 */ public List<ulong> ExpeditionSeedsSelectedToday;
        /* 0x54350 */ public ulong LastKnownDay;
        /* 0x54358 */ public ulong SunTimer;
        /* 0x54360 */ public ulong MultiplayerLobbyID;
        /* 0x54368 */ public GcUniverseAddressData MultiplayerUA;
        /* 0x54380 */ public GcPlayerSpawnStateData MultiplayerSpawn;
        /* 0x54450 */ public List<GcRepairTechData> RepairTechBuffer;
        /* 0x54460 */ public ulong MultiplayerPrivileges;
        [NMS(Size = 0x3, EnumType = typeof(GcHotActionMenuTypes.HotActionMenuTypesEnum))]
        /* 0x54468 */ public GcHotActionsSaveData[] HotActions;
        /* 0x54918 */ public ulong LastUABeforePortalWarp;
        /* 0x54920 */ public ulong StoryPortalSeed;
        /* 0x54928 */ public ushort ShopNumber;
        /* 0x5492A */ public ushort ShopTier;
        /* 0x5492C */ public bool HasAccessToNexus;
        /* 0x54930 */ public GcUniverseAddressData NexusUniverseAddress;
        /* 0x54950 */ public Vector3f NexusMatrixAt;
        /* 0x54960 */ public Vector3f NexusMatrixUp;
        /* 0x54970 */ public Vector3f NexusMatrixPos;
        /* 0x54980 */ public GcPhotoModeSettings PhotoModeSettings;
        /* 0x549D0 */ public int BannerIcon;
        /* 0x549D4 */ public int BannerMainColour;
        /* 0x549D8 */ public int BannerBackgroundColour;
        /* 0x549E0 */ public NMSString0x10 BannerTitleId;
        /* 0x549F0 */ public int TelemetryUploadVersion;
        /* 0x549F4 */ public bool UsesThirdPersonVehicleCam;
        /* 0x549F8 */ public float VRCameraOffset;
        /* 0x54A00 */ public GcSeasonalGameModeData SeasonData;
        /* 0x57DF8 */ public GcSeasonStateData SeasonState;
        /* 0x57E50 */ public bool RestartAllInactiveSeasonalMissions;
        /* 0x57E58 */ public List<NMSString0x10> RedeemedSeasonRewards;
        /* 0x57E68 */ public List<NMSString0x10> RedeemedTwitchRewards;
        /* 0x57E78 */ public List<NMSString0x10> RedeemedPlatformRewards;
        [NMS(Size = 0x64)]
        /* 0x57E90 */ public GcSettlementState[] SettlementStatesV2;
        /* 0x77290 */ public int SettlementStateRingBufferIndexV2;
        /* 0x77294 */ public bool NextLoadSpawnsWithFreshStart;
        [NMS(Size = 0x8, EnumType = typeof(GcAlienRace.AlienRaceEnum))]
        /* 0x77298 */ public GcStoryPageSeenDataArray[] SeenStories;
    }
}
