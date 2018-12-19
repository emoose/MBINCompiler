using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x103AF61B6914E1E3)]
    public class GcDebugOptions : NMSTemplate
    {
        /* 0x0 */ public bool ThirdPersonIsDefaultCamera;
        /* 0x1 */ public bool SkipIntro;
        /* 0x2 */ public bool SkipLogos;
		/* 0x4 */ public int BootDirectlyIntoSaveSlot;
		/* 0x8 */ public GcGameMode NewSaveGameMode;
		/* 0xC */ public bool SkipPlanetDiscoverOnBoot;
		/* 0xD */ public bool VideoCaptureMode;
		/* 0xE */ public bool GodMode;
		/* 0xF */ public bool AlwaysHaveFocus;
		/* 0x10 */ public bool DisableVibration;
		/* 0x11 */ public bool MapWarpCheckIgnoreFuel;
		/* 0x12 */ public bool MapWarpCheckIgnoreDrive;
		/* 0x13 */ public bool EverythingIsFree;
		/* 0x14 */ public bool EverythingIsKnown;
		/* 0x15 */ public bool EverythingIsStar;
		/* 0x16 */ public bool IgnoreMissionRank;
		/* 0x17 */ public bool CanLeaveDialogs;
		/* 0x18 */ public bool DisableOldMissions;
		/* 0x19 */ public bool UseScreenEffects;
		/* 0x1A */ public bool UseGunImpactEffect;
		/* 0x1B */ public bool RenderCreatureDetails;
		/* 0x1C */ public bool SkipTutorial;
		/* 0x1D */ public bool IgnoreFreighterSpawnWarpRequirement;
		/* 0x1E */ public bool DisableSaveSlotSorting;
		/* 0x1F */ public bool DisableSaving;
		/* 0x20 */ public bool UseDebugScreenSettings;
		/* 0x24 */ public int ScreenWidth;
		/* 0x28 */ public int ScreenHeight;
		/* 0x2C */ public bool DisableVSync;
		public enum GameWindowModeEnum { Bordered, Borderless, Fullscreen }
		/* 0x30 */ public GameWindowModeEnum GameWindowMode;
        /* 0x34 */ public int Monitor;
        [NMS(Size = 0x100)]
        /* 0x38 */ public string ForceUniverseAddress;
        [NMS(Size = 0x100)]
        /* 0x138 */ public string ForcePlayerPosition;
        /* 0x238 */ public bool ForceInitialShip;
        /* 0x239 */ public bool ForceInitialWeapon;
		public enum GameStateModeEnum { LoadPreset, UserStorage, FreshStart }
		/* 0x23C */ public GameStateModeEnum GameStateMode;
		public enum BootModeEnum { MinimalSolarSystem, SolarSystem, GalaxyMap, SmokeTest, SmokeTestGalaxyMap, Scratchpad, UnitTest }
		/* 0x240 */ public BootModeEnum BootMode;
		public enum PlayerSpawnLocationOverrideEnum { None, FromSettings, Space, SpaceStation, RandomPlanet, GameStartPlanet }
		/* 0x244 */ public PlayerSpawnLocationOverrideEnum PlayerSpawnLocationOverride;
        [NMS(Size = 0x80)]
        /* 0x248 */ public string SceneSettings;
        [NMS(Size = 0x100)]
        /* 0x2C8 */ public string WorkingDirectory;
		public enum SolarSystemBootEnum { FromSettings, Generate }
		/* 0x3C8 */ public SolarSystemBootEnum SolarSystemBoot;
		public enum ShaderPreloadEnum { Off, Full }
		/* 0x3CC */ public ShaderPreloadEnum ShaderPreload;
        /* 0x3D0 */ public bool ShaderPreloadListExport;
        /* 0x3D1 */ public bool ShaderPreloadListImport;
        /* 0x3D2 */ public bool ShaderCaching;
		public enum BootLoadDelayEnum { LoadAll, WaitForPlanet, WaitForNothing }
		/* 0x3D4 */ public BootLoadDelayEnum BootLoadDelay;
        /* 0x3D8 */ public bool MemCsv;
        /* 0x3DC */ public float ForceTimeOfDay;
        /* 0x3E0 */ public bool UseParticles;
        /* 0x3E1 */ public bool UseVolumetrics;
        /* 0x3E2 */ public bool UseClouds;
        /* 0x3E3 */ public bool UseTerrain;
        /* 0x3E4 */ public bool UseInstances;
        /* 0x3E5 */ public bool UseObjects;
        /* 0x3E6 */ public bool UseBuildings;
        /* 0x3E7 */ public bool UseCreatures;
        /* 0x3E8 */ public bool UseElevation;
        /* 0x3E9 */ public bool UseLegacyFreighters;
        /* 0x3EA */ public bool SpawnPirates;
        /* 0x3EB */ public bool SpawnRobots;
        /* 0x3EC */ public bool SpawnShips;
        /* 0x3ED */ public bool InstanceCollision;
        /* 0x3EE */ public bool MPMissions;
        /* 0x3EF */ public bool SpecialsShop;
		/* 0x3F0 */ public bool MultiplePlayerFreightersInASystem;
		/* 0x3F1 */ public bool MouseLookEnabled;
		/* 0x3F2 */ public bool StartPaused;
		/* 0x3F3 */ public bool DisableDebugControls;
		/* 0x3F4 */ public bool DisableAsserts;
		/* 0x3F5 */ public bool FixedFramerate;
		/* 0x3F6 */ public bool ScreenshotMode;
		/* 0x3F7 */ public bool RenderHud;
		/* 0x3F8 */ public bool DisableDiscoveryNaming;
		/* 0x3F9 */ public bool DebugDrawPlayerInteract;
		/* 0x3FA */ public bool ForceInteractionToSettings;
		/* 0x3FC */ public int ForceInteractionIndex;
        /* 0x400 */ public bool InteractionsAllwaysGivesTech;
        /* 0x401 */ public bool InfiniteInteractions;
        /* 0x402 */ public bool StopSwitchingToSecondaryInteractions;
        /* 0x404 */ public float DebugLanguage;
        [NMS(Size = 0x20)]
        /* 0x408 */ public string AllowedLanguagesFile;
        /* 0x428 */ public bool DoAlienLanguage;
        /* 0x42C */ public float ForceInteractionRaceTo;
        /* 0x430 */ public float RealityMode;
        /* 0x434 */ public bool DebugPersistentInteractions;
        [NMS(Size = 0x80)]
        /* 0x435 */ public string RealityPresetFile;
        [NMS(Size = 0x1, Ignore = true)]
        /* 0x4B5 */ public byte[] Padding4B5;
        /* 0x4B6 */ public short RealityGenerationIteration;
        [NMS(Size = 0x4)]
        /* 0x4B8 */ public NMSString0x20[] LocTableList;
        [NMS(Size = 0x80)]
        /* 0x538 */ public string DefaultSaveData;
        /* 0x5B8 */ public bool FormatDownloadStorageAreaOnBoot;
        /* 0x5B9 */ public bool ForceBasicLoadScreen;
        /* 0x5BC */ public float BootLogoFadeRate;
        /* 0x5C0 */ public bool BootMusic;
        /* 0x5C4 */ public float WeaponScale3P;
        /* 0x5C8 */ public bool LogMissingLocalisedText;
        /* 0x5C9 */ public bool FleetDirectorAutoMode;
        /* 0x5CC */ public float _3dTextDistance;
        /* 0x5D0 */ public float _3dTextMinScale;
		public enum RecordSettingEnum { None, Record, Playback }
		/* 0x5D4 */ public RecordSettingEnum RecordSetting;
        /* 0x5D8 */ public bool DebugBuildingSpawns;
        /* 0x5D9 */ public bool StressTestLongNameDisplay;
        [NMS(Size = 0x20)]
        /* 0x5DA */ public string SaveTestingCommand;
        /* 0x5FA */ public bool NeverUseBanks;
        /* 0x5FB */ public bool DisableProfanityFilter;
        /* 0x5FC */ public bool DisableFileWatcher;
        /* 0x600 */ public int RecurrenceTimeOffset;
        /* 0x604 */ public bool ShowDebugMessages;
        /* 0x605 */ public bool ShowFramerate;
        /* 0x606 */ public bool ShowPositionDebug;
        /* 0x607 */ public bool ShowGPUMemory;
        /* 0x608 */ public bool ShowMempoolOverlay;
        /* 0x609 */ public bool ShowMouseSmoothing;
        [NMS(Size = 0x100)]
        /* 0x60A */ public string ShowUniverseAddressOnGalaxyMap;
        /* 0x70A */ public bool ShowGraphs;
        /* 0x70C */ public int ShowSpecificGraph;
        /* 0x710 */ public bool GraphCommandBuffer;
        /* 0x711 */ public bool GraphGeneration;
        /* 0x712 */ public bool GraphFPS;
        /* 0x713 */ public bool GraphTexStreaming;
        /* 0x714 */ public bool SmokeTestDumpStatsMode;
		public enum SmokeTestCycleModeEnum { None, TourSolarSystem, RegeneratePlanet }
		/* 0x718 */ public SmokeTestCycleModeEnum SmokeTestCycleMode;
        /* 0x71C */ public bool SmokeTestCameraFly;
        /* 0x71D */ public bool SmokeTestOutputOnly;
        /* 0x71E */ public bool SmokeTestPureFlight;
        /* 0x720 */ public int SmokeTestConfigCaptureCycles;
        /* 0x724 */ public float SmokeTestConfigCaptureDurationInSeconds;
        /* 0x728 */ public int SmokeTestConfigCaptureFolderNameNumberOffset;
        /* 0x72C */ public bool SmokeTestConfigRandomizePlanetSeed;
		/* 0x72D */ public bool SmokeTestSmokeBotEnabled;
		/* 0x72E */ public bool SmokeTestSmokeBotAutoStart;
		/* 0x730 */ public int SmokeTestSmokeBotTargetWarps;
		/* 0x734 */ public bool CreatureChatter;
		/* 0x735 */ public bool CreatureErrors;
		/* 0x736 */ public bool CreatureDrawVocals;
		/* 0x737 */ public bool DrawCreaturesInRoutines;
		/* 0x738 */ public bool ShowFirstPersonCharacterShadow;
		/* 0x739 */ public bool CompressTextures;
		/* 0x73A */ public bool DebugIBL;
		/* 0x73B */ public bool DebugTerrainTextures;
		/* 0x73C */ public bool DisableShadowSwitching;
		[NMS(Size = 0x80)]
		/* 0x73D */ public string PipelineFile;
		[NMS(Size = 0x80)]
		/* 0x7BD */ public string PipelineFilePS4;
		[NMS(Size = 0x80)]
		/* 0x83D */ public string PipelineFileXboxOne;
		[NMS(Size = 0x80)]
		/* 0x8BD */ public string PipelineFileVR;
		[NMS(Size = 0x80)]
		/* 0x93D */ public string PipelineFileFrontend;
		[NMS(Size = 0x80)]
		/* 0x9BD */ public string PipelineFileEditor;
		/* 0xA3D */ public bool RenderLowFramerate;
		/* 0xA3E */ public bool EnableComputePost;
        /* 0xA3F */ public bool EnableEvenOddRender;
		/* 0xA40 */ public bool SimulateNoNetworkConnection;
		public enum ProxyTypeEnum { None, ManualURI, InetProxy }
		/* 0xA44 */ public ProxyTypeEnum ProxyType;
        [NMS(Size = 0x80)]
        /* 0xA48 */ public string ProxyURI;
		public enum ServerEnvEnum { Default, dev, qa, prodqa, prod, custom, pentest }
		/* 0xAC8 */ public ServerEnvEnum ServerEnv;
        [NMS(Size = 0x80)]
        /* 0xACC */ public string AuthBaseUrl;
        /* 0xB4C */ public bool CertificateSecurityBypass;
        [NMS(Size = 0x20)]
        /* 0xB4D */ public string OverrideUsernameForDev;
        /* 0xB70 */ public int DiscoveryAutoSyncIntervalSeconds;
        /* 0xB74 */ public bool DisableSpaceStationSpawnOnJoin;
        /* 0xB75 */ public bool AutoJoinUserEnabled;
        [NMS(Size = 8)]
        /* 0xB76 */ public NMSString0x100[] AutoJoinUserNames;      // this is isn't own struct now but this should work...
        /* 0x1376 */ public bool AlwaysSaveGameAsClient;
        /* 0x1377 */ public bool DisableMonumentDownloads;
        /* 0x1378 */ public bool UsePadOnUnfocusedWindow;
        /* 0x137C */ public int OverrideMatchmakingVersion;
        /* 0x1380 */ public bool IgnoreTransactionTimeouts;
        /* 0x1381 */ public bool EnableSynergy;
        [NMS(Size = 0x20)]
        /* 0x1382 */ public string SynergyServer;
        /* 0x13A4 */ public int SynergyPort;
        /* 0x13A8 */ public bool ShowEditorPlacementPreview;
        /* 0x13AC */ public int MaxNumDebugMessages;
        /* 0x13B0 */ public bool PreloadToolbox;
        /* 0x13B4 */ public int DebugTextureSize;
        /* 0x13B8 */ public bool UseProcTextureDebugger;
        /* 0x13BC */ public int ProceduralModelsShown;
        /* 0x13C0 */ public int ProceduralModelBatchSize;
        [NMS(Size = 0x80)]
        /* 0x13C4 */ public string DebugFont;
        [NMS(Size = 0x80)]
        /* 0x1444 */ public string DebugFontTexture;
        [NMS(Size = 0x80)]
        /* 0x14C4 */ public string CursorTexture;
        [NMS(Size = 0x80)]
        /* 0x1544 */ public string PauseTexture;
        [NMS(Size = 0x80)]
        /* 0x15C4 */ public string PlayTexture;
        [NMS(Size = 0x80)]
        /* 0x1644 */ public string StepTexture;
        [NMS(Size = 0x80)]
        /* 0x16C4 */ public string RenderToTexture;
        /* 0x1744 */ public bool HmdEnable;
        /* 0x1745 */ public bool HmdOutput;
        /* 0x1746 */ public bool HmdTracking;
        /* 0x1747 */ public bool HmdStereoRender;
        /* 0x1748 */ public bool HmdDistortionPassthru;
        /* 0x174C */ public int HmdMonitor;
        /* 0x1750 */ public int HmdEyeBufferWidth;
        /* 0x1754 */ public int HmdEyeBufferHeight;
        /* 0x1758 */ public float HmdEyeScalePos;
        /* 0x175C */ public float HmdHeadScalePos;
        /* 0x1760 */ public float HmdImmersionFactor;
        /* 0x1764 */ public bool ForceExtremeWeather;
        /* 0x1765 */ public bool ForceExtremeSentinels;
        /* 0x1766 */ public bool ForceStarType;
        /* 0x1768 */ public GcGalaxyStarTypes ForceStarTypeTo;

        /* 0x176C */ public bool ForceBiome;
        /* 0x1770 */ public GcBiomeType ForceBiomeTo;
        /* 0x1774 */ public GcBiomeSubType ForceBiomeSubTypeTo;
        /* 0x1778 */ public bool ForceBuildingRace;
        /* 0x177C */ public GcAlienRace ForceBuildingRaceTo;
        /* 0x1780 */ public bool ForceLifeLevel;
        /* 0x1784 */ public GcPlanetLife ForceLifeLevelTo;
        /* 0x1788 */ public bool ForceCreatureLifeLevel;
        /* 0x1789 */ public bool ForceDefaultCreatureFile;
        /* 0x178C */ public GcPlanetLife ForceCreatureLifeLevelTo;
        /* 0x1790 */ public int ForceTerrainSettings;                   // there will be an enum/struct
        /* 0x1794 */ public bool ForceTerrainType;
        /* 0x1798 */ public int ForceTerranTypeTo;                      // there will be an enum/struct
		public enum ForceAnomalyToEnum { None, AtlasType1, AtlasType2, Blackhole, Anomaly, Spacewalk }
		/* 0x179C */ public ForceAnomalyToEnum ForceAnomalyTo;
        /* 0x17A0 */ public bool ForcePlanetsToHaveWater;
        /* 0x17A1 */ public bool ModifyPlanetsInInitialSystems;
        /* 0x17A2 */ public bool DisableLimits;
        /* 0x17A3 */ public bool LimitPerRegionInstances;
        /* 0x17A4 */ public bool LimitPerRegionBodies;
        /* 0x17A5 */ public bool LimitGlobalInstances;
        /* 0x17A6 */ public bool LimitGlobalBodies;
        /* 0x17A8 */ public int GenerateFarLodBuildingDist;
        /* 0x17AC */ public bool DeferRegionBodies;
        /* 0x17B0 */ public float GenerateCostDistance;
        /* 0x17B4 */ public float GenerateCostAngle;
        /* 0x17B8 */ public float GenerateCostLOD;
        /* 0x17BC */ public float GenerateCostWait;
        /* 0x17C0 */ public bool DChecksEnabled;
        /* 0x17C1 */ public bool DChecksOutputJson;
        /* 0x17C2 */ public bool DChecksOutputBinary;
        /* 0x17C3 */ public bool DChecksOutputFileLine;
        /* 0x17C4 */ public int FrameFlipRateDefault;
        /* 0x17C8 */ public int FrameFlipRateLoad;
        /* 0x17CC */ public int FrameFlipRateGame;
        /* 0x17D0 */ public float MaxFrameRate;
        /* 0x17D4 */ public bool DisableBaseBuilding;
        /* 0x17D5 */ public bool DisableBaseBuildingLimits;
        /* 0x17D8 */ public float BaseDownloadTimeout;
    }
}
