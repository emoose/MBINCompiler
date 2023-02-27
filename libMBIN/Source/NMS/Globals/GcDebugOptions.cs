using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x1A486F75DA30C4DC, NameHash = 0x13FED27DF728C38)]
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
        /* 0x003F */ public bool DisableStorms;
        /* 0x0040 */ public bool ForceEnableClothComponent;
        /* 0x0041 */ public bool ForceDisableClothComponent;
        /* 0x0042 */ public bool ClothForcePositionExtrapolationOff;
        /* 0x0043 */ public bool ClothForcePositionExtrapolationOn;
        /* 0x0044 */ public bool ClothForcePositionExtrapolationBackOn;
        /* 0x0045 */ public bool ClothForcePositionExtrapolationUpdateOrderDependent;
        /* 0x0046 */ public bool ClothForcePositionExtrapolationSyncWithFpsLock;
        /* 0x0047 */ public bool ClothForcePositionExtrapolationAntiSyncWithFpsLock;
        /* 0x00   */ public bool ClothForceAsyncSimulationOff;
        /* 0x00   */ public bool ClothForceAsyncSimulationOn;
        /* 0x0048 */ public bool ForceEnableSpringAttachmentComponent;
        /* 0x0049 */ public bool ForceDisableSpringAttachmentComponent;
        /* 0x004A */ public bool ForceEnableSplitIkOptimisation;
        /* 0x004B */ public bool ForceDisableSplitIkOptimisation;
        /* 0x00   */ public bool SampleCollisionWithCamera;
        /* 0x00   */ public bool ShowPlayerCollisions;
        /* 0x004C */ public bool DisableNPCs;
        /* 0x004D */ public bool AlternateControls;
        /* 0x004E */ public bool AlwaysShowURI;
        /* 0x004F */ public bool MPMissionsAlwaysEPIC;
        /* 0x0050 */ public bool ShowFireteamMembersUA;
        /* 0x0051 */ public bool RevealAllTitles;
        /* 0x0052 */ public bool UnlockAllTitles;
        /* 0x0053 */ public bool LockAllTitles;
        /* 0x0054 */ public bool AlwaysAllowShipOperations;
        /* 0x0055 */ public bool AlwaysAllowVehicleOperations;
        /* 0x0056 */ public bool AlwaysAllowFreighterInventoryAccess;
        /* 0x0057 */ public NMSString0x200 SeasonalDataOverrideFile;
        /* 0x0257 */ public bool UnlockAllSeasonRewards;
        /* 0x0258 */ public bool UnlockAllTwitchRewards;
        /* 0x0259 */ public bool UnlockAllPlatformRewards;
        /* 0x025A */ public NMSString0x400 DebugTwitchRewards;
        /* 0x065A */ public bool AllowPause;
        /* 0x065B */ public bool AllSettlementsAreCompleted;
        /* 0x065C */ public bool DisableSettlements;
        /* 0x065D */ public bool PlaceOnGroundWhenLeavingDebugCamera;
        /* 0x065E */ public bool OctahedralImpostersEnable;
        /* 0x065F */ public bool OctahedralImpostersDisable;
        /* 0x0660 */ public bool OctahedralImpostersViewFromSpace;
        /* 0x0664 */ public int OctahedralImpostersViewCount;
        /* 0x06   */ public bool EnableMemoryPoolAllocPrint;
        /* 0x0668 */ public bool UseDebugScreenSettings;
        /* 0x066C */ public int ScreenWidth;
        /* 0x0670 */ public int ScreenHeight;
        /* 0x0674 */ public bool DisableVSync;
        // size: 0x3
        public enum GameWindowModeEnum : uint {
            Bordered,
            Borderless,
            Fullscreen,
        }
        /* 0x0678 */ public GameWindowModeEnum GameWindowMode;
        /* 0x067C */ public int Monitor;
        /* 0x0680 */ public int TiledWindowsSplitCount;
        /* 0x0684 */ public int TiledWindowsIndex;
        /* 0x0688 */ public NMSString0x100 ForceUniverseAddress;
        /* 0x0788 */ public NMSString0x100 ForcePlayerPosition;
        /* 0x0888 */ public bool ForceInitialShip;
        /* 0x0889 */ public bool ForceInitialWeapon;
        // size: 0x3
        public enum GameStateModeEnum : uint {
            LoadPreset,
            UserStorage,
            FreshStart,
        }
        /* 0x088C */ public GameStateModeEnum GameStateMode;
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
        /* 0x0890 */ public BootModeEnum BootMode;
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
        /* 0x0894 */ public PlayerSpawnLocationOverrideEnum PlayerSpawnLocationOverride;
        /* 0x0898 */ public NMSString0x80 SceneSettings;
        /* 0x0918 */ public NMSString0x100 WorkingDirectory;
        /* 0x0A18 */ public NMSString0x80 DebugScene;
        // size: 0x2
        public enum SolarSystemBootEnum : uint {
            FromSettings,
            Generate,
        }
        /* 0x0A98 */ public SolarSystemBootEnum SolarSystemBoot;
        // size: 0x2
        public enum ShaderPreloadEnum : uint {
            Off,
            Full,
        }
        /* 0x0A9C */ public ShaderPreloadEnum ShaderPreload;
        /* 0x0AA0 */ public bool ShaderPreloadListExport;
        /* 0x0AA1 */ public bool ShaderPreloadListImport;
        /* 0x0AA2 */ public bool ShaderCaching;
        // size: 0x3
        public enum BootLoadDelayEnum : uint {
            LoadAll,
            WaitForPlanet,
            WaitForNothing,
        }
        /* 0x0AA4 */ public BootLoadDelayEnum BootLoadDelay;
        /* 0x0AA8 */ public bool MemCsv;
        /* 0x0AAC */ public float ForceTimeOfDay;
        /* 0x0AB0 */ public float ForceInitialTimeOfDay;
        /* 0x0AB4 */ public bool ForceSunDirectionFromPhotoMode;
        /* 0x0AB8 */ public float ForceSunAngle;
        /* 0x0ABC */ public bool ResetForcedSaveSlotOnLoad;
        /* 0x0A   */ public bool EnableFrontendPreload;
        /* 0x0ABD */ public bool MissionMessageLoggingEnabled;
        /* 0x0A   */ public bool MissionNGUIShowsConditionResults;
        /* 0x0ABE */ public bool UseParticles;
        ///* 0x0ABF */ public bool UseHeavyAir;
        /* 0x0AC0 */ public bool UseVolumetrics;
        /* 0x0AC1 */ public bool UseClouds;
        /* 0x0AC2 */ public bool EnableCloudAnimation;
        /* 0x0AC3 */ public bool UseTerrain;
        /* 0x0AC4 */ public bool UseInstances;
        /* 0x0AC5 */ public bool UseObjects;
        /* 0x0AC6 */ public bool UseBuildings;
        /* 0x0AC7 */ public bool UseCreatures;
        /* 0x0AC8 */ public bool UseElevation;
        /* 0x0AC9 */ public bool UseLegacyFreighters;
        /* 0x0ACA */ public bool UseLegacyBuildingTable;
        /* 0x0ACB */ public bool EnableDayNightCycle;
        /* 0x0ACC */ public bool SpawnPirates;
        /* 0x0ACD */ public bool SpawnRobots;
        /* 0x0ACE */ public bool SpawnShips;
        /* 0x0ACF */ public bool SpawnPulseEncounters;
        /* 0x0AD0 */ public bool InstanceCollision;
        /* 0x0AD1 */ public bool LoadMissions;
        /* 0x0AD2 */ public bool MPMissions;
        /* 0x0AD3 */ public bool SpecialsShop;
        /* 0x0AD4 */ public bool MultiplePlayerFreightersInASystem;
        /* 0x0AD5 */ public bool ForceNexusInQuickMenu;
        /* 0x0AD6 */ public bool MissionSurveyEnabled;
        /* 0x0AD7 */ public bool AllSeasonMilestonesShowComplete;
        /* 0x0AD8 */ public bool EnableGalaxyRecolouring;
        /* 0x0AD9 */ public bool IgnoreSteamDev;
        /* 0x0ADA */ public bool EnableBaseBuildingExpandables;
        /* 0x0ADB */ public bool MouseLookEnabled;
        /* 0x0ADC */ public bool StartPaused;
        /* 0x0ADD */ public bool DisableDebugControls;
        /* 0x0ADE */ public bool FixedFramerate;
        /* 0x0ADF */ public bool ScreenshotMode;
        /* 0x0AE0 */ public bool RenderHud;
        /* 0x0AE1 */ public bool DisableDiscoveryNaming;
        /* 0x0AE2 */ public bool DebugDrawPlayerInteract;
        /* 0x0AE3 */ public bool ForceInteractionToSettings;
        /* 0x0AE4 */ public int ForceInteractionIndex;
        /* 0x0AE8 */ public bool InteractionsAllwaysGivesTech;
        /* 0x0AE9 */ public bool InfiniteInteractions;
        /* 0x0AEA */ public bool StopSwitchingToSecondaryInteractions;
        /* 0x0AEC */ public TkLanguages DebugLanguage;
        /* 0x0AF0 */ public NMSString0x20 AllowedLanguagesFile;
        /* 0x0B10 */ public bool DoAlienLanguage;
        /* 0x0B14 */ public GcAlienRace ForceInteractionRaceTo;
        // size: 0x2
        public enum RealityModeEnum : uint {
            LoadPreset,
            Generate,
        }
        /* 0x0B18 */ public RealityModeEnum RealityMode;
        /* 0x0B1C */ public bool DebugPersistentInteractions;
        /* 0x0B1D */ public bool UseHighlightedOptionStyle;
        /* 0x0B1E */ public bool DisableMissionShop;
        /* 0x0B1F */ public NMSString0x80 RealityPresetFile;
        /* 0x0BA0 */ public ushort RealityGenerationIteration;
        /* 0x0BA8 */ public List<NMSString0x20> LocTableList;
        /* 0x0BB8 */ public NMSString0x80 DefaultSaveData;
        /* 0x0C38 */ public bool FormatDownloadStorageAreaOnBoot;
        /* 0x0C39 */ public bool ForceBasicLoadScreen;
        /* 0x0C3C */ public float BootLogoFadeRate;
        /* 0x0C40 */ public bool BootMusic;
        /* 0x0C44 */ public float WeaponScale3P;
        /* 0x0C48 */ public bool LogMissingLocalisedText;
        /* 0x0C49 */ public bool FleetDirectorAutoMode;
        /* 0x0C4C */ public float _3dTextDistance;
        /* 0x0C50 */ public float _3dTextMinScale;
        // size: 0x3
        public enum RecordSettingEnum : uint {
            None,
            Record,
            Playback,
        }
        /* 0x0C54 */ public RecordSettingEnum RecordSetting;
        /* 0x0C58 */ public bool DebugBuildingSpawns;
        /* 0x0C59 */ public bool StressTestLongNameDisplay;
        /* 0x0C5A */ public bool ShowLongestStrings;
        /* 0x0C5B */ public NMSString0x20 SaveTestingCommand;
        /* 0x0C7B */ public bool NeverUseBanks;
        /* 0x0C7C */ public bool DisableProfanityFilter;
        /* 0x0C7D */ public bool DisableFileWatcher;
        /* 0x0C7E */ public bool DisableShaderReload;
        /* 0x0C80 */ public int RecurrenceTimeOffset;
        /* 0x0C88 */ public ulong ForceTimeToEpoch;
        /* 0x0C90 */ public NMSString0x80 CrashDumpPath;
        /* 0x0D10 */ public NMSString0x20 CrashDumpIdentifier;
        /* 0x0D30 */ public bool EnableLivePP;
        /* 0x0D31 */ public bool DebugThreatLevels;
        /* 0x0D   */ public bool DumpManifestContents;
        /* 0x0D32 */ public bool ShowDebugMessages;
        /* 0x0D33 */ public bool ShowFramerate;
        /* 0x0D   */ public bool ShowGPURenderTime;
        /* 0x0D   */ public bool ShowDynamicResScale;
        /* 0x0D34 */ public bool PrintAvgFrameTimes;
        /* 0x0D35 */ public bool ShowPositionDebug;
        /* 0x0D36 */ public bool ShowGPUMemory;
        /* 0x0D37 */ public bool ShowMempoolOverlay;
        /* 0x0D38 */ public bool ShowMouseSmoothing;
        /* 0x0D39 */ public NMSString0x100 ShowUniverseAddressOnGalaxyMap;
        /* 0x0E39 */ public bool ShowGraphs;
        /* 0x0E3C */ public int ShowSpecificGraph;
        /* 0x0E40 */ public bool GraphCommandBuffer;
        /* 0x0E41 */ public bool GraphGeneration;
        /* 0x0E42 */ public bool GraphFPS;
        /* 0x0E43 */ public bool GraphTexStreaming;
        /* 0x0E44 */ public bool SmokeTestDumpStatsMode;
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
        /* 0x0E48 */ public SmokeTestCycleModeEnum SmokeTestCycleMode;
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
        /* 0x0E4C */ public SmokeTestScenarioEnum SmokeTestScenario;
        /* 0x0E50 */ public bool SmokeTestLegacyOutput;
        /* 0x0E54 */ public int SmokeTestConfigPlanetPositionCount;
        /* 0x0E58 */ public float SmokeTestConfigScenarioPreambleLength;
        /* 0x0E5C */ public float SmokeTestConfigScenarioLength;
        /* 0x0E60 */ public bool SmokeTestFastExit;
        /* 0x0E61 */ public bool SmokeTestCameraFly;
        /* 0x0E62 */ public bool SmokeTestOutputOnly;
        /* 0x0E63 */ public bool SmokeTestPureFlight;
        /* 0x0E64 */ public int SmokeTestConfigCaptureCycles;
        /* 0x0E68 */ public float SmokeTestConfigCaptureDurationInSeconds;
        /* 0x0E6C */ public int SmokeTestConfigCaptureFolderNameNumberOffset;
        /* 0x0E70 */ public bool SmokeTestConfigRandomizePlanetSeed;
        /* 0x0E71 */ public bool SmokeTestSmokeBotEnabled;
        /* 0x0E72 */ public bool SmokeTestSmokeBotAutoStart;
        /* 0x0E74 */ public int SmokeTestSmokeBotTargetWarps;
        /* 0x0E78 */ public bool SmokeTestPostBandwidthStats;
        /* 0x0E79 */ public NMSString0x20 SmokeTestForcePlanetDetail;
        /* 0x0E99 */ public NMSString0x20 SmokeTestRunFolder;
        /* 0x0EB9 */ public bool CreatureChatter;
        /* 0x0EBA */ public bool CreatureErrors;
        /* 0x0EBB */ public bool CreatureDrawVocals;
        /* 0x0EBC */ public bool DrawCreaturesInRoutines;
        /* 0x0EBD */ public bool CompressTextures;
        /* 0x0EBE */ public bool DebugIBL;
        /* 0x0EBF */ public bool DebugSpotlights;
        /* 0x0EC0 */ public bool DebugTerrainTextures;
        /* 0x0EC1 */ public bool DisableShadowSwitching;
        /* 0x0EC2 */ public NMSString0x80 PipelineFile;
        /* 0x0F42 */ public NMSString0x80 PipelineFilePS4;
        /* 0x0FC2 */ public NMSString0x80 PipelineFileXboxOne;
        /* 0x1042 */ public NMSString0x80 PipelineFileVR;
        /* 0x10C2 */ public NMSString0x80 PipelineFileVRPS4;
        /* 0x1142 */ public NMSString0x80 PipelineFileFrontend;
        /* 0x11C2 */ public NMSString0x80 PipelineFileEditor;
        /* 0x11   */ public NMSString0x80 PipelineFileSwitch;
        /* 0x1242 */ public bool RenderLowFramerate;
        /* 0x1243 */ public bool EnableComputePost;
        /* 0x1244 */ public bool EnableEvenOddRender;
        /* 0x1245 */ public bool MinGPUMode;
        /* 0x1246 */ public bool Proto2DevKit;
        ///* 0x1247 */ public bool SimulateDisabledParticleRefractions;
        /* 0x1248 */ public bool AlwaysIncludeLocalPlayerInChatMessage;
        /* 0x1249 */ public bool SimulateNoNetworkConnection;
        // size: 0x3
        public enum ProxyTypeEnum : uint {
            None,
            ManualURI,
            InetProxy,
        }
        /* 0x124C */ public ProxyTypeEnum ProxyType;
        /* 0x1250 */ public NMSString0x80 ProxyURI;
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
        /* 0x12D0 */ public ServerEnvEnum ServerEnv;
        /* 0x12D4 */ public NMSString0x80 AuthBaseUrl;
        /* 0x1354 */ public bool CertificateSecurityBypass;
        /* 0x1355 */ public NMSString0x20 OverrideUsernameForDev;
        /* 0x1378 */ public int DiscoveryAutoSyncIntervalSeconds;
        /* 0x137C */ public bool DisableSpaceStationSpawnOnJoin;
        /* 0x137D */ public bool AutoJoinUserEnabled;
        /* 0x137E */ public NMSString0x800 AutoJoinUserNames;
        /* 0x1B7E */ public bool AlwaysSaveGameAsClient;
        /* 0x1B7F */ public bool DisableMonumentDownloads;
        /* 0x1B80 */ public bool UsePadOnUnfocusedWindow;
        /* 0x1B84 */ public int OverrideMatchmakingVersion;
        /* 0x1B88 */ public NMSString0x200 LoadToBase;
        /* 0x1D88 */ public bool IgnoreTransactionTimeouts;
        /* 0x1D89 */ public bool AutoJoinRandomGames;
        /* 0x1D8A */ public NMSString0x100 GOGLogin;
        /* 0x1E8A */ public bool RecordNetworkStatsOnBoot;
        /* 0x1E8B */ public bool FakeHandsInMultiplayer;
        /* 0x1E8C */ public bool ForceSmallLobby;
        /* 0x1E8D */ public bool ForceTinyLobby;
        /* 0x1E90 */ public int OverrideServerSeasonNumber;
        /* 0x1E94 */ public int OverrideServerSeasonEndTime;
        /* 0x1E98 */ public bool EnableSynergy;
        /* 0x1E99 */ public NMSString0x20 SynergyServer;
        /* 0x1EBC */ public int SynergyPort;
        /* 0x1EC0 */ public bool ShowEditorPlacementPreview;
        /* 0x1EC4 */ public int MaxNumDebugMessages;
        /* 0x1EC8 */ public bool PreloadToolbox;
        /* 0x1ECC */ public int DebugTextureSize;
        /* 0x1ED0 */ public bool UseProcTextureDebugger;
        /* 0x1ED4 */ public int ProceduralModelsShown;
        /* 0x1ED8 */ public int ProceduralModelBatchSize;
        /* 0x1EDC */ public int ProceduralModelFilterMatchretryCount;
        /* 0x1EE0 */ public bool ProceduralModelsDeterministicSequence;
        /* 0x1EE4 */ public int ProceduralModelsThumbnailSize;
        /* 0x1EE8 */ public NMSString0x80 DebugFont;
        /* 0x1F68 */ public NMSString0x80 DebugFontTexture;
        /* 0x1FE8 */ public NMSString0x80 CursorTexture;
        /* 0x2068 */ public NMSString0x80 PauseTexture;
        /* 0x20E8 */ public NMSString0x80 PlayTexture;
        /* 0x2168 */ public NMSString0x80 StepTexture;
        /* 0x21E8 */ public NMSString0x80 RenderToTexture;
        /* 0x2268 */ public bool HmdEnable;
        /* 0x226C */ public int HmdPreviewScale;
        /* 0x2270 */ public bool HmdTracking;
        /* 0x2271 */ public bool HmdStereoRender;
        /* 0x2272 */ public bool HmdDistortionPassthru;
        /* 0x2274 */ public int HmdMonitor;
        /* 0x2278 */ public int HmdEyeBufferWidth;
        /* 0x227C */ public int HmdEyeBufferHeight;
        /* 0x2280 */ public float HmdEyeScalePos;
        /* 0x2284 */ public float HmdHeadScalePos;
        /* 0x2288 */ public bool HmdFrameShiftEnabled;
        /* 0x2289 */ public bool HmdUseSolidGuiPointer;
        /* 0x228A */ public bool BodyTurning;
        /* 0x228C */ public float HmdImmersionFactor;
        /* 0x2290 */ public bool ShowHmdHandControllers;
        /* 0x2291 */ public bool ShowTeleportEffectLocally;
        /* 0x2292 */ public bool DisableLeftHand;
        /* 0x2293 */ public bool DisableHeadConstraints;
        /* 0x2294 */ public bool EnablePhotomodeVR;
        /* 0x2295 */ public bool AllowNGuiVR;
        /* 0x2296 */ public bool ForceExtremeWeather;
        /* 0x2297 */ public bool ForceExtremeSentinels;
        /* 0x2298 */ public bool ForceStarType;
        /* 0x2299 */ public bool ForceLoadAllWeather;
        /* 0x229C */ public GcGalaxyStarTypes ForceStarTypeTo;
        /* 0x22A0 */ public bool ForceBiome;
        /* 0x22A4 */ public GcBiomeType ForceBiomeTo;
        /* 0x22A8 */ public bool ForceScreenFilter;
        /* 0x22AC */ public GcScreenFilters ForceScreenFilterTo;
        /* 0x22B0 */ public GcBiomeSubType ForceBiomeSubTypeTo;
        /* 0x22B4 */ public bool ForceBuildingRace;
        /* 0x22B8 */ public GcAlienRace ForceBuildingRaceTo;
        /* 0x22BC */ public bool ForceLifeLevel;
        /* 0x22C0 */ public GcPlanetLife ForceLifeLevelTo;
        /* 0x22C4 */ public bool ForceCreatureLifeLevel;
        /* 0x22C5 */ public bool ForceDefaultCreatureFile;
        /* 0x22C8 */ public NMSString0x10 DefaultGroundCreatureTable;
        /* 0x22D8 */ public NMSString0x10 DefaultAirCreatureTable;
        /* 0x22E8 */ public NMSString0x10 DefaultWaterCreatureTable;
        /* 0x22F8 */ public NMSString0x10 DefaultCaveCreatureTable;
        /* 0x2308 */ public GcPlanetLife ForceCreatureLifeLevelTo;
        /* 0x230C */ public GcPlanetLife ForceTerrainSettings;
        /* 0x2310 */ public bool ForceTerrainType;
        /* 0x2314 */ public TkVoxelGeneratorSettingsTypes ForceTerrainTypeTo;
        /* 0x2318 */ public bool ForcePirateSystem;
        /* 0x2319 */ public bool ForcePrimeTerrain;
        /* 0x231A */ public bool ForceBinaryStar;
        /* 0x231B */ public bool ForceTernaryStar;
        /* 0x231C */ public GcGalaxyStarAnomaly ForceAnomalyTo;
        /* 0x2320 */ public bool ForcePlanetsToHaveWater;
        /* 0x2324 */ public int ForceWaterObjectFileIndex;
        /* 0x2328 */ public int ForceSkyColourIndex;
        /* 0x232C */ public int ForceSpaceSkyColourIndex;
        /* 0x2330 */ public bool ForceSpaceSkyColourRare;
        /* 0x2334 */ public int ForceWaterColourIndex;
        /* 0x2338 */ public int ForceGrassColourIndex;
        /* 0x233C */ public bool ModifyPlanetsInInitialSystems;
        /* 0x233D */ public bool ForcePlanetsToHaveNoWater;
        /* 0x233E */ public bool ForcePlanetsToHaveNoCaves;
        /* 0x233F */ public bool ForcePlanetsToHaveNoNoiseLayers;
        /* 0x2340 */ public bool ForcePlanetsToHaveNoTerrainFeatures;
        /* 0x2341 */ public bool ForceRareAsteroidSystem;
        /* 0x2344 */ public int ForceAsteroidSystemIndex;
        /* 0x2348 */ public bool DisableLimits;
        /* 0x2349 */ public bool LimitPerRegionInstances;
        /* 0x234A */ public bool LimitPerRegionBodies;
        /* 0x234B */ public bool LimitGlobalInstances;
        /* 0x234C */ public bool LimitGlobalBodies;
        /* 0x2350 */ public int GenerateFarLodBuildingDist;
        /* 0x2354 */ public bool DeferRegionBodies;
        /* 0x2358 */ public float GenerateCostDistance;
        /* 0x235C */ public float GenerateCostAngle;
        /* 0x2360 */ public float GenerateCostLOD;
        /* 0x2364 */ public float GenerateCostWait;
        /* 0x2368 */ public bool DChecksEnabled;
        /* 0x2369 */ public bool DChecksOutputJson;
        /* 0x236A */ public bool DChecksOutputBinary;
        /* 0x236B */ public bool DChecksOutputFileLine;
        /* 0x236C */ public int FrameFlipRateDefault;
        /* 0x2370 */ public int FrameFlipRateLoad;
        /* 0x2374 */ public int FrameFlipRateGame;
        /* 0x2378 */ public float MaxFrameRate;
        /* 0x237C */ public bool DisableBaseBuilding;
        /* 0x237D */ public bool DisableBaseBuildingLimits;
        /* 0x237E */ public bool AllowGlobalPartSnapping;
        /* 0x2380 */ public float BaseDownloadTimeout;
        /* 0x2384 */ public bool DisableBasePowerRequirements;
        /* 0x2385 */ public bool EnableBaseMovingOption;
        /* 0x2388 */ public int MoveBaseIndex;
        /* 0x238C */ public NMSString0x20 AutomaticPartSpawnID;
        /* 0x23AC */ public GcBaseBuildingPartStyle AutomaticPartSpawnStyle;
        /* 0x23B0 */ public bool AutomaticPartSpawnInactive;
        /* 0x23B4 */ public int ProfilerPartIndexPhase;
        /* 0x23B8 */ public int ProfilerPartIndexStride;
        /* 0x23BC */ public int ProfilerPartIteration;
        /* 0x23C0 */ public bool BaseAdmin;
        /* 0x23C1 */ public NMSString0x20 BaseServerPlatform;
        /* 0x23E4 */ public uint BasePayloadMultiplier;
        /* 0x23E8 */ public bool CrossPlatformFeaturedBases;
        /* 0x23E9 */ public bool ShowMissionIdInTitle;
        /* 0x23EC */ public TkGlobals ToolkitGlobals;
        /* 0x2610 */ public bool AllowOverrideSettlementOwnership;
        /* 0x2611 */ public NMSString0x40 OverrideSettlementOwnershipUsername;
        /* 0x2651 */ public NMSString0x40 OverrideSettlementOwnershipOnlineId;
        /* 0x2691 */ public bool BlockSettlementsNetwork;
        /* 0x2692 */ public bool EnableAccessibleUI;
        /* 0x2693 */ public bool DisablePartialStories;
        /* 0x2694 */ public bool UnlockAllStories;
        /* 0x2695 */ public bool UnlockAllWords;
    }
}
