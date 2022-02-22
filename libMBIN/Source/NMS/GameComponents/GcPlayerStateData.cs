using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x72CC0, GUID = 0x058152671DA5FC9A, NameHash = 0x6C4510BB243EFA64)]
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
        [NMS(Size = 0x7D, EnumType = typeof(GcInteractionType.InteractionTypeEnum))]
        /* 0x0A310 */ public GcSavedInteractionRaceData[] SavedInteractionIndicies;
        /* 0x0B2B0 */ public List<GcSavedInteractionDialogData> SavedInteractionDialogTable;
        /* 0x0B2C0 */ public List<NMSString0x20A> InteractionProgressTable;
        [NMS(Size = 0xA)]
        /* 0x0B2D0 */ public GcUniverseAddressData[] AtlasStationAdressData;
        [NMS(Size = 0xB)]
        /* 0x0B3C0 */ public GcUniverseAddressData[] NewAtlasStationAdressData;
        /* 0x0B4C8 */ public List<GcUniverseAddressData> VisitedAtlasStationsData;
        /* 0x0B4D8 */ public bool FirstAtlasStationDiscovered;
        /* 0x0B4D9 */ public bool UsesThirdPersonCharacterCam;
        /* 0x0B4DC */ public int ProgressionLevel;
        /* 0x0B4E0 */ public int ProcTechIndex;
        /* 0x0B4E4 */ public bool IsNew;
        /* 0x0B4E5 */ public bool UseSmallerBlackholeJumps;
        /* 0x0B4E8 */ public List<GcSavedEntitlement> UsedEntitlements;
        [NMS(Size = 0x10)]
        /* 0x0B500 */ public Vector3f[] PlanetPositions;
        [NMS(Size = 0x10)]
        /* 0x0B600 */ public GcSeed[] PlanetSeeds;
        /* 0x0B700 */ public int PrimaryPlanet;
        /* 0x0B708 */ public ulong TimeLastSpaceBattle;
        /* 0x0B710 */ public int WarpsLastSpaceBattle;
        /* 0x0B718 */ public ulong ActiveSpaceBattleUA;
        /* 0x0B720 */ public ulong TimeLastMiniStation;
        /* 0x0B728 */ public int WarpsLastMiniStation;
        /* 0x0B730 */ public ulong MiniStationUA;
        /* 0x0B740 */ public Vector4f AnomalyPositionOverride;
        /* 0x0B750 */ public GcUniverseAddressData GameStartAddress1;
        /* 0x0B768 */ public GcUniverseAddressData GameStartAddress2;
        [NMS(Size = 0x10)]
        /* 0x0B780 */ public bool[] GalacticMapRequests;
        /* 0x0B790 */ public Vector4f FirstShipPosition;
        /* 0x0B7A0 */ public ulong HazardTimeAlive;
        /* 0x0B7A8 */ public bool RevealBlackHoles;
        /* 0x0B7B0 */ public GcSeed CurrentFreighterHomeSystemSeed;
        /* 0x0B7C0 */ public GcResourceElement CurrentFreighter;
        /* 0x0BA68 */ public GcInventoryLayout FreighterLayout;
        /* 0x0BA88 */ public GcInventoryContainer FreighterInventory;
        /* 0x0BBE8 */ public GcInventoryContainer FreighterInventory_TechOnly;
        /* 0x0BD48 */ public GcUniverseAddressData FreighterUniverseAddress;
        /* 0x0BD60 */ public Vector3f FreighterMatrixAt;
        /* 0x0BD70 */ public Vector3f FreighterMatrixUp;
        /* 0x0BD80 */ public Vector3f FreighterMatrixPos;
        /* 0x0BD90 */ public List<NMSString0x10> SeenBaseBuildingObjects;
        /* 0x0BDA0 */ public List<GcPersistentBBObjectData> BaseBuildingObjects;
        /* 0x0BDB0 */ public GcTerrainEditsBuffer TerrainEditData;
        [NMS(Size = 0x5, EnumType = typeof(GcNPCHabitationType.NPCHabitationTypeEnum))]
        /* 0x48530 */ public GcNPCWorkerData[] NPCWorkers;
        /* 0x49390 */ public List<GcPersistentBase> PersistentPlayerBases;
        /* 0x493A0 */ public List<GcTeleportEndpoint> TeleportEndpoints;
        /* 0x493B0 */ public GcInventoryLayout Chest1Layout;
        /* 0x493D0 */ public GcInventoryContainer Chest1Inventory;
        /* 0x49530 */ public GcInventoryLayout Chest2Layout;
        /* 0x49550 */ public GcInventoryContainer Chest2Inventory;
        /* 0x496B0 */ public GcInventoryLayout Chest3Layout;
        /* 0x496D0 */ public GcInventoryContainer Chest3Inventory;
        /* 0x49830 */ public GcInventoryLayout Chest4Layout;
        /* 0x49850 */ public GcInventoryContainer Chest4Inventory;
        /* 0x499B0 */ public GcInventoryLayout Chest5Layout;
        /* 0x499D0 */ public GcInventoryContainer Chest5Inventory;
        /* 0x49B30 */ public GcInventoryLayout Chest6Layout;
        /* 0x49B50 */ public GcInventoryContainer Chest6Inventory;
        /* 0x49CB0 */ public GcInventoryLayout Chest7Layout;
        /* 0x49CD0 */ public GcInventoryContainer Chest7Inventory;
        /* 0x49E30 */ public GcInventoryLayout Chest8Layout;
        /* 0x49E50 */ public GcInventoryContainer Chest8Inventory;
        /* 0x49FB0 */ public GcInventoryLayout Chest9Layout;
        /* 0x49FD0 */ public GcInventoryContainer Chest9Inventory;
        /* 0x4A130 */ public GcInventoryLayout Chest10Layout;
        /* 0x4A150 */ public GcInventoryContainer Chest10Inventory;
        /* 0x4A2B0 */ public GcInventoryLayout ChestMagicLayout;
        /* 0x4A2D0 */ public GcInventoryContainer ChestMagicInventory;
        /* 0x4A430 */ public GcInventoryLayout ChestMagic2Layout;
        /* 0x4A450 */ public GcInventoryContainer ChestMagic2Inventory;
        /* 0x4A5B0 */ public GcInventoryLayout CookingIngredientsLayout;
        /* 0x4A5D0 */ public GcInventoryContainer CookingIngredientsInventory;
        /* 0x4A730 */ public GcInventoryLayout RocketLockerLayout;
        /* 0x4A750 */ public GcInventoryContainer RocketLockerInventory;
        /* 0x4A8B0 */ public GcResourceElement CurrentFreighterNPC;
        [NMS(Size = 0x7, EnumType = typeof(GcVehicleType.VehicleTypeEnum))]
        /* 0x4AB60 */ public GcPlayerOwnershipData[] VehicleOwnership;
        /* 0x4D410 */ public int PrimaryVehicle;
        [NMS(Size = 0x6)]
        /* 0x4D420 */ public GcPlayerOwnershipData[] ShipOwnership;
        /* 0x4F700 */ public int PrimaryShip;
        /* 0x4F704 */ public bool MultiShipEnabled;
        /* 0x4F705 */ public NMSString0x20 PlayerFreighterName;
        /* 0x4F730 */ public Vector4f StartGameShipPosition;
        /* 0x4F740 */ public bool ShipNeedsTerrainPositioning;
        /* 0x4F744 */ public int TradingSupplyDataIndex;
        /* 0x4F748 */ public List<GcTradingSupplyData> TradingSupplyData;
        /* 0x4F758 */ public List<GcPortalSaveData> LastPortal;
        /* 0x4F768 */ public GcPortalSaveData VisitedPortal;
        /* 0x4F788 */ public int KnownPortalRunes;
        /* 0x4F78C */ public bool OnOtherSideOfPortal;
        /* 0x4F790 */ public GcTeleportEndpoint OtherSideOfPortalReturnBase;
        /* 0x4F820 */ public Vector4f PortalMarkerPosition_Local;
        /* 0x4F830 */ public Vector4f PortalMarkerPosition_Offset;
        /* 0x4F840 */ public GcPlayerWeapons StartingPrimaryWeapon;
        /* 0x4F844 */ public GcPlayerWeapons StartingSecondaryWeapon;
        [NMS(Size = 0x11, EnumType = typeof(GcCustomisationComponentData.CustomisationDataTypeEnum))]
        /* 0x4F848 */ public GcCharacterCustomisationSaveData[] CharacterCustomisationData;
        [NMS(Size = 0x6)]
        /* 0x4FE20 */ public bool[] ShipUsesLegacyColours;
        [NMS(Size = 0x3)]
        /* 0x4FE28 */ public GcCharacterCustomisationData[] Outfits;
        /* 0x4FF00 */ public NMSString0x10 JetpackEffect;
        /* 0x4FF10 */ public GcSeed FleetSeed;
        /* 0x4FF20 */ public List<GcFleetFrigateSaveData> FleetFrigates;
        /* 0x4FF30 */ public List<GcFleetExpeditionSaveData> FleetExpeditions;
        /* 0x4FF40 */ public List<ulong> ExpeditionSeedsSelectedToday;
        /* 0x4FF50 */ public ulong LastKnownDay;
        /* 0x4FF58 */ public ulong SunTimer;
        /* 0x4FF60 */ public ulong MultiplayerLobbyID;
        /* 0x4FF68 */ public GcUniverseAddressData MultiplayerUA;
        /* 0x4FF80 */ public GcPlayerSpawnStateData MultiplayerSpawn;
        /* 0x50030 */ public List<GcRepairTechData> RepairTechBuffer;
        /* 0x50040 */ public ulong MultiplayerPrivileges;
        [NMS(Size = 0x3, EnumType = typeof(GcHotActionMenuTypes.HotActionMenuTypesEnum))]
        /* 0x50048 */ public GcHotActionsSaveData[] HotActions;
        /* 0x504F8 */ public ulong LastUABeforePortalWarp;
        /* 0x50500 */ public ulong StoryPortalSeed;
        /* 0x50508 */ public ushort ShopNumber;
        /* 0x5050A */ public ushort ShopTier;
        /* 0x5050C */ public bool HasAccessToNexus;
        /* 0x50510 */ public GcUniverseAddressData NexusUniverseAddress;
        /* 0x50530 */ public Vector3f NexusMatrixAt;
        /* 0x50540 */ public Vector3f NexusMatrixUp;
        /* 0x50550 */ public Vector3f NexusMatrixPos;
        /* 0x50560 */ public GcPhotoModeSettings PhotoModeSettings;
        /* 0x505B0 */ public int BannerIcon;
        /* 0x505B4 */ public int BannerMainColour;
        /* 0x505B8 */ public int BannerBackgroundColour;
        /* 0x505C0 */ public NMSString0x10 BannerTitleId;
        /* 0x505D0 */ public int TelemetryUploadVersion;
        /* 0x505D4 */ public bool UsesThirdPersonVehicleCam;
        /* 0x505D8 */ public float VRCameraOffset;
        /* 0x505E0 */ public GcSeasonalGameModeData SeasonData;
        /* 0x53830 */ public GcSeasonStateData SeasonState;
        /* 0x53880 */ public bool RestartAllInactiveSeasonalMissions;
        /* 0x53888 */ public List<NMSString0x10> RedeemedSeasonRewards;
        /* 0x53898 */ public List<NMSString0x10> RedeemedTwitchRewards;
        [NMS(Size = 0x64)]
        /* 0x538B0 */ public GcSettlementState[] SettlementStatesV2;
        /* 0x72CB0 */ public int SettlementStateRingBufferIndexV2;
    }
}
