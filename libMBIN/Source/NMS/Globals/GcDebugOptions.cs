using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(Size = 0x1EB4, GUID = 0x4EBE528EBF89E743)]
    public class GcDebugOptions : NMSTemplate
    {
        /* 0x0 */ public bool ThirdPersonIsDefaultCamera;
        /* 0x1 */ public bool SkipIntro;
        /* 0x2 */ public bool SkipLogos;
		/* 0x4 */ public int BootDirectlyIntoSaveSlot;
        /* 0x8 */ public bool Unknown0x8;
		/* 0xC */ public GcGameMode NewSaveGameMode;
		/* 0x10 */ public bool SkipPlanetDiscoverOnBoot;
		/* 0x11 */ public bool VideoCaptureMode;
		/* 0x12 */ public bool GodMode;
		/* 0x13 */ public bool AlwaysHaveFocus;
		/* 0x14 */ public bool DisableVibration;
		/* 0x15 */ public bool MapWarpCheckIgnoreFuel;
		/* 0x16 */ public bool MapWarpCheckIgnoreDrive;
		/* 0x17 */ public bool EverythingIsFree;
		/* 0x18 */ public bool EverythingIsKnown;
		/* 0x19 */ public bool EverythingIsStar;
		/* 0x1A */ public bool IgnoreMissionRank;
		/* 0x1B */ public bool CanLeaveDialogs;
        /* 0x1C */ public bool Unknown0x1C;             // this could potentially be anywhere within this chunk.
        /* 0x1D */ public bool Unknown0x1D;
		/* 0x1E */ public bool DisableOldMissions;
		/* 0x1F */ public bool UseScreenEffects;
		/* 0x20 */ public bool UseGunImpactEffect;
        /* 0x21 */ public bool Unknown0x21;             // this could potentially be anywhere within this chunk.
		/* 0x22 */ public bool RenderCreatureDetails;
		/* 0x23 */ public bool SkipTutorial;
		/* 0x24 */ public bool IgnoreFreighterSpawnWarpRequirement;
		/* 0x25 */ public bool DisableSaveSlotSorting;
		/* 0x26 */ public bool DisableSaving;           // Don't know where these two known values are
		/* 0x27 */ public bool UseDebugScreenSettings;
        /* 0x28 */ public bool Unknown0x28;
        /* 0x29 */ public bool Unknown0x29;

		/* 0x2C */ public int ScreenWidth;
		/* 0x30 */ public int ScreenHeight;
		/* 0x34 */ public bool DisableVSync;
		public enum GameWindowModeEnum { Bordered, Borderless, Fullscreen }
		/* 0x38 */ public GameWindowModeEnum GameWindowMode;
        /* 0x3C */ public int Monitor;
        /* 0x40 */ public int UnknownInt0x40;   // Possibly the default value for some Enum...
        /* 0x44 */ public int UnknownInt0x44;
        [NMS(Size = 0x100)]
        /* 0x48 */ public string ForceUniverseAddress;
        [NMS(Size = 0x100)]
        /* 0x148 */ public string ForcePlayerPosition;
        /* 0x248 */ public bool ForceInitialShip;
        /* 0x249 */ public bool ForceInitialWeapon;
		public enum GameStateModeEnum { LoadPreset, UserStorage, FreshStart }
		/* 0x24C */ public GameStateModeEnum GameStateMode;
		public enum BootModeEnum { MinimalSolarSystem, SolarSystem, GalaxyMap, SmokeTest, SmokeTestGalaxyMap, Scratchpad, UnitTest }
		/* 0x250 */ public BootModeEnum BootMode;
		public enum PlayerSpawnLocationOverrideEnum { None, FromSettings, Space, SpaceStation, RandomPlanet, GameStartPlanet }
		/* 0x254 */ public PlayerSpawnLocationOverrideEnum PlayerSpawnLocationOverride;
        [NMS(Size = 0x80)]
        /* 0x258 */ public string SceneSettings;
        [NMS(Size = 0x100)]
        /* 0x2D8 */ public string WorkingDirectory;
		public enum SolarSystemBootEnum { FromSettings, Generate }
		/* 0x3D8 */ public SolarSystemBootEnum SolarSystemBoot;
		public enum ShaderPreloadEnum { Off, Full }
		/* 0x3DC */ public ShaderPreloadEnum ShaderPreload;
        /* 0x3E0 */ public bool ShaderPreloadListExport;
        /* 0x3E1 */ public bool ShaderPreloadListImport;
        /* 0x3E2 */ public bool ShaderCaching;
		public enum BootLoadDelayEnum { LoadAll, WaitForPlanet, WaitForNothing }
		/* 0x3E4 */ public BootLoadDelayEnum BootLoadDelay;
        /* 0x3E8 */ public bool MemCsv;
        /* 0x3EC */ public float ForceTimeOfDay;

        // Start of "block of mess". The following values could be quite wrong. Lots of testing needed!!

        /* 0x3F0 */ public bool Unknown0x3F0;
        /* 0x3F4 */ public float Unknown0x3F4;          // don't actually know what the data type of this is... either int, float
        /* 0x3F8 */ public bool Unknown0x3F1;
        /* 0x3F9 */ public bool UseParticles;
        /* 0x3FA */ public bool UseVolumetrics;
        /* 0x3FB */ public bool UseClouds;
        /* 0x3FC */ public bool UseTerrain;
        /* 0x3FD */ public bool UseInstances;
        /* 0x3FE */ public bool UseObjects;
        /* 0x3FF */ public bool UseBuildings;
        /* 0x400 */ public bool UseCreatures;
        /* 0x401 */ public bool UseElevation;
        /* 0x402 */ public bool Unknown0x402;
        /* 0x403 */ public bool Unknown0x403;
        /* 0x404 */ public bool Unknown0x404;
        /* 0x405 */ public bool UseLegacyFreighters;
        /* 0x406 */ public bool Unknown0x406;
        /* 0x407 */ public bool SpawnPirates;
        /* 0x408 */ public bool SpawnRobots;
        /* 0x409 */ public bool SpawnShips;
        /* 0x40A */ public bool InstanceCollision;
        /* 0x40B */ public bool MPMissions;
        /* 0x40C */ public bool Unknown0x40C;
        /* 0x40D */ public bool Unknown0x40D;
        /* 0x40E */ public bool SpecialsShop;
		/* 0x40F */ public bool MultiplePlayerFreightersInASystem;

        // End of "block of mess" (?)

		/* 0x410 */ public bool MouseLookEnabled;
		/* 0x411 */ public bool StartPaused;
		/* 0x412 */ public bool DisableDebugControls;
		/* 0x413 */ public bool DisableAsserts;
		/* 0x414 */ public bool FixedFramerate;
		//* 0x414 */ public bool ScreenshotMode;        // It's this or the above 4 bools that is no longer used (may be impossible to determine...)
		/* 0x415 */ public bool RenderHud;
		/* 0x416 */ public bool DisableDiscoveryNaming;
		/* 0x417 */ public bool DebugDrawPlayerInteract;
		/* 0x418 */ public bool ForceInteractionToSettings;
		/* 0x41C */ public int ForceInteractionIndex;
        /* 0x420 */ public bool InteractionsAllwaysGivesTech;
        /* 0x421 */ public bool InfiniteInteractions;
        /* 0x422 */ public bool StopSwitchingToSecondaryInteractions;
        /* 0x424 */ public float DebugLanguage;

        [NMS(Size = 0x20)]
        /* 0x428 */ public string AllowedLanguagesFile;
        /* 0x448 */ public bool DoAlienLanguage;
        /* 0x44C */ public float ForceInteractionRaceTo;
        /* 0x450 */ public float RealityMode;
        /* 0x454 */ public bool DebugPersistentInteractions;
        /* 0x455 */ public bool Unknown0x455;
        [NMS(Size = 0x80)]
        /* 0x456 */ public string RealityPresetFile;
        /* 0x4D6 */ public short RealityGenerationIteration;
        [NMS(Size = 0x5)]
        /* 0x4D8 */ public NMSString0x20[] LocTableList;
        [NMS(Size = 0x80)]
        /* 0x578 */ public string DefaultSaveData;
        /* 0x5F8 */ public bool FormatDownloadStorageAreaOnBoot;
        /* 0x5F9 */ public bool ForceBasicLoadScreen;
        /* 0x5FC */ public float BootLogoFadeRate;
        /* 0x600 */ public bool BootMusic;
        /* 0x604 */ public float WeaponScale3P;
        /* 0x608 */ public bool LogMissingLocalisedText;
        /* 0x609 */ public bool FleetDirectorAutoMode;
        /* 0x60C */ public float _3dTextDistance;
        /* 0x610 */ public float _3dTextMinScale;
		public enum RecordSettingEnum { None, Record, Playback }
		/* 0x614 */ public RecordSettingEnum RecordSetting;
        /* 0x618 */ public bool DebugBuildingSpawns;
        /* 0x619 */ public bool StressTestLongNameDisplay;
        /* 0x61A */ public bool Unknown0x61A;
        [NMS(Size = 0x20)]
        /* 0x61B */ public string SaveTestingCommand;
        /* 0x63B */ public bool NeverUseBanks;
        /* 0x63C */ public bool DisableProfanityFilter;
        /* 0x63D */ public bool DisableFileWatcher;
        /* 0x63E */ public bool Unknown0x63E;
        /* 0x640 */ public int RecurrenceTimeOffset;
        [NMS(Size = 0x80)]
        /* 0x644 */ public string Unknown0x644;
        [NMS(Size = 0x20)]
        /* 0x6C4 */ public string Unknown0x6C4;
        /* 0x6E4 */ public bool Unknown0x6E4;
        /* 0x6E5 */ public bool ShowDebugMessages;
        /* 0x6E6 */ public bool ShowFramerate;
        /* 0x6E7 */ public bool ShowPositionDebug;
        /* 0x6E8 */ public bool Unknown0x6E8;
        /* 0x6E9 */ public bool ShowGPUMemory;
        /* 0x6EA */ public bool ShowMempoolOverlay;
        /* 0x6EB */ public bool ShowMouseSmoothing;

        [NMS(Size = 0x100)]
        /* 0x6EC */ public string ShowUniverseAddressOnGalaxyMap;
        /* 0x7EC */ public bool ShowGraphs;
        /* 0x7F0 */ public int ShowSpecificGraph;
        /* 0x7F4 */ public bool GraphCommandBuffer;
        /* 0x7F5 */ public bool GraphGeneration;
        /* 0x7F6 */ public bool GraphFPS;
        /* 0x7F7 */ public bool GraphTexStreaming;
        /* 0x7F8 */ public bool SmokeTestDumpStatsMode;
		public enum SmokeTestCycleModeEnum { None, TourSolarSystem, RegeneratePlanet }
		/* 0x7FC */ public SmokeTestCycleModeEnum SmokeTestCycleMode;
        /* 0x800 */ public bool SmokeTestCameraFly;
        /* 0x801 */ public bool SmokeTestOutputOnly;
        /* 0x802 */ public bool SmokeTestPureFlight;
        /* 0x804 */ public int SmokeTestConfigCaptureCycles;
        /* 0x808 */ public float SmokeTestConfigCaptureDurationInSeconds;
        /* 0x80C */ public int SmokeTestConfigCaptureFolderNameNumberOffset;
        /* 0x810 */ public bool SmokeTestConfigRandomizePlanetSeed;
		/* 0x811 */ public bool SmokeTestSmokeBotEnabled;
		/* 0x812 */ public bool SmokeTestSmokeBotAutoStart;
		/* 0x814 */ public int SmokeTestSmokeBotTargetWarps;
		/* 0x818 */ public bool CreatureChatter;
		/* 0x819 */ public bool CreatureErrors;
		/* 0x81A */ public bool CreatureDrawVocals;
		/* 0x81B */ public bool DrawCreaturesInRoutines;
		/* 0x81C */ public bool ShowFirstPersonCharacterShadow;
		/* 0x81D */ public bool CompressTextures;
		/* 0x81E */ public bool DebugIBL;
		/* 0x81F */ public bool DebugTerrainTextures;
		/* 0x820 */ public bool DisableShadowSwitching;
		[NMS(Size = 0x80)]
		/* 0x821 */ public string PipelineFile;
		[NMS(Size = 0x80)]
		/* 0x8A1 */ public string PipelineFilePS4;
		[NMS(Size = 0x80)]
		/* 0x921 */ public string PipelineFileXboxOne;
		[NMS(Size = 0x80)]
		/* 0x9A1 */ public string PipelineFileVR;
        [NMS(Size = 0x80)]
		/* 0xA21 */ public string PipelineFileVRPS4;
		[NMS(Size = 0x80)]
		/* 0xAA1 */ public string PipelineFileFrontend;
		[NMS(Size = 0x80)]
		/* 0xB21 */ public string PipelineFileEditor;
		/* 0xBA1 */ public bool RenderLowFramerate;
		/* 0xBA2 */ public bool EnableComputePost;
        /* 0xBA3 */ public bool EnableEvenOddRender;
		/* 0xBA4 */ public bool SimulateNoNetworkConnection;
        /* 0xBA5 */ public bool Unknown0xBA5;
        /* 0xBA6 */ public bool Unknown0xBA6;
		public enum ProxyTypeEnum { None, ManualURI, InetProxy }
		/* 0xBA8 */ public ProxyTypeEnum ProxyType;

        [NMS(Size = 0x80)]
        /* 0xBAC */ public string ProxyURI;
		public enum ServerEnvEnum { Default, dev, qa, prodqa, prod, custom, pentest }
		/* 0xC2C */ public ServerEnvEnum ServerEnv;
        [NMS(Size = 0x80)]
        /* 0xC30 */ public string AuthBaseUrl;
        /* 0xCB0 */ public bool CertificateSecurityBypass;
        [NMS(Size = 0x20)]
        /* 0xCB1 */ public string OverrideUsernameForDev;
        /* 0xCD4 */ public int DiscoveryAutoSyncIntervalSeconds;
        /* 0xCD8 */ public bool DisableSpaceStationSpawnOnJoin;
        /* 0xCD9 */ public bool AutoJoinUserEnabled;
        [NMS(Size = 8)]
        /* 0xCDA */ public NMSString0x100[] AutoJoinUserNames;      // this is its own struct now but this should work...
        /* 0x14DA */ public bool AlwaysSaveGameAsClient;
        /* 0x14DB */ public bool DisableMonumentDownloads;
        /* 0x14DC */ public bool UsePadOnUnfocusedWindow;
        /* 0x14E0 */ public int OverrideMatchmakingVersion;
        [NMS(Size = 0x200)]
        /* 0x14E4 */ public string Unknown0x14E4;
        /* 0x16E4 */ public bool IgnoreTransactionTimeouts;
        /* 0x16E5 */ public bool Unknown0x16E5;
        [NMS(Size = 0x100)]
        /* 0x16E6 */ public string Unknown0x16E6;
        /* 0x17E6 */ public bool Unknown0x17E6;
        /* 0x17E7 */ public bool Unknown0x17E7;
        /* 0x17E8 */ public bool EnableSynergy;
        [NMS(Size = 0x20)]
        /* 0x17E9 */ public string SynergyServer;
        /* 0x180C */ public int SynergyPort;
        /* 0x1810 */ public bool ShowEditorPlacementPreview;
        /* 0x1814 */ public int MaxNumDebugMessages;
        /* 0x1818 */ public bool PreloadToolbox;
        /* 0x181C */ public int DebugTextureSize;
        /* 0x1820 */ public bool UseProcTextureDebugger;
        /* 0x1824 */ public int ProceduralModelsShown;
        /* 0x1828 */ public int ProceduralModelBatchSize;
        [NMS(Size = 0x80)]
        /* 0x182C */ public string DebugFont;
        [NMS(Size = 0x80)]
        /* 0x18AC */ public string DebugFontTexture;
        [NMS(Size = 0x80)]
        /* 0x192C */ public string CursorTexture;
        [NMS(Size = 0x80)]
        /* 0x19AC */ public string PauseTexture;
        [NMS(Size = 0x80)]
        /* 0x1A2C */ public string PlayTexture;
        [NMS(Size = 0x80)]
        /* 0x1AAC */ public string StepTexture;
        [NMS(Size = 0x80)]
        /* 0x1B2C */ public string RenderToTexture;

        // Not sure about this block...
        /* 0x1BAC */ public bool HmdEnable;
        /* 0x1BB0 */ public int UnknownInt0x1BB0;
        /* 0x1BB4 */ public bool HmdOutput;
        /* 0x1BB5 */ public bool HmdTracking;
        /* 0x1BB6 */ public bool HmdStereoRender;
        ///* 0x1BB7 */ public bool HmdDistortionPassthru;         // Arbitrarily removing this value

        /* 0x1BB8 */ public int HmdMonitor;
        /* 0x1BBC */ public int HmdEyeBufferWidth;
        /* 0x1BC0 */ public int HmdEyeBufferHeight;

        /* 0x1BC4 */ public float HmdEyeScalePos;
        /* 0x1BC8 */ public float HmdHeadScalePos;
        /* 0x1BCC */ public bool Unknown0x1BCC;                 // these may have picked up a bool from above
        /* 0x1BCD */ public bool Unknown0x1BCD;
        /* 0x1BCE */ public bool Unknown0x1BCE;
        /* 0x1BD0 */ public float HmdImmersionFactor;

        // Don't know how many bools there are. There should be at least as it is a qword...
        /* 0x1BD4 */ public bool Unknown0x1BD4;
        /* 0x1BD5 */ public bool Unknown0x1BD5;
        /* 0x1BD6 */ public bool Unknown0x1BD6;         // this is True
        /* 0x1BD7 */ public bool Unknown0x1BD7;
        /* 0x1BD8 */ public bool Unknown0x1BD8;
        /* 0x1BD9 */ public bool Unknown0x1BD9;
        /* 0x1BDA */ public bool Unknown0x1BDA;
        /* 0x1BDB */ public bool ForceExtremeWeather;       // I am going to assume this has been absorbed into one of the above bools as there are only 2 at 0x19D4
        /* 0x1BDC */ public bool ForceExtremeSentinels;
        /* 0x1BDD */ public bool ForceStarType;
        /* 0x1BE0 */ public GcGalaxyStarTypes ForceStarTypeTo;
        /* 0x1BE4 */ public bool ForceBiome;
        /* 0x1BE8 */ public GcBiomeType ForceBiomeTo;
        /* 0x1BEC */ public GcBiomeSubType ForceBiomeSubTypeTo;
        /* 0x1BF0 */ public bool ForceBuildingRace;
        /* 0x1BF4 */ public GcAlienRace ForceBuildingRaceTo;
        /* 0x1BF8 */ public bool ForceLifeLevel;
        /* 0x1BFC */ public GcPlanetLife ForceLifeLevelTo;
        /* 0x1C00 */ public bool ForceCreatureLifeLevel;
        /* 0x1C01 */ public bool ForceDefaultCreatureFile;
        /* 0x1C04 */ public GcPlanetLife ForceCreatureLifeLevelTo;
        /* 0x1C08 */ public int ForceTerrainSettings;                   // there will be an enum/struct
        /* 0x1C0C */ public bool ForceTerrainType;
        /* 0x1C10 */ public int ForceTerranTypeTo;                      // there will be an enum/struct
		public enum ForceAnomalyToEnum { None, AtlasType1, AtlasType2, Blackhole, Anomaly, Spacewalk }
		/* 0x1C14 */ public ForceAnomalyToEnum ForceAnomalyTo;
        /* 0x1C18 */ public bool ForcePlanetsToHaveWater;
        /* 0x1C1C */ public int UnknownInt0x1C1C;
        /* 0x1C20 */ public int UnknownInt0x1C20;
        /* 0x1C24 */ public int UnknownInt0x1C24;
        /* 0x1C28 */ public bool ModifyPlanetsInInitialSystems;
        /* 0x1C29 */ public bool DisableLimits;
        /* 0x1C2A */ public bool LimitPerRegionInstances;
        /* 0x1C2B */ public bool LimitPerRegionBodies;
        /* 0x1C2C */ public bool LimitGlobalInstances;
        /* 0x1C2D */ public bool LimitGlobalBodies;
        /* 0x1C30 */ public int GenerateFarLodBuildingDist;
        /* 0x1C34 */ public bool DeferRegionBodies;
        /* 0x1C38 */ public float GenerateCostDistance;
        /* 0x1C3C */ public float GenerateCostAngle;
        /* 0x1C40 */ public float GenerateCostLOD;
        /* 0x1C44 */ public float GenerateCostWait;
        /* 0x1C48 */ public bool DChecksEnabled;
        /* 0x1C49 */ public bool DChecksOutputJson;
        /* 0x1C4A */ public bool DChecksOutputBinary;
        /* 0x1C4B */ public bool DChecksOutputFileLine;
        /* 0x1C4C */ public int FrameFlipRateDefault;
        /* 0x1C50 */ public int FrameFlipRateLoad;
        /* 0x1C54 */ public int FrameFlipRateGame;
        /* 0x1C58 */ public float MaxFrameRate;
        /* 0x1C5C */ public bool DisableBaseBuilding;
        /* 0x1C5D */ public bool DisableBaseBuildingLimits;
        /* 0x1C60 */ public float BaseDownloadTimeout;
        /* 0x1C64 */ public bool BaseBuildingPartsRequirePower;
        /* 0x1C65 */ public bool Unknown0x1C65;
        /* 0x1C68 */ public int UnknownInt0x1C68;       // this and the following int are in a qword
        /* 0x1C6C */ public int UnknownInt0x1C6C;
        /* 0x1C70 */ public bool Unknown0x1C70;
        /* 0x1C71 */ public bool Unknown0x1C71;
        [NMS(Size = 0x20)]
        /* 0x1C72 */ public string Unknown0x1C72;       // "pc"
        /* 0x1C94 */ public int UnknownInt0x1C94;
        /* 0x1C98 */ public bool Unknown0x1A74;
        /* 0x1C99 */ public bool Unknown0x1A75;
        [NMS(Size = 0x2, Ignore = true)]
        /* 0x1C9A */ public byte[] Unknown0x1C9A;
        /* 0x1C9C */ public TkGlobals Unknown0x1C9C;
    }
}
