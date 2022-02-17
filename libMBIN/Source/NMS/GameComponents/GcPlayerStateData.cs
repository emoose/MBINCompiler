using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x71CD0, GUID = 0x2B406E2D448B8D9D, NameHash = 0x6C4510BB243EFA64)]
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
        /* 0x01198 */ public int ActiveMultioolIndex;
        /* 0x011A0 */ public GcByteBeatLibraryData ByteBeatLibrary;
        [NMS(Size = 0x12)]
        /* 0x02BA8 */ public GcPetData[] Pets;
        [NMS(Size = 0x12)]
        /* 0x051E8 */ public GcPetData[] Eggs;
        [NMS(Size = 0x12)]
        /* 0x07828 */ public GcPetCustomisationData[] PetAccessoryCustomisation;
        [NMS(Size = 0x12)]
        /* 0x08AB8 */ public bool[] UnlockedPetSlots;
        /* 0x08AD0 */ public GcInventoryContainer GraveInventory;
        /* 0x08C30 */ public bool SpawnGrave;
        /* 0x08C31 */ public bool SpaceGrave;
        /* 0x08C34 */ public GcUniverseAddressData GraveUniverseAddress;
        /* 0x08C50 */ public Vector4f GravePosition;
        /* 0x08C60 */ public Vector4f GraveMatrixLookAt;
        /* 0x08C70 */ public Vector4f GraveMatrixUp;
        /* 0x08C80 */ public GcInventoryLayout ShipLayout;
        /* 0x08CA0 */ public GcInventoryLayout WeaponLayout;
        /* 0x08CC0 */ public GcResourceElement CurrentShip;
        /* 0x08F68 */ public GcExactResource CurrentWeapon;
        /* 0x08FF8 */ public List<NMSString0x10> KnownTech;
        /* 0x09008 */ public List<NMSString0x10> KnownProducts;
        /* 0x09018 */ public List<NMSString0x10> KnownSpecials;
        /* 0x09028 */ public List<NMSString0x20A> KnownRefinerRecipes;
        /* 0x09038 */ public List<GcWordKnowledge> KnownWords;
        /* 0x09048 */ public List<GcWordGroupKnowledge> KnownWordGroups;
        /* 0x09058 */ public List<GcPlayerMissionProgress> MissionProgress;
        /* 0x09068 */ public int PostMissionIndex;
        /* 0x09070 */ public NMSString0x10 CurrentMissionID;
        /* 0x09080 */ public ulong CurrentMissionSeed;
        /* 0x09088 */ public NMSString0x10 PreviousMissionID;
        /* 0x09098 */ public ulong PreviousMissionSeed;
        /* 0x090A0 */ public int MissionVersion;
        /* 0x090A8 */ public List<GcMissionIDEpochPair> MissionRecurrences;
        /* 0x090C0 */ public GcInteractionData HoloExplorerInteraction;
        /* 0x090E0 */ public GcInteractionData HoloScepticInteraction;
        /* 0x09100 */ public GcInteractionData HoloNooneInteraction;
        /* 0x09120 */ public int Health;
        /* 0x09124 */ public int ShipHealth;
        /* 0x09128 */ public int Shield;
        /* 0x0912C */ public int ShipShield;
        /* 0x09130 */ public int Energy;
        /* 0x09134 */ public int Units;
        /* 0x09138 */ public int Nanites;
        /* 0x0913C */ public int Specials;
        /* 0x09140 */ public bool ThirdPersonShip;
        /* 0x09148 */ public ulong TimeAlive;
        /* 0x09150 */ public ulong TotalPlayTime;
        /* 0x09158 */ public List<GcScanEventSave> MarkerStack;
        /* 0x09168 */ public List<GcScanEventSave> NewMPMarkerStack;
        /* 0x09178 */ public List<Vector3f> SurveyedEventPositions;
        /* 0x09188 */ public int NextSurveyedEventPositionIndex;
        /* 0x09190 */ public List<GcPlayerStatsGroup> Stats;
        /* 0x091A0 */ public List<GcTelemetryStat> TelemetryStats;
        [NMS(Size = 0xB, EnumType = typeof(GcInteractionBufferType.InterationBufferTypeEnum))]
        /* 0x091B0 */ public GcInteractionBuffer[] StoredInteractions;
        /* 0x092B8 */ public List<GcMaintenanceContainer> MaintenanceInteractions;
        /* 0x092C8 */ public List<GcMaintenanceContainer> PersonalMaintenanceInteractions;
        /* 0x092D8 */ public List<ulong> VisitedSystems;        // probably technically the 8 byte hex used to denote systems...
        [NMS(Size = 0x6, EnumType = typeof(GcPlayerHazardType.HazardEnum))]
        /* 0x092E8 */ public float[] Hazard;
        /* 0x09300 */ public int BoltAmmo;
        /* 0x09304 */ public int ScatterAmmo;
        /* 0x09308 */ public int PulseAmmo;
        /* 0x0930C */ public int LaserAmmo;
        /* 0x09310 */ public Vector4f FirstSpawnPosition;
        [NMS(Size = 0x7D, EnumType = typeof(GcInteractionType.InteractionTypeEnum))]
        /* 0x09320 */ public GcSavedInteractionRaceData[] SavedInteractionIndicies;
        /* 0x0A2C0 */ public List<GcSavedInteractionDialogData> SavedInteractionDialogTable;
        /* 0x0A2D0 */ public List<NMSString0x20A> InteractionProgressTable;
        [NMS(Size = 0xA)]
        /* 0x0A2E0 */ public GcUniverseAddressData[] AtlasStationAdressData;
        [NMS(Size = 0xB)]
        /* 0x0A3D0 */ public GcUniverseAddressData[] NewAtlasStationAdressData;
        /* 0x0A4D8 */ public List<GcUniverseAddressData> VisitedAtlasStationsData;
        /* 0x0A4E8 */ public bool FirstAtlasStationDiscovered;
        /* 0x0A4E9 */ public bool UsesThirdPersonCharacterCam;
        /* 0x0A4EC */ public int ProgressionLevel;
        /* 0x0A4F0 */ public int ProcTechIndex;
        /* 0x0A4F4 */ public bool IsNew;
        /* 0x0A4F5 */ public bool UseSmallerBlackholeJumps;
        /* 0x0A4F8 */ public List<GcSavedEntitlement> UsedEntitlements;
        [NMS(Size = 0x10)]
        /* 0x0A510 */ public Vector3f[] PlanetPositions;
        [NMS(Size = 0x10)]
        /* 0x0A610 */ public GcSeed[] PlanetSeeds;
        /* 0x0A710 */ public int PrimaryPlanet;
        /* 0x0A718 */ public ulong TimeLastSpaceBattle;
        /* 0x0A720 */ public int WarpsLastSpaceBattle;
        /* 0x0A728 */ public ulong ActiveSpaceBattleUA;
        /* 0x0A730 */ public ulong TimeLastMiniStation;
        /* 0x0A738 */ public int WarpsLastMiniStation;
        /* 0x0A740 */ public ulong MiniStationUA;
        /* 0x0A750 */ public Vector4f AnomalyPositionOverride;
        /* 0x0A760 */ public GcUniverseAddressData GameStartAddress1;
        /* 0x0A778 */ public GcUniverseAddressData GameStartAddress2;
        [NMS(Size = 0x10)]
        /* 0x0A790 */ public bool[] GalacticMapRequests;
        /* 0x0A7A0 */ public Vector4f FirstShipPosition;
        /* 0x0A7B0 */ public ulong HazardTimeAlive;
        /* 0x0A7B8 */ public bool RevealBlackHoles;
        /* 0x0A7C0 */ public GcSeed CurrentFreighterHomeSystemSeed;
        /* 0x0A7D0 */ public GcResourceElement CurrentFreighter;
        /* 0x0AA78 */ public GcInventoryLayout FreighterLayout;
        /* 0x0AA98 */ public GcInventoryContainer FreighterInventory;
        /* 0x0ABF8 */ public GcInventoryContainer FreighterInventory_TechOnly;
        /* 0x0AD58 */ public GcUniverseAddressData FreighterUniverseAddress;
        /* 0x0AD70 */ public Vector3f FreighterMatrixAt;
        /* 0x0AD80 */ public Vector3f FreighterMatrixUp;
        /* 0x0AD90 */ public Vector3f FreighterMatrixPos;
        /* 0x0ADA0 */ public List<NMSString0x10> SeenBaseBuildingObjects;
        /* 0x0ADB0 */ public List<GcPersistentBBObjectData> BaseBuildingObjects;
        /* 0x0ADC0 */ public GcTerrainEditsBuffer TerrainEditData;
        [NMS(Size = 0x5, EnumType = typeof(GcNPCHabitationType.NPCHabitationTypeEnum))]
        /* 0x47540 */ public GcNPCWorkerData[] NPCWorkers;
        /* 0x483A0 */ public List<GcPersistentBase> PersistentPlayerBases;
        /* 0x483B0 */ public List<GcTeleportEndpoint> TeleportEndpoints;
        /* 0x483C0 */ public GcInventoryLayout Chest1Layout;
        /* 0x483E0 */ public GcInventoryContainer Chest1Inventory;
        /* 0x48540 */ public GcInventoryLayout Chest2Layout;
        /* 0x48560 */ public GcInventoryContainer Chest2Inventory;
        /* 0x486C0 */ public GcInventoryLayout Chest3Layout;
        /* 0x486E0 */ public GcInventoryContainer Chest3Inventory;
        /* 0x48840 */ public GcInventoryLayout Chest4Layout;
        /* 0x48860 */ public GcInventoryContainer Chest4Inventory;
        /* 0x489C0 */ public GcInventoryLayout Chest5Layout;
        /* 0x489E0 */ public GcInventoryContainer Chest5Inventory;
        /* 0x48B40 */ public GcInventoryLayout Chest6Layout;
        /* 0x48B60 */ public GcInventoryContainer Chest6Inventory;
        /* 0x48CC0 */ public GcInventoryLayout Chest7Layout;
        /* 0x48CE0 */ public GcInventoryContainer Chest7Inventory;
        /* 0x48E40 */ public GcInventoryLayout Chest8Layout;
        /* 0x48E60 */ public GcInventoryContainer Chest8Inventory;
        /* 0x48FC0 */ public GcInventoryLayout Chest9Layout;
        /* 0x48FE0 */ public GcInventoryContainer Chest9Inventory;
        /* 0x49140 */ public GcInventoryLayout Chest10Layout;
        /* 0x49160 */ public GcInventoryContainer Chest10Inventory;
        /* 0x492C0 */ public GcInventoryLayout ChestMagicLayout;
        /* 0x492E0 */ public GcInventoryContainer ChestMagicInventory;
        /* 0x49440 */ public GcInventoryLayout ChestMagic2Layout;
        /* 0x49460 */ public GcInventoryContainer ChestMagic2Inventory;
        /* 0x495C0 */ public GcInventoryLayout CookingIngredientsLayout;
        /* 0x495E0 */ public GcInventoryContainer CookingIngredientsInventory;
        /* 0x49740 */ public GcInventoryLayout RocketLockerLayout;
        /* 0x49760 */ public GcInventoryContainer RocketLockerInventory;
        /* 0x498C0 */ public GcResourceElement CurrentFreighterNPC;
        [NMS(Size = 0x7, EnumType = typeof(GcVehicleType.VehicleTypeEnum))]
        /* 0x49B70 */ public GcPlayerOwnershipData[] VehicleOwnership;
        /* 0x4C420 */ public int PrimaryVehicle;
        [NMS(Size = 0x6)]
        /* 0x4C430 */ public GcPlayerOwnershipData[] ShipOwnership;
        /* 0x4E710 */ public int PrimaryShip;
        /* 0x4E714 */ public bool MultiShipEnabled;
        /* 0x4E715 */ public NMSString0x20 PlayerFreighterName;
        /* 0x4E740 */ public Vector4f StartGameShipPosition;
        /* 0x4E750 */ public bool ShipNeedsTerrainPositioning;
        /* 0x4E754 */ public int TradingSupplyDataIndex;
        /* 0x4E758 */ public List<GcTradingSupplyData> TradingSupplyData;
        /* 0x4E768 */ public List<GcPortalSaveData> LastPortal;
        /* 0x4E778 */ public GcPortalSaveData VisitedPortal;
        /* 0x4E798 */ public int KnownPortalRunes;
        /* 0x4E79C */ public bool OnOtherSideOfPortal;
        /* 0x4E7A0 */ public GcTeleportEndpoint OtherSideOfPortalReturnBase;
        /* 0x4E830 */ public Vector4f PortalMarkerPosition_Local;
        /* 0x4E840 */ public Vector4f PortalMarkerPosition_Offset;
        /* 0x4E850 */ public GcPlayerWeapons StartingPrimaryWeapon;
        /* 0x4E854 */ public GcPlayerWeapons StartingSecondaryWeapon;
        [NMS(Size = 0x11, EnumType = typeof(GcCustomisationComponentData.CustomisationDataTypeEnum))]
        /* 0x4E858 */ public GcCharacterCustomisationSaveData[] CharacterCustomisationData;
        [NMS(Size = 0x6)]
        /* 0x4EE30 */ public bool[] ShipUsesLegacyColours;
        [NMS(Size = 0x3)]
        /* 0x4EE38 */ public GcCharacterCustomisationData[] Outfits;
        /* 0x4EF10 */ public NMSString0x10 JetpackEffect;
        /* 0x4EF20 */ public GcSeed FleetSeed;
        /* 0x4EF30 */ public List<GcFleetFrigateSaveData> FleetFrigates;
        /* 0x4EF40 */ public List<GcFleetExpeditionSaveData> FleetExpeditions;
        /* 0x4EF50 */ public List<ulong> ExpeditionSeedsSelectedToday;
        /* 0x4EF60 */ public ulong LastKnownDay;
        /* 0x4EF68 */ public ulong SunTimer;
        /* 0x4EF70 */ public ulong MultiplayerLobbyID;
        /* 0x4EF78 */ public GcUniverseAddressData MultiplayerUA;
        /* 0x4EF90 */ public GcPlayerSpawnStateData MultiplayerSpawn;
        /* 0x4F040 */ public List<GcRepairTechData> RepairTechBuffer;
        /* 0x4F050 */ public ulong MultiplayerPrivileges;
        [NMS(Size = 0x3, EnumType = typeof(GcHotActionMenuTypes.HotActionMenuTypesEnum))]
        /* 0x4F058 */ public GcHotActionsSaveData[] HotActions;
        /* 0x4F508 */ public ulong LastUABeforePortalWarp;
        /* 0x4F510 */ public ulong StoryPortalSeed;
        /* 0x4F518 */ public ushort ShopNumber;
        /* 0x4F51A */ public ushort ShopTier;
        /* 0x4F51C */ public bool HasAccessToNexus;
        /* 0x4F520 */ public GcUniverseAddressData NexusUniverseAddress;
        /* 0x4F540 */ public Vector3f NexusMatrixAt;
        /* 0x4F550 */ public Vector3f NexusMatrixUp;
        /* 0x4F560 */ public Vector3f NexusMatrixPos;
        /* 0x4F570 */ public GcPhotoModeSettings PhotoModeSettings;
        /* 0x4F5C0 */ public int BannerIcon;
        /* 0x4F5C4 */ public int BannerMainColour;
        /* 0x4F5C8 */ public int BannerBackgroundColour;
        /* 0x4F5D0 */ public NMSString0x10 BannerTitleId;
        /* 0x4F5E0 */ public int TelemetryUploadVersion;
        /* 0x4F5E4 */ public bool UsesThirdPersonVehicleCam;
        /* 0x4F5E8 */ public float VRCameraOffset;
        /* 0x4F5F0 */ public GcSeasonalGameModeData SeasonData;
        /* 0x52840 */ public GcSeasonStateData SeasonState;
        /* 0x52890 */ public bool RestartAllInactiveSeasonalMissions;
        /* 0x52898 */ public List<NMSString0x10> RedeemedSeasonRewards;
        /* 0x528A8 */ public List<NMSString0x10> RedeemedTwitchRewards;
        [NMS(Size = 0x64)]
        /* 0x528C0 */ public GcSettlementState[] SettlementStatesV2;
        /* 0x71CC0 */ public int SettlementStateRingBufferIndexV2;
    }
}
