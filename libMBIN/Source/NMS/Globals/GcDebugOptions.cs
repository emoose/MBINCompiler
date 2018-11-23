using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0x21676C20AFF3CCB8)]
    public class GcDebugOptions : NMSTemplate
    {
        /* 0x0 */ public bool ThirdPersonIsDefaultCamera;
        /* 0x1 */ public bool SkipIntro;
        /* 0x2 */ public bool SkipLogos;
        /* 0x3 */ public bool SkipPlanetDiscoverOnBoot;
        /* 0x4 */ public bool VideoCaptureMode;
        /* 0x5 */ public bool GodMode;
        /* 0x6 */ public bool AlwaysHaveFocus;
        /* 0x7 */ public bool DisableVibration;
        /* 0x8 */ public bool MapWarpCheckIgnoreFuel;
        /* 0x9 */ public bool MapWarpCheckIgnoreDrive;
        /* 0xA */ public bool EverythingIsFree;
        /* 0xB */ public bool EverythingIsKnown;
        /* 0xC */ public bool EverythingIsStar;
        /* 0xD */ public bool IgnoreMissionRank;
        /* 0xE */ public bool CanLeaveDialogs;
        /* 0xF */ public bool DisableOldMissions;
        /* 0x10 */ public bool UseScreenEffects;
        /* 0x11 */ public bool UseGunImpactEffect;
        /* 0x12 */ public bool RenderCreatureDetails;
        /* 0x13 */ public bool SkipTutorial;
        /* 0x14 */ public bool IgnoreFreighterSpawnWarpRequirement;
        /* 0x15 */ public bool DisableSaveSlotSorting;
		/* 0x16 */ public bool DisableSaving;
		/* 0x17 */ public bool UseDebugScreenSettings;
        /* 0x18 */ public int ScreenWidth;
        /* 0x1C */ public int ScreenHeight;
        /* 0x20 */ public bool DisableVSync;
		public enum GameWindowModeEnum { Bordered, Borderless, Fullscreen }
		public GameWindowModeEnum GameWindowMode;
        /* 0x28 */ public int Monitor;
        [NMS(Size = 0x100)]
        /* 0x2C */ public string ForceUniverseAddress;
        [NMS(Size = 0x100)]
        /* 0x12C */ public string ForcePlayerPosition;
        /* 0x22C */ public bool ForceInitialShip;
        /* 0x22D */ public bool ForceInitialWeapon;
		public enum GameStateModeEnum { LoadPreset, UserStorage, FreshStart }
		public GameStateModeEnum GameStateMode;
		public enum BootModeEnum { MinimalSolarSystem, SolarSystem, GalaxyMap, SmokeTest, SmokeTestGalaxyMap, Scratchpad, UnitTest }
		public BootModeEnum BootMode;
		public enum PlayerSpawnLocationOverrideEnum { None, FromSettings, Space, SpaceStation, RandomPlanet, GameStartPlanet }
		public PlayerSpawnLocationOverrideEnum PlayerSpawnLocationOverride;
        [NMS(Size = 0x80)]
        /* 0x23C */ public string SceneSettings;
        [NMS(Size = 0x100)]
        /* 0x2BC */ public string WorkingDirectory;
		public enum SolarSystemBootEnum { FromSettings, Generate }
		public SolarSystemBootEnum SolarSystemBoot;
		public enum ShaderPreloadEnum { Off, Full }
		public ShaderPreloadEnum ShaderPreload;
        /* 0x3C4 */ public float PresetGameMode;
        /* 0x3C8 */ public bool ShaderPreloadListExport;
        /* 0x3C9 */ public bool ShaderPreloadListImport;
        /* 0x3CA */ public bool ShaderCaching;
		public enum BootLoadDelayEnum { LoadAll, WaitForPlanet, WaitForNothing }
		public BootLoadDelayEnum BootLoadDelay;
        /* 0x3D0 */ public bool MemCsv;
        /* 0x3D4 */ public float ForceTimeOfDay;
        /* 0x3D8 */ public bool UseParticles;
        /* 0x3D9 */ public bool UseVolumetrics;
        /* 0x3DA */ public bool UseClouds;
        /* 0x3DB */ public bool UseTerrain;
        /* 0x3DC */ public bool UseInstances;
        /* 0x3DD */ public bool UseObjects;
        /* 0x3DE */ public bool UseBuildings;
        /* 0x3DF */ public bool UseCreatures;
        /* 0x3E0 */ public bool UseElevation;
        /* 0x3E1 */ public bool UseLegacyFreighters;
        /* 0x3E2 */ public bool SpawnPirates;
        /* 0x3E3 */ public bool SpawnRobots;
        /* 0x3E4 */ public bool SpawnShips;
        /* 0x3E5 */ public bool InstanceCollision;
        /* 0x3E6 */ public bool MPMissions;
        /* 0x3E7 */ public bool SpecialsShop;
		/* 0x3E8 */ public bool MultiplePlayerFreightersInASystem;
		/* 0x3E9 */ public bool MouseLookEnabled;
		/* 0x3EA */ public bool StartPaused;
		/* 0x3EB */ public bool DisableDebugControls;
		/* 0x3EC */ public bool DisableAsserts;
		/* 0x3ED */ public bool FixedFramerate;
		/* 0x3EE */ public bool ScreenshotMode;
		/* 0x3EF */ public bool RenderHud;
		/* 0x3F0 */ public bool DisableDiscoveryNaming;
		/* 0x3F1 */ public bool DebugDrawPlayerInteract;
		/* 0x3F2 */ public bool ForceInteractionToSettings;
		/* 0x3F4 */ public int ForceInteractionIndex;
        /* 0x3F8 */ public bool InteractionsAllwaysGivesTech;
        /* 0x3F9 */ public bool InfiniteInteractions;
        /* 0x3FA */ public bool StopSwitchingToSecondaryInteractions;
        /* 0x3FC */ public float DebugLanguage;
        [NMS(Size = 0x20)]
        /* 0x400 */ public string AllowedLanguagesFile;
        /* 0x420 */ public bool DoAlienLanguage;
        /* 0x424 */ public float ForceInteractionRaceTo;
        /* 0x428 */ public float RealityMode;
        /* 0x42C */ public bool DebugPersistentInteractions;
        [NMS(Size = 0x80)]
        /* 0x42D */ public string RealityPresetFile;
        [NMS(Size = 0x1, Ignore = true)]
        /* 0x4AD */ public byte[] Padding4AD;
        /* 0x4AE */ public short RealityGenerationIteration;
        [NMS(Size = 0x3)]
        /* 0x4B0 */ public NMSString0x20[] LocTableList;
        [NMS(Size = 0x80)]
        /* 0x510 */ public string DefaultSaveData;
        /* 0x590 */ public bool FormatDownloadStorageAreaOnBoot;
        /* 0x591 */ public bool ForceBasicLoadScreen;
        /* 0x594 */ public float BootLogoFadeRate;
        /* 0x598 */ public bool BootMusic;
        /* 0x59C */ public float WeaponScale3P;
        /* 0x5A0 */ public bool LogMissingLocalisedText;
        /* 0x5A1 */ public bool FleetDirectorAutoMode;
        /* 0x5A4 */ public float _3dTextDistance;
        /* 0x5A8 */ public float _3dTextMinScale;
		public enum RecordSettingEnum { None, Record, Playback }
		public RecordSettingEnum RecordSetting;
        /* 0x5B0 */ public bool DebugBuildingSpawns;
        /* 0x5B1 */ public bool StressTestLongNameDisplay;
        [NMS(Size = 0x20)]
        /* 0x5B2 */ public string SaveTestingCommand;
        /* 0x5D2 */ public bool NeverUseBanks;
        /* 0x5D3 */ public bool DisableProfanityFilter;
        /* 0x5D4 */ public bool DisableFileWatcher;
        /* 0x5D5 */ public bool ShowDebugMessages;
        /* 0x5D6 */ public bool ShowFramerate;
        /* 0x5D7 */ public bool ShowPositionDebug;
        /* 0x5D8 */ public bool ShowGPUMemory;
        /* 0x5D9 */ public bool ShowMempoolOverlay;
        /* 0x5DA */ public bool ShowMouseSmoothing;
        [NMS(Size = 0x100)]
        /* 0x5DB */ public string ShowUniverseAddressOnGalaxyMap;
        /* 0x6DB */ public bool ShowGraphs;
        /* 0x6DC */ public int ShowSpecificGraph;
        /* 0x6E0 */ public bool GraphCommandBuffer;
        /* 0x6E1 */ public bool GraphGeneration;
        /* 0x6E2 */ public bool GraphFPS;
        /* 0x6E3 */ public bool GraphTexStreaming;
        /* 0x6E4 */ public bool SmokeTestDumpStatsMode;
		public enum SmokeTestCycleModeEnum { None, TourSolarSystem, RegeneratePlanet }
		public SmokeTestCycleModeEnum SmokeTestCycleMode;
        /* 0x6EC */ public bool SmokeTestCameraFly;
        /* 0x6ED */ public bool SmokeTestOutputOnly;
        /* 0x6EE */ public bool SmokeTestPureFlight;
        /* 0x6F0 */ public int SmokeTestConfigCaptureCycles;
        /* 0x6F4 */ public float SmokeTestConfigCaptureDurationInSeconds;
        /* 0x6F8 */ public int SmokeTestConfigCaptureFolderNameNumberOffset;
        /* 0x6FC */ public bool SmokeTestConfigRandomizePlanetSeed;
		/* 0x6FD */ public bool SmokeTestSmokeBotEnabled;
		/* 0x6FE */ public bool SmokeTestSmokeBotAutoStart;
		/* 0x700 */ public int SmokeTestSmokeBotTargetWarps;
		/* 0x704 */ public bool CreatureChatter;
		/* 0x705 */ public bool CreatureErrors;
		/* 0x706 */ public bool CreatureDrawVocals;
		/* 0x707 */ public bool DrawCreaturesInRoutines;
		/* 0x708 */ public bool ShowFirstPersonCharacterShadow;
		/* 0x709 */ public bool CompressTextures;
		/* 0x70A */ public bool DebugIBL;
		/* 0x70B */ public bool DebugTerrainTextures;
		/* 0x70C */ public bool DisableShadowSwitching;
		[NMS(Size = 0x80)]
		/* 0x70D */ public string PipelineFile;
		[NMS(Size = 0x80)]
		/* 0x78D */ public string PipelineFilePS4;
		[NMS(Size = 0x80)]
		/* 0x80D */ public string PipelineFileXboxOne;
		[NMS(Size = 0x80)]
		/* 0x88D */ public string PipelineFileVR;
		[NMS(Size = 0x80)]
		/* 0x90D */ public string PipelineFileFrontend;
		[NMS(Size = 0x80)]
		/* 0x98D */ public string PipelineFileEditor;
		/* 0xA0D */ public bool RenderLowFramerate;
		/* 0xA0E */ public bool EnableComputePost;
        /* 0xA0F */ public bool EnableEvenOddRender;
		/* 0xA10 */ public bool SimulateNoNetworkConnection;
		public enum ProxyTypeEnum { None, ManualURI, InetProxy }
		/* 0xA14 */ public ProxyTypeEnum ProxyType;
        [NMS(Size = 0x80)]
        /* 0xA18 */ public string ProxyURI;
		public enum ServerEnvEnum { Default, dev, qa, prodqa, prod, custom, pentest }
		/* 0xA98 */ public ServerEnvEnum ServerEnv;
        [NMS(Size = 0x80)]
        /* 0xA9C */ public string AuthBaseUrl;
        /* 0xB1C */ public bool CertificateSecurityBypass;
        [NMS(Size = 0x20)]
        /* 0xB1D */ public string OverrideUsernameForDev;
        /* 0xB40 */ public int DiscoveryAutoSyncIntervalSeconds;
        /* 0xB44 */ public bool DisableSpaceStationSpawnOnJoin;
        /* 0xB45 */ public bool AutoJoinUserEnabled;
        [NMS(Size = 8)]
        /* 0xB46 */ public NMSString0x100[] AutoJoinUserNames;      // this is isn't own struct now but this should work...
        /* 0x1346 */ public bool AlwaysSaveGameAsClient;
        /* 0x1347 */ public bool DisableMonumentDownloads;
        /* 0x1348 */ public bool UsePadOnUnfocusedWindow;
        /* 0x134C */ public int OverrideMatchmakingVersion;
        /* 0x1350 */ public bool IgnoreTransactionTimeouts;
        /* 0x1351 */ public bool EnableSynergy;
        [NMS(Size = 0x20)]
        /* 0x1352 */ public string SynergyServer;
        /* 0x1374 */ public int SynergyPort;
        /* 0x1378 */ public bool ShowEditorPlacementPreview;
        /* 0x137C */ public int MaxNumDebugMessages;
        /* 0x1380 */ public bool PreloadToolbox;
        /* 0x1384 */ public int DebugTextureSize;
        /* 0x1388 */ public bool UseProcTextureDebugger;
        /* 0x138C */ public int ProceduralModelsShown;
        /* 0x1390 */ public int ProceduralModelBatchSize;
        [NMS(Size = 0x80)]
        /* 0x1394 */ public string DebugFont;
        [NMS(Size = 0x80)]
        /* 0x1414 */ public string DebugFontTexture;
        [NMS(Size = 0x80)]
        /* 0x1494 */ public string CursorTexture;
        [NMS(Size = 0x80)]
        /* 0x1514 */ public string PauseTexture;
        [NMS(Size = 0x80)]
        /* 0x1594 */ public string PlayTexture;
        [NMS(Size = 0x80)]
        /* 0x1614 */ public string StepTexture;
        [NMS(Size = 0x80)]
        /* 0x1694 */ public string RenderToTexture;
        /* 0x1714 */ public bool HmdEnable;
        /* 0x1715 */ public bool HmdOutput;
        /* 0x1716 */ public bool HmdTracking;
        /* 0x1717 */ public bool HmdStereoRender;
        /* 0x1718 */ public bool HmdDistortionPassthru;
        /* 0x171C */ public int HmdMonitor;
        /* 0x1720 */ public int HmdEyeBufferWidth;
        /* 0x1724 */ public int HmdEyeBufferHeight;
        /* 0x1728 */ public float HmdEyeScalePos;
        /* 0x172C */ public float HmdHeadScalePos;
        /* 0x1730 */ public float HmdImmersionFactor;
        /* 0x1734 */ public bool ForceExtremeWeather;
        /* 0x1735 */ public bool ForceExtremeSentinels;
        /* 0x1736 */ public bool ForceStarType;
        /* 0x1738 */ public GcGalaxyStarTypes ForceStarTypeTo;

        /* 0x173C */ public bool ForceBiome;
        /* 0x1740 */ public GcBiomeType ForceBiomeTo;
        /* 0x1744 */ public int ForceBiomeFileIndex;
        /* 0x1748 */ public bool ForceBuildingRace;
        /* 0x174C */ public GcAlienRace ForceBuildingRaceTo;
        /* 0x1750 */ public bool ForceLifeLevel;
        /* 0x1754 */ public GcPlanetLife ForceLifeLevelTo;
        /* 0x1758 */ public bool ForceCreatureLifeLevel;
        /* 0x1759 */ public bool ForceDefaultCreatureFile;
        /* 0x175C */ public GcPlanetLife ForceCreatureLifeLevelTo;
        /* 0x1760 */ public int ForceTerrainSettings;                   // there will be an enum/struct
        /* 0x1764 */ public bool ForceTerrainType;
        /* 0x1768 */ public int ForceTerranTypeTo;                      // there will be an enum/struct
		public enum ForceAnomalyToEnum { None, AtlasType1, AtlasType2, Blackhole, Anomaly, Spacewalk }
		/* 0x176C */ public ForceAnomalyToEnum ForceAnomalyTo;
        /* 0x1770 */ public bool ForcePlanetsToHaveWater;
        /* 0x1771 */ public bool ModifyPlanetsInInitialSystems;
        /* 0x1772 */ public bool DisableLimits;
        /* 0x1773 */ public bool LimitPerRegionInstances;
        /* 0x1774 */ public bool LimitPerRegionBodies;
        /* 0x1775 */ public bool LimitGlobalInstances;
        /* 0x1776 */ public bool LimitGlobalBodies;
        /* 0x1778 */ public int GenerateFarLodBuildingDist;
        /* 0x177C */ public bool DeferRegionBodies;
        /* 0x1780 */ public float GenerateCostDistance;
        /* 0x1784 */ public float GenerateCostAngle;
        /* 0x1788 */ public float GenerateCostLOD;
        /* 0x178C */ public float GenerateCostWait;
        /* 0x1790 */ public bool DChecksEnabled;
        /* 0x1791 */ public bool DChecksOutputJson;
        /* 0x1792 */ public bool DChecksOutputBinary;
        /* 0x1793 */ public bool DChecksOutputFileLine;
        /* 0x1794 */ public int FrameFlipRateDefault;
        /* 0x1798 */ public int FrameFlipRateLoad;
        /* 0x179C */ public int FrameFlipRateGame;
        /* 0x17A0 */ public float MaxFrameRate;
        /* 0x17A4 */ public bool DisableBaseBuilding;
        /* 0x17A5 */ public bool DisableBaseBuildingLimits;
        /* 0x17A8 */ public float BaseDownloadTimeout;
    }
}
