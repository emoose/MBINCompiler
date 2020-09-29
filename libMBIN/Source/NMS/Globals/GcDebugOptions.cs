using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(Size = 0x1F38, GUID = 0x25367B82E3E17D03)]
    public class GcDebugOptions : NMSTemplate
    {
        /* 0x0000 */ public bool ForceScanEventsToGoPrime;
        /* 0x0001 */ public bool SkipAbandonedFreighterUnlocking;
        /* 0x0002 */ public bool AllowSavingOnAbandonedFreighters;
        /* 0x0003 */ public bool DisableAbandonedFreighterRoomsOptimisation;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x0004 */ public byte[] Padding4;
        /* 0x0008 */ public ulong OverrideAbandonedFreighterSeed;
        /* 0x0010 */ public bool ThirdPersonIsDefaultCamera;
        /* 0x0011 */ public bool SkipIntro;
        /* 0x0012 */ public bool SkipLogos;
        [NMS(Size = 0x1, Ignore = true)]
        /* 0x0013 */ public byte[] Padding13;
        /* 0x0014 */ public int BootDirectlyIntoSaveSlot;
        /* 0x0018 */ public bool BootDirectlyIntoLastSave;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x0019 */ public byte[] Padding19;
        /* 0x001C */ public GcGameMode NewSaveGameMode;
        /* 0x0020 */ public bool SkipPlanetDiscoverOnBoot;
        /* 0x0021 */ public bool VideoCaptureMode;
        /* 0x0022 */ public bool GodMode;
        /* 0x0023 */ public bool TakeNoDamage;
        /* 0x0024 */ public bool AlwaysHaveFocus;
        /* 0x0025 */ public bool DisableVibration;
        /* 0x0026 */ public bool DebugGalaxyMapInQuickMenu;
        /* 0x0027 */ public bool MapWarpCheckIgnoreFuel;
        /* 0x0028 */ public bool MapWarpCheckIgnoreDrive;
        /* 0x0029 */ public bool EverythingIsFree;
        /* 0x002A */ public bool EverythingIsKnown;
        /* 0x002B */ public bool EverythingIsStar;
        /* 0x002C */ public bool InfiniteStamina;
        /* 0x002D */ public bool DisableHazards;
        /* 0x002E */ public bool IgnoreMissionRank;
        /* 0x002F */ public bool CanLeaveDialogs;
        /* 0x0030 */ public bool DisableOldMissions;
        /* 0x0031 */ public bool UseScreenEffects;
        /* 0x0032 */ public bool UseGunImpactEffect;
        /* 0x0033 */ public bool RenderCreatureDetails;
        /* 0x0034 */ public bool SkipTutorial;
        /* 0x0035 */ public bool IgnoreFreighterSpawnWarpRequirement;
        /* 0x0036 */ public bool MaximumFreighterSpawns;
        /* 0x0037 */ public bool DisableSaveSlotSorting;
        /* 0x0038 */ public bool DisableSaving;
        /* 0x0039 */ public bool DisableStorms;
        /* 0x003A */ public bool AlternateControls;
        /* 0x003B */ public bool AlwaysShowURI;
        /* 0x003C */ public bool MPMissionsAlwaysEPIC;
        /* 0x003D */ public bool ShowFireteamMembersUA;
        /* 0x003E */ public bool RevealAllTitles;
        /* 0x003F */ public bool UnlockAllTitles;
        /* 0x0040 */ public bool LockAllTitles;
        /* 0x0041 */ public bool AlwaysAllowShipOperations;
        /* 0x0042 */ public bool AlwaysAllowVehicleOperations;
        /* 0x0043 */ public bool AlwaysAllowFreighterInventoryAccess;
        /* 0x0044 */ public bool UseDebugScreenSettings;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x0045 */ public byte[] Padding45;
        /* 0x0048 */ public int ScreenWidth;
        /* 0x004C */ public int ScreenHeight;
        /* 0x0050 */ public bool DisableVSync;
		public enum GameWindowModeEnum { Bordered, Borderless, Fullscreen }
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x0051 */ public byte[] Padding51;
        /* 0x0054 */ public GameWindowModeEnum GameWindowMode;
        /* 0x0058 */ public int Monitor;
        /* 0x005C */ public int TiledWindowsSplitCount;
        /* 0x0060 */ public int TiledWindowsIndex;
        [NMS(Size = 0x100)]
        /* 0x0064 */ public string ForceUniverseAddress;
        [NMS(Size = 0x100)]
        /* 0x0164 */ public string ForcePlayerPosition;
        /* 0x0264 */ public bool ForceInitialShip;
        /* 0x0265 */ public bool ForceInitialWeapon;
		public enum GameStateModeEnum { LoadPreset, UserStorage, FreshStart }
        [NMS(Size = 0x2, Ignore = true)]
        /* 0x0266 */ public byte[] Padding266;
        /* 0x0268 */ public GameStateModeEnum GameStateMode;
		public enum BootModeEnum { MinimalSolarSystem, SolarSystem, GalaxyMap, SmokeTest, SmokeTestGalaxyMap, Scratchpad, UnitTest }
        /* 0x026C */ public BootModeEnum BootMode;
		public enum PlayerSpawnLocationOverrideEnum { None, FromSettings, Space, SpaceStation, RandomPlanet, GameStartPlanet, SpecificLocation }
        /* 0x0270 */ public PlayerSpawnLocationOverrideEnum PlayerSpawnLocationOverride;
        [NMS(Size = 0x80)]
        /* 0x0274 */ public string SceneSettings;
        [NMS(Size = 0x100)]
        /* 0x02F4 */ public string WorkingDirectory;
		public enum SolarSystemBootEnum { FromSettings, Generate }
        /* 0x03F4 */ public SolarSystemBootEnum SolarSystemBoot;
		public enum ShaderPreloadEnum { Off, Full }
        /* 0x03F8 */ public ShaderPreloadEnum ShaderPreload;
        /* 0x03FC */ public bool ShaderPreloadListExport;
        /* 0x03FD */ public bool ShaderPreloadListImport;
        /* 0x03FE */ public bool ShaderCaching;
		public enum BootLoadDelayEnum { LoadAll, WaitForPlanet, WaitForNothing }
        [NMS(Size = 0x1, Ignore = true)]
        /* 0x03FF */ public byte[] Padding3FF;
        /* 0x0400 */ public BootLoadDelayEnum BootLoadDelay;
        /* 0x0404 */ public bool MemCsv;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x0405 */ public byte[] Padding405;
        /* 0x0408 */ public float ForceTimeOfDay;
        /* 0x040C */ public float ForceInitialTimeOfDay;
        /* 0x0410 */ public bool ForceSunDirectionFromPhotoMode;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x0411 */ public byte[] Padding411;
        /* 0x0414 */ public float ForceSunAngle;
        /* 0x0418 */ public bool ResetForcedSaveSlotOnLoad;
        /* 0x0419 */ public bool UseParticles;
        /* 0x041A */ public bool UseHeavyAir;
        /* 0x041B */ public bool UseVolumetrics;
        /* 0x041C */ public bool UseClouds;
        /* 0x041D */ public bool EnableCloudAnimation;
        /* 0x041E */ public bool UseTerrain;
        /* 0x041F */ public bool UseInstances;
        /* 0x0420 */ public bool UseObjects;
        /* 0x0421 */ public bool UseBuildings;
        /* 0x0422 */ public bool UseCreatures;
        /* 0x0423 */ public bool UseElevation;
        /* 0x0424 */ public bool UseLegacyFreighters;
        /* 0x0425 */ public bool UseLegacyBuildingTable;
        /* 0x0426 */ public bool EnableDayNightCycle;
        /* 0x0427 */ public bool SpawnPirates;
        /* 0x0428 */ public bool SpawnRobots;
        /* 0x0429 */ public bool SpawnShips;
        /* 0x042A */ public bool SpawnPulseEncounters;
        /* 0x042B */ public bool InstanceCollision;
        /* 0x042C */ public bool LoadMissions;
        /* 0x042D */ public bool MPMissions;
        /* 0x042E */ public bool SpecialsShop;
        /* 0x042F */ public bool MultiplePlayerFreightersInASystem;
        /* 0x0430 */ public bool ForceNexusInQuickMenu;
        /* 0x0431 */ public bool MissionSurveyEnabled;
        /* 0x0432 */ public bool MouseLookEnabled;
        /* 0x0433 */ public bool StartPaused;
        /* 0x0434 */ public bool DisableDebugControls;
        /* 0x0435 */ public bool FixedFramerate;
        /* 0x0436 */ public bool ScreenshotMode;
        /* 0x0437 */ public bool RenderHud;
        /* 0x0438 */ public bool DisableDiscoveryNaming;
        /* 0x0439 */ public bool DebugDrawPlayerInteract;
        /* 0x043A */ public bool ForceInteractionToSettings;
        [NMS(Size = 0x1, Ignore = true)]
        /* 0x043B */ public byte[] Padding43B;
        /* 0x043C */ public int ForceInteractionIndex;
        /* 0x0440 */ public bool InteractionsAllwaysGivesTech;
        /* 0x0441 */ public bool InfiniteInteractions;
        /* 0x0442 */ public bool StopSwitchingToSecondaryInteractions;
        [NMS(Size = 0x1, Ignore = true)]
        /* 0x0443 */ public byte[] Padding443;
        /* 0x0444 */ public TkLanguages DebugLanguage;
        [NMS(Size = 0x20)]
        /* 0x0448 */ public string AllowedLanguagesFile;
        /* 0x0468 */ public bool DoAlienLanguage;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x0469 */ public byte[] Padding469;
        /* 0x046C */ public GcAlienRace ForceInteractionRaceTo;
        public enum RealityModeEnum { LoadPreset, Generate }
        /* 0x0470 */ public RealityModeEnum RealityMode;
        /* 0x0474 */ public bool DebugPersistentInteractions;
        /* 0x0475 */ public bool DisableMissionShop;
        [NMS(Size = 0x80)]
        /* 0x0476 */ public string RealityPresetFile;
        /* 0x04F6 */ public ushort RealityGenerationIteration;
        [NMS(Size = 0x5)]
        /* 0x04F8 */ public NMSString0x20[] LocTableList;
        [NMS(Size = 0x80)]
        /* 0x0598 */ public string DefaultSaveData;
        /* 0x0618 */ public bool FormatDownloadStorageAreaOnBoot;
        /* 0x0619 */ public bool ForceBasicLoadScreen;
        [NMS(Size = 0x2, Ignore = true)]
        /* 0x061A */ public byte[] Padding61A;
        /* 0x061C */ public float BootLogoFadeRate;
        /* 0x0620 */ public bool BootMusic;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x0621 */ public byte[] Padding621;
        /* 0x0624 */ public float WeaponScale3P;
        /* 0x0628 */ public bool LogMissingLocalisedText;
        /* 0x0629 */ public bool FleetDirectorAutoMode;
        [NMS(Size = 0x2, Ignore = true)]
        /* 0x062A */ public byte[] Padding62A;
        /* 0x062C */ public float _3dTextDistance;
        /* 0x0630 */ public float _3dTextMinScale;
		public enum RecordSettingEnum { None, Record, Playback }
        /* 0x0634 */ public RecordSettingEnum RecordSetting;
        /* 0x0638 */ public bool DebugBuildingSpawns;
        /* 0x0639 */ public bool StressTestLongNameDisplay;
        /* 0x063A */ public bool ShowLongestStrings;
        [NMS(Size = 0x20)]
        /* 0x063B */ public string SaveTestingCommand;
        /* 0x065B */ public bool NeverUseBanks;
        /* 0x065C */ public bool DisableProfanityFilter;
        /* 0x065D */ public bool DisableFileWatcher;
        /* 0x065E */ public bool DisableShaderReload;
        [NMS(Size = 0x1, Ignore = true)]
        /* 0x065F */ public byte[] Padding65F;
        /* 0x0660 */ public int RecurrenceTimeOffset;
        [NMS(Size = 0x80)]
        /* 0x0664 */ public string CrashDumpPath;
        [NMS(Size = 0x20)]
        /* 0x06E4 */ public string CrashDumpIdentifier;
        /* 0x0704 */ public bool EnableLivePP;
        /* 0x0705 */ public bool DebugThreatLevels;
        /* 0x0706 */ public bool ShowDebugMessages;
        /* 0x0707 */ public bool ShowFramerate;
        /* 0x0708 */ public bool PrintAvgFrameTimes;
        /* 0x0709 */ public bool ShowPositionDebug;
        /* 0x070A */ public bool ShowGPUMemory;
        /* 0x070B */ public bool ShowMempoolOverlay;
        /* 0x070C */ public bool ShowMouseSmoothing;
        [NMS(Size = 0x100)]
        /* 0x070D */ public string ShowUniverseAddressOnGalaxyMap;
        /* 0x080D */ public bool ShowGraphs;
        [NMS(Size = 0x2, Ignore = true)]
        /* 0x080E */ public byte[] Padding80E;
        /* 0x0810 */ public int ShowSpecificGraph;
        /* 0x0814 */ public bool GraphCommandBuffer;
        /* 0x0815 */ public bool GraphGeneration;
        /* 0x0816 */ public bool GraphFPS;
        /* 0x0817 */ public bool GraphTexStreaming;
        /* 0x0818 */ public bool SmokeTestDumpStatsMode;
		public enum SmokeTestCycleModeEnum { None, TourSolarSystem, RegeneratePlanet }
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x0819 */ public byte[] Padding819;
        /* 0x081C */ public SmokeTestCycleModeEnum SmokeTestCycleMode;
        public enum SmokeTestScenarioEnum { None, TerrainSnapShotFromAltitude, BelowCloudLayerSnapShot, Flying }
        /* 0x0820 */ public SmokeTestScenarioEnum SmokeTestScenario;
        /* 0x0824 */ public bool SmokeTestLegacyOutput;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x0825 */ public byte[] Padding825;
        /* 0x0828 */ public int SmokeTestConfigPlanetPositionCount;
        /* 0x082C */ public float SmokeTestConfigScenarioPreambleLength;
        /* 0x0830 */ public float SmokeTestConfigScenarioLength;
        /* 0x0834 */ public bool SmokeTestCameraFly;
        /* 0x0835 */ public bool SmokeTestOutputOnly;
        /* 0x0836 */ public bool SmokeTestPureFlight;
        [NMS(Size = 0x1, Ignore = true)]
        /* 0x0837 */ public byte[] Padding837;
        /* 0x0838 */ public int SmokeTestConfigCaptureCycles;
        /* 0x083C */ public float SmokeTestConfigCaptureDurationInSeconds;
        /* 0x0840 */ public int SmokeTestConfigCaptureFolderNameNumberOffset;
        /* 0x0844 */ public bool SmokeTestConfigRandomizePlanetSeed;
        /* 0x0845 */ public bool SmokeTestSmokeBotEnabled;
        /* 0x0846 */ public bool SmokeTestSmokeBotAutoStart;
        [NMS(Size = 0x1, Ignore = true)]
        /* 0x0847 */ public byte[] Padding847;
        /* 0x0848 */ public int SmokeTestSmokeBotTargetWarps;
        /* 0x084C */ public bool SmokeTestPostBandwidthStats;
        /* 0x084D */ public bool CreatureChatter;
        /* 0x084E */ public bool CreatureErrors;
        /* 0x084F */ public bool CreatureDrawVocals;
        /* 0x0850 */ public bool DrawCreaturesInRoutines;
        /* 0x0851 */ public bool CompressTextures;
        /* 0x0852 */ public bool DebugIBL;
        /* 0x0853 */ public bool DebugTerrainTextures;
        /* 0x0854 */ public bool DisableShadowSwitching;
        [NMS(Size = 0x80)]
        /* 0x0855 */ public string PipelineFile;
        [NMS(Size = 0x80)]
        /* 0x08D5 */ public string PipelineFilePS4;
        [NMS(Size = 0x80)]
        /* 0x0955 */ public string PipelineFileXboxOne;
        [NMS(Size = 0x80)]
        /* 0x09D5 */ public string PipelineFileVR;
        [NMS(Size = 0x80)]
        /* 0x0A55 */ public string PipelineFileVRPS4;
        [NMS(Size = 0x80)]
        /* 0x0AD5 */ public string PipelineFileFrontend;
        [NMS(Size = 0x80)]
        /* 0x0B55 */ public string PipelineFileEditor;
        /* 0x0BD5 */ public bool RenderLowFramerate;
        /* 0x0BD6 */ public bool EnableComputePost;
        /* 0x0BD7 */ public bool EnableEvenOddRender;
        /* 0x0BD8 */ public bool MinGPUMode;
        /* 0x0BD9 */ public bool AlwaysIncludeLocalPlayerInChatMessage;
        /* 0x0BDA */ public bool SimulateNoNetworkConnection;
		public enum ProxyTypeEnum { None, ManualURI, InetProxy }
        [NMS(Size = 0x1, Ignore = true)]
        /* 0x0BDB */ public byte[] PaddingBDB;
        /* 0x0BDC */ public ProxyTypeEnum ProxyType;
        [NMS(Size = 0x80)]
        /* 0x0BE0 */ public string ProxyURI;
		public enum ServerEnvEnum { Default, dev, qa, prodqa, prod, custom, pentest }
        /* 0x0C60 */ public ServerEnvEnum ServerEnv;
        [NMS(Size = 0x80)]
        /* 0x0C64 */ public string AuthBaseUrl;
        /* 0x0CE4 */ public bool CertificateSecurityBypass;
        [NMS(Size = 0x20)]
        /* 0x0CE5 */ public string OverrideUsernameForDev;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x0D05 */ public byte[] PaddingD05;
        /* 0x0D08 */ public int DiscoveryAutoSyncIntervalSeconds;
        /* 0x0D0C */ public bool DisableSpaceStationSpawnOnJoin;
        /* 0x0D0D */ public bool AutoJoinUserEnabled;
        [NMS(Size = 0x8)]
        /* 0x0D0E */ public NMSString0x100[] AutoJoinUserNames;      // this is its own struct now but this should work...
        /* 0x150E */ public bool AlwaysSaveGameAsClient;
        /* 0x150F */ public bool DisableMonumentDownloads;
        /* 0x1510 */ public bool UsePadOnUnfocusedWindow;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x1511 */ public byte[] Padding1511;
        /* 0x1514 */ public int OverrideMatchmakingVersion;
        [NMS(Size = 0x200)]
        /* 0x1518 */ public string LoadToBase;
        /* 0x1718 */ public bool IgnoreTransactionTimeouts;
        /* 0x1719 */ public bool AutoJoinRandomGames;
        [NMS(Size = 0x100)]
        /* 0x171A */ public string GOGLogin;
        /* 0x181A */ public bool RecordNetworkStatsOnBoot;
        /* 0x181B */ public bool FakeHandsInMultiplayer;
        /* 0x181C */ public bool ForceSmallLobby;
        /* 0x181D */ public bool EnableSynergy;
        [NMS(Size = 0x20)]
        /* 0x181E */ public string SynergyServer;
        [NMS(Size = 0x2, Ignore = true)]
        /* 0x183E */ public byte[] Padding183E;
        /* 0x1840 */ public int SynergyPort;
        /* 0x1844 */ public bool ShowEditorPlacementPreview;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x1845 */ public byte[] Padding1845;
        /* 0x1848 */ public int MaxNumDebugMessages;
        /* 0x184C */ public bool PreloadToolbox;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x184D */ public byte[] Padding184D;
        /* 0x1850 */ public int DebugTextureSize;
        /* 0x1854 */ public bool UseProcTextureDebugger;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x1855 */ public byte[] Padding1855;
        /* 0x1858 */ public int ProceduralModelsShown;
        /* 0x185C */ public int ProceduralModelBatchSize;
        [NMS(Size = 0x80)]
        /* 0x1860 */ public string DebugFont;
        [NMS(Size = 0x80)]
        /* 0x18E0 */ public string DebugFontTexture;
        [NMS(Size = 0x80)]
        /* 0x1960 */ public string CursorTexture;
        [NMS(Size = 0x80)]
        /* 0x19E0 */ public string PauseTexture;
        [NMS(Size = 0x80)]
        /* 0x1A60 */ public string PlayTexture;
        [NMS(Size = 0x80)]
        /* 0x1AE0 */ public string StepTexture;
        [NMS(Size = 0x80)]
        /* 0x1B60 */ public string RenderToTexture;
        /* 0x1BE0 */ public bool HmdEnable;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x1BE1 */ public byte[] Padding1BE1;
        /* 0x1BE4 */ public int HmdPreviewScale;
        /* 0x1BE8 */ public bool HmdTracking;
        /* 0x1BE9 */ public bool HmdStereoRender;
        /* 0x1BEA */ public bool HmdDistortionPassthru;
        [NMS(Size = 0x1, Ignore = true)]
        /* 0x1BEB */ public byte[] Padding1BEB;
        /* 0x1BEC */ public int HmdMonitor;
        /* 0x1BF0 */ public int HmdEyeBufferWidth;
        /* 0x1BF4 */ public int HmdEyeBufferHeight;
        /* 0x1BF8 */ public float HmdEyeScalePos;
        /* 0x1BFC */ public float HmdHeadScalePos;
        /* 0x1C00 */ public bool HmdFrameShiftEnabled;
        /* 0x1C01 */ public bool HmdUseSolidGuiPointer;
        /* 0x1C02 */ public bool BodyTurning;
        [NMS(Size = 0x1, Ignore = true)]
        /* 0x1C03 */ public byte[] Padding1C03;
        /* 0x1C04 */ public float HmdImmersionFactor;
        /* 0x1C08 */ public bool ShowHmdHandControllers;
        /* 0x1C09 */ public bool ShowTeleportEffectLocally;
        /* 0x1C0A */ public bool DisableLeftHand;
        /* 0x1C0B */ public bool DisableHeadConstraints;
        /* 0x1C0C */ public bool EnablePhotomodeVR;
        /* 0x1C0D */ public bool AllowNGuiVR;
        /* 0x1C0E */ public bool ForceExtremeWeather;
        /* 0x1C0F */ public bool ForceExtremeSentinels;
        /* 0x1C10 */ public bool ForceStarType;
        /* 0x1C11 */ public bool ForceLoadAllWeather;
        [NMS(Size = 0x2, Ignore = true)]
        /* 0x1C12 */ public byte[] Padding1C12;
        /* 0x1C14 */ public GcGalaxyStarTypes ForceStarTypeTo;
        /* 0x1C18 */ public bool ForceBiome;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x1C19 */ public byte[] Padding1C19;
        /* 0x1C1C */ public GcBiomeSubType ForceBiomeTo;
        /* 0x1C20 */ public bool ForceScreenFilter;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x1C21 */ public byte[] Padding1C21;
        /* 0x1C24 */ public GcScreenFilters ForceScreenFilterTo;
        /* 0x1C28 */ public GcBiomeSubType ForceBiomeSubTypeTo;
        /* 0x1C2C */ public bool ForceBuildingRace;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x1C2D */ public byte[] Padding1C2D;
        /* 0x1C30 */ public GcAlienRace ForceBuildingRaceTo;
        /* 0x1C34 */ public bool ForceLifeLevel;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x1C35 */ public byte[] Padding1C35;
        /* 0x1C38 */ public GcPlanetLife ForceLifeLevelTo;
        /* 0x1C3C */ public bool ForceCreatureLifeLevel;
        /* 0x1C3D */ public bool ForceDefaultCreatureFile;
        [NMS(Size = 0x2, Ignore = true)]
        /* 0x1C3E */ public byte[] Padding1C3E;
        [NMS(Size = 0x10)]
        /* 0x1C40 */ public string DefaultGroundCreatureTable;
        [NMS(Size = 0x10)]
        /* 0x1C50 */ public string DefaultAirCreatureTable;
        [NMS(Size = 0x10)]
        /* 0x1C60 */ public string DefaultWaterCreatureTable;
        [NMS(Size = 0x10)]
        /* 0x1C70 */ public string DefaultCaveCreatureTable;
        /* 0x1C80 */ public GcPlanetLife ForceCreatureLifeLevelTo;
        /* 0x1C84 */ public GcPlanetLife ForceTerrainSettings;
        /* 0x1C88 */ public bool ForceTerrainType;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x1C89 */ public byte[] Padding1C89;
        /* 0x1C8C */ public TkVoxelGeneratorSettingsTypes ForceTerrainTypeTo;
        /* 0x1C90 */ public bool ForcePrimeTerrain;
        /* 0x1C91 */ public bool ForceBinaryStar;
        /* 0x1C92 */ public bool ForceTernaryStar;
        [NMS(Size = 0x1, Ignore = true)]
        /* 0x1C93 */ public byte[] Padding1C93;
        /* 0x1C94 */ public GcGalaxyStarAnomaly ForceAnomalyTo;
        /* 0x1C98 */ public bool ForcePlanetsToHaveWater;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x1C99 */ public byte[] Padding1C99;
        /* 0x1C9C */ public int ForceWaterObjectFileIndex;
        /* 0x1CA0 */ public int ForceSkyColourIndex;
        /* 0x1CA4 */ public int ForceWaterColourIndex;
        /* 0x1CA8 */ public int ForceGrassColourIndex;
        /* 0x1CAC */ public bool ModifyPlanetsInInitialSystems;
        /* 0x1CAD */ public bool DisableLimits;
        /* 0x1CAE */ public bool LimitPerRegionInstances;
        /* 0x1CAF */ public bool LimitPerRegionBodies;
        /* 0x1CB0 */ public bool LimitGlobalInstances;
        /* 0x1CB1 */ public bool LimitGlobalBodies;
        [NMS(Size = 0x2, Ignore = true)]
        /* 0x1CB2 */ public byte[] Padding1CB2;
        /* 0x1CB4 */ public int GenerateFarLodBuildingDist;
        /* 0x1CB8 */ public bool DeferRegionBodies;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x1CB9 */ public byte[] Padding1CB9;
        /* 0x1CBC */ public float GenerateCostDistance;
        /* 0x1CC0 */ public float GenerateCostAngle;
        /* 0x1CC4 */ public float GenerateCostLOD;
        /* 0x1CC8 */ public float GenerateCostWait;
        /* 0x1CCC */ public bool DChecksEnabled;
        /* 0x1CCD */ public bool DChecksOutputJson;
        /* 0x1CCE */ public bool DChecksOutputBinary;
        /* 0x1CCF */ public bool DChecksOutputFileLine;
        /* 0x1CD0 */ public int FrameFlipRateDefault;
        /* 0x1CD4 */ public int FrameFlipRateLoad;
        /* 0x1CD8 */ public int FrameFlipRateGame;
        /* 0x1CDC */ public float MaxFrameRate;
        /* 0x1CE0 */ public bool DisableBaseBuilding;
        /* 0x1CE1 */ public bool DisableBaseBuildingLimits;
        [NMS(Size = 0x2, Ignore = true)]
        /* 0x1CE2 */ public byte[] Padding1CE2;
        /* 0x1CE4 */ public float BaseDownloadTimeout;
        /* 0x1CE8 */ public bool DisableBasePowerRequirements;
        /* 0x1CE9 */ public bool EnableBaseMovingOption;
        [NMS(Size = 0x2, Ignore = true)]
        /* 0x1CEA */ public byte[] Padding1CEA;
        /* 0x1CEC */ public int MoveBaseIndex;
        /* 0x1CF0 */ public int AutomaticPartSpawnIndex;
        /* 0x1CF4 */ public bool BaseAdmin;
        [NMS(Size = 0x20)]
        /* 0x1CF5 */ public string BaseServerPlatform;       // "pc"
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x1D15 */ public byte[] Padding1D15;
        /* 0x1D18 */ public uint BasePayloadMultiplier;
        /* 0x1D1C */ public bool CrossPlatformFeaturedBases;
        /* 0x1D1D */ public bool ShowMissionIdInTitle;
        [NMS(Size = 0x2, Ignore = true)]
        /* 0x1D1E */ public byte[] Padding1D1E;
        /* 0x1D20 */ public TkGlobals ToolkitGlobals;
    }
}
