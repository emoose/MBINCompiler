using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x29690, GUID = 0x78BEB4F749C9098B, NameHash = 0x6C4510BB243EFA64)]
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
        [NMS(Size = 0x4, Ignore = true)]
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

        /* 0x013C8 */ public List<GcMaintenanceContainer> MaintenanceInteractions;
        /* 0x013D8 */ public List<GcMaintenanceContainer> PersonalMaintenanceInteractions;
        /* 0x013E8 */ public List<ulong> VisitedSystems;        // probably technically the 8 byte hex used to denote systems...

        [NMS(Size = 6, EnumType = typeof(GcPlayerHazardType.HazardEnum))]
        /* 0x013F8 */ public float[] Hazard;

        /* 0x01410 */ public int BoltAmmo;
        /* 0x01414 */ public int ScatterAmmo;
        /* 0x01418 */ public int PulseAmmo;
        /* 0x0141C */ public int LaserAmmo;

        /* 0x001420 */ public Vector4f FirstSpawnPosition;

        [NMS(Size = 0x65, EnumType = typeof(GcInteractionType.InteractionTypeEnum))]
        /* 0x01430 */ public GcSavedInteractionRaceData[] SavedInteractionIndicies;

        /* 0x020D0 */ public List<GcSavedInteractionDialogData> SavedInteractionDialogTable;
        /* 0x020E0 */ public List<NMSString0x20> InteractionProgressTable;

        [NMS(Size = 0xA)]
        /* 0x020F0 */ public GcUniverseAddressData[] AtlasStationAdressData;
        [NMS(Size = 0xB)]
        /* 0x021E0 */ public GcUniverseAddressData[] NewAtlasStationAdressData;

        /* 0x022E8 */ public List<GcUniverseAddressData> VisitedAtlasStationsData;

        /* 0x022F8 */ public bool FirstAtlasStationDiscovered;
        /* 0x022F9 */ public bool UsesThirdPersonCharacterCam;
        /* 0x022FC */ public int ProgressionLevel;
        /* 0x02300 */ public int ProcTechIndex;
        /* 0x02304 */ public bool IsNew;
        /* 0x02305 */ public bool UseSmallerBlackholeJumps;

        [NMS(Size = 0x2, Ignore = true)]
        /* 0x02306 */ public byte[] Padding2306;

        /* 0x02308 */ public List<GcSavedEntitlement> UsedEntitlements;

        [NMS(Size = 0x10)]
        /* 0x02320 */ public Vector4f[] PlanetPositions;

        [NMS(Size = 0x10)]
        /* 0x02420 */ public GcSeed[] PlanetSeeds;

        /* 0x02520 */ public int PrimaryPlanet;
        [NMS(Size = 4, Ignore = true)]
        /* 0x02524 */ public byte[] Padding2524;

        /* 0x02528 */ public ulong TimeLastSpaceBattle;
        /* 0x02530 */ public int WarpsLastSpaceBattle;
        [NMS(Size = 4, Ignore = true)]
        /* 0x02534 */ public byte[] Padding2534;

        /* 0x02538 */ public ulong ActiveSpaceBattleUA;
        /* 0x02540 */ public ulong TimeLastMiniStation;
        /* 0x02548 */ public int WarpsLastMiniStation;
        [NMS(Size = 4, Ignore = true)]
        /* 0x0254C */ public byte[] Padding254C;

        /* 0x02550 */ public ulong MiniStationUA;
        [NMS(Size = 8, Ignore = true)]
        /* 0x02558 */ public byte[] Padding2558;
        /* 0x02560 */ public Vector4f AnomalyPositionOverride;

        /* 0x02570 */ public GcUniverseAddressData GameStartAddress1;
        /* 0x02588 */ public GcUniverseAddressData GameStartAddress2;

        [NMS(Size = 0x10)]
        /* 0x025A0 */ public bool[] GalacticMapRequests;

        /* 0x025B0 */ public Vector4f FirstShipPosition;

        /* 0x025C0 */ public ulong HazardTimeAlive;

        /* 0x025C8 */ public bool RevealBlackHoles;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x025C9 */ public byte[] Padding25C9;
        /* 0x025D0 */ public GcSeed CurrentFreighterHomeSystemSeed;

        /* 0x025E0 */ public GcResourceElement CurrentFreighter;
        /* 0x02888 */ public GcInventoryLayout FreighterLayout;
        /* 0x028A8 */ public GcInventoryContainer FreighterInventory;
        /* 0x02A08 */ public GcInventoryContainer FreighterInventory_TechOnly;
        /* 0x02B68 */ public GcUniverseAddressData FreighterUniverseAddress;
        /* 0x02B80 */ public Vector3f FreighterMatrixAt;
        /* 0x02B90 */ public Vector3f FreighterMatrixUp;
        /* 0x02BA0 */ public Vector3f FreighterMatrixPos;
        /* 0x02BB0 */ public List<GcPersistentBBObjectData> BaseBuildingObjects;
        /* 0x02BC0 */ public GcTerrainEditsBuffer TerrainEditData;
        [NMS(Size = 0x5, EnumType = typeof(GcNPCHabitationType.NPCHabitationTypeEnum))]
        /* 0x21E80 */ public GcNPCWorkerData[] NPCWorkers;
        /* 0x22CE0 */ public List<GcPersistentBase> PersistentPlayerBases;
        /* 0x22CF0 */ public List<GcTeleportEndpoint> TeleportEndpoints;

        /* 0x22D00 */ public GcInventoryLayout Chest1Layout;
        /* 0x22D20 */ public GcInventoryContainer Chest1Inventory;
        /* 0x22E80 */ public GcInventoryLayout Chest2Layout;
        /* 0x22EA0 */ public GcInventoryContainer Chest2Inventory;
        /* 0x23000 */ public GcInventoryLayout Chest3Layout;
        /* 0x23020 */ public GcInventoryContainer Chest3Inventory;
        /* 0x23180 */ public GcInventoryLayout Chest4Layout;
        /* 0x231A0 */ public GcInventoryContainer Chest4Inventory;
        /* 0x23300 */ public GcInventoryLayout Chest5Layout;
        /* 0x23320 */ public GcInventoryContainer Chest5Inventory;
        /* 0x23480 */ public GcInventoryLayout Chest6Layout;
        /* 0x234A0 */ public GcInventoryContainer Chest6Inventory;
        /* 0x23600 */ public GcInventoryLayout Chest7Layout;
        /* 0x23620 */ public GcInventoryContainer Chest7Inventory;
        /* 0x23780 */ public GcInventoryLayout Chest8Layout;
        /* 0x237A0 */ public GcInventoryContainer Chest8Inventory;
        /* 0x23900 */ public GcInventoryLayout Chest9Layout;
        /* 0x23920 */ public GcInventoryContainer Chest9Inventory;
        /* 0x23A80 */ public GcInventoryLayout Chest10Layout;
        /* 0x23AA0 */ public GcInventoryContainer Chest10Inventory;
        /* 0x23C00 */ public GcInventoryLayout ChestMagicLayout;
        /* 0x23C20 */ public GcInventoryContainer ChestMagicInventory;
        /* 0x23D80 */ public GcInventoryLayout ChestMagic2Layout;
        /* 0x23DA0 */ public GcInventoryContainer ChestMagic2Inventory;
        /* 0x23F00 */ public GcInventoryLayout CookingIngredientsLayout;
        /* 0x23F20 */ public GcInventoryContainer CookingIngredientsInventory;
        /* 0x24080 */ public GcResourceElement CurrentFreighterNPC;

        [NMS(Size = 0x8, Ignore = true)]
        /* 0x24328 */ public byte[] Padding24328;

        [NMS(Size = 0x6, EnumType = typeof(GcVehicleType.VehicleTypeEnum))]
        /* 0x24330 */ public GcPlayerOwnershipData[] VehicleOwnership;
        /* 0x26610 */ public int PrimaryVehicle;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x26614 */ public byte[] Padding26614;
        [NMS(Size = 0x6)]
        /* 0x26620 */ public GcPlayerOwnershipData[] ShipOwnership;
        /* 0x28900 */ public int PrimaryShip;

        /* 0x28904 */ public bool MultiShipEnabled;
        [NMS(Size = 0x20)]
        /* 0x28905 */ public string PlayerWeaponName;
        [NMS(Size = 0xB, Ignore = true)]
        /* 0x28925 */ public byte[] Padding28925;
        /* 0x28930 */ public Vector4f StartGameShipPosition;
        /* 0x28940 */ public bool ShipNeedsTerrainPositioning;
        /* 0x28944 */ public int TradingSupplyDataIndex;
        /* 0x28948 */ public List<GcTradingSupplyData> TradingSupplyData;
        /* 0x28958 */ public List<GcPortalData> LastPortal;
        /* 0x28968 */ public GcPortalSaveData VisitedPortal;
        /* 0x28980 */ public int KnownPortalRunes;
        /* 0x28984 */ public bool OnOtherSideOfPortal;
        [NMS(Size = 0xB, Ignore = true)]
        /* 0x28985 */ public byte[] Padding28985;
        /* 0x28990 */ public GcTeleportEndpoint OtherSideOfPortalReturnBase;
        /* 0x28A20 */ public Vector4f PortalMarkerPosition_Local;
        /* 0x28A30 */ public Vector4f PortalMarkerPosition_Offset;
        /* 0x28A40 */ public GcPlayerWeapons StartingPrimaryWeapon;
        /* 0x28A44 */ public GcPlayerWeapons StartingSecondaryWeapon;
        [NMS(Size = 0xE, EnumType = typeof(GcCustomisationComponentData.CustomisationDataTypeEnum))]
        /* 0x28A48 */ public GcCharacterCustomisationSaveData[] CharacterCustomisationData;
        [NMS(Size = 0x6)]
        /* 0x28F18 */ public bool[] ShipUsesLegacyColours;

        [NMS(Size = 0x2, Ignore = true)]
        /* 0x28F1E */ public byte[] Padding28F1E;

        [NMS(Size = 0x3)]
        /* 0x28F20 */ public GcCharacterCustomisationData[] Outfits;
        [NMS(Size = 0x10)]
        /* 0x28FF8 */ public string JetpackEffect;
        /* 0x29008 */ public GcSeed FleetSeed;
        /* 0x29018 */ public List<GcFleetFrigateSaveData> FleetFrigates;
        /* 0x29028 */ public List<GcFleetExpeditionSaveData> FleetExpeditions;
        /* 0x29038 */ public List<long> ExpeditionSeedsSelectedToday;
        /* 0x29048 */ public ulong LastKnownDay;
        /* 0x29050 */ public ulong SunTimer;
        /* 0x29058 */ public ulong MultiplayerLobbyID;
        /* 0x29060 */ public GcUniverseAddressData MultiplayerUA;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x29078 */ public byte[] Padding29078;
        /* 0x29080 */ public GcPlayerSpawnStateData MultiplayerSpawn;
        /* 0x29100 */ public List<GcRepairTechData> RepairTechBuffer;
        /* 0x29110 */ public ulong MultiplayerPrivileges;
        [NMS(Size = 0x3, EnumType = typeof(GcHotActionMenuTypes.HotActionMenuTypesEnum))]
        /* 0x29118 */ public GcHotActionsSaveData[] HotActions;
        /* 0x295C8 */ public ulong LastUABeforePortalWarp;
        /* 0x295D0 */ public ulong StoryPortalSeed;
        /* 0x295D8 */ public uint ShopNumber;
        /* 0x295DA */ public uint ShopTier;
        /* 0x295DC */ public bool HasAccessToNexus;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x295DD */ public byte[] Padding295DD;
        /* 0x295E0 */ public GcUniverseAddressData NexusUniverseAddress;
        /* 0x29600 */ public Vector3f NexusMatrixAt;
        /* 0x29610 */ public Vector3f NexusMatrixUp;
        /* 0x29620 */ public Vector3f NexusMatrixPos;
        /* 0x29630 */ public GcPhotoModeSettings PhotoModeSettings;
        /* 0x29670 */ public int BannerIcon;
        /* 0x29674 */ public int BannerMainColour;
        /* 0x29678 */ public int BannerBackgroundColour;
        /* 0x2967C */ public int TelemetryUploadVersion;
        /* 0x29680 */ public bool UsesThirdPersonVehicleCam;
        [NMS(Size = 0xF, Ignore = true)]
        /* 0x29681 */ public byte[] EndPadding;
    }
}
