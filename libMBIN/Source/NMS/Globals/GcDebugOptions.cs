using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(GUID = 0xB462D08AC2561841)]
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
        /* 0x409 */ public bool SpecialsShop;
		/* 0x40A */ public bool MultiplePlayerFreightersInASystem;

        // End of "block of mess" (?)

		/* 0x40B */ public bool MouseLookEnabled;
		/* 0x40C */ public bool StartPaused;
		/* 0x40D */ public bool DisableDebugControls;
		/* 0x40E */ public bool DisableAsserts;
		/* 0x40F */ public bool FixedFramerate;
		//* 0x410 */ public bool ScreenshotMode;        // It's this or the above 4 bools that is no longer used (may be impossible to determine...)
		/* 0x410 */ public bool RenderHud;
		/* 0x411 */ public bool DisableDiscoveryNaming;
		/* 0x412 */ public bool DebugDrawPlayerInteract;
		/* 0x413 */ public bool ForceInteractionToSettings;
		/* 0x414 */ public int ForceInteractionIndex;
        /* 0x418 */ public bool InteractionsAllwaysGivesTech;
        /* 0x419 */ public bool InfiniteInteractions;
        /* 0x41A */ public bool StopSwitchingToSecondaryInteractions;
        /* 0x41C */ public float DebugLanguage;

        [NMS(Size = 0x20)]
        /* 0x420 */ public string AllowedLanguagesFile;
        /* 0x440 */ public bool DoAlienLanguage;
        /* 0x444 */ public float ForceInteractionRaceTo;
        /* 0x448 */ public float RealityMode;
        /* 0x44C */ public bool DebugPersistentInteractions;
        /* 0x44D */ public bool Unknown0x44D;
        [NMS(Size = 0x80)]
        /* 0x44E */ public string RealityPresetFile;
        /* 0x4CE */ public short RealityGenerationIteration;
        [NMS(Size = 0x5)]
        /* 0x4D0 */ public NMSString0x20[] LocTableList;
        [NMS(Size = 0x80)]
        /* 0x570 */ public string DefaultSaveData;
        /* 0x5F0 */ public bool FormatDownloadStorageAreaOnBoot;
        /* 0x5F1 */ public bool ForceBasicLoadScreen;
        /* 0x5F4 */ public float BootLogoFadeRate;
        /* 0x5F8 */ public bool BootMusic;
        /* 0x5FC */ public float WeaponScale3P;
        /* 0x600 */ public bool LogMissingLocalisedText;
        /* 0x601 */ public bool FleetDirectorAutoMode;
        /* 0x604 */ public float _3dTextDistance;
        /* 0x608 */ public float _3dTextMinScale;
		public enum RecordSettingEnum { None, Record, Playback }
		/* 0x60C */ public RecordSettingEnum RecordSetting;
        /* 0x610 */ public bool DebugBuildingSpawns;
        /* 0x611 */ public bool StressTestLongNameDisplay;
        /* 0x612 */ public bool Unknown0x612;
        [NMS(Size = 0x20)]
        /* 0x613 */ public string SaveTestingCommand;
        /* 0x633 */ public bool NeverUseBanks;
        /* 0x634 */ public bool DisableProfanityFilter;
        /* 0x635 */ public bool DisableFileWatcher;
        /* 0x636 */ public bool Unknown0x636;
        /* 0x638 */ public int RecurrenceTimeOffset;
        [NMS(Size = 0x80)]
        /* 0x63C */ public string Unknown0x63C;
        [NMS(Size = 0x20)]
        /* 0x6BC */ public string Unknown0x6BC;
        /* 0x6DC */ public bool Unknown0x6DC;
        /* 0x6DD */ public bool ShowDebugMessages;
        /* 0x6DE */ public bool ShowFramerate;
        /* 0x6DF */ public bool ShowPositionDebug;
        /* 0x6E0 */ public bool Unknown0x6E0;
        /* 0x6E1 */ public bool ShowGPUMemory;
        /* 0x6E2 */ public bool ShowMempoolOverlay;
        /* 0x6E3 */ public bool ShowMouseSmoothing;

        [NMS(Size = 0x100)]
        /* 0x6E4 */ public string ShowUniverseAddressOnGalaxyMap;
        /* 0x7E4 */ public bool ShowGraphs;
        /* 0x7E8 */ public int ShowSpecificGraph;
        /* 0x7EC */ public bool GraphCommandBuffer;
        /* 0x7ED */ public bool GraphGeneration;
        /* 0x7EE */ public bool GraphFPS;
        /* 0x7EF */ public bool GraphTexStreaming;
        /* 0x7F0 */ public bool SmokeTestDumpStatsMode;
		public enum SmokeTestCycleModeEnum { None, TourSolarSystem, RegeneratePlanet }
		/* 0x7F4 */ public SmokeTestCycleModeEnum SmokeTestCycleMode;
        /* 0x7F8 */ public bool SmokeTestCameraFly;
        /* 0x7F9 */ public bool SmokeTestOutputOnly;
        /* 0x7FA */ public bool SmokeTestPureFlight;
        /* 0x7FC */ public int SmokeTestConfigCaptureCycles;
        /* 0x800 */ public float SmokeTestConfigCaptureDurationInSeconds;
        /* 0x804 */ public int SmokeTestConfigCaptureFolderNameNumberOffset;
        /* 0x808 */ public bool SmokeTestConfigRandomizePlanetSeed;
		/* 0x809 */ public bool SmokeTestSmokeBotEnabled;
		/* 0x80A */ public bool SmokeTestSmokeBotAutoStart;
		/* 0x80C */ public int SmokeTestSmokeBotTargetWarps;
		/* 0x810 */ public bool CreatureChatter;
		/* 0x811 */ public bool CreatureErrors;
		/* 0x812 */ public bool CreatureDrawVocals;
		/* 0x813 */ public bool DrawCreaturesInRoutines;
		/* 0x814 */ public bool ShowFirstPersonCharacterShadow;
		/* 0x815 */ public bool CompressTextures;
		/* 0x816 */ public bool DebugIBL;
		/* 0x817 */ public bool DebugTerrainTextures;
		/* 0x818 */ public bool DisableShadowSwitching;
		[NMS(Size = 0x80)]
		/* 0x819 */ public string PipelineFile;
		[NMS(Size = 0x80)]
		/* 0x899 */ public string PipelineFilePS4;
		[NMS(Size = 0x80)]
		/* 0x919 */ public string PipelineFileXboxOne;
		[NMS(Size = 0x80)]
		/* 0x999 */ public string PipelineFileVR;
        [NMS(Size = 0x80)]
		/* 0xA19 */ public string PipelineFileVRPS4;
		[NMS(Size = 0x80)]
		/* 0xA99 */ public string PipelineFileFrontend;
		[NMS(Size = 0x80)]
		/* 0xB19 */ public string PipelineFileEditor;
		/* 0xB99 */ public bool RenderLowFramerate;
		/* 0xB9A */ public bool EnableComputePost;
        /* 0xB9B */ public bool EnableEvenOddRender;
		/* 0xB9C */ public bool SimulateNoNetworkConnection;
        /* 0xB9D */ public bool Unknown0xB9D;
        /* 0xB9E */ public bool Unknown0xB9E;
		public enum ProxyTypeEnum { None, ManualURI, InetProxy }
		/* 0xBA0 */ public ProxyTypeEnum ProxyType;

        [NMS(Size = 0x80)]
        /* 0xBA4 */ public string ProxyURI;
		public enum ServerEnvEnum { Default, dev, qa, prodqa, prod, custom, pentest }
		/* 0xC24 */ public ServerEnvEnum ServerEnv;
        [NMS(Size = 0x80)]
        /* 0xC28 */ public string AuthBaseUrl;
        /* 0xCA8 */ public bool CertificateSecurityBypass;
        [NMS(Size = 0x20)]
        /* 0xCA9 */ public string OverrideUsernameForDev;
        /* 0xCCC */ public int DiscoveryAutoSyncIntervalSeconds;
        /* 0xCD0 */ public bool DisableSpaceStationSpawnOnJoin;
        /* 0xCD1 */ public bool AutoJoinUserEnabled;
        [NMS(Size = 8)]
        /* 0xCD2 */ public NMSString0x100[] AutoJoinUserNames;      // this is its own struct now but this should work...
        /* 0x14D2 */ public bool AlwaysSaveGameAsClient;
        /* 0x14D3 */ public bool DisableMonumentDownloads;
        /* 0x14D4 */ public bool UsePadOnUnfocusedWindow;
        /* 0x14D8 */ public int OverrideMatchmakingVersion;
        /* 0x14DC */ public bool IgnoreTransactionTimeouts;
        /* 0x14DD */ public bool Unknown0x14DD;
        [NMS(Size = 0x100)]
        /* 0x14DE */ public string Unknown0x14DE;
        /* 0x15DE */ public bool Unknown0x15DE;
        /* 0x15DF */ public bool Unknown0x15DF;
        /* 0x15E0 */ public bool EnableSynergy;
        [NMS(Size = 0x20)]
        /* 0x15E1 */ public string SynergyServer;
        /* 0x1604 */ public int SynergyPort;
        /* 0x1608 */ public bool ShowEditorPlacementPreview;
        /* 0x160C */ public int MaxNumDebugMessages;
        /* 0x1610 */ public bool PreloadToolbox;
        /* 0x1614 */ public int DebugTextureSize;
        /* 0x1618 */ public bool UseProcTextureDebugger;
        /* 0x161C */ public int ProceduralModelsShown;
        /* 0x1620 */ public int ProceduralModelBatchSize;
        [NMS(Size = 0x80)]
        /* 0x1624 */ public string DebugFont;
        [NMS(Size = 0x80)]
        /* 0x16A4 */ public string DebugFontTexture;
        [NMS(Size = 0x80)]
        /* 0x1724 */ public string CursorTexture;
        [NMS(Size = 0x80)]
        /* 0x17A4 */ public string PauseTexture;
        [NMS(Size = 0x80)]
        /* 0x1824 */ public string PlayTexture;
        [NMS(Size = 0x80)]
        /* 0x18A4 */ public string StepTexture;
        [NMS(Size = 0x80)]
        /* 0x1924 */ public string RenderToTexture;

        // Not sure about this block...
        /* 0x19A4 */ public bool HmdEnable;
        /* 0x19A8 */ public int UnknownInt0x19A8;
        /* 0x19AC */ public bool HmdOutput;
        /* 0x19AD */ public bool HmdTracking;
        /* 0x19AE */ public bool HmdStereoRender;
        ///* 0x19AF */ public bool HmdDistortionPassthru;         // Arbitrarily removing this value

        /* 0x19B0 */ public int HmdMonitor;
        /* 0x19B4 */ public int HmdEyeBufferWidth;
        /* 0x19B8 */ public int HmdEyeBufferHeight;

        /* 0x19BC */ public float HmdEyeScalePos;
        /* 0x19C0 */ public float HmdHeadScalePos;
        /* 0x19C4 */ public bool Unknown0x19C4;                 // these may have picked up a bool from above
        /* 0x19C5 */ public bool Unknown0x19C5;
        /* 0x19C6 */ public bool Unknown0x19C6;
        /* 0x19C8 */ public float HmdImmersionFactor;

        // Don't know how many bools there are. There should be at least as it is a qword...
        /* 0x19CC */ public bool Unknown0x19CC;
        /* 0x19CD */ public bool Unknown0x19CD;
        /* 0x19CE */ public bool Unknown0x19CE;         // this is True
        /* 0x19CF */ public bool Unknown0x19CF;
        /* 0x19D0 */ public bool Unknown0x19D0;
        /* 0x19D1 */ public bool Unknown0x19D1;
        /* 0x19D2 */ public bool Unknown0x19D2;
        /* 0x19D3 */ public bool ForceExtremeWeather;       // I am going to assume this has been absorbed into one of the above bools as there are only 2 at 0x19D4
        /* 0x19D4 */ public bool ForceExtremeSentinels;
        /* 0x19D5 */ public bool ForceStarType;
        /* 0x19D8 */ public GcGalaxyStarTypes ForceStarTypeTo;
        /* 0x19DC */ public bool ForceBiome;
        /* 0x19E0 */ public GcBiomeType ForceBiomeTo;
        /* 0x19E4 */ public GcBiomeSubType ForceBiomeSubTypeTo;
        /* 0x19E8 */ public bool ForceBuildingRace;
        /* 0x19EC */ public GcAlienRace ForceBuildingRaceTo;
        /* 0x19F0 */ public bool ForceLifeLevel;
        /* 0x19F4 */ public GcPlanetLife ForceLifeLevelTo;
        /* 0x19F8 */ public bool ForceCreatureLifeLevel;
        /* 0x19F9 */ public bool ForceDefaultCreatureFile;
        /* 0x19FC */ public GcPlanetLife ForceCreatureLifeLevelTo;
        /* 0x1A00 */ public int ForceTerrainSettings;                   // there will be an enum/struct
        /* 0x1A04 */ public bool ForceTerrainType;
        /* 0x1A08 */ public int ForceTerranTypeTo;                      // there will be an enum/struct
		public enum ForceAnomalyToEnum { None, AtlasType1, AtlasType2, Blackhole, Anomaly, Spacewalk }
		/* 0x1A0C */ public ForceAnomalyToEnum ForceAnomalyTo;
        /* 0x1A10 */ public bool ForcePlanetsToHaveWater;
        /* 0x1A14 */ public int UnknownInt0x1A14;
        /* 0x1A18 */ public int UnknownInt0x1A18;
        /* 0x1A1C */ public int UnknownInt0x1A1C;
        /* 0x1A20 */ public bool ModifyPlanetsInInitialSystems;
        /* 0x1A21 */ public bool DisableLimits;
        /* 0x1A22 */ public bool LimitPerRegionInstances;
        /* 0x1A23 */ public bool LimitPerRegionBodies;
        /* 0x1A24 */ public bool LimitGlobalInstances;
        /* 0x1A25 */ public bool LimitGlobalBodies;
        /* 0x1A28 */ public int GenerateFarLodBuildingDist;
        /* 0x1A2C */ public bool DeferRegionBodies;
        /* 0x1A30 */ public float GenerateCostDistance;
        /* 0x1A34 */ public float GenerateCostAngle;
        /* 0x1A38 */ public float GenerateCostLOD;
        /* 0x1A3C */ public float GenerateCostWait;
        /* 0x1A40 */ public bool DChecksEnabled;
        /* 0x1A41 */ public bool DChecksOutputJson;
        /* 0x1A42 */ public bool DChecksOutputBinary;
        /* 0x1A43 */ public bool DChecksOutputFileLine;
        /* 0x1A44 */ public int FrameFlipRateDefault;
        /* 0x1A48 */ public int FrameFlipRateLoad;
        /* 0x1A4C */ public int FrameFlipRateGame;
        /* 0x1A50 */ public float MaxFrameRate;
        /* 0x1A54 */ public bool DisableBaseBuilding;
        /* 0x1A55 */ public bool DisableBaseBuildingLimits;
        /* 0x1A58 */ public float BaseDownloadTimeout;
        /* 0x1A5C */ public bool BaseBuildingPartsRequirePower;
        /* 0x1A5D */ public bool Unknown0x1A5D;
        /* 0x1A60 */ public int UnknownInt0x1A60;       // this and the following int are in a qword
        /* 0x1A64 */ public int UnknownInt0x1A64;
        /* 0x1A68 */ public bool Unknown0x1A68;
        [NMS(Size = 0x20)]
        /* 0x1A69 */ public string Unknown0x1A69;       // "pc"
        /* 0x1A8C */ public int UnknownInt0x1A8C;
        /* 0x1A90 */ public bool Unknown0x1A74;
        /* 0x1A91 */ public bool Unknown0x1A75;
        [NMS(Size = 0x2, Ignore = true)]
        /* 0x1A92 */ public byte[] Unknown0x1A92;
        /* 0x1A94 */ public TkGlobals Unknown0x1A94;
    }
}
