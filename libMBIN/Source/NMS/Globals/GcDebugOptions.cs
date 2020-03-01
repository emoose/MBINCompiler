using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0xB98C54AF2A29813A)]
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
        /* 0x18 */ public bool Unknown0x18;             // this could potentially be anywhere within this chunk.
        /* 0x19 */ public bool Unknown0x19;
		/* 0x1A */ public bool DisableOldMissions;
		/* 0x1B */ public bool UseScreenEffects;
		/* 0x1C */ public bool UseGunImpactEffect;
        /* 0x1D */ public bool Unknown0x1D;             // this could potentially be anywhere within this chunk.
		/* 0x1E */ public bool RenderCreatureDetails;
		/* 0x1F */ public bool SkipTutorial;
		/* 0x20 */ public bool IgnoreFreighterSpawnWarpRequirement;
		/* 0x21 */ public bool DisableSaveSlotSorting;
		/* 0x22 */ public bool DisableSaving;           // Don't know where these two known values are
		/* 0x23 */ public bool UseDebugScreenSettings;
        /* 0x24 */ public bool Unknown0x24;
        /* 0x25 */ public bool Unknown0x25;

		/* 0x28 */ public int ScreenWidth;
		/* 0x2C */ public int ScreenHeight;
		/* 0x30 */ public bool DisableVSync;
		public enum GameWindowModeEnum { Bordered, Borderless, Fullscreen }
		/* 0x34 */ public GameWindowModeEnum GameWindowMode;
        /* 0x38 */ public int Monitor;
        /* 0x3C */ public int UnknownInt0x3C;   // Possibly the default value for some Enum...
        /* 0x40 */ public int UnknownInt0x40;
        [NMS(Size = 0x100)]
        /* 0x44 */ public string ForceUniverseAddress;
        [NMS(Size = 0x100)]
        /* 0x144 */ public string ForcePlayerPosition;
        /* 0x244 */ public bool ForceInitialShip;
        /* 0x245 */ public bool ForceInitialWeapon;
		public enum GameStateModeEnum { LoadPreset, UserStorage, FreshStart }
		/* 0x248 */ public GameStateModeEnum GameStateMode;
		public enum BootModeEnum { MinimalSolarSystem, SolarSystem, GalaxyMap, SmokeTest, SmokeTestGalaxyMap, Scratchpad, UnitTest }
		/* 0x24C */ public BootModeEnum BootMode;
		public enum PlayerSpawnLocationOverrideEnum { None, FromSettings, Space, SpaceStation, RandomPlanet, GameStartPlanet }
		/* 0x250 */ public PlayerSpawnLocationOverrideEnum PlayerSpawnLocationOverride;
        [NMS(Size = 0x80)]
        /* 0x254 */ public string SceneSettings;
        [NMS(Size = 0x100)]
        /* 0x2D4 */ public string WorkingDirectory;
		public enum SolarSystemBootEnum { FromSettings, Generate }
		/* 0x3D4 */ public SolarSystemBootEnum SolarSystemBoot;
		public enum ShaderPreloadEnum { Off, Full }
		/* 0x3D8 */ public ShaderPreloadEnum ShaderPreload;
        /* 0x3DC */ public bool ShaderPreloadListExport;
        /* 0x3DD */ public bool ShaderPreloadListImport;
        /* 0x3DE */ public bool ShaderCaching;
		public enum BootLoadDelayEnum { LoadAll, WaitForPlanet, WaitForNothing }
		/* 0x3E0 */ public BootLoadDelayEnum BootLoadDelay;
        /* 0x3E4 */ public bool MemCsv;
        /* 0x3E8 */ public float ForceTimeOfDay;

        // Start of "block of mess". The following values could be quite wrong. Lots of testing needed!!

        /* 0x3EC */ public bool Unknown0x3EC;
        /* 0x3F0 */ public float Unknown0x3F0;          // don't actually know what the data type of this is... either int, float or 4 bools
        /* 0x3F4 */ public bool Unknown0x3F1;
        /* 0x3F5 */ public bool UseParticles;
        /* 0x3F6 */ public bool UseVolumetrics;
        /* 0x3F7 */ public bool UseClouds;
        /* 0x3F8 */ public bool UseTerrain;
        /* 0x3F9 */ public bool UseInstances;
        /* 0x3FA */ public bool UseObjects;
        /* 0x3FB */ public bool UseBuildings;
        /* 0x3FC */ public bool UseCreatures;
        /* 0x3FD */ public bool UseElevation;
        /* 0x3FE */ public bool Unknown0x3FE;
        /* 0x3FF */ public bool Unknown0x3FF;
        /* 0x400 */ public bool Unknown0x400;
        /* 0x401 */ public bool UseLegacyFreighters;
        /* 0x402 */ public bool Unknown0x402;
        /* 0x403 */ public bool SpawnPirates;
        /* 0x404 */ public bool SpawnRobots;
        /* 0x405 */ public bool SpawnShips;
        /* 0x406 */ public bool InstanceCollision;
        /* 0x407 */ public bool MPMissions;
        /* 0x408 */ public bool Unknown0x408;
        /* 0x409 */ public bool Unknown0x409;
        /* 0x40A */ public bool SpecialsShop;
		/* 0x40B */ public bool MultiplePlayerFreightersInASystem;

        // End of "block of mess" (?)

		/* 0x40C */ public bool MouseLookEnabled;
		/* 0x40D */ public bool StartPaused;
		/* 0x40E */ public bool DisableDebugControls;
		/* 0x40F */ public bool DisableAsserts;
		/* 0x410 */ public bool FixedFramerate;
		//* 0x410 */ public bool ScreenshotMode;        // It's this or the above 4 bools that is no longer used (may be impossible to determine...)
		/* 0x411 */ public bool RenderHud;
		/* 0x412 */ public bool DisableDiscoveryNaming;
		/* 0x413 */ public bool DebugDrawPlayerInteract;
		/* 0x414 */ public bool ForceInteractionToSettings;
		/* 0x418 */ public int ForceInteractionIndex;
        /* 0x41C */ public bool InteractionsAllwaysGivesTech;
        /* 0x41D */ public bool InfiniteInteractions;
        /* 0x41E */ public bool StopSwitchingToSecondaryInteractions;
        /* 0x420 */ public float DebugLanguage;

        [NMS(Size = 0x20)]
        /* 0x424 */ public string AllowedLanguagesFile;
        /* 0x444 */ public bool DoAlienLanguage;
        /* 0x448 */ public float ForceInteractionRaceTo;
        /* 0x44C */ public float RealityMode;
        /* 0x450 */ public bool DebugPersistentInteractions;
        /* 0x451 */ public bool Unknown0x451;
        [NMS(Size = 0x80)]
        /* 0x452 */ public string RealityPresetFile;
        /* 0x4D2 */ public short RealityGenerationIteration;
        [NMS(Size = 0x5)]
        /* 0x4D4 */ public NMSString0x20[] LocTableList;
        [NMS(Size = 0x80)]
        /* 0x574 */ public string DefaultSaveData;
        /* 0x5F4 */ public bool FormatDownloadStorageAreaOnBoot;
        /* 0x5F5 */ public bool ForceBasicLoadScreen;
        /* 0x5F8 */ public float BootLogoFadeRate;
        /* 0x5FC */ public bool BootMusic;
        /* 0x600 */ public float WeaponScale3P;
        /* 0x604 */ public bool LogMissingLocalisedText;
        /* 0x605 */ public bool FleetDirectorAutoMode;
        /* 0x608 */ public float _3dTextDistance;
        /* 0x60C */ public float _3dTextMinScale;
		public enum RecordSettingEnum { None, Record, Playback }
		/* 0x610 */ public RecordSettingEnum RecordSetting;
        /* 0x614 */ public bool DebugBuildingSpawns;
        /* 0x615 */ public bool StressTestLongNameDisplay;
        /* 0x616 */ public bool Unknown0x616;
        [NMS(Size = 0x20)]
        /* 0x617 */ public string SaveTestingCommand;
        /* 0x637 */ public bool NeverUseBanks;
        /* 0x638 */ public bool DisableProfanityFilter;
        /* 0x639 */ public bool DisableFileWatcher;
        /* 0x63A */ public bool Unknown0x63A;
        /* 0x63C */ public int RecurrenceTimeOffset;
        [NMS(Size = 0x80)]
        /* 0x640 */ public string Unknown0x640;
        [NMS(Size = 0x20)]
        /* 0x6C0 */ public string Unknown0x6C0;
        /* 0x6E0 */ public bool Unknown0x6E0;
        /* 0x6E1 */ public bool ShowDebugMessages;
        /* 0x6E2 */ public bool ShowFramerate;
        /* 0x6E3 */ public bool ShowPositionDebug;
        /* 0x6E4 */ public bool Unknown0x6E4;
        /* 0x6E5 */ public bool ShowGPUMemory;
        /* 0x6E6 */ public bool ShowMempoolOverlay;
        /* 0x6E7 */ public bool ShowMouseSmoothing;

        [NMS(Size = 0x100)]
        /* 0x6E8 */ public string ShowUniverseAddressOnGalaxyMap;
        /* 0x7E8 */ public bool ShowGraphs;
        /* 0x7EC */ public int ShowSpecificGraph;
        /* 0x7F0 */ public bool GraphCommandBuffer;
        /* 0x7F1 */ public bool GraphGeneration;
        /* 0x7F2 */ public bool GraphFPS;
        /* 0x7F3 */ public bool GraphTexStreaming;
        /* 0x7F4 */ public bool SmokeTestDumpStatsMode;
		public enum SmokeTestCycleModeEnum { None, TourSolarSystem, RegeneratePlanet }
		/* 0x7F8 */ public SmokeTestCycleModeEnum SmokeTestCycleMode;
        /* 0x7FC */ public bool SmokeTestCameraFly;
        /* 0x7FD */ public bool SmokeTestOutputOnly;
        /* 0x7FE */ public bool SmokeTestPureFlight;
        /* 0x800 */ public int SmokeTestConfigCaptureCycles;
        /* 0x804 */ public float SmokeTestConfigCaptureDurationInSeconds;
        /* 0x808 */ public int SmokeTestConfigCaptureFolderNameNumberOffset;
        /* 0x80C */ public bool SmokeTestConfigRandomizePlanetSeed;
		/* 0x80D */ public bool SmokeTestSmokeBotEnabled;
		/* 0x80E */ public bool SmokeTestSmokeBotAutoStart;
		/* 0x810 */ public int SmokeTestSmokeBotTargetWarps;
		/* 0x814 */ public bool CreatureChatter;
		/* 0x815 */ public bool CreatureErrors;
		/* 0x816 */ public bool CreatureDrawVocals;
		/* 0x817 */ public bool DrawCreaturesInRoutines;
		/* 0x818 */ public bool ShowFirstPersonCharacterShadow;
		/* 0x819 */ public bool CompressTextures;
		/* 0x81A */ public bool DebugIBL;
		/* 0x81B */ public bool DebugTerrainTextures;
		/* 0x81C */ public bool DisableShadowSwitching;
		[NMS(Size = 0x80)]
		/* 0x81D */ public string PipelineFile;
		[NMS(Size = 0x80)]
		/* 0x89D */ public string PipelineFilePS4;
		[NMS(Size = 0x80)]
		/* 0x91D */ public string PipelineFileXboxOne;
		[NMS(Size = 0x80)]
		/* 0x99D */ public string PipelineFileVR;
        [NMS(Size = 0x80)]
		/* 0xA1D */ public string PipelineFileVRPS4;
		[NMS(Size = 0x80)]
		/* 0xA9D */ public string PipelineFileFrontend;
		[NMS(Size = 0x80)]
		/* 0xB1D */ public string PipelineFileEditor;
		/* 0xB9D */ public bool RenderLowFramerate;
		/* 0xB9E */ public bool EnableComputePost;
        /* 0xB9F */ public bool EnableEvenOddRender;
		/* 0xBA0 */ public bool SimulateNoNetworkConnection;
        /* 0xBA1 */ public bool Unknown0xBA1;
        /* 0xBA2 */ public bool Unknown0xBA2;
		public enum ProxyTypeEnum { None, ManualURI, InetProxy }
		/* 0xBA4 */ public ProxyTypeEnum ProxyType;

        [NMS(Size = 0x80)]
        /* 0xBA8 */ public string ProxyURI;
		public enum ServerEnvEnum { Default, dev, qa, prodqa, prod, custom, pentest }
		/* 0xC28 */ public ServerEnvEnum ServerEnv;
        [NMS(Size = 0x80)]
        /* 0xC2C */ public string AuthBaseUrl;
        /* 0xCAC */ public bool CertificateSecurityBypass;
        [NMS(Size = 0x20)]
        /* 0xCAD */ public string OverrideUsernameForDev;
        /* 0xCD0 */ public int DiscoveryAutoSyncIntervalSeconds;
        /* 0xCD4 */ public bool DisableSpaceStationSpawnOnJoin;
        /* 0xCD5 */ public bool AutoJoinUserEnabled;
        [NMS(Size = 8)]
        /* 0xCD6 */ public NMSString0x100[] AutoJoinUserNames;      // this is its own struct now but this should work...
        /* 0x14D6 */ public bool AlwaysSaveGameAsClient;
        /* 0x14D7 */ public bool DisableMonumentDownloads;
        /* 0x14D8 */ public bool UsePadOnUnfocusedWindow;
        /* 0x14DC */ public int OverrideMatchmakingVersion;
        /* 0x14E0 */ public bool IgnoreTransactionTimeouts;
        /* 0x14E1 */ public bool Unknown0x14E1;
        [NMS(Size = 0x100)]
        /* 0x14E2 */ public string Unknown0x14E2;
        /* 0x15E2 */ public bool Unknown0x15E2;
        /* 0x15E3 */ public bool Unknown0x15E3;
        /* 0x15E4 */ public bool EnableSynergy;
        [NMS(Size = 0x20)]
        /* 0x15E5 */ public string SynergyServer;
        /* 0x1608 */ public int SynergyPort;
        /* 0x160C */ public bool ShowEditorPlacementPreview;
        /* 0x1610 */ public int MaxNumDebugMessages;
        /* 0x1614 */ public bool PreloadToolbox;
        /* 0x1618 */ public int DebugTextureSize;
        /* 0x161C */ public bool UseProcTextureDebugger;
        /* 0x1620 */ public int ProceduralModelsShown;
        /* 0x1624 */ public int ProceduralModelBatchSize;
        [NMS(Size = 0x80)]
        /* 0x1628 */ public string DebugFont;
        [NMS(Size = 0x80)]
        /* 0x16A8 */ public string DebugFontTexture;
        [NMS(Size = 0x80)]
        /* 0x1728 */ public string CursorTexture;
        [NMS(Size = 0x80)]
        /* 0x17A8 */ public string PauseTexture;
        [NMS(Size = 0x80)]
        /* 0x1828 */ public string PlayTexture;
        [NMS(Size = 0x80)]
        /* 0x18A8 */ public string StepTexture;
        [NMS(Size = 0x80)]
        /* 0x1928 */ public string RenderToTexture;

        // Not sure about this block...
        /* 0x19A8 */ public bool HmdEnable;
        /* 0x19AC */ public int UnknownInt0x19AC;
        /* 0x19B0 */ public bool HmdOutput;
        /* 0x19B1 */ public bool HmdTracking;
        /* 0x19B2 */ public bool HmdStereoRender;
        ///* 0x19B3 */ public bool HmdDistortionPassthru;         // Arbitrarily removing this value

        /* 0x19B4 */ public int HmdMonitor;
        /* 0x19B8 */ public int HmdEyeBufferWidth;
        /* 0x19BC */ public int HmdEyeBufferHeight;

        /* 0x19C0 */ public float HmdEyeScalePos;
        /* 0x19C4 */ public float HmdHeadScalePos;
        /* 0x19C8 */ public bool Unknown0x19C8;                 // these may have picked up a bool from above
        /* 0x19C9 */ public bool Unknown0x19C9;
        /* 0x19CA */ public bool Unknown0x19CA;
        /* 0x19CC */ public float HmdImmersionFactor;

        // Don't know how many bools there are. There should be at least as it is a qword...
        /* 0x19D0 */ public bool Unknown0x19D0;
        /* 0x19D1 */ public bool Unknown0x19D1;
        /* 0x19D2 */ public bool Unknown0x19D2;         // this is True
        /* 0x19D3 */ public bool Unknown0x19D3;
        /* 0x19D4 */ public bool Unknown0x19D4;
        /* 0x19D5 */ public bool Unknown0x19D5;
        /* 0x19D6 */ public bool Unknown0x19D6;
        /* 0x19D7 */ public bool ForceExtremeWeather;       // I am going to assume this has been absorbed into one of the above bools as there are only 2 at 0x19D4
        /* 0x19D8 */ public bool ForceExtremeSentinels;
        /* 0x19D9 */ public bool ForceStarType;
        /* 0x19DC */ public GcGalaxyStarTypes ForceStarTypeTo;
        /* 0x19E0 */ public bool ForceBiome;
        /* 0x19E4 */ public GcBiomeType ForceBiomeTo;
        /* 0x19E8 */ public GcBiomeSubType ForceBiomeSubTypeTo;
        /* 0x19EC */ public bool ForceBuildingRace;
        /* 0x19F0 */ public GcAlienRace ForceBuildingRaceTo;
        /* 0x19F4 */ public bool ForceLifeLevel;
        /* 0x19F8 */ public GcPlanetLife ForceLifeLevelTo;
        /* 0x19FC */ public bool ForceCreatureLifeLevel;
        /* 0x19FD */ public bool ForceDefaultCreatureFile;
        /* 0x1A00 */ public GcPlanetLife ForceCreatureLifeLevelTo;
        /* 0x1A04 */ public int ForceTerrainSettings;                   // there will be an enum/struct
        /* 0x1A08 */ public bool ForceTerrainType;
        /* 0x1A0C */ public int ForceTerranTypeTo;                      // there will be an enum/struct
		public enum ForceAnomalyToEnum { None, AtlasType1, AtlasType2, Blackhole, Anomaly, Spacewalk }
		/* 0x1A10 */ public ForceAnomalyToEnum ForceAnomalyTo;
        /* 0x1A14 */ public bool ForcePlanetsToHaveWater;
        /* 0x1A18 */ public int UnknownInt0x1A18;
        /* 0x1A1C */ public int UnknownInt0x1A1C;
        /* 0x1A20 */ public int UnknownInt0x1A20;
        /* 0x1A24 */ public bool ModifyPlanetsInInitialSystems;
        /* 0x1A25 */ public bool DisableLimits;
        /* 0x1A26 */ public bool LimitPerRegionInstances;
        /* 0x1A27 */ public bool LimitPerRegionBodies;
        /* 0x1A28 */ public bool LimitGlobalInstances;
        /* 0x1A29 */ public bool LimitGlobalBodies;
        /* 0x1A2C */ public int GenerateFarLodBuildingDist;
        /* 0x1A30 */ public bool DeferRegionBodies;
        /* 0x1A34 */ public float GenerateCostDistance;
        /* 0x1A38 */ public float GenerateCostAngle;
        /* 0x1A3C */ public float GenerateCostLOD;
        /* 0x1A40 */ public float GenerateCostWait;
        /* 0x1A44 */ public bool DChecksEnabled;
        /* 0x1A45 */ public bool DChecksOutputJson;
        /* 0x1A46 */ public bool DChecksOutputBinary;
        /* 0x1A47 */ public bool DChecksOutputFileLine;
        /* 0x1A48 */ public int FrameFlipRateDefault;
        /* 0x1A4C */ public int FrameFlipRateLoad;
        /* 0x1A50 */ public int FrameFlipRateGame;
        /* 0x1A54 */ public float MaxFrameRate;
        /* 0x1A58 */ public bool DisableBaseBuilding;
        /* 0x1A59 */ public bool DisableBaseBuildingLimits;
        /* 0x1A5C */ public float BaseDownloadTimeout;
        /* 0x1A60 */ public bool BaseBuildingPartsRequirePower;
        /* 0x1A61 */ public bool Unknown0x1A61;
        /* 0x1A64 */ public int UnknownInt0x1A64;       // this and the following int are in a qword
        /* 0x1A68 */ public int UnknownInt0x1A68;
        /* 0x1A6C */ public bool Unknown0x1A6C;
        /* 0x1A6D */ public bool Unknown0x1A6D;
        [NMS(Size = 0x20)]
        /* 0x1A6E */ public string Unknown0x1A6E;       // "pc"
        /* 0x1A90 */ public int UnknownInt0x1A90;
        /* 0x1A94 */ public bool Unknown0x1A74;
        /* 0x1A95 */ public bool Unknown0x1A75;
        [NMS(Size = 0x2, Ignore = true)]
        /* 0x1A96 */ public byte[] Unknown0x1A96;
        /* 0x1A98 */ public TkGlobals Unknown0x1A98;
    }
}
