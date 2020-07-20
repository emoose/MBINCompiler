using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(Size = 0x1ED0, GUID = 0x193008B30B4182FD)]
    public class GcDebugOptions : NMSTemplate
    {
        /* 0x0 */ public bool SkipAbandonedFreighterUnlocking;
        /* 0x1 */ public bool AllowSavingOnAbandonedFreighters;
        /* 0x2 */ public bool DisableAbandonedFreighterRoomsOptimisation;
        /* 0x8 */ public ulong OverrideAbandonedFreighterSeed;
        /* 0x10 */ public bool ThirdPersonIsDefaultCamera;
        /* 0x11 */ public bool SkipIntro;
        /* 0x12 */ public bool SkipLogos;
		/* 0x14 */ public int BootDirectlyIntoSaveSlot;
        /* 0x18 */ public bool BootDirectlyIntoLastSave;
		/* 0x1C */ public GcGameMode NewSaveGameMode;
		/* 0x20 */ public bool SkipPlanetDiscoverOnBoot;
		/* 0x21 */ public bool VideoCaptureMode;
		/* 0x22 */ public bool GodMode;
		/* 0x23 */ public bool TakeNoDamage;
		/* 0x24 */ public bool AlwaysHaveFocus;
		/* 0x25 */ public bool DisableVibration;
		/* 0x26 */ public bool DebugGalaxyMapInQuickMenu;
		/* 0x27 */ public bool MapWarpCheckIgnoreFuel;
		/* 0x28 */ public bool MapWarpCheckIgnoreDrive;
		/* 0x29 */ public bool EverythingIsFree;
		/* 0x2A */ public bool EverythingIsKnown;
		/* 0x2B */ public bool EverythingIsStar;
		/* 0x2C */ public bool InfiniteStamina;
		/* 0x2D */ public bool IgnoreMissionRank;
		/* 0x2E */ public bool CanLeaveDialogs;
		/* 0x2F */ public bool DisableOldMissions;
		/* 0x30 */ public bool UseScreenEffects;
		/* 0x31 */ public bool UseGunImpactEffect;
		/* 0x32 */ public bool RenderCreatureDetails;
		/* 0x33 */ public bool SkipTutorial;
		/* 0x34 */ public bool IgnoreFreighterSpawnWarpRequirement;
		/* 0x35 */ public bool MaximumFreighterSpawns;
		/* 0x36 */ public bool DisableSaveSlotSorting;
		/* 0x37 */ public bool DisableSaving;
		/* 0x38 */ public bool AlternateControls;
		/* 0x39 */ public bool AlwaysShowURI;
		/* 0x3A */ public bool MPMissionsAlwaysEPIC;
		/* 0x3B */ public bool ShowFireteamMembersUA;
        /* 0x3C */ public bool RevealAllTitles;
        /* 0x3D */ public bool UnlockAllTitles;
        /* 0x3E */ public bool LockAllTitles;
        /* 0x3F */ public bool AlwaysAllowShipOperations;
        /* 0x40 */ public bool AlwaysAllowVehicleOperations;
        /* 0x41 */ public bool AlwaysAllowFreighterInventoryAccess;
		/* 0x42 */ public bool UseDebugScreenSettings;
		/* 0x44 */ public int ScreenWidth;
		/* 0x48 */ public int ScreenHeight;
		/* 0x4C */ public bool DisableVSync;
		public enum GameWindowModeEnum { Bordered, Borderless, Fullscreen }
		/* 0x50 */ public GameWindowModeEnum GameWindowMode;
        /* 0x54 */ public int Monitor;
        /* 0x58 */ public int TiledWindowsSplitCount;
        /* 0x5C */ public int TiledWindowsIndex;
        [NMS(Size = 0x100)]
        /* 0x60 */ public string ForceUniverseAddress;
        [NMS(Size = 0x100)]
        /* 0x160 */ public string ForcePlayerPosition;
        /* 0x260 */ public bool ForceInitialShip;
        /* 0x261 */ public bool ForceInitialWeapon;
		public enum GameStateModeEnum { LoadPreset, UserStorage, FreshStart }
		/* 0x264 */ public GameStateModeEnum GameStateMode;
		public enum BootModeEnum { MinimalSolarSystem, SolarSystem, GalaxyMap, SmokeTest, SmokeTestGalaxyMap, Scratchpad, UnitTest }
		/* 0x268 */ public BootModeEnum BootMode;
		public enum PlayerSpawnLocationOverrideEnum { None, FromSettings, Space, SpaceStation, RandomPlanet, GameStartPlanet, SpecificLocation }
		/* 0x26C */ public PlayerSpawnLocationOverrideEnum PlayerSpawnLocationOverride;
        [NMS(Size = 0x80)]
        /* 0x270 */ public string SceneSettings;
        [NMS(Size = 0x100)]
        /* 0x2F0 */ public string WorkingDirectory;
		public enum SolarSystemBootEnum { FromSettings, Generate }
		/* 0x3F0 */ public SolarSystemBootEnum SolarSystemBoot;
		public enum ShaderPreloadEnum { Off, Full }
		/* 0x3F4 */ public ShaderPreloadEnum ShaderPreload;
        /* 0x3F8 */ public bool ShaderPreloadListExport;
        /* 0x3F9 */ public bool ShaderPreloadListImport;
        /* 0x3FA */ public bool ShaderCaching;
		public enum BootLoadDelayEnum { LoadAll, WaitForPlanet, WaitForNothing }
		/* 0x3FC */ public BootLoadDelayEnum BootLoadDelay;
        /* 0x400 */ public bool MemCsv;
		/* 0x404 */ public float ForceTimeOfDay;
		/* 0x408 */ public bool ForceSunDirectionFromPhotoMode;
		/* 0x40C */ public float ForceSunAngle;
		/* 0x410 */ public bool ResetForcedSaveSlotOnLoad;
		/* 0x411 */ public bool UseParticles;
		/* 0x412 */ public bool UseHeavyAir;
		/* 0x413 */ public bool UseVolumetrics;
		/* 0x414 */ public bool UseClouds;
		/* 0x415 */ public bool EnableCloudAnimation;
		/* 0x416 */ public bool UseTerrain;
		/* 0x417 */ public bool UseInstances;
		/* 0x418 */ public bool UseObjects;
		/* 0x419 */ public bool UseBuildings;
		/* 0x41A */ public bool UseCreatures;
		/* 0x41B */ public bool UseElevation;
		/* 0x41C */ public bool UseLegacyFreighters;
		/* 0x41D */ public bool UseLegacyBuildingTable;
		/* 0x41E */ public bool EnableDayNightCycle;
		/* 0x41F */ public bool SpawnPirates;
		/* 0x420 */ public bool SpawnRobots;
		/* 0x421 */ public bool SpawnShips;
		/* 0x422 */ public bool SpawnPulseEncounters;
		/* 0x423 */ public bool InstanceCollision;
		/* 0x424 */ public bool MPMissions;
		/* 0x425 */ public bool SpecialsShop;
		/* 0x426 */ public bool MultiplePlayerFreightersInASystem;
		/* 0x427 */ public bool ForceNexusInQuickMenu;
		/* 0x428 */ public bool MouseLookEnabled;
		/* 0x429 */ public bool StartPaused;
		/* 0x42A */ public bool DisableDebugControls;
		/* 0x42B */ public bool FixedFramerate;
		/* 0x42C */ public bool ScreenshotMode;
		/* 0x42D */ public bool RenderHud;
		/* 0x42E */ public bool DisableDiscoveryNaming;
		/* 0x42F */ public bool DebugDrawPlayerInteract;
		/* 0x430 */ public bool ForceInteractionToSettings;
		/* 0x434 */ public int ForceInteractionIndex;
		/* 0x438 */ public bool InteractionsAllwaysGivesTech;
		/* 0x439 */ public bool InfiniteInteractions;
		/* 0x43A */ public bool StopSwitchingToSecondaryInteractions;
        /* 0x43C */ public TkLanguages DebugLanguage;
        [NMS(Size = 0x20)]
        /* 0x440 */ public string AllowedLanguagesFile;
        /* 0x460 */ public bool DoAlienLanguage;
        /* 0x464 */ public GcAlienRace ForceInteractionRaceTo;
        public enum RealityModeEnum { LoadPreset, Generate }
        /* 0x468 */ public RealityModeEnum RealityMode;
        /* 0x46C */ public bool DebugPersistentInteractions;
        /* 0x46D */ public bool DisableMissionShop;
        [NMS(Size = 0x80)]
        /* 0x46E */ public string RealityPresetFile;
        /* 0x4EE */ public ushort RealityGenerationIteration;
        [NMS(Size = 0x5)]
        /* 0x4F0 */ public NMSString0x20[] LocTableList;
        [NMS(Size = 0x80)]
        /* 0x590 */ public string DefaultSaveData;
        /* 0x610 */ public bool FormatDownloadStorageAreaOnBoot;
        /* 0x611 */ public bool ForceBasicLoadScreen;
        /* 0x614 */ public float BootLogoFadeRate;
        /* 0x618 */ public bool BootMusic;
        /* 0x61C */ public float WeaponScale3P;
        /* 0x620 */ public bool LogMissingLocalisedText;
        /* 0x621 */ public bool FleetDirectorAutoMode;
        /* 0x624 */ public float _3dTextDistance;
        /* 0x628 */ public float _3dTextMinScale;
		public enum RecordSettingEnum { None, Record, Playback }
		/* 0x62C */ public RecordSettingEnum RecordSetting;
        /* 0x630 */ public bool DebugBuildingSpawns;
        /* 0x631 */ public bool StressTestLongNameDisplay;
        /* 0x632 */ public bool ShowLongestStrings;
        [NMS(Size = 0x20)]
        /* 0x633 */ public string SaveTestingCommand;
        /* 0x653 */ public bool NeverUseBanks;
        /* 0x654 */ public bool DisableProfanityFilter;
        /* 0x655 */ public bool DisableFileWatcher;
        /* 0x656 */ public bool DisableShaderReload;
        /* 0x658 */ public int RecurrenceTimeOffset;
        [NMS(Size = 0x80)]
        /* 0x65C */ public string CrashDumpPath;
        [NMS(Size = 0x20)]
        /* 0x6DC */ public string CrashDumpIdentifier;
        /* 0x6FC */ public bool EnableLivePP;
        /* 0x6FD */ public bool DebugThreatLevels;
        /* 0x6FE */ public bool ShowDebugMessages;
        /* 0x6FF */ public bool ShowFramerate;
        /* 0x700 */ public bool PrintAvgFrameTimes;
        /* 0x701 */ public bool ShowPositionDebug;
        /* 0x702 */ public bool ShowGPUMemory;
        /* 0x703 */ public bool ShowMempoolOverlay;
        /* 0x704 */ public bool ShowMouseSmoothing;
        [NMS(Size = 0x100)]
        /* 0x705 */ public string ShowUniverseAddressOnGalaxyMap;
        /* 0x805 */ public bool ShowGraphs;
        /* 0x808 */ public int ShowSpecificGraph;
        /* 0x80C */ public bool GraphCommandBuffer;
        /* 0x80D */ public bool GraphGeneration;
        /* 0x80E */ public bool GraphFPS;
        /* 0x80F */ public bool GraphTexStreaming;
        /* 0x810 */ public bool SmokeTestDumpStatsMode;
		public enum SmokeTestCycleModeEnum { None, TourSolarSystem, RegeneratePlanet }
		/* 0x814 */ public SmokeTestCycleModeEnum SmokeTestCycleMode;
        /* 0x818 */ public bool SmokeTestCameraFly;
        /* 0x819 */ public bool SmokeTestOutputOnly;
        /* 0x81A */ public bool SmokeTestPureFlight;
        /* 0x81C */ public int SmokeTestConfigCaptureCycles;
        /* 0x820 */ public float SmokeTestConfigCaptureDurationInSeconds;
        /* 0x824 */ public int SmokeTestConfigCaptureFolderNameNumberOffset;
        /* 0x828 */ public bool SmokeTestConfigRandomizePlanetSeed;
		/* 0x829 */ public bool SmokeTestSmokeBotEnabled;
		/* 0x82A */ public bool SmokeTestSmokeBotAutoStart;
		/* 0x82C */ public int SmokeTestSmokeBotTargetWarps;
        /* 0x830 */ public bool SmokeTestPostBandwidthStats;
		/* 0x831 */ public bool CreatureChatter;
		/* 0x832 */ public bool CreatureErrors;
		/* 0x833 */ public bool CreatureDrawVocals;
		/* 0x834 */ public bool DrawCreaturesInRoutines;
		/* 0x835 */ public bool CompressTextures;
		/* 0x836 */ public bool DebugIBL;
		/* 0x837 */ public bool DebugTerrainTextures;
		/* 0x838 */ public bool DisableShadowSwitching;
		[NMS(Size = 0x80)]
		/* 0x839 */ public string PipelineFile;
		[NMS(Size = 0x80)]
		/* 0x8B9 */ public string PipelineFilePS4;
		[NMS(Size = 0x80)]
		/* 0x939 */ public string PipelineFileXboxOne;
		[NMS(Size = 0x80)]
		/* 0x9B9 */ public string PipelineFileVR;
        [NMS(Size = 0x80)]
		/* 0xA39 */ public string PipelineFileVRPS4;
		[NMS(Size = 0x80)]
		/* 0xAB9 */ public string PipelineFileFrontend;
		[NMS(Size = 0x80)]
		/* 0xB39 */ public string PipelineFileEditor;
		/* 0xBB9 */ public bool RenderLowFramerate;
		/* 0xBBA */ public bool EnableComputePost;
        /* 0xBBB */ public bool EnableEvenOddRender;
		/* 0xBBC */ public bool MinGPUMode;
        /* 0xBBD */ public bool AlwaysIncludeLocalPlayerInChatMessage;
        /* 0xBBE */ public bool SimulateNoNetworkConnection;
		public enum ProxyTypeEnum { None, ManualURI, InetProxy }
		/* 0xBC0 */ public ProxyTypeEnum ProxyType;
        [NMS(Size = 0x80)]
        /* 0xBC4 */ public string ProxyURI;
		public enum ServerEnvEnum { Default, dev, qa, prodqa, prod, custom, pentest }
		/* 0xC44 */ public ServerEnvEnum ServerEnv;
        [NMS(Size = 0x80)]
        /* 0xC48 */ public string AuthBaseUrl;
        /* 0xCC8 */ public bool CertificateSecurityBypass;
        [NMS(Size = 0x20)]
        /* 0xCC9 */ public string OverrideUsernameForDev;
        /* 0xCEC */ public int DiscoveryAutoSyncIntervalSeconds;
        /* 0xCF0 */ public bool DisableSpaceStationSpawnOnJoin;
        /* 0xCF1 */ public bool AutoJoinUserEnabled;
        [NMS(Size = 8)]
        /* 0xCF2 */ public NMSString0x100[] AutoJoinUserNames;      // this is its own struct now but this should work...
        /* 0x14F2 */ public bool AlwaysSaveGameAsClient;
        /* 0x14F3 */ public bool DisableMonumentDownloads;
        /* 0x14F4 */ public bool UsePadOnUnfocusedWindow;
        /* 0x14F8 */ public int OverrideMatchmakingVersion;
        [NMS(Size = 0x200)]
        /* 0x14FC */ public string LoadToBase;
        /* 0x16FC */ public bool IgnoreTransactionTimeouts;
        /* 0x16FD */ public bool AutoJoinRandomGames;
        [NMS(Size = 0x100)]
        /* 0x16FE */ public string GOGLogin;
        /* 0x17FE */ public bool RecordNetworkStatsOnBoot;
        /* 0x17FF */ public bool FakeHandsInMultiplayer;
        /* 0x1800 */ public bool ForceSmallLobby;
        /* 0x1801 */ public bool EnableSynergy;
        [NMS(Size = 0x20)]
        /* 0x1802 */ public string SynergyServer;
        /* 0x1824 */ public int SynergyPort;
        /* 0x1828 */ public bool ShowEditorPlacementPreview;
        /* 0x182C */ public int MaxNumDebugMessages;
        /* 0x1830 */ public bool PreloadToolbox;
        /* 0x1834 */ public int DebugTextureSize;
        /* 0x1838 */ public bool UseProcTextureDebugger;
        /* 0x183C */ public int ProceduralModelsShown;
        /* 0x1840 */ public int ProceduralModelBatchSize;
        [NMS(Size = 0x80)]
        /* 0x1844 */ public string DebugFont;
        [NMS(Size = 0x80)]
        /* 0x18C4 */ public string DebugFontTexture;
        [NMS(Size = 0x80)]
        /* 0x1944 */ public string CursorTexture;
        [NMS(Size = 0x80)]
        /* 0x19C4 */ public string PauseTexture;
        [NMS(Size = 0x80)]
        /* 0x1A44 */ public string PlayTexture;
        [NMS(Size = 0x80)]
        /* 0x1AC4 */ public string StepTexture;
        [NMS(Size = 0x80)]
        /* 0x1B44 */ public string RenderToTexture;
		/* 0x1BC4 */ public bool HmdEnable;
		/* 0x1BC8 */ public int HmdPreviewScale;
		/* 0x1BCC */ public bool HmdTracking;
		/* 0x1BCD */ public bool HmdStereoRender;
		/* 0x1BCE */ public bool HmdDistortionPassthru;
		/* 0x1BD0 */ public int HmdMonitor;
		/* 0x1BD4 */ public int HmdEyeBufferWidth;
		/* 0x1BD8 */ public int HmdEyeBufferHeight;
		/* 0x1BDC */ public float HmdEyeScalePos;
		/* 0x1BE0 */ public float HmdHeadScalePos;
		/* 0x1BE4 */ public bool HmdFrameShiftEnabled;
		/* 0x1BE5 */ public bool HmdUseSolidGuiPointer;
		/* 0x1BE6 */ public bool BodyTurning;
		/* 0x1BE8 */ public float HmdImmersionFactor;
		/* 0x1BEC */ public bool ShowHmdHandControllers;
		/* 0x1BED */ public bool ShowTeleportEffectLocally;
		/* 0x1BEE */ public bool DisableLeftHand;
		/* 0x1BEF */ public bool DisableHeadConstraints;
		/* 0x1BF0 */ public bool EnablePhotomodeVR;
		/* 0x1BF1 */ public bool AllowNGuiVR;
		/* 0x1BF2 */ public bool ForceExtremeWeather;
		/* 0x1BF3 */ public bool ForceExtremeSentinels;
        /* 0x1BF4 */ public bool ForceStarType;
        /* 0x1BF8 */ public GcGalaxyStarTypes ForceStarTypeTo;
        /* 0x1BFC */ public bool ForceBiome;
        /* 0x1C00 */ public GcBiomeType ForceBiomeTo;
        /* 0x1C04 */ public GcBiomeSubType ForceBiomeSubTypeTo;
        /* 0x1C08 */ public bool ForceBuildingRace;
        /* 0x1C0C */ public GcAlienRace ForceBuildingRaceTo;
        /* 0x1C10 */ public bool ForceLifeLevel;
        /* 0x1C14 */ public GcPlanetLife ForceLifeLevelTo;
        /* 0x1C18 */ public bool ForceCreatureLifeLevel;
        /* 0x1C19 */ public bool ForceDefaultCreatureFile;
        /* 0x1C1C */ public GcPlanetLife ForceCreatureLifeLevelTo;
        /* 0x1C20 */ public GcPlanetLife ForceTerrainSettings;
        /* 0x1C24 */ public bool ForceTerrainType;
        /* 0x1C28 */ public TkVoxelGeneratorSettingsTypes ForceTerranTypeTo;
		/* 0x1C2C */ public GcGalaxyStarAnomaly ForceAnomalyTo;
        /* 0x1C30 */ public bool ForcePlanetsToHaveWater;
        /* 0x1C34 */ public int ForceWaterObjectFileIndex;
        /* 0x1C38 */ public int ForceSkyColourIndex;
        /* 0x1C3C */ public int ForceWaterColourIndex;
        /* 0x1C40 */ public bool ModifyPlanetsInInitialSystems;
        /* 0x1C41 */ public bool DisableLimits;
        /* 0x1C42 */ public bool LimitPerRegionInstances;
        /* 0x1C43 */ public bool LimitPerRegionBodies;
        /* 0x1C44 */ public bool LimitGlobalInstances;
        /* 0x1C45 */ public bool LimitGlobalBodies;
        /* 0x1C48 */ public int GenerateFarLodBuildingDist;
        /* 0x1C4C */ public bool DeferRegionBodies;
        /* 0x1C50 */ public float GenerateCostDistance;
        /* 0x1C54 */ public float GenerateCostAngle;
        /* 0x1C58 */ public float GenerateCostLOD;
        /* 0x1C5C */ public float GenerateCostWait;
        /* 0x1C60 */ public bool DChecksEnabled;
        /* 0x1C61 */ public bool DChecksOutputJson;
        /* 0x1C62 */ public bool DChecksOutputBinary;
        /* 0x1C63 */ public bool DChecksOutputFileLine;
        /* 0x1C64 */ public int FrameFlipRateDefault;
        /* 0x1C68 */ public int FrameFlipRateLoad;
        /* 0x1C6C */ public int FrameFlipRateGame;
        /* 0x1C70 */ public float MaxFrameRate;
        /* 0x1C74 */ public bool DisableBaseBuilding;
        /* 0x1C75 */ public bool DisableBaseBuildingLimits;
        /* 0x1C78 */ public float BaseDownloadTimeout;
        /* 0x1C7C */ public bool DisableBasePowerRequirements;
        /* 0x1C7D */ public bool EnableBaseMovingOption;
        /* 0x1C80 */ public int MoveBaseIndex;
        /* 0x1C84 */ public int AutomaticPartSpawnIndex;
        /* 0x1C88 */ public bool BaseAdmin;
        [NMS(Size = 0x20)]
        /* 0x1C89 */ public string BaseServerPlatform;       // "pc"
        /* 0x1CAC */ public uint BasePayloadMultiplier;
        /* 0x1CB0 */ public bool CrossPlatformFeaturedBases;
        /* 0x1CB1 */ public bool ShowMissionIdInTitle;
        [NMS(Size = 0x2, Ignore = true)]
        /* 0x1CB2 */ public byte[] Padding1CB2;
        /* 0x1CB4 */ public TkGlobals ToolkitGlobals;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x1ECC */ public byte[] EndPadding;
    }
}
