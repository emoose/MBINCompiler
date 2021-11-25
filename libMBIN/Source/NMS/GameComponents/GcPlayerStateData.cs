using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x4D4E0, GUID = 0x2C0AEE83935AD0BC, NameHash = 0x6C4510BB243EFA64)]
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
        [NMS(Size = 0x3)]
        /* 0x00718 */ public GcMultitoolData[] Multitools;
        /* 0x00C58 */ public int ActiveMultioolIndex;
        /* 0x006C0 */ public GcByteBeatLibraryData ByteBeatLibrary;
        [NMS(Size = 0x6)]
        /* 0x02668 */ public GcPetData[] Pets;
        [NMS(Size = 0x6)]
        /* 0x03328 */ public GcPetData[] Eggs;
        [NMS(Size = 0x6)]
        /* 0x03FE8 */ public GcPetCustomisationData[] PetAccessoryCustomisation;
        [NMS(Size = 0x6)]
        /* 0x04618 */ public bool[] UnlockedPetSlots;
        /* 0x04620 */ public GcInventoryContainer GraveInventory;
        /* 0x04780 */ public bool SpawnGrave;
        /* 0x04781 */ public bool SpaceGrave;
        /* 0x04784 */ public GcUniverseAddressData GraveUniverseAddress;
        /* 0x047A0 */ public Vector4f GravePosition;
        /* 0x047B0 */ public Vector4f GraveMatrixLookAt;
        /* 0x047C0 */ public Vector4f GraveMatrixUp;
        /* 0x047D0 */ public GcInventoryLayout ShipLayout;
        /* 0x047F0 */ public GcInventoryLayout WeaponLayout;
        /* 0x04810 */ public GcResourceElement CurrentShip;
        /* 0x04AB8 */ public GcExactResource CurrentWeapon;
        /* 0x04B48 */ public List<NMSString0x10> KnownTech;
        /* 0x04B58 */ public List<NMSString0x10> KnownProducts;
        /* 0x04B68 */ public List<NMSString0x10> KnownSpecials;
        /* 0x04B78 */ public List<NMSString0x20A> KnownRefinerRecipes;
        /* 0x04B88 */ public List<GcWordKnowledge> KnownWords;
        /* 0x04B98 */ public List<GcWordGroupKnowledge> KnownWordGroups;
        /* 0x04BA8 */ public List<GcPlayerMissionProgress> MissionProgress;
        /* 0x04BB8 */ public int PostMissionIndex;
        /* 0x04BC0 */ public NMSString0x10 CurrentMissionID;
        /* 0x04BD0 */ public ulong CurrentMissionSeed;
        /* 0x04BD8 */ public NMSString0x10 PreviousMissionID;
        /* 0x04BE8 */ public ulong PreviousMissionSeed;
        /* 0x04BF0 */ public int MissionVersion;
        /* 0x04BF8 */ public List<GcMissionIDEpochPair> MissionRecurrences;
        /* 0x04C10 */ public GcInteractionData HoloExplorerInteraction;
        /* 0x04C30 */ public GcInteractionData HoloScepticInteraction;
        /* 0x04C50 */ public GcInteractionData HoloNooneInteraction;
        /* 0x04C70 */ public int Health;
        /* 0x04C74 */ public int ShipHealth;
        /* 0x04C78 */ public int Shield;
        /* 0x04C7C */ public int ShipShield;
        /* 0x04C80 */ public int Energy;
        /* 0x04C84 */ public int Units;
        /* 0x04C88 */ public int Nanites;
        /* 0x04C8C */ public int Specials;
        /* 0x04C90 */ public bool ThirdPersonShip;
        /* 0x04C98 */ public ulong TimeAlive;
        /* 0x04CA0 */ public ulong TotalPlayTime;
        /* 0x04CA8 */ public List<GcScanEventSave> MarkerStack;
        /* 0x04CB8 */ public List<GcScanEventSave> NewMPMarkerStack;
        /* 0x04CC8 */ public List<Vector3f> SurveyedEventPositions;
        /* 0x04CD8 */ public int NextSurveyedEventPositionIndex;
        /* 0x04CE0 */ public List<GcPlayerStatsGroup> Stats;
        /* 0x04CF0 */ public List<GcTelemetryStat> TelemetryStats;
        [NMS(Size = 0xB, EnumType = typeof(GcInteractionBufferType.InterationBufferTypeEnum))]
        /* 0x04D00 */ public GcInteractionBuffer[] StoredInteractions;
        /* 0x04E08 */ public List<GcMaintenanceContainer> MaintenanceInteractions;
        /* 0x04E18 */ public List<GcMaintenanceContainer> PersonalMaintenanceInteractions;
        /* 0x04E28 */ public List<ulong> VisitedSystems;        // probably technically the 8 byte hex used to denote systems...
        [NMS(Size = 0x6, EnumType = typeof(GcPlayerHazardType.HazardEnum))]
        /* 0x04E38 */ public float[] Hazard;
        /* 0x04E50 */ public int BoltAmmo;
        /* 0x04E54 */ public int ScatterAmmo;
        /* 0x04E58 */ public int PulseAmmo;
        /* 0x04E5C */ public int LaserAmmo;
        /* 0x04E60 */ public Vector4f FirstSpawnPosition;
        [NMS(Size = 0x7A, EnumType = typeof(GcInteractionType.InteractionTypeEnum))]
        /* 0x04E70 */ public GcSavedInteractionRaceData[] SavedInteractionIndicies;
        /* 0x05DB0 */ public List<GcSavedInteractionDialogData> SavedInteractionDialogTable;
        /* 0x05DC0 */ public List<NMSString0x20A> InteractionProgressTable;
        [NMS(Size = 0xA)]
        /* 0x05DD0 */ public GcUniverseAddressData[] AtlasStationAdressData;
        [NMS(Size = 0xB)]
        /* 0x05EC0 */ public GcUniverseAddressData[] NewAtlasStationAdressData;
        /* 0x05FC8 */ public List<GcUniverseAddressData> VisitedAtlasStationsData;
        /* 0x05FD8 */ public bool FirstAtlasStationDiscovered;
        /* 0x05FD9 */ public bool UsesThirdPersonCharacterCam;
        /* 0x05FDC */ public int ProgressionLevel;
        /* 0x05FE0 */ public int ProcTechIndex;
        /* 0x05FE4 */ public bool IsNew;
        /* 0x05FE5 */ public bool UseSmallerBlackholeJumps;
        /* 0x05FE8 */ public List<GcSavedEntitlement> UsedEntitlements;
        [NMS(Size = 0x10)]
        /* 0x06000 */ public Vector3f[] PlanetPositions;
        [NMS(Size = 0x10)]
        /* 0x06100 */ public GcSeed[] PlanetSeeds;
        /* 0x06200 */ public int PrimaryPlanet;
        /* 0x06208 */ public ulong TimeLastSpaceBattle;
        /* 0x06210 */ public int WarpsLastSpaceBattle;
        /* 0x06218 */ public ulong ActiveSpaceBattleUA;
        /* 0x06220 */ public ulong TimeLastMiniStation;
        /* 0x06228 */ public int WarpsLastMiniStation;
        /* 0x06230 */ public ulong MiniStationUA;
        /* 0x06240 */ public Vector4f AnomalyPositionOverride;
        /* 0x06250 */ public GcUniverseAddressData GameStartAddress1;
        /* 0x06268 */ public GcUniverseAddressData GameStartAddress2;
        [NMS(Size = 0x10)]
        /* 0x06280 */ public bool[] GalacticMapRequests;
        /* 0x06290 */ public Vector4f FirstShipPosition;
        /* 0x062A0 */ public ulong HazardTimeAlive;
        /* 0x062A8 */ public bool RevealBlackHoles;
        /* 0x062B0 */ public GcSeed CurrentFreighterHomeSystemSeed;
        /* 0x062C0 */ public GcResourceElement CurrentFreighter;
        /* 0x06568 */ public GcInventoryLayout FreighterLayout;
        /* 0x06588 */ public GcInventoryContainer FreighterInventory;
        /* 0x066E8 */ public GcInventoryContainer FreighterInventory_TechOnly;
        /* 0x06848 */ public GcUniverseAddressData FreighterUniverseAddress;
        /* 0x06860 */ public Vector3f FreighterMatrixAt;
        /* 0x06870 */ public Vector3f FreighterMatrixUp;
        /* 0x06880 */ public Vector3f FreighterMatrixPos;
        /* 0x06890 */ public List<NMSString0x10> SeenBaseBuildingObjects;
        /* 0x068A0 */ public List<GcPersistentBBObjectData> BaseBuildingObjects;
        /* 0x068B0 */ public GcTerrainEditsBuffer TerrainEditData;
        [NMS(Size = 0x5, EnumType = typeof(GcNPCHabitationType.NPCHabitationTypeEnum))]
        /* 0x25B70 */ public GcNPCWorkerData[] NPCWorkers;
        /* 0x269D0 */ public List<GcPersistentBase> PersistentPlayerBases;
        /* 0x269E0 */ public List<GcTeleportEndpoint> TeleportEndpoints;
        /* 0x269F0 */ public GcInventoryLayout Chest1Layout;
        /* 0x26A10 */ public GcInventoryContainer Chest1Inventory;
        /* 0x26B70 */ public GcInventoryLayout Chest2Layout;
        /* 0x26B90 */ public GcInventoryContainer Chest2Inventory;
        /* 0x26CF0 */ public GcInventoryLayout Chest3Layout;
        /* 0x26D10 */ public GcInventoryContainer Chest3Inventory;
        /* 0x26E70 */ public GcInventoryLayout Chest4Layout;
        /* 0x26E90 */ public GcInventoryContainer Chest4Inventory;
        /* 0x26FF0 */ public GcInventoryLayout Chest5Layout;
        /* 0x27010 */ public GcInventoryContainer Chest5Inventory;
        /* 0x27170 */ public GcInventoryLayout Chest6Layout;
        /* 0x27190 */ public GcInventoryContainer Chest6Inventory;
        /* 0x272F0 */ public GcInventoryLayout Chest7Layout;
        /* 0x27310 */ public GcInventoryContainer Chest7Inventory;
        /* 0x27470 */ public GcInventoryLayout Chest8Layout;
        /* 0x27490 */ public GcInventoryContainer Chest8Inventory;
        /* 0x275F0 */ public GcInventoryLayout Chest9Layout;
        /* 0x27610 */ public GcInventoryContainer Chest9Inventory;
        /* 0x27770 */ public GcInventoryLayout Chest10Layout;
        /* 0x27790 */ public GcInventoryContainer Chest10Inventory;
        /* 0x278F0 */ public GcInventoryLayout ChestMagicLayout;
        /* 0x27910 */ public GcInventoryContainer ChestMagicInventory;
        /* 0x27A70 */ public GcInventoryLayout ChestMagic2Layout;
        /* 0x27A90 */ public GcInventoryContainer ChestMagic2Inventory;
        /* 0x27BF0 */ public GcInventoryLayout CookingIngredientsLayout;
        /* 0x27C10 */ public GcInventoryContainer CookingIngredientsInventory;
        /* 0x27D70 */ public GcResourceElement CurrentFreighterNPC;
        [NMS(Size = 0x7, EnumType = typeof(GcVehicleType.VehicleTypeEnum))]
        /* 0x28020 */ public GcPlayerOwnershipData[] VehicleOwnership;
        /* 0x2A8D0 */ public int PrimaryVehicle;
        [NMS(Size = 0x6)]
        /* 0x2A8E0 */ public GcPlayerOwnershipData[] ShipOwnership;
        /* 0x2CBC0 */ public int PrimaryShip;
        /* 0x2CBC4 */ public bool MultiShipEnabled;
        /* 0x2CBC5 */ public NMSString0x20 PlayerFreighterName;
        /* 0x2CBF0 */ public Vector4f StartGameShipPosition;
        /* 0x2CC00 */ public bool ShipNeedsTerrainPositioning;
        /* 0x2CC04 */ public int TradingSupplyDataIndex;
        /* 0x2CC08 */ public List<GcTradingSupplyData> TradingSupplyData;
        /* 0x2CC18 */ public List<GcPortalSaveData> LastPortal;
        /* 0x2CC28 */ public GcPortalSaveData VisitedPortal;
        /* 0x2CC48 */ public int KnownPortalRunes;
        /* 0x2CC4C */ public bool OnOtherSideOfPortal;
        /* 0x2CC50 */ public GcTeleportEndpoint OtherSideOfPortalReturnBase;
        /* 0x2CCE0 */ public Vector4f PortalMarkerPosition_Local;
        /* 0x2CCF0 */ public Vector4f PortalMarkerPosition_Offset;
        /* 0x2CD00 */ public GcPlayerWeapons StartingPrimaryWeapon;
        /* 0x2CD04 */ public GcPlayerWeapons StartingSecondaryWeapon;
        [NMS(Size = 0x11, EnumType = typeof(GcCustomisationComponentData.CustomisationDataTypeEnum))]
        /* 0x2CD08 */ public GcCharacterCustomisationSaveData[] CharacterCustomisationData;
        [NMS(Size = 0x6)]
        /* 0x2D2E0 */ public bool[] ShipUsesLegacyColours;
        [NMS(Size = 0x3)]
        /* 0x2D2E8 */ public GcCharacterCustomisationData[] Outfits;
        /* 0x2D3C0 */ public NMSString0x10 JetpackEffect;
        /* 0x2D3D0 */ public GcSeed FleetSeed;
        /* 0x2D3E0 */ public List<GcFleetFrigateSaveData> FleetFrigates;
        /* 0x2D3F0 */ public List<GcFleetExpeditionSaveData> FleetExpeditions;
        /* 0x2D400 */ public List<ulong> ExpeditionSeedsSelectedToday;
        /* 0x2D410 */ public ulong LastKnownDay;
        /* 0x2D418 */ public ulong SunTimer;
        /* 0x2D420 */ public ulong MultiplayerLobbyID;
        /* 0x2D428 */ public GcUniverseAddressData MultiplayerUA;
        /* 0x2D440 */ public GcPlayerSpawnStateData MultiplayerSpawn;
        /* 0x2D4F0 */ public List<GcRepairTechData> RepairTechBuffer;
        /* 0x2D500 */ public ulong MultiplayerPrivileges;
        [NMS(Size = 0x3, EnumType = typeof(GcHotActionMenuTypes.HotActionMenuTypesEnum))]
        /* 0x2D508 */ public GcHotActionsSaveData[] HotActions;
        /* 0x2D9B8 */ public ulong LastUABeforePortalWarp;
        /* 0x2D9C0 */ public ulong StoryPortalSeed;
        /* 0x2D9C8 */ public ushort ShopNumber;
        /* 0x2D9CA */ public ushort ShopTier;
        /* 0x2D9CC */ public bool HasAccessToNexus;
        /* 0x2D9D0 */ public GcUniverseAddressData NexusUniverseAddress;
        /* 0x2D9F0 */ public Vector3f NexusMatrixAt;
        /* 0x2DA00 */ public Vector3f NexusMatrixUp;
        /* 0x2DA10 */ public Vector3f NexusMatrixPos;
        /* 0x2DA20 */ public GcPhotoModeSettings PhotoModeSettings;
        /* 0x2DA70 */ public int BannerIcon;
        /* 0x2DA74 */ public int BannerMainColour;
        /* 0x2DA78 */ public int BannerBackgroundColour;
        /* 0x2DA80 */ public NMSString0x10 BannerTitleId;
        /* 0x2DA90 */ public int TelemetryUploadVersion;
        /* 0x2DA94 */ public bool UsesThirdPersonVehicleCam;
        /* 0x2DA98 */ public float VRCameraOffset;
        /* 0x2DAA0 */ public GcSeasonalGameModeData SeasonData;
        /* 0x2E698 */ public GcSeasonStateData SeasonState;
        /* 0x2E6E8 */ public bool RestartAllInactiveSeasonalMissions;
        /* 0x2E6F0 */ public List<NMSString0x10> RedeemedSeasonRewards;
        /* 0x2E700 */ public List<NMSString0x10> RedeemedTwitchRewards;
        [NMS(Size = 0x64)]
        /* 0x2E710 */ public GcSettlementState[] SettlementStatesV2;
        /* 0x4D4D0 */ public int SettlementStateRingBufferIndexV2;
    }
}
