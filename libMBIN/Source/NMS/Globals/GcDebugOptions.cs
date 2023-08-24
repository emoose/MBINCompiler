using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x464037EC5024E67B, NameHash = 0x13FED27DF728C38)]
    public class GcDebugOptions : NMSTemplate
    {
        /* 0x0000 */ public bool ForceScanEventsToGoPrime;
        /* 0x0001 */ public bool SkipAbandonedFreighterUnlocking;
        /* 0x0002 */ public bool AllowSavingOnAbandonedFreighters;
        /* 0x0003 */ public bool DisableAbandonedFreighterRoomsOptimisation;
        /* 0x0008 */ public ulong OverrideAbandonedFreighterSeed;
        /* 0x0010 */ public bool ThirdPersonIsDefaultCameraForPlayer;
        /* 0x0011 */ public bool ThirdPersonIsDefaultCameraForShipAndVehicles;
        /* 0x0012 */ public bool SkipIntro;
        /* 0x0013 */ public bool SkipLogos;
        /* 0x0014 */ public bool SkipUITimers;
        /* 0x0015 */ public bool FastLoad;
        /* 0x0018 */ public int BootDirectlyIntoSaveSlot;
        /* 0x001C */ public bool BootDirectlyIntoLastSave;
        /* 0x0020 */ public GcGameMode NewSaveGameMode;
        /* 0x0024 */ public bool SkipPlanetDiscoverOnBoot;
        /* 0x0025 */ public bool VideoCaptureMode;
        /* 0x0026 */ public bool GodMode;
        /* 0x0027 */ public bool TakeNoDamage;
        /* 0x0028 */ public bool SuperKillGuns;
        /* 0x0029 */ public bool AlwaysHaveFocus;
        /* 0x002A */ public bool DisableVibration;
        /* 0x002B */ public bool DebugGalaxyMapInQuickMenu;
        /* 0x002C */ public bool MapWarpCheckIgnoreFuel;
        /* 0x002D */ public bool MapWarpCheckIgnoreDrive;
        /* 0x002E */ public bool EverythingIsFree;
        /* 0x002F */ public bool EverythingIsKnown;
        /* 0x0030 */ public bool EverythingIsStar;
        /* 0x0031 */ public bool InfiniteStamina;
        /* 0x0032 */ public bool DisableHazards;
        /* 0x0033 */ public bool IgnoreMissionRank;
        /* 0x0034 */ public bool CanLeaveDialogs;
        /* 0x0035 */ public bool DisableOldMissions;
        /* 0x0036 */ public bool UseScreenEffects;
        /* 0x0037 */ public bool UseGunImpactEffect;
        /* 0x0038 */ public bool RenderCreatureDetails;
        /* 0x0039 */ public bool SkipTutorial;
        /* 0x003A */ public bool ForceTranslateAllAlienText;
        /* 0x003B */ public bool IgnoreFreighterSpawnWarpRequirement;
        /* 0x003C */ public bool MaximumFreighterSpawns;
        /* 0x003D */ public bool AlwaysSpaceBattle;
        /* 0x0040 */ public int ForceSpaceBattleLevel;
        /* 0x0044 */ public bool DisableSaveSlotSorting;
        /* 0x0045 */ public bool DisableSaving;
        /* 0x0046 */ public bool DisableContinuousSaving;
        /* 0x0047 */ public bool DisableInvalidSaveVersion;
        /* 0x0048 */ public bool DisableStorms;
        /* 0x0049 */ public bool ForceEnableClothComponent;
        /* 0x004A */ public bool ForceDisableClothComponent;
        /* 0x004B */ public bool ClothForcePositionExtrapolationOff;
        /* 0x004C */ public bool ClothForcePositionExtrapolationOn;
        /* 0x004D */ public bool ClothForcePositionExtrapolationBackOn;
        /* 0x004E */ public bool ClothForcePositionExtrapolationUpdateOrderDependent;
        /* 0x004F */ public bool ClothForcePositionExtrapolationSyncWithFpsLock;
        /* 0x0050 */ public bool ClothForcePositionExtrapolationAntiSyncWithFpsLock;
        /* 0x0051 */ public bool ClothForceAsyncSimulationOff;
        /* 0x0052 */ public bool ClothForceAsyncSimulationOn;
        /* 0x0053 */ public bool ForceEnableSpringAttachmentComponent;
        /* 0x0054 */ public bool ForceDisableSpringAttachmentComponent;
        /* 0x0055 */ public bool ForceEnableRagdollComponent;
        /* 0x0056 */ public bool ForceDisableRagdollComponent;
        /* 0x0057 */ public bool ForceDisableNonPlayerRagdollComponents;
        /* 0x0058 */ public bool ForceEnableSplitIkOptimisation;
        /* 0x0059 */ public bool ForceDisableSplitIkOptimisation;
        /* 0x005A */ public bool DisableNPCs;
        /* 0x005B */ public bool DisableNPCHiddenUntilScanned;
        /* 0x005C */ public bool ForceBuildersAlwaysKnown;
        /* 0x0060 */ public NMSString0x10 ForceBuilderMissionBoardMission;
        /* 0x0070 */ public bool AlternateControls;
        /* 0x0071 */ public bool AlwaysShowURI;
        /* 0x0072 */ public bool MPMissionsAlwaysEPIC;
        /* 0x0073 */ public bool ShowFireteamMembersUA;
        /* 0x0074 */ public bool RevealAllTitles;
        /* 0x0075 */ public bool UnlockAllTitles;
        /* 0x0076 */ public bool LockAllTitles;
        /* 0x0077 */ public bool AlwaysAllowShipOperations;
        /* 0x0078 */ public bool AlwaysAllowVehicleOperations;
        /* 0x0079 */ public bool AlwaysAllowFreighterInventoryAccess;
        /* 0x007A */ public NMSString0x200 SeasonalDataOverrideFile;
        /* 0x027A */ public bool UnlockAllSeasonRewards;
        /* 0x027B */ public bool UnlockAllTwitchRewards;
        /* 0x027C */ public bool UnlockAllPlatformRewards;
        /* 0x027D */ public NMSString0x400 DebugTwitchRewards;
        /* 0x067D */ public bool AllowPause;
        /* 0x067E */ public bool AllSettlementsAreCompleted;
        /* 0x067F */ public bool DisableSettlements;
        /* 0x0680 */ public bool PlaceOnGroundWhenLeavingDebugCamera;
        /* 0x0681 */ public bool OctahedralImpostersEnable;
        /* 0x0682 */ public bool OctahedralImpostersDisable;
        /* 0x0683 */ public bool OctahedralImpostersViewFromSpace;
        /* 0x0684 */ public int OctahedralImpostersViewCount;
        /* 0x0688 */ public bool EnableMemoryPoolAllocPrint;
        /* 0x0689 */ public bool BlockCommunicatorSignals;
        /* 0x068A */ public bool ResetToSupportedResolution;
        /* 0x068B */ public NMSString0x100 ForceUniverseAddress;
        /* 0x078B */ public NMSString0x100 ForcePlayerPosition;
        /* 0x088B */ public bool ForceInitialShip;
        /* 0x088C */ public bool ForceInitialWeapon;
        // size: 0x3
        public enum GameStateModeEnum : uint {
            LoadPreset,
            UserStorage,
            FreshStart,
        }
        /* 0x0890 */ public GameStateModeEnum GameStateMode;
        // size: 0x7
        public enum BootModeEnum : uint {
            MinimalSolarSystem,
            SolarSystem,
            GalaxyMap,
            SmokeTest,
            SmokeTestGalaxyMap,
            Scratchpad,
            UnitTest,
        }
        /* 0x0894 */ public BootModeEnum BootMode;
        // size: 0x7
        public enum PlayerSpawnLocationOverrideEnum : uint {
            None,
            FromSettings,
            Space,
            SpaceStation,
            RandomPlanet,
            GameStartPlanet,
            SpecificLocation,
        }
        /* 0x0898 */ public PlayerSpawnLocationOverrideEnum PlayerSpawnLocationOverride;
        /* 0x089C */ public NMSString0x80 SceneSettings;
        /* 0x091C */ public NMSString0x100 WorkingDirectory;
        /* 0x0A1C */ public NMSString0x80 DebugScene;
        // size: 0x2
        public enum SolarSystemBootEnum : uint {
            FromSettings,
            Generate,
        }
        /* 0x0A9C */ public SolarSystemBootEnum SolarSystemBoot;
        // size: 0x2
        public enum ShaderPreloadEnum : uint {
            Off,
            Full,
        }
        /* 0x0AA0 */ public ShaderPreloadEnum ShaderPreload;
        /* 0x0AA4 */ public bool ShaderPreloadListExport;
        /* 0x0AA5 */ public bool ShaderPreloadListImport;
        /* 0x0AA6 */ public bool ShaderCaching;
        // size: 0x3
        public enum BootLoadDelayEnum : uint {
            LoadAll,
            WaitForPlanet,
            WaitForNothing,
        }
        /* 0x0AA8 */ public BootLoadDelayEnum BootLoadDelay;
        /* 0x0AAC */ public bool MemCsv;
        /* 0x0AB0 */ public float ForceTimeOfDay;
        /* 0x0AB4 */ public float ForceInitialTimeOfDay;
        /* 0x0AB8 */ public bool ForceSunDirectionFromPhotoMode;
        /* 0x0ABC */ public float ForceSunAngle;
        /* 0x0AC0 */ public bool ResetForcedSaveSlotOnLoad;
        /* 0x0AC1 */ public bool EnableFrontendPreload;
        /* 0x0AC2 */ public bool MissionMessageLoggingEnabled;
        /* 0x0AC3 */ public bool MissionNGUIShowsConditionResults;
        /* 0x0AC4 */ public bool UseParticles;
        /* 0x0AC5 */ public bool UseVolumetrics;
        /* 0x0AC6 */ public bool UseClouds;
        /* 0x0AC7 */ public bool EnableCloudAnimation;
        /* 0x0AC8 */ public bool UseTerrain;
        /* 0x0AC9 */ public bool UseInstances;
        /* 0x0ACA */ public bool UseObjects;
        /* 0x0ACB */ public bool UseBuildings;
        /* 0x0ACC */ public bool UseCreatures;
        /* 0x0ACD */ public bool UseElevation;
        /* 0x0ACE */ public bool UseLegacyFreighters;
        /* 0x0ACF */ public bool UseLegacyBuildingTable;
        /* 0x0AD0 */ public bool EnableDayNightCycle;
        /* 0x0AD1 */ public bool SpawnPirates;
        /* 0x0AD2 */ public bool SpawnRobots;
        /* 0x0AD3 */ public bool SpawnShips;
        /* 0x0AD4 */ public bool SpawnPulseEncounters;
        /* 0x0AD5 */ public bool InstanceCollision;
        /* 0x0AD6 */ public bool LoadMissions;
        /* 0x0AD7 */ public bool MPMissions;
        /* 0x0AD8 */ public bool SpecialsShop;
        /* 0x0AD9 */ public bool MultiplePlayerFreightersInASystem;
        /* 0x0ADA */ public bool ForceNexusInQuickMenu;
        /* 0x0ADB */ public bool MissionSurveyEnabled;
        /* 0x0ADC */ public bool AllSeasonMilestonesShowComplete;
        /* 0x0ADD */ public bool EnableGalaxyRecolouring;
        /* 0x0ADE */ public bool IgnoreSteamDev;
        /* 0x0ADF */ public bool EnableBaseBuildingExpandables;
        /* 0x0AE0 */ public bool MouseLookEnabled;
        /* 0x0AE1 */ public bool StartPaused;
        /* 0x0AE2 */ public bool DisableDebugControls;
        /* 0x0AE3 */ public bool FixedFramerate;
        /* 0x0AE4 */ public bool ScreenshotMode;
        /* 0x0AE5 */ public bool RenderHud;
        /* 0x0AE6 */ public bool DisableDiscoveryNaming;
        /* 0x0AE7 */ public bool DebugDrawPlayerInteract;
        /* 0x0AE8 */ public bool ForceInteractionToSettings;
        /* 0x0AEC */ public int ForceInteractionIndex;
        /* 0x0AF0 */ public bool InteractionsAllwaysGivesTech;
        /* 0x0AF1 */ public bool InfiniteInteractions;
        /* 0x0AF2 */ public bool StopSwitchingToSecondaryInteractions;
        /* 0x0AF4 */ public TkLanguages DebugLanguage;
        /* 0x0AF8 */ public NMSString0x20 AllowedLanguagesFile;
        /* 0x0B18 */ public bool DoAlienLanguage;
        /* 0x0B1C */ public GcAlienRace ForceInteractionRaceTo;
        // size: 0x2
        public enum RealityModeEnum : uint {
            LoadPreset,
            Generate,
        }
        /* 0x0B20 */ public RealityModeEnum RealityMode;
        /* 0x0B24 */ public bool DebugPersistentInteractions;
        /* 0x0B25 */ public bool UseHighlightedOptionStyle;
        /* 0x0B26 */ public bool DisableMissionShop;
        /* 0x0B27 */ public NMSString0x80 RealityPresetFile;
        /* 0x0BA8 */ public ushort RealityGenerationIteration;
        /* 0x0BB0 */ public List<NMSString0x20> LocTableList;
        /* 0x0BC0 */ public NMSString0x80 DefaultSaveData;
        /* 0x0C40 */ public bool FormatDownloadStorageAreaOnBoot;
        /* 0x0C41 */ public bool ForceBasicLoadScreen;
        /* 0x0C44 */ public float BootLogoFadeRate;
        /* 0x0C48 */ public bool BootMusic;
        /* 0x0C4C */ public float WeaponScale3P;
        /* 0x0C50 */ public bool LogMissingLocalisedText;
        /* 0x0C51 */ public bool FleetDirectorAutoMode;
        /* 0x0C54 */ public float _3dTextDistance;
        /* 0x0C58 */ public float _3dTextMinScale;
        // size: 0x3
        public enum RecordSettingEnum : uint {
            None,
            Record,
            Playback,
        }
        /* 0x0C5C */ public RecordSettingEnum RecordSetting;
        /* 0x0C60 */ public bool DebugBuildingSpawns;
        /* 0x0C61 */ public bool StressTestLongNameDisplay;
        /* 0x0C62 */ public bool ShowLongestStrings;
        /* 0x0C63 */ public NMSString0x20 SaveTestingCommand;
        /* 0x0C83 */ public bool NeverUseBanks;
        /* 0x0C84 */ public bool HangOnCrash;
        /* 0x0C85 */ public bool DisableProfanityFilter;
        /* 0x0C86 */ public bool DisableFileWatcher;
        /* 0x0C87 */ public bool DisableShaderReload;
        /* 0x0C88 */ public int RecurrenceTimeOffset;
        /* 0x0C90 */ public ulong ForceTimeToEpoch;
        /* 0x0C98 */ public NMSString0x80 CrashDumpPath;
        /* 0x0D18 */ public NMSString0x20 CrashDumpIdentifier;
        /* 0x0D38 */ public bool DebugThreatLevels;
        /* 0x0D39 */ public bool DumpManifestContents;
        /* 0x0D3A */ public bool ShowDebugMessages;
        /* 0x0D3B */ public bool ShowFramerate;
        /* 0x0D3C */ public bool ShowGPURenderTime;
        /* 0x0D3D */ public bool ShowDynamicResScale;
        /* 0x0D3E */ public bool PrintAvgFrameTimes;
        /* 0x0D3F */ public bool ShowPositionDebug;
        /* 0x0D40 */ public bool ShowGPUMemory;
        /* 0x0D41 */ public bool ShowMempoolOverlay;
        /* 0x0D42 */ public bool ShowMouseSmoothing;
        /* 0x0D43 */ public NMSString0x100 ShowUniverseAddressOnGalaxyMap;
        /* 0x0E43 */ public bool ShowGraphs;
        /* 0x0E44 */ public int ShowSpecificGraph;
        /* 0x0E48 */ public bool GraphCommandBuffer;
        /* 0x0E49 */ public bool GraphGeneration;
        /* 0x0E4A */ public bool GraphFPS;
        /* 0x0E4B */ public bool GraphTexStreaming;
        /* 0x0E4C */ public bool SmokeTestDumpStatsMode;
        // size: 0x7
        public enum SmokeTestCycleModeEnum : uint {
            None,
            TourPlanet,
            TourSolarSystem,
            TourGalaxy,
            TourUDAs,
            TourShortUDAs,
            TourRandomWarps,
        }
        /* 0x0E50 */ public SmokeTestCycleModeEnum SmokeTestCycleMode;
        // size: 0x8
        public enum SmokeTestScenarioEnum : uint {
            None,
            TerrainSnapShotFromAltitude,
            BelowCloudLayerSnapShot,
            Flying,
            UltraBiomeSnapShot,
            Walking,
            LeakDetector,
            WalkingSnapshot,
        }
        /* 0x0E54 */ public SmokeTestScenarioEnum SmokeTestScenario;
        /* 0x0E58 */ public bool SmokeTestLegacyOutput;
        /* 0x0E5C */ public int SmokeTestConfigPlanetPositionCount;
        /* 0x0E60 */ public float SmokeTestConfigScenarioPreambleLength;
        /* 0x0E64 */ public float SmokeTestConfigScenarioLength;
        /* 0x0E68 */ public bool SmokeTestFastExit;
        /* 0x0E69 */ public bool SmokeTestCameraFly;
        /* 0x0E6A */ public bool SmokeTestOutputOnly;
        /* 0x0E6B */ public bool SmokeTestPureFlight;
        /* 0x0E6C */ public int SmokeTestConfigCaptureCycles;
        /* 0x0E70 */ public float SmokeTestConfigCaptureDurationInSeconds;
        /* 0x0E74 */ public int SmokeTestConfigCaptureFolderNameNumberOffset;
        /* 0x0E78 */ public bool SmokeTestConfigRandomizePlanetSeed;
        /* 0x0E79 */ public bool SmokeTestSmokeBotEnabled;
        /* 0x0E7C */ public int SmokeTestSmokeBotTargetWarps;
        /* 0x0E80 */ public bool SmokeTestPostBandwidthStats;
        /* 0x0E81 */ public NMSString0x20 SmokeTestForcePlanetDetail;
        /* 0x0EA1 */ public NMSString0x20 SmokeTestRunFolder;
        /* 0x0EC1 */ public bool CreatureChatter;
        /* 0x0EC2 */ public bool CreatureErrors;
        /* 0x0EC3 */ public bool CreatureDrawVocals;
        /* 0x0EC4 */ public bool DrawCreaturesInRoutines;
        /* 0x0EC5 */ public bool CompressTextures;
        /* 0x0EC6 */ public bool DebugIBL;
        /* 0x0EC7 */ public bool DebugSpotlights;
        /* 0x0EC8 */ public bool DebugTerrainTextures;
        /* 0x0EC9 */ public bool DisableShadowSwitching;
        /* 0x0ECA */ public NMSString0x80 PipelineFile;
        /* 0x0F4A */ public NMSString0x80 PipelineFileApple;
        /* 0x0FCA */ public NMSString0x80 PipelineFilePS4;
        /* 0x104A */ public NMSString0x80 PipelineFileXboxOne;
        /* 0x10CA */ public NMSString0x80 PipelineFileVR;
        /* 0x114A */ public NMSString0x80 PipelineFileVRPS4;
        /* 0x11CA */ public NMSString0x80 PipelineFileFrontend;
        /* 0x124A */ public NMSString0x80 PipelineFileEditor;
        /* 0x12CA */ public NMSString0x80 PipelineFileSwitch;
        /* 0x134A */ public NMSString0x80 PipelineFileSwitchFSR2;
        /* 0x13CA */ public bool RenderLowFramerate;
        /* 0x13CB */ public bool EnableComputePost;
        /* 0x13CC */ public bool EnableEvenOddRender;
        /* 0x13CD */ public bool Proto2DevKit;
        /* 0x13CE */ public bool LoadShaderSourceIfRenderdocEnabled;
        /* 0x13CF */ public bool AlwaysIncludeLocalPlayerInChatMessage;
        /* 0x13D0 */ public bool SimulateNoNetworkConnection;
        // size: 0x3
        public enum ProxyTypeEnum : uint {
            None,
            ManualURI,
            InetProxy,
        }
        /* 0x13D4 */ public ProxyTypeEnum ProxyType;
        /* 0x13D8 */ public NMSString0x80 ProxyURI;
        // size: 0x8
        public enum ServerEnvEnum : uint {
            Default,
            dev,
            qa,
            prodqa,
            prod,
            custom,
            pentest,
            merged,
        }
        /* 0x1458 */ public ServerEnvEnum ServerEnv;
        /* 0x145C */ public NMSString0x80 AuthBaseUrl;
        /* 0x14DC */ public bool CertificateSecurityBypass;
        /* 0x14DD */ public NMSString0x20 OverrideUsernameForDev;
        /* 0x1500 */ public int DiscoveryAutoSyncIntervalSeconds;
        /* 0x1504 */ public bool DisableSpaceStationSpawnOnJoin;
        /* 0x1505 */ public bool AutoJoinUserEnabled;
        /* 0x1506 */ public NMSString0x800 AutoJoinUserNames;
        /* 0x1D06 */ public bool AlwaysSaveGameAsClient;
        /* 0x1D07 */ public bool DisableMonumentDownloads;
        /* 0x1D08 */ public bool UsePadOnUnfocusedWindow;
        /* 0x1D0C */ public int OverrideMatchmakingVersion;
        /* 0x1D10 */ public NMSString0x200 LoadToBase;
        /* 0x1F10 */ public bool IgnoreTransactionTimeouts;
        /* 0x1F11 */ public bool AutoJoinRandomGames;
        /* 0x1F12 */ public NMSString0x100 GOGLogin;
        /* 0x2012 */ public bool RecordNetworkStatsOnBoot;
        /* 0x2013 */ public bool FakeHandsInMultiplayer;
        /* 0x2014 */ public bool ForceSmallLobby;
        /* 0x2015 */ public bool ForceTinyLobby;
        /* 0x2018 */ public int OverrideServerSeasonNumber;
        /* 0x201C */ public int OverrideServerSeasonEndTime;
        /* 0x2020 */ public bool EnableSynergy;
        /* 0x2021 */ public NMSString0x20 SynergyServer;
        /* 0x2044 */ public int SynergyPort;
        /* 0x2048 */ public bool ShowEditorPlacementPreview;
        /* 0x204C */ public int MaxNumDebugMessages;
        /* 0x2050 */ public bool PreloadToolbox;
        /* 0x2054 */ public int DebugTextureSize;
        /* 0x2058 */ public bool UseProcTextureDebugger;
        /* 0x205C */ public int ProceduralModelsShown;
        /* 0x2060 */ public int ProceduralModelBatchSize;
        /* 0x2064 */ public int ProceduralModelFilterMatchretryCount;
        /* 0x2068 */ public bool ProceduralModelsDeterministicSequence;
        /* 0x206C */ public int ProceduralModelsThumbnailSize;
        /* 0x2070 */ public NMSString0x80 DebugFont;
        /* 0x20F0 */ public NMSString0x80 DebugFontTexture;
        /* 0x2170 */ public NMSString0x80 CursorTexture;
        /* 0x21F0 */ public NMSString0x80 PauseTexture;
        /* 0x2270 */ public NMSString0x80 PlayTexture;
        /* 0x22F0 */ public NMSString0x80 StepTexture;
        /* 0x2370 */ public NMSString0x80 RenderToTexture;
        /* 0x23F0 */ public bool HmdFrameShiftEnabled;
        /* 0x23F1 */ public bool HmdUseSolidGuiPointer;
        /* 0x23F2 */ public bool BodyTurning;
        /* 0x23F3 */ public bool ShowHmdHandControllers;
        /* 0x23F4 */ public bool ShowTeleportEffectLocally;
        /* 0x23F5 */ public bool DisableLeftHand;
        /* 0x23F6 */ public bool DisableHeadConstraints;
        /* 0x23F7 */ public bool EnablePhotomodeVR;
        /* 0x23F8 */ public bool AllowNGuiVR;
        /* 0x23F9 */ public bool ForceExtremeWeather;
        /* 0x23FA */ public bool ForceExtremeSentinels;
        /* 0x23FB */ public bool ForceCorruptSentinels;
        /* 0x23FC */ public bool ForceStarType;
        /* 0x23FD */ public bool ForceLoadAllWeather;
        /* 0x2400 */ public GcGalaxyStarTypes ForceStarTypeTo;
        /* 0x2404 */ public bool ForceBiome;
        /* 0x2408 */ public GcBiomeType ForceBiomeTo;
        /* 0x240C */ public bool ForceScreenFilter;
        /* 0x2410 */ public GcScreenFilters ForceScreenFilterTo;
        /* 0x2414 */ public GcBiomeSubType ForceBiomeSubTypeTo;
        /* 0x2418 */ public bool ForceBuildingRace;
        /* 0x241C */ public GcAlienRace ForceBuildingRaceTo;
        /* 0x2420 */ public bool ForceLifeLevel;
        /* 0x2424 */ public GcPlanetLife ForceLifeLevelTo;
        /* 0x2428 */ public bool ForceCreatureLifeLevel;
        /* 0x2429 */ public bool ForceDefaultCreatureFile;
        /* 0x2430 */ public NMSString0x10 DefaultGroundCreatureTable;
        /* 0x2440 */ public NMSString0x10 DefaultAirCreatureTable;
        /* 0x2450 */ public NMSString0x10 DefaultWaterCreatureTable;
        /* 0x2460 */ public NMSString0x10 DefaultCaveCreatureTable;
        /* 0x2470 */ public GcPlanetLife ForceCreatureLifeLevelTo;
        /* 0x2474 */ public GcPlanetLife ForceTerrainSettings;
        /* 0x2478 */ public bool ForceTerrainType;
        /* 0x247C */ public TkVoxelGeneratorSettingsTypes ForceTerrainTypeTo;
        /* 0x2480 */ public bool ForcePirateSystem;
        /* 0x2481 */ public bool ForcePrimeTerrain;
        /* 0x2482 */ public bool ForceBinaryStar;
        /* 0x2483 */ public bool ForceTernaryStar;
        /* 0x2484 */ public GcGalaxyStarAnomaly ForceAnomalyTo;
        /* 0x2488 */ public bool ForcePlanetsToHaveWater;
        /* 0x248C */ public int ForceWaterObjectFileIndex;
        /* 0x2490 */ public int ForceSkyColourIndex;
        /* 0x2494 */ public int ForceSpaceSkyColourIndex;
        /* 0x2498 */ public bool ForceSpaceSkyColourRare;
        /* 0x249C */ public int ForceWaterColourIndex;
        /* 0x24A0 */ public int ForceGrassColourIndex;
        /* 0x24A4 */ public bool ModifyPlanetsInInitialSystems;
        /* 0x24A5 */ public bool ForcePlanetsToHaveNoWater;
        /* 0x24A6 */ public bool ForcePlanetsToHaveNoCaves;
        /* 0x24A7 */ public bool ForcePlanetsToHaveNoNoiseLayers;
        /* 0x24A8 */ public bool ForcePlanetsToHaveNoTerrainFeatures;
        /* 0x24A9 */ public bool ForceRareAsteroidSystem;
        /* 0x24AC */ public int ForceAsteroidSystemIndex;
        /* 0x24B0 */ public bool DisableLimits;
        /* 0x24B1 */ public bool LimitPerRegionInstances;
        /* 0x24B2 */ public bool LimitPerRegionBodies;
        /* 0x24B3 */ public bool LimitGlobalInstances;
        /* 0x24B4 */ public bool LimitGlobalBodies;
        /* 0x24B8 */ public int GenerateFarLodBuildingDist;
        /* 0x24BC */ public bool DeferRegionBodies;
        /* 0x24C0 */ public float GenerateCostDistance;
        /* 0x24C4 */ public float GenerateCostAngle;
        /* 0x24C8 */ public float GenerateCostLOD;
        /* 0x24CC */ public float GenerateCostWait;
        /* 0x24D0 */ public bool DChecksEnabled;
        /* 0x24D1 */ public bool DChecksOutputJson;
        /* 0x24D2 */ public bool DChecksOutputBinary;
        /* 0x24D3 */ public bool DChecksOutputFileLine;
        /* 0x24D4 */ public bool DisableBaseBuilding;
        /* 0x24D5 */ public bool DisableBaseBuildingLimits;
        /* 0x24D6 */ public bool AllowGlobalPartSnapping;
        /* 0x24D8 */ public float BaseDownloadTimeout;
        /* 0x24DC */ public bool DisableBasePowerRequirements;
        /* 0x24DD */ public bool EnableBaseMovingOption;
        /* 0x24E0 */ public int MoveBaseIndex;
        /* 0x24E4 */ public NMSString0x20 AutomaticPartSpawnID;
        /* 0x2504 */ public GcBaseBuildingPartStyle AutomaticPartSpawnStyle;
        /* 0x2508 */ public bool AutomaticPartSpawnInactive;
        /* 0x250C */ public int ProfilerPartIndexPhase;
        /* 0x2510 */ public int ProfilerPartIndexStride;
        /* 0x2514 */ public int ProfilerPartIteration;
        /* 0x2518 */ public bool BaseAdmin;
        /* 0x2519 */ public NMSString0x20 BaseServerPlatform;
        /* 0x253C */ public uint BasePayloadMultiplier;
        /* 0x2540 */ public bool CrossPlatformFeaturedBases;
        /* 0x2541 */ public bool ShowMissionIdInTitle;
        /* 0x2544 */ public TkGlobals ToolkitGlobals;
        /* 0x27E0 */ public bool AllowOverrideSettlementOwnership;
        /* 0x27E1 */ public NMSString0x40 OverrideSettlementOwnershipUsername;
        /* 0x2821 */ public NMSString0x40 OverrideSettlementOwnershipOnlineId;
        /* 0x2861 */ public bool BlockSettlementsNetwork;
        /* 0x2862 */ public bool EnableAccessibleUI;
        /* 0x2863 */ public bool DisablePartialStories;
        /* 0x2864 */ public bool UnlockAllStories;
        /* 0x2865 */ public bool UnlockAllWords;
        /* 0x2866 */ public NMSString0x40 ScreenshotForUploadName;
        /* 0x28A8 */ public int ScreenshotForUploadWidth;
        /* 0x28AC */ public int ScreenshotForUploadHeight;
        /* 0x28B0 */ public int MultipleFingersSamePressFrameDelta;
        /* 0x28B4 */ public int SwipeDetectionMaxFrames;
        /* 0x28B8 */ public float SwipeDetectionNormalizedTravelThreshold;
        /* 0x28BC */ public float PanDeadzone;
    }
}
