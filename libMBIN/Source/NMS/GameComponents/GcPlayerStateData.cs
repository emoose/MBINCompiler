using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFBB26B480E2A2265, NameHash = 0x6C4510BB243EFA64)]
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
        // size: 0xB
        public enum StoredInteractionsEnum {
            Distress_Signal,
            Crate,
            Destructable,
            Terrain,
            Cost,
            Building,
            Creature,
            Maintenance,
            Personal,
            Personal_Maintenance,
            FireteamSync
        }
        [NMS(Size = 0xB, EnumType = typeof(StoredInteractionsEnum))]
        /* 0x0A2A0 */ public GcInteractionBuffer[] StoredInteractions;
        /* 0x0A3A8 */ public List<GcMaintenanceContainer> MaintenanceInteractions;
        /* 0x0A3B8 */ public List<GcMaintenanceContainer> PersonalMaintenanceInteractions;
        /* 0x0A3C8 */ public List<ulong> VisitedSystems;
        // size: 0x6
        public enum HazardEnum {
            None,
            NoOxygen,
            ExtremeHeat,
            ExtremeCold,
            ToxicGas,
            Radiation
        }
        [NMS(Size = 0x6, EnumType = typeof(HazardEnum))]
        /* 0x0A3D8 */ public float[] Hazard;
        /* 0x0A3F0 */ public int BoltAmmo;
        /* 0x0A3F4 */ public int ScatterAmmo;
        /* 0x0A3F8 */ public int PulseAmmo;
        /* 0x0A3FC */ public int LaserAmmo;
        /* 0x0A400 */ public Vector4f FirstSpawnPosition;
        // size: 0x83
        public enum SavedInteractionIndiciesEnum {
            None,
            Shop,
            NPC,
            NPC_Secondary,
            NPC_Anomaly,
            NPC_Anomaly_Secondary,
            Ship,
            Outpost,
            SpaceStation,
            RadioTower,
            Monolith,
            Factory,
            AbandonedShip,
            Harvester,
            Observatory,
            TradingPost,
            DistressBeacon,
            Portal,
            Plaque,
            AtlasStation,
            AbandonedBuildings,
            WeaponTerminal,
            SuitTerminal,
            SignalScanner,
            Teleporter_Base,
            Teleporter_Station,
            ClaimBase,
            NPC_Freighter_Captain,
            NPC_HIRE_Weapons,
            NPC_HIRE_Weapons_Wait,
            NPC_HIRE_Farmer,
            NPC_HIRE_Farmer_Wait,
            NPC_HIRE_Builder,
            NPC_HIRE_Builder_Wait,
            NPC_HIRE_Vehicles,
            NPC_HIRE_Vehicles_Wait,
            MessageBeacon,
            NPC_HIRE_Scientist,
            NPC_HIRE_Scientist_Wait,
            NPC_Recruit,
            NPC_Freighter_Captain_Secondary,
            NPC_Recruit_Secondary,
            Vehicle,
            MessageModule,
            TechShop,
            VehicleRaceStart,
            BuildingShop,
            MissionGiver,
            HoloHub,
            HoloExplorer,
            HoloSceptic,
            HoloNoone,
            PortalRuneEntry,
            PortalActivate,
            CrashedFreighter,
            GraveInCave,
            GlitchyStoryBox,
            NetworkPlayer,
            NetworkMonument,
            AnomalyComputer,
            AtlasPlinth,
            Epilogue,
            GuildEnvoy,
            ManageFleet,
            ManageExpeditions,
            Frigate,
            CustomiseCharacter,
            CustomiseShip,
            CustomiseWeapon,
            CustomiseVehicle,
            ClaimBaseAnywhere,
            FleetNavigator,
            FleetCommandPost,
            StoryUtility,
            MPMissionGiver,
            SpecialsShop,
            WaterRuin,
            LocationScanner,
            ByteBeat,
            NPC_CrashSite,
            NPC_Scavenger,
            BaseGridPart,
            NPC_Freighter_Crew,
            NPC_Freighter_Crew_Owned,
            AbandonedShip_With_NPC,
            ShipPilot,
            NexusMilestones,
            NexusDailyMission,
            CreatureFeeder,
            ExoticExtra1,
            ExoticExtra2,
            ExoticExtra3,
            ExoticExtra4,
            ExoticExtra5,
            ExoticExtra6,
            MapShop,
            NPC_Closure,
            StorageContainer,
            Teleporter_Nexus,
            ShipSalvage,
            ByteBeatSwitch,
            AbandonedFreighterIntro,
            AbandonedFreighterEnd,
            AbandonedFreighterProcText,
            AbandonedFreighterCaptLog,
            AbandonedFreighterCrewLog,
            AbandonedFreighterShop,
            CustomiseFreighter,
            LibraryVault,
            LibraryMainTerminal,
            LibraryMap,
            WeaponUpgrade,
            Pet,
            Creature,
            FreighterGalacticMap,
            RecipeStation,
            StationCore,
            NPC_Settlement_SpecialWorker,
            NPC_Settlement_Secondary,
            SettlementHub,
            SettlementBuildingSite,
            SettlementAdminTerminal,
            FriendlyDrone,
            DroneHive,
            RocketLocker,
            FrigateCaptain,
            PirateShop,
            NPC_PirateSecondary,
            NPC_FreighterBase_SquadronPilot,
            NPC_FreighterBase_FrigateCaptain,
            NPC_FreighterBase_Worker
        }
        [NMS(Size = 0x83, EnumType = typeof(SavedInteractionIndiciesEnum))]
        /* 0x0A410 */ public GcSavedInteractionRaceData[] SavedInteractionIndicies;
        /* 0x0B470 */ public List<GcSavedInteractionDialogData> SavedInteractionDialogTable;
        /* 0x0B480 */ public List<NMSString0x20A> InteractionProgressTable;
        [NMS(Size = 0xA)]
        /* 0x0B490 */ public GcUniverseAddressData[] AtlasStationAdressData;
        [NMS(Size = 0xB)]
        /* 0x0B580 */ public GcUniverseAddressData[] NewAtlasStationAdressData;
        /* 0x0B688 */ public List<GcUniverseAddressData> VisitedAtlasStationsData;
        /* 0x0B698 */ public bool FirstAtlasStationDiscovered;
        /* 0x0B699 */ public bool UsesThirdPersonCharacterCam;
        /* 0x0B69C */ public int ProgressionLevel;
        /* 0x0B6A0 */ public int ProcTechIndex;
        /* 0x0B6A4 */ public bool IsNew;
        /* 0x0B6A5 */ public bool UseSmallerBlackholeJumps;
        /* 0x0B6A8 */ public List<GcSavedEntitlement> UsedEntitlements;
        [NMS(Size = 0x10)]
        /* 0x0B6C0 */ public Vector3f[] PlanetPositions;
        [NMS(Size = 0x10)]
        /* 0x0B7C0 */ public GcSeed[] PlanetSeeds;
        /* 0x0B8C0 */ public int PrimaryPlanet;
        /* 0x0B8C8 */ public ulong TimeLastSpaceBattle;
        /* 0x0B8D0 */ public int WarpsLastSpaceBattle;
        /* 0x0B8D8 */ public ulong ActiveSpaceBattleUA;
        /* 0x0B8E0 */ public ulong TimeLastMiniStation;
        /* 0x0B8E8 */ public int WarpsLastMiniStation;
        /* 0x0B8F0 */ public ulong MiniStationUA;
        /* 0x0B900 */ public Vector4f AnomalyPositionOverride;
        /* 0x0B910 */ public GcUniverseAddressData GameStartAddress1;
        /* 0x0B928 */ public GcUniverseAddressData GameStartAddress2;
        [NMS(Size = 0x10)]
        /* 0x0B940 */ public bool[] GalacticMapRequests;
        /* 0x0B950 */ public Vector4f FirstShipPosition;
        /* 0x0B960 */ public ulong HazardTimeAlive;
        /* 0x0B968 */ public bool RevealBlackHoles;
        /* 0x0B970 */ public GcSeed CurrentFreighterHomeSystemSeed;
        /* 0x0B980 */ public GcResourceElement CurrentFreighter;
        /* 0x0BC28 */ public GcInventoryLayout FreighterLayout;
        /* 0x0BC48 */ public GcInventoryLayout FreighterCargoLayout;
        /* 0x0BC68 */ public GcInventoryContainer FreighterInventory;
        /* 0x0BDC0 */ public GcInventoryContainer FreighterInventory_TechOnly;
        /* 0x0BF18 */ public GcInventoryContainer FreighterInventory_Cargo;
        /* 0x0C070 */ public ulong FreighterLastSpawnTime;
        /* 0x0C078 */ public GcUniverseAddressData FreighterUniverseAddress;
        /* 0x0C090 */ public bool FreighterDismissed;
        /* 0x0C0A0 */ public Vector3f FreighterMatrixAt;
        /* 0x0C0B0 */ public Vector3f FreighterMatrixUp;
        /* 0x0C0C0 */ public Vector3f FreighterMatrixPos;
        [NMS(Size = 0x4)]
        /* 0x0C0D0 */ public bool[] SquadronUnlockedPilotSlots;
        [NMS(Size = 0x4)]
        /* 0x0C0D8 */ public GcSquadronPilotData[] SquadronPilots;
        /* 0x0D658 */ public List<NMSString0x10> SeenBaseBuildingObjects;
        /* 0x0D668 */ public List<GcPersistentBBObjectData> BaseBuildingObjects;
        /* 0x0D680 */ public GcTerrainEditsBuffer TerrainEditData;
        // size: 0x5
        public enum NPCWorkersEnum {
            WeaponsExpert,
            Farmer,
            Builder,
            Vehicles,
            Scientist
        }
        [NMS(Size = 0x5, EnumType = typeof(NPCWorkersEnum))]
        /* 0x49E00 */ public GcNPCWorkerData[] NPCWorkers;
        /* 0x4AC60 */ public List<GcPersistentBase> PersistentPlayerBases;
        /* 0x4AC70 */ public List<GcTeleportEndpoint> TeleportEndpoints;
        /* 0x4AC80 */ public GcInventoryLayout Chest1Layout;
        /* 0x4ACA0 */ public GcInventoryContainer Chest1Inventory;
        /* 0x4ADF8 */ public GcInventoryLayout Chest2Layout;
        /* 0x4AE18 */ public GcInventoryContainer Chest2Inventory;
        /* 0x4AF70 */ public GcInventoryLayout Chest3Layout;
        /* 0x4AF90 */ public GcInventoryContainer Chest3Inventory;
        /* 0x4B0E8 */ public GcInventoryLayout Chest4Layout;
        /* 0x4B108 */ public GcInventoryContainer Chest4Inventory;
        /* 0x4B260 */ public GcInventoryLayout Chest5Layout;
        /* 0x4B280 */ public GcInventoryContainer Chest5Inventory;
        /* 0x4B3D8 */ public GcInventoryLayout Chest6Layout;
        /* 0x4B3F8 */ public GcInventoryContainer Chest6Inventory;
        /* 0x4B550 */ public GcInventoryLayout Chest7Layout;
        /* 0x4B570 */ public GcInventoryContainer Chest7Inventory;
        /* 0x4B6C8 */ public GcInventoryLayout Chest8Layout;
        /* 0x4B6E8 */ public GcInventoryContainer Chest8Inventory;
        /* 0x4B840 */ public GcInventoryLayout Chest9Layout;
        /* 0x4B860 */ public GcInventoryContainer Chest9Inventory;
        /* 0x4B9B8 */ public GcInventoryLayout Chest10Layout;
        /* 0x4B9D8 */ public GcInventoryContainer Chest10Inventory;
        /* 0x4BB30 */ public GcInventoryLayout ChestMagicLayout;
        /* 0x4BB50 */ public GcInventoryContainer ChestMagicInventory;
        /* 0x4BCA8 */ public GcInventoryLayout ChestMagic2Layout;
        /* 0x4BCC8 */ public GcInventoryContainer ChestMagic2Inventory;
        /* 0x4BE20 */ public GcInventoryLayout CookingIngredientsLayout;
        /* 0x4BE40 */ public GcInventoryContainer CookingIngredientsInventory;
        /* 0x4BF98 */ public GcInventoryLayout RocketLockerLayout;
        /* 0x4BFB8 */ public GcInventoryContainer RocketLockerInventory;
        /* 0x4C110 */ public GcResourceElement CurrentFreighterNPC;
        // size: 0x7
        public enum VehicleOwnershipEnum {
            Buggy,
            Bike,
            Truck,
            WheeledBike,
            Hovercraft,
            Submarine,
            Mech
        }
        [NMS(Size = 0x7, EnumType = typeof(VehicleOwnershipEnum))]
        /* 0x4C3C0 */ public GcPlayerOwnershipData[] VehicleOwnership;
        /* 0x4F5A0 */ public int PrimaryVehicle;
        [NMS(Size = 0x9)]
        /* 0x4F5B0 */ public GcPlayerOwnershipData[] ShipOwnership;
        /* 0x535D0 */ public int PrimaryShip;
        /* 0x535D4 */ public bool MultiShipEnabled;
        /* 0x535D5 */ public bool VehicleAIControlEnabled;
        /* 0x535D6 */ public NMSString0x20 PlayerFreighterName;
        /* 0x53600 */ public Vector4f StartGameShipPosition;
        /* 0x53610 */ public bool ShipNeedsTerrainPositioning;
        /* 0x53614 */ public int TradingSupplyDataIndex;
        /* 0x53618 */ public List<GcTradingSupplyData> TradingSupplyData;
        /* 0x53628 */ public List<GcPortalSaveData> LastPortal;
        /* 0x53638 */ public GcPortalSaveData VisitedPortal;
        /* 0x53658 */ public int KnownPortalRunes;
        /* 0x5365C */ public bool OnOtherSideOfPortal;
        /* 0x53660 */ public GcTeleportEndpoint OtherSideOfPortalReturnBase;
        /* 0x536F0 */ public Vector4f PortalMarkerPosition_Local;
        /* 0x53700 */ public Vector4f PortalMarkerPosition_Offset;
        /* 0x53710 */ public GcPlayerWeapons StartingPrimaryWeapon;
        /* 0x53714 */ public GcPlayerWeapons StartingSecondaryWeapon;
        // size: 0x14
        public enum CharacterCustomisationDataEnum {
            Player,
            Vehicle,
            Weapon,
            Ship_01,
            Ship_02,
            Ship_03,
            Ship_04,
            Ship_05,
            Ship_06,
            Vehicle_Bike,
            Vehicle_Truck,
            Vehicle_WheeledBike,
            Vehicle_Hovercraft,
            Vehicle_Submarine,
            Vehicle_Mech,
            Freighter,
            Pet,
            Ship_07,
            Ship_08,
            Ship_09
        }
        [NMS(Size = 0x14, EnumType = typeof(CharacterCustomisationDataEnum))]
        /* 0x53718 */ public GcCharacterCustomisationSaveData[] CharacterCustomisationData;
        [NMS(Size = 0x9)]
        /* 0x53DF8 */ public bool[] ShipUsesLegacyColours;
        [NMS(Size = 0x3)]
        /* 0x53E08 */ public GcCharacterCustomisationData[] Outfits;
        /* 0x53EE0 */ public NMSString0x10 JetpackEffect;
        /* 0x53EF0 */ public NMSString0x10 FreighterEngineEffect;
        /* 0x53F00 */ public GcSeed FleetSeed;
        /* 0x53F10 */ public List<GcFleetFrigateSaveData> FleetFrigates;
        /* 0x53F20 */ public List<GcFleetExpeditionSaveData> FleetExpeditions;
        /* 0x53F30 */ public List<ulong> ExpeditionSeedsSelectedToday;
        /* 0x53F40 */ public ulong LastKnownDay;
        /* 0x53F48 */ public ulong SunTimer;
        /* 0x53F50 */ public ulong MultiplayerLobbyID;
        /* 0x53F58 */ public GcUniverseAddressData MultiplayerUA;
        /* 0x53F70 */ public GcPlayerSpawnStateData MultiplayerSpawn;
        /* 0x54040 */ public List<GcRepairTechData> RepairTechBuffer;
        /* 0x54050 */ public ulong MultiplayerPrivileges;
        // size: 0x3
        public enum HotActionsEnum {
            OnFoot,
            InShip,
            InExocraft
        }
        [NMS(Size = 0x3, EnumType = typeof(HotActionsEnum))]
        /* 0x54058 */ public GcHotActionsSaveData[] HotActions;
        /* 0x54508 */ public ulong LastUABeforePortalWarp;
        /* 0x54510 */ public ulong StoryPortalSeed;
        /* 0x54518 */ public ushort ShopNumber;
        /* 0x5451A */ public ushort ShopTier;
        /* 0x5451C */ public bool HasAccessToNexus;
        /* 0x54520 */ public GcUniverseAddressData NexusUniverseAddress;
        /* 0x54540 */ public Vector3f NexusMatrixAt;
        /* 0x54550 */ public Vector3f NexusMatrixUp;
        /* 0x54560 */ public Vector3f NexusMatrixPos;
        /* 0x54570 */ public GcPhotoModeSettings PhotoModeSettings;
        /* 0x545C0 */ public int BannerIcon;
        /* 0x545C4 */ public int BannerMainColour;
        /* 0x545C8 */ public int BannerBackgroundColour;
        /* 0x545D0 */ public NMSString0x10 BannerTitleId;
        /* 0x545E0 */ public int TelemetryUploadVersion;
        /* 0x545E4 */ public bool UsesThirdPersonVehicleCam;
        /* 0x545E8 */ public float VRCameraOffset;
        /* 0x545F0 */ public GcSeasonalGameModeData SeasonData;
        /* 0x579D8 */ public GcSeasonStateData SeasonState;
        /* 0x57A30 */ public bool RestartAllInactiveSeasonalMissions;
        /* 0x57A38 */ public List<NMSString0x10> RedeemedSeasonRewards;
        /* 0x57A48 */ public List<NMSString0x10> RedeemedTwitchRewards;
        /* 0x57A58 */ public List<NMSString0x10> RedeemedPlatformRewards;
        [NMS(Size = 0x64)]
        /* 0x57A70 */ public GcSettlementState[] SettlementStatesV2;
        /* 0x76E70 */ public int SettlementStateRingBufferIndexV2;
        /* 0x76E74 */ public bool NextLoadSpawnsWithFreshStart;
    }
}
