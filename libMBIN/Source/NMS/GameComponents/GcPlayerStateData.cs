using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x29660, GUID = 0xE93A66060D7F21DA, NameHash = 0x6C4510BB243EFA64)]
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

        [NMS(Size = 0x64, EnumType = typeof(GcInteractionType.InteractionTypeEnum))]
        /* 0x01430 */ public GcSavedInteractionRaceData[] SavedInteractionIndicies;

        /* 0x020B0 */ public List<GcSavedInteractionDialogData> SavedInteractionDialogTable;
        /* 0x020C0 */ public List<NMSString0x20> InteractionProgressTable;

        [NMS(Size = 0xA)]
        /* 0x020D0 */ public GcUniverseAddressData[] AtlasStationAdressData;
        [NMS(Size = 0xB)]
        /* 0x021C0 */ public GcUniverseAddressData[] NewAtlasStationAdressData;

        /* 0x022C8 */ public List<GcUniverseAddressData> VisitedAtlasStationsData;

        /* 0x022D8 */ public bool FirstAtlasStationDiscovered;
        /* 0x022D9 */ public bool UsesThirdPersonCharacterCam;
        /* 0x022DC */ public int ProgressionLevel;
        /* 0x022E0 */ public int ProcTechIndex;
        /* 0x022E4 */ public bool IsNew;
        /* 0x022E5 */ public bool UseSmallerBlackholeJumps;

        [NMS(Size = 0x2, Ignore = true)]
        /* 0x022E6 */ public byte[] Padding22E6;

        /* 0x022E8 */ public List<GcSavedEntitlement> UsedEntitlements;

        [NMS(Size = 0x10)]
        /* 0x02300 */ public Vector4f[] PlanetPositions;

        [NMS(Size = 0x10)]
        /* 0x02400 */ public GcSeed[] PlanetSeeds;

        /* 0x02500 */ public int PrimaryPlanet;
        [NMS(Size = 4, Ignore = true)]
        /* 0x02504 */ public byte[] Padding2504;

        /* 0x02508 */ public ulong TimeLastSpaceBattle;
        /* 0x02510 */ public int WarpsLastSpaceBattle;
        [NMS(Size = 4, Ignore = true)]
        /* 0x02514 */ public byte[] Padding2514;

        /* 0x02518 */ public ulong ActiveSpaceBattleUA;
        /* 0x02520 */ public ulong TimeLastMiniStation;
        /* 0x02528 */ public int WarpsLastMiniStation;
        [NMS(Size = 4, Ignore = true)]
        /* 0x0252C */ public byte[] Padding252C;

        /* 0x02530 */ public ulong MiniStationUA;
        [NMS(Size = 8, Ignore = true)]
        /* 0x02538 */ public byte[] Padding2538;
        /* 0x02540 */ public Vector4f AnomalyPositionOverride;

        /* 0x02550 */ public GcUniverseAddressData GameStartAddress1;
        /* 0x02568 */ public GcUniverseAddressData GameStartAddress2;

        [NMS(Size = 0x10)]
        /* 0x02580 */ public bool[] GalacticMapRequests;

        /* 0x02590 */ public Vector4f FirstShipPosition;

        /* 0x025A0 */ public ulong HazardTimeAlive;

        /* 0x025A8 */ public bool RevealBlackHoles;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x025A9 */ public byte[] Padding25A9;
        /* 0x025B0 */ public GcSeed CurrentFreighterHomeSystemSeed;

        /* 0x025C0 */ public GcResourceElement CurrentFreighter;
        /* 0x02868 */ public GcInventoryLayout FreighterLayout;
        /* 0x02888 */ public GcInventoryContainer FreighterInventory;
        /* 0x029E8 */ public GcInventoryContainer FreighterInventory_TechOnly;
        /* 0x02B48 */ public GcUniverseAddressData FreighterUniverseAddress;
        /* 0x02B60 */ public Vector3f FreighterMatrixAt;
        /* 0x02B70 */ public Vector3f FreighterMatrixUp;
        /* 0x02B80 */ public Vector3f FreighterMatrixPos;
        /* 0x02B90 */ public List<GcPersistentBBObjectData> BaseBuildingObjects;
        /* 0x02BA0 */ public GcTerrainEditsBuffer TerrainEditData;
        [NMS(Size = 0x5, EnumType = typeof(GcNPCHabitationType.NPCHabitationTypeEnum))]
        /* 0x21E60 */ public GcNPCWorkerData[] NPCWorkers;
        /* 0x22CC0 */ public List<GcPersistentBase> PersistentPlayerBases;
        /* 0x22CD0 */ public List<GcTeleportEndpoint> TeleportEndpoints;

        /* 0x22CE0 */ public GcInventoryLayout Chest1Layout;
        /* 0x22D00 */ public GcInventoryContainer Chest1Inventory;
        /* 0x22E60 */ public GcInventoryLayout Chest2Layout;
        /* 0x22E80 */ public GcInventoryContainer Chest2Inventory;
        /* 0x22FE0 */ public GcInventoryLayout Chest3Layout;
        /* 0x23000 */ public GcInventoryContainer Chest3Inventory;
        /* 0x23160 */ public GcInventoryLayout Chest4Layout;
        /* 0x23180 */ public GcInventoryContainer Chest4Inventory;
        /* 0x232E0 */ public GcInventoryLayout Chest5Layout;
        /* 0x23300 */ public GcInventoryContainer Chest5Inventory;
        /* 0x23460 */ public GcInventoryLayout Chest6Layout;
        /* 0x23480 */ public GcInventoryContainer Chest6Inventory;
        /* 0x235E0 */ public GcInventoryLayout Chest7Layout;
        /* 0x23600 */ public GcInventoryContainer Chest7Inventory;
        /* 0x23760 */ public GcInventoryLayout Chest8Layout;
        /* 0x23780 */ public GcInventoryContainer Chest8Inventory;
        /* 0x238E0 */ public GcInventoryLayout Chest9Layout;
        /* 0x23900 */ public GcInventoryContainer Chest9Inventory;
        /* 0x23A60 */ public GcInventoryLayout Chest10Layout;
        /* 0x23A80 */ public GcInventoryContainer Chest10Inventory;
        /* 0x23BE0 */ public GcInventoryLayout ChestMagicLayout;
        /* 0x23C00 */ public GcInventoryContainer ChestMagicInventory;
        /* 0x23D60 */ public GcInventoryLayout ChestMagic2Layout;
        /* 0x23D80 */ public GcInventoryContainer ChestMagic2Inventory;
        /* 0x23EE0 */ public GcInventoryLayout CookingIngredientsLayout;
        /* 0x23F00 */ public GcInventoryContainer CookingIngredientsInventory;
        /* 0x24060 */ public GcResourceElement CurrentFreighterNPC;

        [NMS(Size = 0x8, Ignore = true)]
        /* 0x24308 */ public byte[] Padding24308;

        [NMS(Size = 0x6, EnumType = typeof(GcVehicleType.VehicleTypeEnum))]
        /* 0x24310 */ public GcPlayerOwnershipData[] VehicleOwnership;
        /* 0x265F0 */ public int PrimaryVehicle;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x265F4 */ public byte[] Padding265F4;
        [NMS(Size = 0x6)]
        /* 0x26600 */ public GcPlayerOwnershipData[] ShipOwnership;
        /* 0x288E0 */ public int PrimaryShip;

        /* 0x288E4 */ public bool MultiShipEnabled;
        [NMS(Size = 0x20)]
        /* 0x288E5 */ public string PlayerWeaponName;
        [NMS(Size = 0xB, Ignore = true)]
        /* 0x28905 */ public byte[] Padding28905;
        /* 0x28910 */ public Vector4f StartGameShipPosition;
        /* 0x28920 */ public bool ShipNeedsTerrainPositioning;
        /* 0x28924 */ public int TradingSupplyDataIndex;
        /* 0x28928 */ public List<GcTradingSupplyData> TradingSupplyData;
        /* 0x28938 */ public List<GcPortalData> LastPortal;
        /* 0x28948 */ public GcPortalSaveData VisitedPortal;
        /* 0x28960 */ public int KnownPortalRunes;
        /* 0x28964 */ public bool OnOtherSideOfPortal;
        [NMS(Size = 0xB, Ignore = true)]
        /* 0x28965 */ public byte[] Padding28965;
        /* 0x28970 */ public GcTeleportEndpoint OtherSideOfPortalReturnBase;
        /* 0x28A00 */ public Vector4f PortalMarkerPosition_Local;
        /* 0x28A10 */ public Vector4f PortalMarkerPosition_Offset;
        /* 0x28A20 */ public GcPlayerWeapons StartingPrimaryWeapon;
        /* 0x28A24 */ public GcPlayerWeapons StartingSecondaryWeapon;
        [NMS(Size = 0xE, EnumType = typeof(GcCustomisationComponentData.CustomisationDataTypeEnum))]
        /* 0x28A28 */ public GcCharacterCustomisationSaveData[] CharacterCustomisationData;
        [NMS(Size = 0x6)]
        /* 0x28EF8 */ public bool[] ShipUsesLegacyColours;

        [NMS(Size = 0x2, Ignore = true)]
        /* 0x28EFE */ public byte[] Padding28EFE;

        [NMS(Size = 0x3)]
        /* 0x28F00 */ public GcCharacterCustomisationData[] Outfits;

        /* 0x28FD8 */ public GcSeed FleetSeed;
        /* 0x28FE8 */ public List<GcFleetFrigateSaveData> FleetFrigates;
        /* 0x28FF8 */ public List<GcFleetExpeditionSaveData> FleetExpeditions;
        /* 0x29008 */ public List<long> ExpeditionSeedsSelectedToday;
        /* 0x29018 */ public ulong LastKnownDay;
        /* 0x29020 */ public ulong SunTimer;
        /* 0x29028 */ public ulong MultiplayerLobbyID;
        /* 0x29030 */ public GcUniverseAddressData MultiplayerUA;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x29048 */ public byte[] Padding29048;
        /* 0x29050 */ public GcPlayerSpawnStateData MultiplayerSpawn;
        /* 0x290D0 */ public List<GcRepairTechData> RepairTechBuffer;
        /* 0x290E0 */ public ulong MultiplayerPrivileges;
        [NMS(Size = 0x3, EnumType = typeof(GcHotActionMenuTypes.HotActionMenuTypesEnum))]
        /* 0x290E8 */ public GcHotActionsSaveData[] HotActions;
        /* 0x29598 */ public ulong LastUABeforePortalWarp;
        /* 0x295A0 */ public ulong StoryPortalSeed;
        /* 0x295A8 */ public uint ShopNumber;
        /* 0x295AA */ public uint ShopTier;
        /* 0x295AC */ public bool HasAccessToNexus;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x295AD */ public byte[] Padding295AD;
        /* 0x295B0 */ public GcUniverseAddressData NexusUniverseAddress;
        /* 0x295D0 */ public Vector3f NexusMatrixAt;
        /* 0x295E0 */ public Vector3f NexusMatrixUp;
        /* 0x295F0 */ public Vector3f NexusMatrixPos;
        /* 0x29600 */ public GcPhotoModeSettings PhotoModeSettings;
        /* 0x29640 */ public int BannerIcon;
        /* 0x29644 */ public int BannerMainColour;
        /* 0x29648 */ public int BannerBackgroundColour;
        /* 0x2964C */ public int TelemetryUploadVersion;
        /* 0x29650 */ public bool UsesThirdPersonVehicleCam;
        [NMS(Size = 0xF, Ignore = true)]
        /* 0x29651 */ public byte[] EndPadding;
    }
}
