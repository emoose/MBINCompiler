using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x8F1BAECA637BE7FE, NameHash = 0x13FED27DF728C38)]
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
        /* 0x003A */ public bool IgnoreFreighterSpawnWarpRequirement;
        /* 0x003B */ public bool MaximumFreighterSpawns;
        /* 0x003C */ public bool DisableSaveSlotSorting;
        /* 0x003D */ public bool DisableSaving;
        /* 0x003E */ public bool DisableContinuousSaving;
        /* 0x003F */ public bool DisableInvalidSaveVersion;
        /* 0x0040 */ public bool DisableStorms;
        /* 0x0041 */ public bool ForceEnableClothComponent;
        /* 0x0042 */ public bool ForceDisableClothComponent;
        /* 0x0043 */ public bool ClothForcePositionExtrapolationOff;
        /* 0x0044 */ public bool ClothForcePositionExtrapolationOn;
        /* 0x0045 */ public bool ClothForcePositionExtrapolationBackOn;
        /* 0x0046 */ public bool ClothForcePositionExtrapolationUpdateOrderDependent;
        /* 0x0047 */ public bool ClothForcePositionExtrapolationSyncWithFpsLock;
        /* 0x0048 */ public bool ClothForcePositionExtrapolationAntiSyncWithFpsLock;
        /* 0x0049 */ public bool ClothForceAsyncSimulationOff;
        /* 0x004A */ public bool ClothForceAsyncSimulationOn;
        /* 0x004B */ public bool ForceEnableSpringAttachmentComponent;
        /* 0x004C */ public bool ForceDisableSpringAttachmentComponent;
        /* 0x004D */ public bool ForceEnableRagdollComponent;
        /* 0x004E */ public bool ForceDisableRagdollComponent;
        /* 0x004F */ public bool ForceDisableNonPlayerRagdollComponents;
        /* 0x0050 */ public bool ForceEnableSplitIkOptimisation;
        /* 0x0051 */ public bool ForceDisableSplitIkOptimisation;
        /* 0x0052 */ public bool SampleCollisionWithCamera;
        /* 0x0053 */ public bool ShowPlayerCollisions;
        /* 0x0054 */ public bool DisableNPCs;
        /* 0x0055 */ public bool DisableNPCHiddenUntilScanned;
        /* 0x0056 */ public bool AlternateControls;
        /* 0x0057 */ public bool AlwaysShowURI;
        /* 0x0058 */ public bool MPMissionsAlwaysEPIC;
        /* 0x0059 */ public bool ShowFireteamMembersUA;
        /* 0x005A */ public bool RevealAllTitles;
        /* 0x005B */ public bool UnlockAllTitles;
        /* 0x005C */ public bool LockAllTitles;
        /* 0x005D */ public bool AlwaysAllowShipOperations;
        /* 0x005E */ public bool AlwaysAllowVehicleOperations;
        /* 0x005F */ public bool AlwaysAllowFreighterInventoryAccess;
        /* 0x0060 */ public NMSString0x200 SeasonalDataOverrideFile;
        /* 0x0260 */ public bool UnlockAllSeasonRewards;
        /* 0x0261 */ public bool UnlockAllTwitchRewards;
        /* 0x0262 */ public bool UnlockAllPlatformRewards;
        /* 0x0263 */ public NMSString0x400 DebugTwitchRewards;
        /* 0x0663 */ public bool AllowPause;
        /* 0x0664 */ public bool AllSettlementsAreCompleted;
        /* 0x0665 */ public bool DisableSettlements;
        /* 0x0666 */ public bool PlaceOnGroundWhenLeavingDebugCamera;
        /* 0x0667 */ public bool OctahedralImpostersEnable;
        /* 0x0668 */ public bool OctahedralImpostersDisable;
        /* 0x0669 */ public bool OctahedralImpostersViewFromSpace;
        /* 0x066C */ public int OctahedralImpostersViewCount;
        /* 0x0670 */ public bool EnableMemoryPoolAllocPrint;
        /* 0x0671 */ public bool UseDebugScreenSettings;
        /* 0x0674 */ public int ScreenWidth;
        /* 0x0678 */ public int ScreenHeight;
        /* 0x067C */ public bool DisableVSync;
        // size: 0x3
        public enum GameWindowModeEnum : uint {
            Bordered,
            Borderless,
            Fullscreen,
        }
        /* 0x0680 */ public GameWindowModeEnum GameWindowMode;
        /* 0x0684 */ public int Monitor;
        /* 0x0688 */ public int TiledWindowsSplitCount;
        /* 0x068C */ public int TiledWindowsIndex;
        /* 0x0690 */ public bool ResetToSupportedResolution;
        /* 0x0691 */ public NMSString0x100 ForceUniverseAddress;
        /* 0x0791 */ public NMSString0x100 ForcePlayerPosition;
        /* 0x0891 */ public bool ForceInitialShip;
        /* 0x0892 */ public bool ForceInitialWeapon;
        // size: 0x3
        public enum GameStateModeEnum : uint {
            LoadPreset,
            UserStorage,
            FreshStart,
        }
        /* 0x0894 */ public GameStateModeEnum GameStateMode;
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
        /* 0x0898 */ public BootModeEnum BootMode;
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
        /* 0x089C */ public PlayerSpawnLocationOverrideEnum PlayerSpawnLocationOverride;
        /* 0x08A0 */ public NMSString0x80 SceneSettings;
        /* 0x0920 */ public NMSString0x100 WorkingDirectory;
        /* 0x0A20 */ public NMSString0x80 DebugScene;
        // size: 0x2
        public enum SolarSystemBootEnum : uint {
            FromSettings,
            Generate,
        }
        /* 0x0AA0 */ public SolarSystemBootEnum SolarSystemBoot;
        // size: 0x2
        public enum ShaderPreloadEnum : uint {
            Off,
            Full,
        }
        /* 0x0AA4 */ public ShaderPreloadEnum ShaderPreload;
        /* 0x0AA8 */ public bool ShaderPreloadListExport;
        /* 0x0AA9 */ public bool ShaderPreloadListImport;
        /* 0x0AAA */ public bool ShaderCaching;
        // size: 0x3
        public enum BootLoadDelayEnum : uint {
            LoadAll,
            WaitForPlanet,
            WaitForNothing,
        }
        /* 0x0AAC */ public BootLoadDelayEnum BootLoadDelay;
        /* 0x0AB0 */ public bool MemCsv;
        /* 0x0AB4 */ public float ForceTimeOfDay;
        /* 0x0AB8 */ public float ForceInitialTimeOfDay;
        /* 0x0ABC */ public bool ForceSunDirectionFromPhotoMode;
        /* 0x0AC0 */ public float ForceSunAngle;
        /* 0x0AC4 */ public bool ResetForcedSaveSlotOnLoad;
        /* 0x0AC5 */ public bool EnableFrontendPreload;
        /* 0x0AC6 */ public bool MissionMessageLoggingEnabled;
        /* 0x0AC7 */ public bool MissionNGUIShowsConditionResults;
        /* 0x0AC8 */ public bool UseParticles;
        /* 0x0AC9 */ public bool UseVolumetrics;
        /* 0x0ACA */ public bool UseClouds;
        /* 0x0ACB */ public bool EnableCloudAnimation;
        /* 0x0ACC */ public bool UseTerrain;
        /* 0x0ACD */ public bool UseInstances;
        /* 0x0ACE */ public bool UseObjects;
        /* 0x0ACF */ public bool UseBuildings;
        /* 0x0AD0 */ public bool UseCreatures;
        /* 0x0AD1 */ public bool UseElevation;
        /* 0x0AD2 */ public bool UseLegacyFreighters;
        /* 0x0AD3 */ public bool UseLegacyBuildingTable;
        /* 0x0AD4 */ public bool EnableDayNightCycle;
        /* 0x0AD5 */ public bool SpawnPirates;
        /* 0x0AD6 */ public bool SpawnRobots;
        /* 0x0AD7 */ public bool SpawnShips;
        /* 0x0AD8 */ public bool SpawnPulseEncounters;
        /* 0x0AD9 */ public bool InstanceCollision;
        /* 0x0ADA */ public bool LoadMissions;
        /* 0x0ADB */ public bool MPMissions;
        /* 0x0ADC */ public bool SpecialsShop;
        /* 0x0ADD */ public bool MultiplePlayerFreightersInASystem;
        /* 0x0ADE */ public bool ForceNexusInQuickMenu;
        /* 0x0ADF */ public bool MissionSurveyEnabled;
        /* 0x0AE0 */ public bool AllSeasonMilestonesShowComplete;
        /* 0x0AE1 */ public bool EnableGalaxyRecolouring;
        /* 0x0AE2 */ public bool IgnoreSteamDev;
        /* 0x0AE3 */ public bool EnableBaseBuildingExpandables;
        /* 0x0AE4 */ public bool MouseLookEnabled;
        /* 0x0AE5 */ public bool StartPaused;
        /* 0x0AE6 */ public bool DisableDebugControls;
        /* 0x0AE7 */ public bool FixedFramerate;
        /* 0x0AE8 */ public bool ScreenshotMode;
        /* 0x0AE9 */ public bool RenderHud;
        /* 0x0AEA */ public bool DisableDiscoveryNaming;
        /* 0x0AEB */ public bool DebugDrawPlayerInteract;
        /* 0x0AEC */ public bool ForceInteractionToSettings;
        /* 0x0AF0 */ public int ForceInteractionIndex;
        /* 0x0AF4 */ public bool InteractionsAllwaysGivesTech;
        /* 0x0AF5 */ public bool InfiniteInteractions;
        /* 0x0AF6 */ public bool StopSwitchingToSecondaryInteractions;
        /* 0x0AF8 */ public TkLanguages DebugLanguage;
        /* 0x0AFC */ public NMSString0x20 AllowedLanguagesFile;
        /* 0x0B1C */ public bool DoAlienLanguage;
        /* 0x0B20 */ public GcAlienRace ForceInteractionRaceTo;
        // size: 0x2
        public enum RealityModeEnum : uint {
            LoadPreset,
            Generate,
        }
        /* 0x0B24 */ public RealityModeEnum RealityMode;
        /* 0x0B28 */ public bool DebugPersistentInteractions;
        /* 0x0B29 */ public bool UseHighlightedOptionStyle;
        /* 0x0B2A */ public bool DisableMissionShop;
        /* 0x0B2B */ public NMSString0x80 RealityPresetFile;
        /* 0x0BAC */ public ushort RealityGenerationIteration;
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
        /* 0x0C84 */ public bool DisableProfanityFilter;
        /* 0x0C85 */ public bool DisableFileWatcher;
        /* 0x0C86 */ public bool DisableShaderReload;
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
        /* 0x0E7A */ public bool SmokeTestSmokeBotAutoStart;
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
        /* 0x134A */ public bool RenderLowFramerate;
        /* 0x134B */ public bool EnableComputePost;
        /* 0x134C */ public bool EnableEvenOddRender;
        /* 0x134D */ public bool MinGPUMode;
        /* 0x134E */ public bool ForceGPUPreset;
        // size: 0xD
        public enum ForceGPUPresetToEnum : uint {
            PC_Low,
            PC_Medium,
            PC_High,
            PC_Ultra,
            PS4,
            PS4VR,
            PS4Pro,
            PS4ProVR,
            XB1,
            XB1X,
            Oberon,
            MacOS,
            iOS,
        }
        /* 0x1350 */ public ForceGPUPresetToEnum ForceGPUPresetTo;
        /* 0x1354 */ public bool Proto2DevKit;
        /* 0x1355 */ public bool AlwaysIncludeLocalPlayerInChatMessage;
        /* 0x1356 */ public bool SimulateNoNetworkConnection;
        // size: 0x3
        public enum ProxyTypeEnum : uint {
            None,
            ManualURI,
            InetProxy,
        }
        /* 0x1358 */ public ProxyTypeEnum ProxyType;
        /* 0x135C */ public NMSString0x80 ProxyURI;
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
        /* 0x13DC */ public ServerEnvEnum ServerEnv;
        /* 0x13E0 */ public NMSString0x80 AuthBaseUrl;
        /* 0x1460 */ public bool CertificateSecurityBypass;
        /* 0x1461 */ public NMSString0x20 OverrideUsernameForDev;
        /* 0x1484 */ public int DiscoveryAutoSyncIntervalSeconds;
        /* 0x1488 */ public bool DisableSpaceStationSpawnOnJoin;
        /* 0x1489 */ public bool AutoJoinUserEnabled;
        /* 0x148A */ public NMSString0x800 AutoJoinUserNames;
        /* 0x1C8A */ public bool AlwaysSaveGameAsClient;
        /* 0x1C8B */ public bool DisableMonumentDownloads;
        /* 0x1C8C */ public bool UsePadOnUnfocusedWindow;
        /* 0x1C90 */ public int OverrideMatchmakingVersion;
        /* 0x1C94 */ public NMSString0x200 LoadToBase;
        /* 0x1E94 */ public bool IgnoreTransactionTimeouts;
        /* 0x1E95 */ public bool AutoJoinRandomGames;
        /* 0x1E96 */ public NMSString0x100 GOGLogin;
        /* 0x1F96 */ public bool RecordNetworkStatsOnBoot;
        /* 0x1F97 */ public bool FakeHandsInMultiplayer;
        /* 0x1F98 */ public bool ForceSmallLobby;
        /* 0x1F99 */ public bool ForceTinyLobby;
        /* 0x1F9C */ public int OverrideServerSeasonNumber;
        /* 0x1FA0 */ public int OverrideServerSeasonEndTime;
        /* 0x1FA4 */ public bool EnableSynergy;
        /* 0x1FA5 */ public NMSString0x20 SynergyServer;
        /* 0x1FC8 */ public int SynergyPort;
        /* 0x1FCC */ public bool ShowEditorPlacementPreview;
        /* 0x1FD0 */ public int MaxNumDebugMessages;
        /* 0x1FD4 */ public bool PreloadToolbox;
        /* 0x1FD8 */ public int DebugTextureSize;
        /* 0x1FDC */ public bool UseProcTextureDebugger;
        /* 0x1FE0 */ public int ProceduralModelsShown;
        /* 0x1FE4 */ public int ProceduralModelBatchSize;
        /* 0x1FE8 */ public int ProceduralModelFilterMatchretryCount;
        /* 0x1FEC */ public bool ProceduralModelsDeterministicSequence;
        /* 0x1FF0 */ public int ProceduralModelsThumbnailSize;
        /* 0x1FF4 */ public NMSString0x80 DebugFont;
        /* 0x2074 */ public NMSString0x80 DebugFontTexture;
        /* 0x20F4 */ public NMSString0x80 CursorTexture;
        /* 0x2174 */ public NMSString0x80 PauseTexture;
        /* 0x21F4 */ public NMSString0x80 PlayTexture;
        /* 0x2274 */ public NMSString0x80 StepTexture;
        /* 0x22F4 */ public NMSString0x80 RenderToTexture;
        /* 0x2374 */ public bool HmdEnable;
        /* 0x2378 */ public int HmdPreviewScale;
        /* 0x237C */ public bool HmdTracking;
        /* 0x237D */ public bool HmdStereoRender;
        /* 0x237E */ public bool HmdDistortionPassthru;
        /* 0x2380 */ public int HmdMonitor;
        /* 0x2384 */ public int HmdEyeBufferWidth;
        /* 0x2388 */ public int HmdEyeBufferHeight;
        /* 0x238C */ public float HmdEyeScalePos;
        /* 0x2390 */ public float HmdHeadScalePos;
        /* 0x2394 */ public bool HmdFrameShiftEnabled;
        /* 0x2395 */ public bool HmdUseSolidGuiPointer;
        /* 0x2396 */ public bool BodyTurning;
        /* 0x2398 */ public float HmdImmersionFactor;
        /* 0x239C */ public bool ShowHmdHandControllers;
        /* 0x239D */ public bool ShowTeleportEffectLocally;
        /* 0x239E */ public bool DisableLeftHand;
        /* 0x239F */ public bool DisableHeadConstraints;
        /* 0x23A0 */ public bool EnablePhotomodeVR;
        /* 0x23A1 */ public bool AllowNGuiVR;
        /* 0x23A2 */ public bool ForceExtremeWeather;
        /* 0x23A3 */ public bool ForceExtremeSentinels;
        /* 0x23A4 */ public bool ForceCorruptSentinels;
        /* 0x23A5 */ public bool ForceStarType;
        /* 0x23A6 */ public bool ForceLoadAllWeather;
        /* 0x23A8 */ public GcGalaxyStarTypes ForceStarTypeTo;
        /* 0x23AC */ public bool ForceBiome;
        /* 0x23B0 */ public GcBiomeType ForceBiomeTo;
        /* 0x23B4 */ public bool ForceScreenFilter;
        /* 0x23B8 */ public GcScreenFilters ForceScreenFilterTo;
        /* 0x23BC */ public GcBiomeSubType ForceBiomeSubTypeTo;
        /* 0x23C0 */ public bool ForceBuildingRace;
        /* 0x23C4 */ public GcAlienRace ForceBuildingRaceTo;
        /* 0x23C8 */ public bool ForceLifeLevel;
        /* 0x23CC */ public GcPlanetLife ForceLifeLevelTo;
        /* 0x23D0 */ public bool ForceCreatureLifeLevel;
        /* 0x23D1 */ public bool ForceDefaultCreatureFile;
        /* 0x23D8 */ public NMSString0x10 DefaultGroundCreatureTable;
        /* 0x23E8 */ public NMSString0x10 DefaultAirCreatureTable;
        /* 0x23F8 */ public NMSString0x10 DefaultWaterCreatureTable;
        /* 0x2408 */ public NMSString0x10 DefaultCaveCreatureTable;
        /* 0x2418 */ public GcPlanetLife ForceCreatureLifeLevelTo;
        /* 0x241C */ public GcPlanetLife ForceTerrainSettings;
        /* 0x2420 */ public bool ForceTerrainType;
        /* 0x2424 */ public TkVoxelGeneratorSettingsTypes ForceTerrainTypeTo;
        /* 0x2428 */ public bool ForcePirateSystem;
        /* 0x2429 */ public bool ForcePrimeTerrain;
        /* 0x242A */ public bool ForceBinaryStar;
        /* 0x242B */ public bool ForceTernaryStar;
        /* 0x242C */ public GcGalaxyStarAnomaly ForceAnomalyTo;
        /* 0x2430 */ public bool ForcePlanetsToHaveWater;
        /* 0x2434 */ public int ForceWaterObjectFileIndex;
        /* 0x2438 */ public int ForceSkyColourIndex;
        /* 0x243C */ public int ForceSpaceSkyColourIndex;
        /* 0x2440 */ public bool ForceSpaceSkyColourRare;
        /* 0x2444 */ public int ForceWaterColourIndex;
        /* 0x2448 */ public int ForceGrassColourIndex;
        /* 0x244C */ public bool ModifyPlanetsInInitialSystems;
        /* 0x244D */ public bool ForcePlanetsToHaveNoWater;
        /* 0x244E */ public bool ForcePlanetsToHaveNoCaves;
        /* 0x244F */ public bool ForcePlanetsToHaveNoNoiseLayers;
        /* 0x2450 */ public bool ForcePlanetsToHaveNoTerrainFeatures;
        /* 0x2451 */ public bool ForceRareAsteroidSystem;
        /* 0x2454 */ public int ForceAsteroidSystemIndex;
        /* 0x2458 */ public bool DisableLimits;
        /* 0x2459 */ public bool LimitPerRegionInstances;
        /* 0x245A */ public bool LimitPerRegionBodies;
        /* 0x245B */ public bool LimitGlobalInstances;
        /* 0x245C */ public bool LimitGlobalBodies;
        /* 0x2460 */ public int GenerateFarLodBuildingDist;
        /* 0x2464 */ public bool DeferRegionBodies;
        /* 0x2468 */ public float GenerateCostDistance;
        /* 0x246C */ public float GenerateCostAngle;
        /* 0x2470 */ public float GenerateCostLOD;
        /* 0x2474 */ public float GenerateCostWait;
        /* 0x2478 */ public bool DChecksEnabled;
        /* 0x2479 */ public bool DChecksOutputJson;
        /* 0x247A */ public bool DChecksOutputBinary;
        /* 0x247B */ public bool DChecksOutputFileLine;
        /* 0x247C */ public int FrameFlipRateDefault;
        /* 0x2480 */ public int FrameFlipRateLoad;
        /* 0x2484 */ public int FrameFlipRateGame;
        /* 0x2488 */ public float MaxFrameRate;
        /* 0x248C */ public bool DisableBaseBuilding;
        /* 0x248D */ public bool DisableBaseBuildingLimits;
        /* 0x248E */ public bool AllowGlobalPartSnapping;
        /* 0x2490 */ public float BaseDownloadTimeout;
        /* 0x2494 */ public bool DisableBasePowerRequirements;
        /* 0x2495 */ public bool EnableBaseMovingOption;
        /* 0x2498 */ public int MoveBaseIndex;
        /* 0x249C */ public NMSString0x20 AutomaticPartSpawnID;
        /* 0x24BC */ public GcBaseBuildingPartStyle AutomaticPartSpawnStyle;
        /* 0x24C0 */ public bool AutomaticPartSpawnInactive;
        /* 0x24C4 */ public int ProfilerPartIndexPhase;
        /* 0x24C8 */ public int ProfilerPartIndexStride;
        /* 0x24CC */ public int ProfilerPartIteration;
        /* 0x24D0 */ public bool BaseAdmin;
        /* 0x24D1 */ public NMSString0x20 BaseServerPlatform;
        /* 0x24F4 */ public uint BasePayloadMultiplier;
        /* 0x24F8 */ public bool CrossPlatformFeaturedBases;
        /* 0x24F9 */ public bool ShowMissionIdInTitle;
        /* 0x24FC */ public TkGlobals ToolkitGlobals;
        /* 0x272C */ public bool AllowOverrideSettlementOwnership;
        /* 0x272D */ public NMSString0x40 OverrideSettlementOwnershipUsername;
        /* 0x276D */ public NMSString0x40 OverrideSettlementOwnershipOnlineId;
        /* 0x27AD */ public bool BlockSettlementsNetwork;
        /* 0x27AE */ public bool EnableAccessibleUI;
        /* 0x27AF */ public bool DisablePartialStories;
        /* 0x27B0 */ public bool UnlockAllStories;
        /* 0x27B1 */ public bool UnlockAllWords;
        /* 0x27B4 */ public int MultipleFingersSamePressFrameDelta;
        /* 0x27B8 */ public int SwipeDetectionMaxFrames;
        /* 0x27BC */ public float SwipeDetectionNormalizedTravelThreshold;
        /* 0x27C0 */ public float PanDeadzone;
    }
}
