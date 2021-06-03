using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x2D730, GUID = 0xEAF41C1A72F588FC, NameHash = 0x6C4510BB243EFA64)]
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
        /* 0x006C0 */ public GcByteBeatLibraryData ByteBeatLibrary;
        [NMS(Size = 0x6)]
        /* 0x02068 */ public GcPetData[] Pets;
        [NMS(Size = 0x6)]
        /* 0x02C38 */ public GcPetData[] Eggs;
        [NMS(Size = 0x6)]
        /* 0x03808 */ public GcPetCustomisationData[] PetAccessoryCustomisation;
        [NMS(Size = 0x6)]
        /* 0x03E38 */ public bool[] UnlockedPetSlots;
        [NMS(Size = 0x2, Ignore = true)]
        /* 0x03E3E */ public byte[] Padding3E3E;
        /* 0x03E40 */ public GcInventoryContainer GraveInventory;
        /* 0x03FA0 */ public bool SpawnGrave;
        /* 0x03FA1 */ public bool SpaceGrave;
        [NMS(Size = 2, Ignore = true)]
        /* 0x03FA2 */ public byte[] Padding3FA2;
        /* 0x03FA4 */ public GcUniverseAddressData GraveUniverseAddress;
        /* 0x03FC0 */ public Vector4f GravePosition;
        /* 0x03FD0 */ public Vector4f GraveMatrixLookAt;
        /* 0x03FE0 */ public Vector4f GraveMatrixUp;
        /* 0x03FF0 */ public GcInventoryLayout ShipLayout;
        /* 0x04010 */ public GcInventoryLayout WeaponLayout;
        /* 0x04030 */ public GcResourceElement CurrentShip;
        /* 0x042D8 */ public GcExactResource CurrentWeapon;
        /* 0x04368 */ public List<NMSString0x10> KnownTech;
        /* 0x04378 */ public List<NMSString0x10> KnownProducts;
        /* 0x04388 */ public List<NMSString0x10> KnownSpecials;
        /* 0x04398 */ public List<NMSString0x20A> KnownRefinerRecipes;
        /* 0x043A8 */ public List<GcWordKnowledge> KnownWords;
        /* 0x043B8 */ public List<GcWordGroupKnowledge> KnownWordGroups;
        /* 0x043C8 */ public List<GcPlayerMissionProgress> MissionProgress;
        /* 0x043D8 */ public int PostMissionIndex;
        /* 0x043E0 */ public NMSString0x10 CurrentMissionID;
        /* 0x043F0 */ public ulong CurrentMissionSeed;
        /* 0x043F8 */ public NMSString0x10 PreviousMissionID;
        /* 0x04408 */ public ulong PreviousMissionSeed;
        /* 0x04410 */ public int MissionVersion;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x04414 */ public byte[] Padding4414;
        /* 0x04418 */ public List<GcMissionIDEpochPair> MissionRecurrences;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x04428 */ public byte[] Padding4428;
        /* 0x04430 */ public GcInteractionData HoloExplorerInteraction;
        /* 0x04450 */ public GcInteractionData HoloScepticInteraction;
        /* 0x04470 */ public GcInteractionData HoloNooneInteraction;
        /* 0x04490 */ public int Health;
		/* 0x04494 */ public int ShipHealth;
        /* 0x04498 */ public int Shield;
		/* 0x0449C */ public int ShipShield;
		/* 0x044A0 */ public int Energy;
        /* 0x044A4 */ public int Units;
        /* 0x044A8 */ public int Nanites;
        /* 0x044AC */ public int Specials;
        /* 0x044B0 */ public bool ThirdPersonShip;
        /* 0x044B8 */ public ulong TimeAlive;
        /* 0x044C0 */ public ulong TotalPlayTime;
        /* 0x044C8 */ public List<GcScanEventSave> MarkerStack;
        /* 0x044D8 */ public List<GcScanEventSave> NewMPMarkerStack;
        /* 0x044E8 */ public List<Vector4f> SurveyedEventPositions;
        /* 0x044F8 */ public int NextSurveyedEventPositionIndex;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x044FC */ public byte[] Padding44FC;
        /* 0x04500 */ public List<GcPlayerStatsGroup> Stats;
        /* 0x04510 */ public List<GcTelemetryStat> TelemetryStats;
        [NMS(Size = 0xB, EnumType = typeof(GcInteractionBufferType.InterationBufferTypeEnum))]
        /* 0x04520 */ public GcInteractionBuffer[] StoredInteractions;
        /* 0x04628 */ public List<GcMaintenanceContainer> MaintenanceInteractions;
        /* 0x04638 */ public List<GcMaintenanceContainer> PersonalMaintenanceInteractions;
        /* 0x04648 */ public List<ulong> VisitedSystems;        // probably technically the 8 byte hex used to denote systems...
        [NMS(Size = 6, EnumType = typeof(GcPlayerHazardType.HazardEnum))]
        /* 0x04658 */ public float[] Hazard;
        /* 0x04670 */ public int BoltAmmo;
        /* 0x04674 */ public int ScatterAmmo;
        /* 0x04678 */ public int PulseAmmo;
        /* 0x0467C */ public int LaserAmmo;
        /* 0x04680 */ public Vector4f FirstSpawnPosition;
        [NMS(Size = 0x75, EnumType = typeof(GcInteractionType.InteractionTypeEnum))]
        /* 0x04690 */ public GcSavedInteractionRaceData[] SavedInteractionIndicies;
        /* 0x05530 */ public List<GcSavedInteractionDialogData> SavedInteractionDialogTable;
        /* 0x05540 */ public List<NMSString0x20A> InteractionProgressTable;
        [NMS(Size = 0xA)]
        /* 0x05550 */ public GcUniverseAddressData[] AtlasStationAdressData;
        [NMS(Size = 0xB)]
        /* 0x05640 */ public GcUniverseAddressData[] NewAtlasStationAdressData;
        /* 0x05748 */ public List<GcUniverseAddressData> VisitedAtlasStationsData;
        /* 0x05758 */ public bool FirstAtlasStationDiscovered;
        /* 0x05759 */ public bool UsesThirdPersonCharacterCam;
        /* 0x0575C */ public int ProgressionLevel;
        /* 0x05760 */ public int ProcTechIndex;
        /* 0x05764 */ public bool IsNew;
        /* 0x05765 */ public bool UseSmallerBlackholeJumps;
        [NMS(Size = 0x2, Ignore = true)]
        /* 0x05766 */ public byte[] Padding5766;
        /* 0x05768 */ public List<GcSavedEntitlement> UsedEntitlements;
        [NMS(Size = 0x10)]
        /* 0x05780 */ public Vector4f[] PlanetPositions;
        [NMS(Size = 0x10)]
        /* 0x05880 */ public GcSeed[] PlanetSeeds;
        /* 0x05980 */ public int PrimaryPlanet;
        /* 0x05988 */ public ulong TimeLastSpaceBattle;
        /* 0x05990 */ public int WarpsLastSpaceBattle;
        /* 0x05998 */ public ulong ActiveSpaceBattleUA;
        /* 0x059A0 */ public ulong TimeLastMiniStation;
        /* 0x059A8 */ public int WarpsLastMiniStation;
        /* 0x059B0 */ public ulong MiniStationUA;
        /* 0x059C0 */ public Vector4f AnomalyPositionOverride;
        /* 0x059D0 */ public GcUniverseAddressData GameStartAddress1;
        /* 0x059E8 */ public GcUniverseAddressData GameStartAddress2;
        [NMS(Size = 0x10)]
        /* 0x05A00 */ public bool[] GalacticMapRequests;
        /* 0x05A10 */ public Vector4f FirstShipPosition;
        /* 0x05A20 */ public ulong HazardTimeAlive;
        /* 0x05A28 */ public bool RevealBlackHoles;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x05A29 */ public byte[] Padding5A29;
        /* 0x05A30 */ public GcSeed CurrentFreighterHomeSystemSeed;
        /* 0x05A40 */ public GcResourceElement CurrentFreighter;
        /* 0x05CE8 */ public GcInventoryLayout FreighterLayout;
        /* 0x05D08 */ public GcInventoryContainer FreighterInventory;
        /* 0x05E68 */ public GcInventoryContainer FreighterInventory_TechOnly;
        /* 0x05FC8 */ public GcUniverseAddressData FreighterUniverseAddress;
        /* 0x05FE0 */ public Vector3f FreighterMatrixAt;
        /* 0x05FF0 */ public Vector3f FreighterMatrixUp;
        /* 0x06000 */ public Vector3f FreighterMatrixPos;
        /* 0x06010 */ public List<GcPersistentBBObjectData> BaseBuildingObjects;
        /* 0x06020 */ public GcTerrainEditsBuffer TerrainEditData;
        [NMS(Size = 0x5, EnumType = typeof(GcNPCHabitationType.NPCHabitationTypeEnum))]
        /* 0x252E0 */ public GcNPCWorkerData[] NPCWorkers;
        /* 0x26140 */ public List<GcPersistentBase> PersistentPlayerBases;
        /* 0x26150 */ public List<GcTeleportEndpoint> TeleportEndpoints;
        /* 0x26160 */ public GcInventoryLayout Chest1Layout;
        /* 0x26180 */ public GcInventoryContainer Chest1Inventory;
        /* 0x262E0 */ public GcInventoryLayout Chest2Layout;
        /* 0x26300 */ public GcInventoryContainer Chest2Inventory;
        /* 0x26460 */ public GcInventoryLayout Chest3Layout;
        /* 0x26480 */ public GcInventoryContainer Chest3Inventory;
        /* 0x265E0 */ public GcInventoryLayout Chest4Layout;
        /* 0x26600 */ public GcInventoryContainer Chest4Inventory;
        /* 0x26760 */ public GcInventoryLayout Chest5Layout;
        /* 0x26780 */ public GcInventoryContainer Chest5Inventory;
        /* 0x268E0 */ public GcInventoryLayout Chest6Layout;
        /* 0x26900 */ public GcInventoryContainer Chest6Inventory;
        /* 0x26A60 */ public GcInventoryLayout Chest7Layout;
        /* 0x26A80 */ public GcInventoryContainer Chest7Inventory;
        /* 0x26BE0 */ public GcInventoryLayout Chest8Layout;
        /* 0x26C00 */ public GcInventoryContainer Chest8Inventory;
        /* 0x26D60 */ public GcInventoryLayout Chest9Layout;
        /* 0x26D80 */ public GcInventoryContainer Chest9Inventory;
        /* 0x26EE0 */ public GcInventoryLayout Chest10Layout;
        /* 0x26F00 */ public GcInventoryContainer Chest10Inventory;
        /* 0x27060 */ public GcInventoryLayout ChestMagicLayout;
        /* 0x27080 */ public GcInventoryContainer ChestMagicInventory;
        /* 0x271E0 */ public GcInventoryLayout ChestMagic2Layout;
        /* 0x27200 */ public GcInventoryContainer ChestMagic2Inventory;
        /* 0x27360 */ public GcInventoryLayout CookingIngredientsLayout;
        /* 0x27380 */ public GcInventoryContainer CookingIngredientsInventory;
        /* 0x274E0 */ public GcResourceElement CurrentFreighterNPC;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x27788 */ public byte[] Padding27788;
        [NMS(Size = 0x7, EnumType = typeof(GcVehicleType.VehicleTypeEnum))]
        /* 0x27790 */ public GcPlayerOwnershipData[] VehicleOwnership;
        /* 0x2A040 */ public int PrimaryVehicle;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x2A044 */ public byte[] Padding2A044;
        [NMS(Size = 0x6)]
        /* 0x2A050 */ public GcPlayerOwnershipData[] ShipOwnership;
        /* 0x2C330 */ public int PrimaryShip;
        /* 0x2C334 */ public bool MultiShipEnabled;
        /* 0x2C335 */ public NMSString0x20 PlayerFreighterName;
        /* 0x2C360 */ public Vector4f StartGameShipPosition;
        /* 0x2C370 */ public bool ShipNeedsTerrainPositioning;
        /* 0x2C374 */ public int TradingSupplyDataIndex;
        /* 0x2C378 */ public List<GcTradingSupplyData> TradingSupplyData;
        /* 0x2C388 */ public List<GcPortalData> LastPortal;
        /* 0x2C398 */ public GcPortalSaveData VisitedPortal;
        /* 0x2C3B0 */ public int KnownPortalRunes;
        /* 0x2C3B4 */ public bool OnOtherSideOfPortal;
        [NMS(Size = 0xB, Ignore = true)]
        /* 0x2C3B5 */ public byte[] Padding2C3B5;
        /* 0x2C3C0 */ public GcTeleportEndpoint OtherSideOfPortalReturnBase;
        /* 0x2C450 */ public Vector4f PortalMarkerPosition_Local;
        /* 0x2C460 */ public Vector4f PortalMarkerPosition_Offset;
        /* 0x2C470 */ public GcPlayerWeapons StartingPrimaryWeapon;
        /* 0x2C474 */ public GcPlayerWeapons StartingSecondaryWeapon;
        [NMS(Size = 0x11, EnumType = typeof(GcCustomisationComponentData.CustomisationDataTypeEnum))]
        /* 0x2C478 */ public GcCharacterCustomisationSaveData[] CharacterCustomisationData;
        [NMS(Size = 0x6)]
        /* 0x2CA50 */ public bool[] ShipUsesLegacyColours;
        [NMS(Size = 0x2, Ignore = true)]
        /* 0x2CA56 */ public byte[] Padding2CA56;
        [NMS(Size = 0x3)]
        /* 0x2CA58 */ public GcCharacterCustomisationData[] Outfits;
        /* 0x2CB30 */ public NMSString0x10 JetpackEffect;
        /* 0x2CB40 */ public GcSeed FleetSeed;
        /* 0x2CB50 */ public List<GcFleetFrigateSaveData> FleetFrigates;
        /* 0x2CB60 */ public List<GcFleetExpeditionSaveData> FleetExpeditions;
        /* 0x2CB70 */ public List<long> ExpeditionSeedsSelectedToday;
        /* 0x2CB80 */ public ulong LastKnownDay;
        /* 0x2CB88 */ public ulong SunTimer;
        /* 0x2CB90 */ public ulong MultiplayerLobbyID;
        /* 0x2CB98 */ public GcUniverseAddressData MultiplayerUA;
        /* 0x2CBB0 */ public GcPlayerSpawnStateData MultiplayerSpawn;
        /* 0x2CC60 */ public List<GcRepairTechData> RepairTechBuffer;
        /* 0x2CC70 */ public ulong MultiplayerPrivileges;
        [NMS(Size = 0x3, EnumType = typeof(GcHotActionMenuTypes.HotActionMenuTypesEnum))]
        /* 0x2CC78 */ public GcHotActionsSaveData[] HotActions;
        /* 0x2D128 */ public ulong LastUABeforePortalWarp;
        /* 0x2D130 */ public ulong StoryPortalSeed;
        /* 0x2D138 */ public ushort ShopNumber;
        /* 0x2D13A */ public ushort ShopTier;
        /* 0x2D13C */ public bool HasAccessToNexus;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x2D13D */ public byte[] Padding2D13D;
        /* 0x2D140 */ public GcUniverseAddressData NexusUniverseAddress;
        /* 0x2D160 */ public Vector3f NexusMatrixAt;
        /* 0x2D170 */ public Vector3f NexusMatrixUp;
        /* 0x2D180 */ public Vector3f NexusMatrixPos;
        /* 0x2D190 */ public GcPhotoModeSettings PhotoModeSettings;
        /* 0x2D1F0 */ public int BannerIcon;
        /* 0x2D1F4 */ public int BannerMainColour;
        /* 0x2D1F8 */ public int BannerBackgroundColour;
        /* 0x2D200 */ public NMSString0x10 BannerTitleId;
        /* 0x2D210 */ public int TelemetryUploadVersion;
        /* 0x2D214 */ public bool UsesThirdPersonVehicleCam;
        /* 0x2D218 */ public float VRCameraOffset;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x2D21C */ public byte[] Padding2D21C;
        /* 0x2D220 */ public GcSeasonalGameModeData SeasonalData;
        /* 0x2D6B8 */ public GcSeasonStateData SeasonState;
        /* 0x2D708 */ public bool RestartAllInactiveSeasonalMissions;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x2D709 */ public byte[] Padding2D709;
        /* 0x2D710 */ public List<NMSString0x10> RedeemedSeasonRewards;
        /* 0x2D720 */ public List<NMSString0x10> RedeemedTwitchRewards;
    }
}
