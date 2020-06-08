using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(Size = 0x1EB8, GUID = 0xFD526D130190F45E)]
    public class GcDebugOptions : NMSTemplate
    {
        /* 0x0 */ public bool ThirdPersonIsDefaultCamera;
        /* 0x1 */ public bool SkipIntro;
        /* 0x2 */ public bool SkipLogos;
		/* 0x4 */ public int BootDirectlyIntoSaveSlot;
        /* 0x8 */ public bool BootDirectlyIntoLastSave;
		/* 0xC */ public GcGameMode NewSaveGameMode;
		/* 0x10 */ public bool SkipPlanetDiscoverOnBoot;
		/* 0x11 */ public bool VideoCaptureMode;
		/* 0x12 */ public bool GodMode;
		/* 0x13 */ public bool TakeNoDamage;
		/* 0x14 */ public bool AlwaysHaveFocus;
		/* 0x15 */ public bool DisableVibration;
		/* 0x16 */ public bool DebugGalaxyMapInQuickMenu;
		/* 0x17 */ public bool MapWarpCheckIgnoreFuel;
		/* 0x18 */ public bool MapWarpCheckIgnoreDrive;
		/* 0x19 */ public bool EverythingIsFree;
		/* 0x1A */ public bool EverythingIsKnown;
		/* 0x1B */ public bool EverythingIsStar;
		/* 0x1C */ public bool InfiniteStamina;
		/* 0x1D */ public bool IgnoreMissionRank;
		/* 0x1E */ public bool CanLeaveDialogs;
		/* 0x1F */ public bool DisableOldMissions;
		/* 0x20 */ public bool UseScreenEffects;
		/* 0x21 */ public bool UseGunImpactEffect;
		/* 0x22 */ public bool RenderCreatureDetails;
		/* 0x23 */ public bool SkipTutorial;
		/* 0x24 */ public bool IgnoreFreighterSpawnWarpRequirement;
		/* 0x25 */ public bool MaximumFreighterSpawns;
		/* 0x26 */ public bool DisableSaveSlotSorting;
		/* 0x27 */ public bool DisableSaving;
		/* 0x28 */ public bool AlternateControls;
		/* 0x29 */ public bool AlwaysShowURI;
		/* 0x2A */ public bool MPMissionsAlwaysEPIC;
		/* 0x2B */ public bool ShowFireteamMembersUA;
		/* 0x2C */ public bool UseDebugScreenSettings;
		/* 0x30 */ public int ScreenWidth;
		/* 0x34 */ public int ScreenHeight;
		/* 0x38 */ public bool DisableVSync;
		public enum GameWindowModeEnum { Bordered, Borderless, Fullscreen }
		/* 0x3C */ public GameWindowModeEnum GameWindowMode;
        /* 0x40 */ public int Monitor;
        /* 0x44 */ public int TiledWindowsSplitCount;
        /* 0x48 */ public int TiledWindowsIndex;
        [NMS(Size = 0x100)]
        /* 0x4C */ public string ForceUniverseAddress;
        [NMS(Size = 0x100)]
        /* 0x14C */ public string ForcePlayerPosition;
        /* 0x24C */ public bool ForceInitialShip;
        /* 0x24D */ public bool ForceInitialWeapon;
		public enum GameStateModeEnum { LoadPreset, UserStorage, FreshStart }
		/* 0x250 */ public GameStateModeEnum GameStateMode;
		public enum BootModeEnum { MinimalSolarSystem, SolarSystem, GalaxyMap, SmokeTest, SmokeTestGalaxyMap, Scratchpad, UnitTest }
		/* 0x254 */ public BootModeEnum BootMode;
		public enum PlayerSpawnLocationOverrideEnum { None, FromSettings, Space, SpaceStation, RandomPlanet, GameStartPlanet, SpecificLocation }
		/* 0x258 */ public PlayerSpawnLocationOverrideEnum PlayerSpawnLocationOverride;
        [NMS(Size = 0x80)]
        /* 0x25C */ public string SceneSettings;
        [NMS(Size = 0x100)]
        /* 0x2DC */ public string WorkingDirectory;
		public enum SolarSystemBootEnum { FromSettings, Generate }
		/* 0x3DC */ public SolarSystemBootEnum SolarSystemBoot;
		public enum ShaderPreloadEnum { Off, Full }
		/* 0x3E0 */ public ShaderPreloadEnum ShaderPreload;
        /* 0x3E4 */ public bool ShaderPreloadListExport;
        /* 0x3E5 */ public bool ShaderPreloadListImport;
        /* 0x3E6 */ public bool ShaderCaching;
		public enum BootLoadDelayEnum { LoadAll, WaitForPlanet, WaitForNothing }
		/* 0x3E8 */ public BootLoadDelayEnum BootLoadDelay;
        /* 0x3EC */ public bool MemCsv;
		/* 0x3F0 */ public float ForceTimeOfDay;
		/* 0x3F4 */ public bool ForceSunDirectionFromPhotoMode;
		/* 0x3F8 */ public float ForceSunAngle;
		/* 0x3FC */ public bool ResetForcedSaveSlotOnLoad;
		/* 0x3FD */ public bool UseParticles;
		/* 0x3FE */ public bool UseHeavyAir;
		/* 0x3FF */ public bool UseVolumetrics;
		/* 0x400 */ public bool UseClouds;
		/* 0x401 */ public bool EnableCloudAnimation;
		/* 0x402 */ public bool UseTerrain;
		/* 0x403 */ public bool UseInstances;
		/* 0x404 */ public bool UseObjects;
		/* 0x405 */ public bool UseBuildings;
		/* 0x406 */ public bool UseCreatures;
		/* 0x407 */ public bool UseElevation;
		/* 0x408 */ public bool UseLegacyFreighters;
		/* 0x409 */ public bool UseLegacyBuildingTable;
		/* 0x40A */ public bool EnableDayNightCycle;
		/* 0x40B */ public bool SpawnPirates;
		/* 0x40C */ public bool SpawnRobots;
		/* 0x40D */ public bool SpawnShips;
		/* 0x40E */ public bool SpawnPulseEncounters;
		/* 0x40F */ public bool InstanceCollision;
		/* 0x410 */ public bool MPMissions;
		/* 0x411 */ public bool SpecialsShop;
		/* 0x412 */ public bool MultiplePlayerFreightersInASystem;
		/* 0x413 */ public bool ForceNexusInQuickMenu;
		/* 0x414 */ public bool MouseLookEnabled;
		/* 0x415 */ public bool StartPaused;
		/* 0x416 */ public bool DisableDebugControls;
		/* 0x417 */ public bool FixedFramerate;
		/* 0x418 */ public bool ScreenshotMode;
		/* 0x419 */ public bool RenderHud;
		/* 0x41A */ public bool DisableDiscoveryNaming;
		/* 0x41B */ public bool DebugDrawPlayerInteract;
		/* 0x41C */ public bool ForceInteractionToSettings;
		/* 0x420 */ public int ForceInteractionIndex;
		/* 0x424 */ public bool InteractionsAllwaysGivesTech;
		/* 0x425 */ public bool InfiniteInteractions;
		/* 0x426 */ public bool StopSwitchingToSecondaryInteractions;
        /* 0x428 */ public TkLanguages DebugLanguage;
        [NMS(Size = 0x20)]
        /* 0x42C */ public string AllowedLanguagesFile;
        /* 0x44C */ public bool DoAlienLanguage;
        /* 0x450 */ public GcAlienRace ForceInteractionRaceTo;
        public enum RealityModeEnum { LoadPreset, Generate }
        /* 0x454 */ public RealityModeEnum RealityMode;
        /* 0x458 */ public bool DebugPersistentInteractions;
        /* 0x459 */ public bool DisableMissionShop;
        [NMS(Size = 0x80)]
        /* 0x45A */ public string RealityPresetFile;
        /* 0x4DA */ public ushort RealityGenerationIteration;
        [NMS(Size = 0x5)]
        /* 0x4DC */ public NMSString0x20[] LocTableList;
        [NMS(Size = 0x80)]
        /* 0x57C */ public string DefaultSaveData;
        /* 0x5FC */ public bool FormatDownloadStorageAreaOnBoot;
        /* 0x5FD */ public bool ForceBasicLoadScreen;
        /* 0x600 */ public float BootLogoFadeRate;
        /* 0x604 */ public bool BootMusic;
        /* 0x608 */ public float WeaponScale3P;
        /* 0x60C */ public bool LogMissingLocalisedText;
        /* 0x60D */ public bool FleetDirectorAutoMode;
        /* 0x610 */ public float _3dTextDistance;
        /* 0x614 */ public float _3dTextMinScale;
		public enum RecordSettingEnum { None, Record, Playback }
		/* 0x618 */ public RecordSettingEnum RecordSetting;
        /* 0x61C */ public bool DebugBuildingSpawns;
        /* 0x61D */ public bool StressTestLongNameDisplay;
        /* 0x61E */ public bool ShowLongestStrings;
        [NMS(Size = 0x20)]
        /* 0x61F */ public string SaveTestingCommand;
        /* 0x63F */ public bool NeverUseBanks;
        /* 0x640 */ public bool DisableProfanityFilter;
        /* 0x641 */ public bool DisableFileWatcher;
        /* 0x642 */ public bool DisableShaderReload;
        /* 0x644 */ public int RecurrenceTimeOffset;
        [NMS(Size = 0x80)]
        /* 0x648 */ public string CrashDumpPath;
        [NMS(Size = 0x20)]
        /* 0x6C8 */ public string CrashDumpIdentifier;
        /* 0x6E8 */ public bool EnableLivePP;
        /* 0x6E9 */ public bool ShowDebugMessages;
        /* 0x6EA */ public bool ShowFramerate;
        /* 0x6EB */ public bool PrintAvgFrameTimes;
        /* 0x6EC */ public bool ShowPositionDebug;
        /* 0x6ED */ public bool ShowGPUMemory;
        /* 0x6EE */ public bool ShowMempoolOverlay;
        /* 0x6EF */ public bool ShowMouseSmoothing;
        [NMS(Size = 0x100)]
        /* 0x6F0 */ public string ShowUniverseAddressOnGalaxyMap;
        /* 0x7F0 */ public bool ShowGraphs;
        /* 0x7F4 */ public int ShowSpecificGraph;
        /* 0x7F8 */ public bool GraphCommandBuffer;
        /* 0x7F9 */ public bool GraphGeneration;
        /* 0x7FA */ public bool GraphFPS;
        /* 0x7FB */ public bool GraphTexStreaming;
        /* 0x7FC */ public bool SmokeTestDumpStatsMode;
		public enum SmokeTestCycleModeEnum { None, TourSolarSystem, RegeneratePlanet }
		/* 0x800 */ public SmokeTestCycleModeEnum SmokeTestCycleMode;
        /* 0x804 */ public bool SmokeTestCameraFly;
        /* 0x805 */ public bool SmokeTestOutputOnly;
        /* 0x806 */ public bool SmokeTestPureFlight;
        /* 0x808 */ public int SmokeTestConfigCaptureCycles;
        /* 0x80C */ public float SmokeTestConfigCaptureDurationInSeconds;
        /* 0x810 */ public int SmokeTestConfigCaptureFolderNameNumberOffset;
        /* 0x814 */ public bool SmokeTestConfigRandomizePlanetSeed;
		/* 0x815 */ public bool SmokeTestSmokeBotEnabled;
		/* 0x816 */ public bool SmokeTestSmokeBotAutoStart;
		/* 0x818 */ public int SmokeTestSmokeBotTargetWarps;
        /* 0x81C */ public bool SmokeTestPostBandwidthStats;
		/* 0x81D */ public bool CreatureChatter;
		/* 0x81E */ public bool CreatureErrors;
		/* 0x81F */ public bool CreatureDrawVocals;
		/* 0x820 */ public bool DrawCreaturesInRoutines;
		/* 0x821 */ public bool CompressTextures;
		/* 0x822 */ public bool DebugIBL;
		/* 0x823 */ public bool DebugTerrainTextures;
		/* 0x824 */ public bool DisableShadowSwitching;
		[NMS(Size = 0x80)]
		/* 0x825 */ public string PipelineFile;
		[NMS(Size = 0x80)]
		/* 0x8A5 */ public string PipelineFilePS4;
		[NMS(Size = 0x80)]
		/* 0x925 */ public string PipelineFileXboxOne;
		[NMS(Size = 0x80)]
		/* 0x9A5 */ public string PipelineFileVR;
        [NMS(Size = 0x80)]
		/* 0xA25 */ public string PipelineFileVRPS4;
		[NMS(Size = 0x80)]
		/* 0xAA5 */ public string PipelineFileFrontend;
		[NMS(Size = 0x80)]
		/* 0xB25 */ public string PipelineFileEditor;
		/* 0xBA5 */ public bool RenderLowFramerate;
		/* 0xBA6 */ public bool EnableComputePost;
        /* 0xBA7 */ public bool EnableEvenOddRender;
		/* 0xBA8 */ public bool MinGPUMode;
        /* 0xBA9 */ public bool AlwaysIncludeLocalPlayerInChatMessage;
        /* 0xBAA */ public bool SimulateNoNetworkConnection;
		public enum ProxyTypeEnum { None, ManualURI, InetProxy }
		/* 0xBAC */ public ProxyTypeEnum ProxyType;
        [NMS(Size = 0x80)]
        /* 0xBB0 */ public string ProxyURI;
		public enum ServerEnvEnum { Default, dev, qa, prodqa, prod, custom, pentest }
		/* 0xC30 */ public ServerEnvEnum ServerEnv;
        [NMS(Size = 0x80)]
        /* 0xC34 */ public string AuthBaseUrl;
        /* 0xCB4 */ public bool CertificateSecurityBypass;
        [NMS(Size = 0x20)]
        /* 0xCB5 */ public string OverrideUsernameForDev;
        /* 0xCD8 */ public int DiscoveryAutoSyncIntervalSeconds;
        /* 0xCDC */ public bool DisableSpaceStationSpawnOnJoin;
        /* 0xCDD */ public bool AutoJoinUserEnabled;
        [NMS(Size = 8)]
        /* 0xCDE */ public NMSString0x100[] AutoJoinUserNames;      // this is its own struct now but this should work...
        /* 0x14DE */ public bool AlwaysSaveGameAsClient;
        /* 0x14DF */ public bool DisableMonumentDownloads;
        /* 0x14E0 */ public bool UsePadOnUnfocusedWindow;
        /* 0x14E4 */ public int OverrideMatchmakingVersion;
        [NMS(Size = 0x200)]
        /* 0x14E8 */ public string LoadToBase;
        /* 0x16E8 */ public bool IgnoreTransactionTimeouts;
        /* 0x16E9 */ public bool AutoJoinRandomGames;
        [NMS(Size = 0x100)]
        /* 0x16EA */ public string GOGLogin;
        /* 0x17EA */ public bool RecordNetworkStatsOnBoot;
        /* 0x17EB */ public bool FakeHandsInMultiplayer;
        /* 0x17EC */ public bool ForceSmallLobby;
        /* 0x17ED */ public bool EnableSynergy;
        [NMS(Size = 0x20)]
        /* 0x17EE */ public string SynergyServer;
        /* 0x1810 */ public int SynergyPort;
        /* 0x1814 */ public bool ShowEditorPlacementPreview;
        /* 0x1818 */ public int MaxNumDebugMessages;
        /* 0x181C */ public bool PreloadToolbox;
        /* 0x1820 */ public int DebugTextureSize;
        /* 0x1824 */ public bool UseProcTextureDebugger;
        /* 0x1828 */ public int ProceduralModelsShown;
        /* 0x182C */ public int ProceduralModelBatchSize;
        [NMS(Size = 0x80)]
        /* 0x1830 */ public string DebugFont;
        [NMS(Size = 0x80)]
        /* 0x18B0 */ public string DebugFontTexture;
        [NMS(Size = 0x80)]
        /* 0x1930 */ public string CursorTexture;
        [NMS(Size = 0x80)]
        /* 0x19B0 */ public string PauseTexture;
        [NMS(Size = 0x80)]
        /* 0x1A30 */ public string PlayTexture;
        [NMS(Size = 0x80)]
        /* 0x1AB0 */ public string StepTexture;
        [NMS(Size = 0x80)]
        /* 0x1B30 */ public string RenderToTexture;
		/* 0x1BB0 */ public bool HmdEnable;
		/* 0x1BB4 */ public int HmdPreviewScale;
		/* 0x1BB8 */ public bool HmdTracking;
		/* 0x1BB9 */ public bool HmdStereoRender;
		/* 0x1BBA */ public bool HmdDistortionPassthru;
		/* 0x1BBC */ public int HmdMonitor;
		/* 0x1BC0 */ public int HmdEyeBufferWidth;
		/* 0x1BC4 */ public int HmdEyeBufferHeight;
		/* 0x1BC8 */ public float HmdEyeScalePos;
		/* 0x1BCC */ public float HmdHeadScalePos;
		/* 0x1BD0 */ public bool HmdFrameShiftEnabled;
		/* 0x1BD1 */ public bool HmdUseSolidGuiPointer;
		/* 0x1BD2 */ public bool BodyTurning;
		/* 0x1BD4 */ public float HmdImmersionFactor;
		/* 0x1BD8 */ public bool ShowHmdHandControllers;
		/* 0x1BD9 */ public bool ShowTeleportEffectLocally;
		/* 0x1BDA */ public bool DisableLeftHand;
		/* 0x1BDB */ public bool DisableHeadConstraints;
		/* 0x1BDC */ public bool EnablePhotomodeVR;
		/* 0x1BDD */ public bool AllowNGuiVR;
		/* 0x1BDE */ public bool ForceExtremeWeather;
		/* 0x1BDF */ public bool ForceExtremeSentinels;
        /* 0x1BE0 */ public bool ForceStarType;
        /* 0x1BE4 */ public GcGalaxyStarTypes ForceStarTypeTo;
        /* 0x1BE8 */ public bool ForceBiome;
        /* 0x1BEC */ public GcBiomeType ForceBiomeTo;
        /* 0x1BF0 */ public GcBiomeSubType ForceBiomeSubTypeTo;
        /* 0x1BF4 */ public bool ForceBuildingRace;
        /* 0x1BF8 */ public GcAlienRace ForceBuildingRaceTo;
        /* 0x1BFC */ public bool ForceLifeLevel;
        /* 0x1C00 */ public GcPlanetLife ForceLifeLevelTo;
        /* 0x1C04 */ public bool ForceCreatureLifeLevel;
        /* 0x1C05 */ public bool ForceDefaultCreatureFile;
        /* 0x1C08 */ public GcPlanetLife ForceCreatureLifeLevelTo;
        /* 0x1C0C */ public GcPlanetLife ForceTerrainSettings;
        /* 0x1C10 */ public bool ForceTerrainType;
        /* 0x1C14 */ public TkVoxelGeneratorSettingsTypes ForceTerranTypeTo;
		/* 0x1C18 */ public GcGalaxyStarAnomaly ForceAnomalyTo;
        /* 0x1C1C */ public bool ForcePlanetsToHaveWater;
        /* 0x1C20 */ public int ForceWaterObjectFileIndex;
        /* 0x1C24 */ public int ForceSkyColourIndex;
        /* 0x1C28 */ public int ForceWaterColourIndex;
        /* 0x1C2C */ public bool ModifyPlanetsInInitialSystems;
        /* 0x1C2D */ public bool DisableLimits;
        /* 0x1C2E */ public bool LimitPerRegionInstances;
        /* 0x1C2F */ public bool LimitPerRegionBodies;
        /* 0x1C30 */ public bool LimitGlobalInstances;
        /* 0x1C31 */ public bool LimitGlobalBodies;
        /* 0x1C34 */ public int GenerateFarLodBuildingDist;
        /* 0x1C38 */ public bool DeferRegionBodies;
        /* 0x1C3C */ public float GenerateCostDistance;
        /* 0x1C40 */ public float GenerateCostAngle;
        /* 0x1C44 */ public float GenerateCostLOD;
        /* 0x1C48 */ public float GenerateCostWait;
        /* 0x1C4C */ public bool DChecksEnabled;
        /* 0x1C4D */ public bool DChecksOutputJson;
        /* 0x1C4E */ public bool DChecksOutputBinary;
        /* 0x1C4F */ public bool DChecksOutputFileLine;
        /* 0x1C50 */ public int FrameFlipRateDefault;
        /* 0x1C54 */ public int FrameFlipRateLoad;
        /* 0x1C58 */ public int FrameFlipRateGame;
        /* 0x1C5C */ public float MaxFrameRate;
        /* 0x1C60 */ public bool DisableBaseBuilding;
        /* 0x1C61 */ public bool DisableBaseBuildingLimits;
        /* 0x1C64 */ public float BaseDownloadTimeout;
        /* 0x1C68 */ public bool DisableBasePowerRequirements;
        /* 0x1C69 */ public bool EnableBaseMovingOption;
        /* 0x1C6C */ public int MoveBaseIndex;
        /* 0x1C70 */ public int AutomaticPartSpawnIndex;
        /* 0x1C74 */ public bool GenerateAbandonedCivilianFreighterBases;
        /* 0x1C75 */ public bool BaseAdmin;
        [NMS(Size = 0x20)]
        /* 0x1C76 */ public string BaseServerPlatform;       // "pc"
        /* 0x1C98 */ public uint BasePayloadMultiplier;      // I think this is a uint...
        /* 0x1C9C */ public bool CrossPlatformFeaturedBases;
        /* 0x1C9D */ public bool ShowMissionIdInTitle;
        [NMS(Size = 0x2, Ignore = true)]
        /* 0x1C9E */ public byte[] Padding1C9E;
        /* 0x1CA0 */ public TkGlobals ToolkitGlobals;
    }
}
