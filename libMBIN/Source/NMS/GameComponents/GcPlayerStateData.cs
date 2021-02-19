using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x2B240, GUID = 0x25D1E4862AEFAF62, NameHash = 0x6C4510BB243EFA64)]
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
        [NMS(Size = 0x6)]
        /* 0x00C60 */ public GcPetData[] Pets;
        [NMS(Size = 0x6)]
        /* 0x01200 */ public GcPetData[] Eggs;
        [NMS(Size = 0x6)]
        /* 0x017A0 */ public GcPetCustomisationData[] PetAccessoryCustomisation;
        [NMS(Size = 0x6)]
        /* 0x01DD0 */ public bool[] UnlockedPetSlots;
        [NMS(Size = 0x2, Ignore = true)]
        /* 0x01DD6 */ public byte[] Padding1DD6;
        /* 0x01DD8 */ public GcInventoryContainer GraveInventory;
        /* 0x01F38 */ public bool SpawnGrave;
        /* 0x01F39 */ public bool SpaceGrave;
        [NMS(Size = 2, Ignore = true)]
        /* 0x01F3A */ public byte[] Padding1F3A;
        /* 0x01F3C */ public GcUniverseAddressData GraveUniverseAddress;
        /* 0x01F60 */ public Vector4f GravePosition;
        /* 0x01F70 */ public Vector4f GraveMatrixLookAt;
        /* 0x01F80 */ public Vector4f GraveMatrixUp;
        /* 0x01F90 */ public GcInventoryLayout ShipLayout;
        /* 0x01FB0 */ public GcInventoryLayout WeaponLayout;
        /* 0x01FD0 */ public GcResourceElement CurrentShip;
        /* 0x02278 */ public GcExactResource CurrentWeapon;
        /* 0x02308 */ public List<NMSString0x10> KnownTech;
        /* 0x02318 */ public List<NMSString0x10> KnownProducts;
        /* 0x02328 */ public List<NMSString0x10> KnownSpecials;
        /* 0x02338 */ public List<NMSString0x20> KnownRefinerRecipes;
        /* 0x02348 */ public List<GcWordKnowledge> KnownWords;
        /* 0x02358 */ public List<GcWordGroupKnowledge> KnownWordGroups;
        /* 0x02368 */ public List<GcPlayerMissionProgress> MissionProgress;
        /* 0x02378 */ public int PostMissionIndex;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x0237C */ public byte[] Padding237C;
        [NMS(Size = 0x10)]
        /* 0x02380 */ public string CurrentMissionID;
        /* 0x02390 */ public ulong CurrentMissionSeed;
        [NMS(Size = 0x10)]
        /* 0x02398 */ public string PreviousMissionID;
        /* 0x023A8 */ public ulong PreviousMissionSeed;
        /* 0x023B0 */ public int MissionVersion;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x023B4 */ public byte[] Padding23B4;
        /* 0x023B8 */ public List<GcMissionIDEpochPair> MissionRecurrences;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x023C8 */ public byte[] Padding23C8;
        /* 0x023D0 */ public GcInteractionData HoloExplorerInteraction;
        /* 0x023F0 */ public GcInteractionData HoloScepticInteraction;
        /* 0x02410 */ public GcInteractionData HoloNooneInteraction;
        /* 0x02430 */ public int Health;
		/* 0x02434 */ public int ShipHealth;
        /* 0x02438 */ public int Shield;
		/* 0x0243C */ public int ShipShield;
		/* 0x02440 */ public int Energy;
        /* 0x02444 */ public int Units;
        /* 0x02448 */ public int Nanites;
        /* 0x0244C */ public int Specials;
        /* 0x02450 */ public bool ThirdPersonShip;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x02451 */ public byte[] Padding2451;
        /* 0x02458 */ public ulong TimeAlive;
        /* 0x02460 */ public ulong TotalPlayTime;
        /* 0x02468 */ public List<GcScanEventSave> MarkerStack;
        /* 0x02478 */ public List<GcScanEventSave> NewMPMarkerStack;
        /* 0x02488 */ public List<Vector4f> SurveyedEventPositions;
        /* 0x02498 */ public int NextSurveyedEventPositionIndex;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x0249C */ public byte[] Padding249C;
        /* 0x024A0 */ public List<GcPlayerStatsGroup> Stats;
        /* 0x024B0 */ public List<GcTelemetryStat> TelemetryStats;
        [NMS(Size = 0xB, EnumType = typeof(GcInteractionBufferType.InterationBufferTypeEnum))]
        /* 0x024C0 */ public GcInteractionBuffer[] StoredInteractions;
        /* 0x025C8 */ public List<GcMaintenanceContainer> MaintenanceInteractions;
        /* 0x025D8 */ public List<GcMaintenanceContainer> PersonalMaintenanceInteractions;
        /* 0x025E8 */ public List<ulong> VisitedSystems;        // probably technically the 8 byte hex used to denote systems...
        [NMS(Size = 6, EnumType = typeof(GcPlayerHazardType.HazardEnum))]
        /* 0x025F8 */ public float[] Hazard;
        /* 0x02610 */ public int BoltAmmo;
        /* 0x02614 */ public int ScatterAmmo;
        /* 0x02618 */ public int PulseAmmo;
        /* 0x0261C */ public int LaserAmmo;
        /* 0x02620 */ public Vector4f FirstSpawnPosition;
        [NMS(Size = 0x72, EnumType = typeof(GcInteractionType.InteractionTypeEnum))]
        /* 0x02630 */ public GcSavedInteractionRaceData[] SavedInteractionIndicies;
        /* 0x03470 */ public List<GcSavedInteractionDialogData> SavedInteractionDialogTable;
        /* 0x03480 */ public List<NMSString0x20> InteractionProgressTable;
        [NMS(Size = 0xA)]
        /* 0x03490 */ public GcUniverseAddressData[] AtlasStationAdressData;
        [NMS(Size = 0xB)]
        /* 0x03580 */ public GcUniverseAddressData[] NewAtlasStationAdressData;
        /* 0x03688 */ public List<GcUniverseAddressData> VisitedAtlasStationsData;
        /* 0x03698 */ public bool FirstAtlasStationDiscovered;
        /* 0x03699 */ public bool UsesThirdPersonCharacterCam;
        /* 0x0369C */ public int ProgressionLevel;
        /* 0x036A0 */ public int ProcTechIndex;
        /* 0x036A4 */ public bool IsNew;
        /* 0x036A5 */ public bool UseSmallerBlackholeJumps;
        [NMS(Size = 0x2, Ignore = true)]
        /* 0x036A6 */ public byte[] Padding36A6;
        /* 0x036A8 */ public List<GcSavedEntitlement> UsedEntitlements;
        [NMS(Size = 0x10)]
        /* 0x036C0 */ public Vector4f[] PlanetPositions;
        [NMS(Size = 0x10)]
        /* 0x037C0 */ public GcSeed[] PlanetSeeds;
        /* 0x038C0 */ public int PrimaryPlanet;
        [NMS(Size = 4, Ignore = true)]
        /* 0x038C4 */ public byte[] Padding38C4;
        /* 0x038C8 */ public ulong TimeLastSpaceBattle;
        /* 0x038D0 */ public int WarpsLastSpaceBattle;
        [NMS(Size = 4, Ignore = true)]
        /* 0x038D4 */ public byte[] Padding38D4;
        /* 0x038D8 */ public ulong ActiveSpaceBattleUA;
        /* 0x038E0 */ public ulong TimeLastMiniStation;
        /* 0x038E8 */ public int WarpsLastMiniStation;
        [NMS(Size = 4, Ignore = true)]
        /* 0x038EC */ public byte[] Padding38EC;
        /* 0x038F0 */ public ulong MiniStationUA;
        [NMS(Size = 8, Ignore = true)]
        /* 0x038F8 */ public byte[] Padding38F8;
        /* 0x03900 */ public Vector4f AnomalyPositionOverride;
        /* 0x03910 */ public GcUniverseAddressData GameStartAddress1;
        /* 0x03928 */ public GcUniverseAddressData GameStartAddress2;
        [NMS(Size = 0x10)]
        /* 0x03940 */ public bool[] GalacticMapRequests;
        /* 0x03950 */ public Vector4f FirstShipPosition;
        /* 0x03960 */ public ulong HazardTimeAlive;
        /* 0x03968 */ public bool RevealBlackHoles;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x03969 */ public byte[] Padding3969;
        /* 0x03970 */ public GcSeed CurrentFreighterHomeSystemSeed;
        /* 0x03980 */ public GcResourceElement CurrentFreighter;
        /* 0x03C28 */ public GcInventoryLayout FreighterLayout;
        /* 0x03C48 */ public GcInventoryContainer FreighterInventory;
        /* 0x03DA8 */ public GcInventoryContainer FreighterInventory_TechOnly;
        /* 0x03F08 */ public GcUniverseAddressData FreighterUniverseAddress;
        /* 0x03F20 */ public Vector3f FreighterMatrixAt;
        /* 0x03F30 */ public Vector3f FreighterMatrixUp;
        /* 0x03F40 */ public Vector3f FreighterMatrixPos;
        /* 0x03F50 */ public List<GcPersistentBBObjectData> BaseBuildingObjects;
        /* 0x03F60 */ public GcTerrainEditsBuffer TerrainEditData;
        [NMS(Size = 0x5, EnumType = typeof(GcNPCHabitationType.NPCHabitationTypeEnum))]
        /* 0x23220 */ public GcNPCWorkerData[] NPCWorkers;
        /* 0x24080 */ public List<GcPersistentBase> PersistentPlayerBases;
        /* 0x24090 */ public List<GcTeleportEndpoint> TeleportEndpoints;
        /* 0x240A0 */ public GcInventoryLayout Chest1Layout;
        /* 0x240C0 */ public GcInventoryContainer Chest1Inventory;
        /* 0x24220 */ public GcInventoryLayout Chest2Layout;
        /* 0x24240 */ public GcInventoryContainer Chest2Inventory;
        /* 0x243A0 */ public GcInventoryLayout Chest3Layout;
        /* 0x243C0 */ public GcInventoryContainer Chest3Inventory;
        /* 0x24520 */ public GcInventoryLayout Chest4Layout;
        /* 0x24540 */ public GcInventoryContainer Chest4Inventory;
        /* 0x246A0 */ public GcInventoryLayout Chest5Layout;
        /* 0x246C0 */ public GcInventoryContainer Chest5Inventory;
        /* 0x24820 */ public GcInventoryLayout Chest6Layout;
        /* 0x24840 */ public GcInventoryContainer Chest6Inventory;
        /* 0x249A0 */ public GcInventoryLayout Chest7Layout;
        /* 0x249C0 */ public GcInventoryContainer Chest7Inventory;
        /* 0x24B20 */ public GcInventoryLayout Chest8Layout;
        /* 0x24B40 */ public GcInventoryContainer Chest8Inventory;
        /* 0x24CA0 */ public GcInventoryLayout Chest9Layout;
        /* 0x24CC0 */ public GcInventoryContainer Chest9Inventory;
        /* 0x24E20 */ public GcInventoryLayout Chest10Layout;
        /* 0x24E40 */ public GcInventoryContainer Chest10Inventory;
        /* 0x24FA0 */ public GcInventoryLayout ChestMagicLayout;
        /* 0x24FC0 */ public GcInventoryContainer ChestMagicInventory;
        /* 0x25120 */ public GcInventoryLayout ChestMagic2Layout;
        /* 0x25140 */ public GcInventoryContainer ChestMagic2Inventory;
        /* 0x252A0 */ public GcInventoryLayout CookingIngredientsLayout;
        /* 0x252C0 */ public GcInventoryContainer CookingIngredientsInventory;
        /* 0x25420 */ public GcResourceElement CurrentFreighterNPC;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x256C8 */ public byte[] Padding256C8;
        [NMS(Size = 0x7, EnumType = typeof(GcVehicleType.VehicleTypeEnum))]
        /* 0x256D0 */ public GcPlayerOwnershipData[] VehicleOwnership;
        /* 0x27F80 */ public int PrimaryVehicle;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x27F84 */ public byte[] Padding27F84;
        [NMS(Size = 0x6)]
        /* 0x27F90 */ public GcPlayerOwnershipData[] ShipOwnership;
        /* 0x2A270 */ public int PrimaryShip;
        /* 0x2A274 */ public bool MultiShipEnabled;
        [NMS(Size = 0x20)]
        /* 0x2A275 */ public string PlayerFreighterName;
        [NMS(Size = 0xB, Ignore = true)]
        /* 0x2A295 */ public byte[] Padding2A295;
        /* 0x2A2A0 */ public Vector4f StartGameShipPosition;
        /* 0x2A2B0 */ public bool ShipNeedsTerrainPositioning;
        /* 0x2A2B4 */ public int TradingSupplyDataIndex;
        /* 0x2A2B8 */ public List<GcTradingSupplyData> TradingSupplyData;
        /* 0x2A2C8 */ public List<GcPortalData> LastPortal;
        /* 0x2A2D8 */ public GcPortalSaveData VisitedPortal;
        /* 0x2A2F0 */ public int KnownPortalRunes;
        /* 0x2A2F4 */ public bool OnOtherSideOfPortal;
        [NMS(Size = 0xB, Ignore = true)]
        /* 0x2A2F5 */ public byte[] Padding2A2F5;
        /* 0x2A300 */ public GcTeleportEndpoint OtherSideOfPortalReturnBase;
        /* 0x2A390 */ public Vector4f PortalMarkerPosition_Local;
        /* 0x2A3A0 */ public Vector4f PortalMarkerPosition_Offset;
        /* 0x2A3B0 */ public GcPlayerWeapons StartingPrimaryWeapon;
        /* 0x2A3B4 */ public GcPlayerWeapons StartingSecondaryWeapon;
        [NMS(Size = 0x11, EnumType = typeof(GcCustomisationComponentData.CustomisationDataTypeEnum))]
        /* 0x2A3B8 */ public GcCharacterCustomisationSaveData[] CharacterCustomisationData;
        [NMS(Size = 0x6)]
        /* 0x2A990 */ public bool[] ShipUsesLegacyColours;
        [NMS(Size = 0x2, Ignore = true)]
        /* 0x2A996 */ public byte[] Padding2A996;
        [NMS(Size = 0x3)]
        /* 0x2A998 */ public GcCharacterCustomisationData[] Outfits;
        [NMS(Size = 0x10)]
        /* 0x2AA70 */ public string JetpackEffect;
        /* 0x2AA80 */ public GcSeed FleetSeed;
        /* 0x2AA90 */ public List<GcFleetFrigateSaveData> FleetFrigates;
        /* 0x2AAA0 */ public List<GcFleetExpeditionSaveData> FleetExpeditions;
        /* 0x2AAB0 */ public List<long> ExpeditionSeedsSelectedToday;
        /* 0x2AAC0 */ public ulong LastKnownDay;
        /* 0x2AAC8 */ public ulong SunTimer;
        /* 0x2AAD0 */ public ulong MultiplayerLobbyID;
        /* 0x2AAD8 */ public GcUniverseAddressData MultiplayerUA;
        /* 0x2AAF0 */ public GcPlayerSpawnStateData MultiplayerSpawn;
        /* 0x2ABA0 */ public List<GcRepairTechData> RepairTechBuffer;
        /* 0x2ABB0 */ public ulong MultiplayerPrivileges;
        [NMS(Size = 0x3, EnumType = typeof(GcHotActionMenuTypes.HotActionMenuTypesEnum))]
        /* 0x2ABB8 */ public GcHotActionsSaveData[] HotActions;
        /* 0x2B068 */ public ulong LastUABeforePortalWarp;
        /* 0x2B070 */ public ulong StoryPortalSeed;
        /* 0x2B078 */ public ushort ShopNumber;
        /* 0x2B07A */ public ushort ShopTier;
        /* 0x2B07C */ public bool HasAccessToNexus;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x2B07D */ public byte[] Padding2B07D;
        /* 0x2B080 */ public GcUniverseAddressData NexusUniverseAddress;
        /* 0x2B0A0 */ public Vector3f NexusMatrixAt;
        /* 0x2B0B0 */ public Vector3f NexusMatrixUp;
        /* 0x2B0C0 */ public Vector3f NexusMatrixPos;
        /* 0x2B0D0 */ public GcPhotoModeSettings PhotoModeSettings;
        /* 0x2B120 */ public int BannerIcon;
        /* 0x2B124 */ public int BannerMainColour;
        /* 0x2B128 */ public int BannerBackgroundColour;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x2B12C */ public byte[] Padding2B12C;
        [NMS(Size = 0x10)]
        /* 0x2B130 */ public string BannerTitleId;
        /* 0x2B140 */ public int TelemetryUploadVersion;
        /* 0x2B144 */ public bool UsesThirdPersonVehicleCam;
        /* 0x2B148 */ public float VRCameraOffset;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x2B14C */ public byte[] Padding2B14C;
        /* 0x2B150 */ public GcSeasonalGameModeData SeasonalData;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x2B238 */ public byte[] EndPadding;
    }
}
