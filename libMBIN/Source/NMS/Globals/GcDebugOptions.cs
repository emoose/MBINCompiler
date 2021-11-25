using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(Size = 0x25D0, GUID = 0xFADAAC086CAB431B, NameHash = 0x013FED27DF728C38)]
    public class GcDebugOptions : NMSTemplate
    {
        /* 0x0000 */ public bool ForceScanEventsToGoPrime;
        /* 0x0001 */ public bool SkipAbandonedFreighterUnlocking;
        /* 0x0002 */ public bool AllowSavingOnAbandonedFreighters;
        /* 0x0003 */ public bool DisableAbandonedFreighterRoomsOptimisation;
        /* 0x0008 */ public ulong OverrideAbandonedFreighterSeed;
        /* 0x0010 */ public bool ThirdPersonIsDefaultCamera;
        /* 0x0011 */ public bool SkipIntro;
        /* 0x0012 */ public bool SkipLogos;
        /* 0x0014 */ public int BootDirectlyIntoSaveSlot;
        /* 0x0018 */ public bool BootDirectlyIntoLastSave;
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
        /* 0x0044 */ public NMSString0x200 SeasonalDataOverrideFile;
        /* 0x0244 */ public bool UnlockAllSeasonRewards;
        /* 0x0245 */ public bool UnlockAllTwitchRewards;
        /* 0x0246 */ public NMSString0x400 DebugTwitchRewards;
        /* 0x0646 */ public bool AllowPause;
        /* 0x0647 */ public bool AllSettlementsAreCompleted;
        /* 0x0648 */ public bool UseDebugScreenSettings;
        /* 0x064C */ public int ScreenWidth;
        /* 0x0650 */ public int ScreenHeight;
        /* 0x0654 */ public bool DisableVSync;
        // size: 0x3
        public enum GameWindowModeEnum { Bordered, Borderless, Fullscreen }
        /* 0x0658 */ public GameWindowModeEnum GameWindowMode;
        /* 0x065C */ public int Monitor;
        /* 0x0660 */ public int TiledWindowsSplitCount;
        /* 0x0664 */ public int TiledWindowsIndex;
        /* 0x0668 */ public NMSString0x100 ForceUniverseAddress;
        /* 0x0768 */ public NMSString0x100 ForcePlayerPosition;
        /* 0x0868 */ public bool ForceInitialShip;
        /* 0x0869 */ public bool ForceInitialWeapon;
        // size: 0x3
        public enum GameStateModeEnum { LoadPreset, UserStorage, FreshStart }
        /* 0x086C */ public GameStateModeEnum GameStateMode;
        // size: 0x7
        public enum BootModeEnum { MinimalSolarSystem, SolarSystem, GalaxyMap, SmokeTest, SmokeTestGalaxyMap,
            Scratchpad, UnitTest
        }
        /* 0x0870 */ public BootModeEnum BootMode;
        // size: 0x7
        public enum PlayerSpawnLocationOverrideEnum { None, FromSettings, Space, SpaceStation, RandomPlanet, GameStartPlanet, SpecificLocation
        }
        /* 0x0874 */ public PlayerSpawnLocationOverrideEnum PlayerSpawnLocationOverride;
        /* 0x0878 */ public NMSString0x80 SceneSettings;
        /* 0x08F8 */ public NMSString0x100 WorkingDirectory;
        /* 0x09F8 */ public NMSString0x80 DebugScene;
        // size: 0x2
        public enum SolarSystemBootEnum { FromSettings, Generate }
        /* 0x0A78 */ public SolarSystemBootEnum SolarSystemBoot;
        // size: 0x2
        public enum ShaderPreloadEnum { Off, Full }
        /* 0x0A7C */ public ShaderPreloadEnum ShaderPreload;
        /* 0x0A80 */ public bool ShaderPreloadListExport;
        /* 0x0A81 */ public bool ShaderPreloadListImport;
        /* 0x0A82 */ public bool ShaderCaching;
        // size: 0x3
        public enum BootLoadDelayEnum { LoadAll, WaitForPlanet, WaitForNothing }
        /* 0x0A84 */ public BootLoadDelayEnum BootLoadDelay;
        /* 0x0A88 */ public bool MemCsv;
        /* 0x0A8C */ public float ForceTimeOfDay;
        /* 0x0A90 */ public float ForceInitialTimeOfDay;
        /* 0x0A94 */ public bool ForceSunDirectionFromPhotoMode;
        /* 0x0A98 */ public float ForceSunAngle;
        /* 0x0A9C */ public bool ResetForcedSaveSlotOnLoad;
        /* 0x0A9D */ public bool UseParticles;
        /* 0x0A9E */ public bool UseHeavyAir;
        /* 0x0A9F */ public bool UseVolumetrics;
        /* 0x0AA0 */ public bool UseClouds;
        /* 0x0AA1 */ public bool EnableCloudAnimation;
        /* 0x0AA2 */ public bool UseTerrain;
        /* 0x0AA3 */ public bool UseInstances;
        /* 0x0AA4 */ public bool UseObjects;
        /* 0x0AA5 */ public bool UseBuildings;
        /* 0x0AA6 */ public bool UseCreatures;
        /* 0x0AA7 */ public bool UseElevation;
        /* 0x0AA8 */ public bool UseLegacyFreighters;
        /* 0x0AA9 */ public bool UseLegacyBuildingTable;
        /* 0x0AAA */ public bool EnableDayNightCycle;
        /* 0x0AAB */ public bool SpawnPirates;
        /* 0x0AAC */ public bool SpawnRobots;
        /* 0x0AAD */ public bool SpawnShips;
        /* 0x0AAE */ public bool SpawnPulseEncounters;
        /* 0x0AAF */ public bool InstanceCollision;
        /* 0x0AB0 */ public bool LoadMissions;
        /* 0x0AB1 */ public bool MPMissions;
        /* 0x0AB2 */ public bool SpecialsShop;
        /* 0x0AB3 */ public bool MultiplePlayerFreightersInASystem;
        /* 0x0AB4 */ public bool ForceNexusInQuickMenu;
        /* 0x0AB5 */ public bool MissionSurveyEnabled;
        /* 0x0AB6 */ public bool SeasonalModeEnabled;
        /* 0x0AB7 */ public bool AllSeasonMilestonesShowComplete;
        /* 0x0AB8 */ public bool EnableGalaxyRecolouring;
        /* 0x0AB9 */ public bool IgnoreSteamDev;
        /* 0x0ABA */ public bool MouseLookEnabled;
        /* 0x0ABB */ public bool StartPaused;
        /* 0x0ABC */ public bool DisableDebugControls;
        /* 0x0ABD */ public bool FixedFramerate;
        /* 0x0ABE */ public bool ScreenshotMode;
        /* 0x0ABF */ public bool RenderHud;
        /* 0x0AC0 */ public bool DisableDiscoveryNaming;
        /* 0x0AC1 */ public bool DebugDrawPlayerInteract;
        /* 0x0AC2 */ public bool ForceInteractionToSettings;
        /* 0x0AC4 */ public int ForceInteractionIndex;
        /* 0x0AC8 */ public bool InteractionsAllwaysGivesTech;
        /* 0x0AC9 */ public bool InfiniteInteractions;
        /* 0x0ACA */ public bool StopSwitchingToSecondaryInteractions;
        /* 0x0ACC */ public TkLanguages DebugLanguage;
        /* 0x0AD0 */ public NMSString0x20 AllowedLanguagesFile;
        /* 0x0AF0 */ public bool DoAlienLanguage;
        /* 0x0AF4 */ public GcAlienRace ForceInteractionRaceTo;
        // size: 0x2
        public enum RealityModeEnum { LoadPreset, Generate }
        /* 0x0AF8 */ public RealityModeEnum RealityMode;
        /* 0x0AFC */ public bool DebugPersistentInteractions;
        /* 0x0AFD */ public bool UseHighlightedOptionStyle;
        /* 0x0AFE */ public bool DisableMissionShop;
        /* 0x0AFF */ public NMSString0x80 RealityPresetFile;
        /* 0x0B80 */ public ushort RealityGenerationIteration;
        /* 0x0B88 */ public List<NMSString0x20> LocTableList;
        /* 0x0B98 */ public NMSString0x80 DefaultSaveData;
        /* 0x0C18 */ public bool FormatDownloadStorageAreaOnBoot;
        /* 0x0C19 */ public bool ForceBasicLoadScreen;
        /* 0x0C1C */ public float BootLogoFadeRate;
        /* 0x0C20 */ public bool BootMusic;
        /* 0x0C24 */ public float WeaponScale3P;
        /* 0x0C28 */ public bool LogMissingLocalisedText;
        /* 0x0C29 */ public bool FleetDirectorAutoMode;
        /* 0x0C2C */ public float _3dTextDistance;
        /* 0x0C30 */ public float _3dTextMinScale;
        // size: 0x3
        public enum RecordSettingEnum { None, Record, Playback }
        /* 0x0C34 */ public RecordSettingEnum RecordSetting;
        /* 0x0C38 */ public bool DebugBuildingSpawns;
        /* 0x0C39 */ public bool StressTestLongNameDisplay;
        /* 0x0C3A */ public bool ShowLongestStrings;
        /* 0x0C3B */ public NMSString0x20 SaveTestingCommand;
        /* 0x0C5B */ public bool NeverUseBanks;
        /* 0x0C5C */ public bool DisableProfanityFilter;
        /* 0x0C5D */ public bool DisableFileWatcher;
        /* 0x0C5E */ public bool DisableShaderReload;
        /* 0x0C60 */ public int RecurrenceTimeOffset;
        /* 0x0C64 */ public NMSString0x80 CrashDumpPath;
        /* 0x0CE4 */ public NMSString0x20 CrashDumpIdentifier;
        /* 0x0D04 */ public bool EnableLivePP;
        /* 0x0D05 */ public bool DebugThreatLevels;
        /* 0x0D06 */ public bool ShowDebugMessages;
        /* 0x0D07 */ public bool ShowFramerate;
        /* 0x0D08 */ public bool PrintAvgFrameTimes;
        /* 0x0D09 */ public bool ShowPositionDebug;
        /* 0x0D0A */ public bool ShowGPUMemory;
        /* 0x0D0B */ public bool ShowMempoolOverlay;
        /* 0x0D0C */ public bool ShowMouseSmoothing;
        /* 0x0D0D */ public NMSString0x100 ShowUniverseAddressOnGalaxyMap;
        /* 0x0E0D */ public bool ShowGraphs;
        /* 0x0E10 */ public int ShowSpecificGraph;
        /* 0x0E14 */ public bool GraphCommandBuffer;
        /* 0x0E15 */ public bool GraphGeneration;
        /* 0x0E16 */ public bool GraphFPS;
        /* 0x0E17 */ public bool GraphTexStreaming;
        /* 0x0E18 */ public bool SmokeTestDumpStatsMode;
        // size: 0x5
        public enum SmokeTestCycleModeEnum { None, TourPlanet, TourSolarSystem, TourGalaxy, TourUDAs }
        /* 0x0E1C */ public SmokeTestCycleModeEnum SmokeTestCycleMode;
        // size: 0x6
        public enum SmokeTestScenarioEnum { None, TerrainSnapShotFromAltitude, BelowCloudLayerSnapShot, Flying, UltraBiomeSnapShot,
            Walking
        }
        /* 0x0E20 */ public SmokeTestScenarioEnum SmokeTestScenario;
        /* 0x0E24 */ public bool SmokeTestLegacyOutput;
        /* 0x0E28 */ public int SmokeTestConfigPlanetPositionCount;
        /* 0x0E2C */ public float SmokeTestConfigScenarioPreambleLength;
        /* 0x0E30 */ public float SmokeTestConfigScenarioLength;
        /* 0x0E34 */ public bool SmokeTestFastExit;
        /* 0x0E35 */ public bool SmokeTestCameraFly;
        /* 0x0E36 */ public bool SmokeTestOutputOnly;
        /* 0x0E37 */ public bool SmokeTestPureFlight;
        /* 0x0E38 */ public int SmokeTestConfigCaptureCycles;
        /* 0x0E3C */ public float SmokeTestConfigCaptureDurationInSeconds;
        /* 0x0E40 */ public int SmokeTestConfigCaptureFolderNameNumberOffset;
        /* 0x0E44 */ public bool SmokeTestConfigRandomizePlanetSeed;
        /* 0x0E45 */ public bool SmokeTestSmokeBotEnabled;
        /* 0x0E46 */ public bool SmokeTestSmokeBotAutoStart;
        /* 0x0E48 */ public int SmokeTestSmokeBotTargetWarps;
        /* 0x0E4C */ public bool SmokeTestPostBandwidthStats;
        /* 0x0E4D */ public NMSString0x20 SmokeTestForcePlanetDetail;
        /* 0x0E6D */ public NMSString0x20 SmokeTestRunFolder;
        /* 0x0E8D */ public bool CreatureChatter;
        /* 0x0E8E */ public bool CreatureErrors;
        /* 0x0E8F */ public bool CreatureDrawVocals;
        /* 0x0E90 */ public bool DrawCreaturesInRoutines;
        /* 0x0E91 */ public bool CompressTextures;
        /* 0x0E92 */ public bool DebugIBL;
        /* 0x0E93 */ public bool DebugTerrainTextures;
        /* 0x0E94 */ public bool DisableShadowSwitching;
        /* 0x0E95 */ public NMSString0x80 PipelineFile;
        /* 0x0F15 */ public NMSString0x80 PipelineFilePS4;
        /* 0x0F95 */ public NMSString0x80 PipelineFileXboxOne;
        /* 0x1015 */ public NMSString0x80 PipelineFileVR;
        /* 0x1095 */ public NMSString0x80 PipelineFileVRPS4;
        /* 0x1115 */ public NMSString0x80 PipelineFileFrontend;
        /* 0x1195 */ public NMSString0x80 PipelineFileEditor;
        /* 0x1215 */ public bool RenderLowFramerate;
        /* 0x1216 */ public bool EnableComputePost;
        /* 0x1217 */ public bool EnableEvenOddRender;
        /* 0x1218 */ public bool MinGPUMode;
        /* 0x1219 */ public bool Proto2DevKit;
        /* 0x121A */ public bool AlwaysIncludeLocalPlayerInChatMessage;
        /* 0x121B */ public bool SimulateNoNetworkConnection;
        // size: 0x3
        public enum ProxyTypeEnum { None, ManualURI, InetProxy }
        /* 0x121C */ public ProxyTypeEnum ProxyType;
        /* 0x1220 */ public NMSString0x80 ProxyURI;
        // size: 0x8
        public enum ServerEnvEnum { Default, dev, qa, prodqa, prod, custom, pentest, merged }
        /* 0x12A0 */ public ServerEnvEnum ServerEnv;
        /* 0x12A4 */ public NMSString0x80 AuthBaseUrl;
        /* 0x1324 */ public bool CertificateSecurityBypass;
        /* 0x1325 */ public NMSString0x20 OverrideUsernameForDev;
        /* 0x1348 */ public int DiscoveryAutoSyncIntervalSeconds;
        /* 0x134C */ public bool DisableSpaceStationSpawnOnJoin;
        /* 0x134D */ public bool AutoJoinUserEnabled;
        /* 0x134E */ public NMSString0x800 AutoJoinUserNames;
        /* 0x1B4E */ public bool AlwaysSaveGameAsClient;
        /* 0x1B4F */ public bool DisableMonumentDownloads;
        /* 0x1B50 */ public bool UsePadOnUnfocusedWindow;
        /* 0x1B54 */ public int OverrideMatchmakingVersion;
        /* 0x1B58 */ public NMSString0x200 LoadToBase;
        /* 0x1D58 */ public bool IgnoreTransactionTimeouts;
        /* 0x1D59 */ public bool AutoJoinRandomGames;
        /* 0x1D5A */ public NMSString0x100 GOGLogin;
        /* 0x1E5A */ public bool RecordNetworkStatsOnBoot;
        /* 0x1E5B */ public bool FakeHandsInMultiplayer;
        /* 0x1E5C */ public bool ForceSmallLobby;
        /* 0x1E60 */ public int OverrideServerSeasonNumber;
        /* 0x1E64 */ public int OverrideServerSeasonEndTime;
        /* 0x1E68 */ public bool EnableSynergy;
        /* 0x1E69 */ public NMSString0x20 SynergyServer;
        /* 0x1E8C */ public int SynergyPort;
        /* 0x1E90 */ public bool ShowEditorPlacementPreview;
        /* 0x1E94 */ public int MaxNumDebugMessages;
        /* 0x1E98 */ public bool PreloadToolbox;
        /* 0x1E9C */ public int DebugTextureSize;
        /* 0x1EA0 */ public bool UseProcTextureDebugger;
        /* 0x1EA4 */ public int ProceduralModelsShown;
        /* 0x1EA8 */ public int ProceduralModelBatchSize;
        /* 0x1EAC */ public int ProceduralModelFilterMatchretryCount;
        /* 0x1EB0 */ public bool ProceduralModelsDeterministicSequence;
        /* 0x1EB4 */ public int ProceduralModelsThumbnailSize;
        /* 0x1EB8 */ public NMSString0x80 DebugFont;
        /* 0x1F38 */ public NMSString0x80 DebugFontTexture;
        /* 0x1FB8 */ public NMSString0x80 CursorTexture;
        /* 0x2038 */ public NMSString0x80 PauseTexture;
        /* 0x20B8 */ public NMSString0x80 PlayTexture;
        /* 0x2138 */ public NMSString0x80 StepTexture;
        /* 0x21B8 */ public NMSString0x80 RenderToTexture;
        /* 0x2238 */ public bool HmdEnable;
        /* 0x223C */ public int HmdPreviewScale;
        /* 0x2240 */ public bool HmdTracking;
        /* 0x2241 */ public bool HmdStereoRender;
        /* 0x2242 */ public bool HmdDistortionPassthru;
        /* 0x2244 */ public int HmdMonitor;
        /* 0x2248 */ public int HmdEyeBufferWidth;
        /* 0x224C */ public int HmdEyeBufferHeight;
        /* 0x2250 */ public float HmdEyeScalePos;
        /* 0x2254 */ public float HmdHeadScalePos;
        /* 0x2258 */ public bool HmdFrameShiftEnabled;
        /* 0x2259 */ public bool HmdUseSolidGuiPointer;
        /* 0x225A */ public bool BodyTurning;
        /* 0x225C */ public float HmdImmersionFactor;
        /* 0x2260 */ public bool ShowHmdHandControllers;
        /* 0x2261 */ public bool ShowTeleportEffectLocally;
        /* 0x2262 */ public bool DisableLeftHand;
        /* 0x2263 */ public bool DisableHeadConstraints;
        /* 0x2264 */ public bool EnablePhotomodeVR;
        /* 0x2265 */ public bool AllowNGuiVR;
        /* 0x2266 */ public bool ForceExtremeWeather;
        /* 0x2267 */ public bool ForceExtremeSentinels;
        /* 0x2268 */ public bool ForceStarType;
        /* 0x2269 */ public bool ForceLoadAllWeather;
        /* 0x226C */ public GcGalaxyStarTypes ForceStarTypeTo;
        /* 0x2270 */ public bool ForceBiome;
        /* 0x2274 */ public GcBiomeType ForceBiomeTo;
        /* 0x2278 */ public bool ForceScreenFilter;
        /* 0x227C */ public GcScreenFilters ForceScreenFilterTo;
        /* 0x2280 */ public GcBiomeSubType ForceBiomeSubTypeTo;
        /* 0x2284 */ public bool ForceBuildingRace;
        /* 0x2288 */ public GcAlienRace ForceBuildingRaceTo;
        /* 0x228C */ public bool ForceLifeLevel;
        /* 0x2290 */ public GcPlanetLife ForceLifeLevelTo;
        /* 0x2294 */ public bool ForceCreatureLifeLevel;
        /* 0x2295 */ public bool ForceDefaultCreatureFile;
        /* 0x2298 */ public NMSString0x10 DefaultGroundCreatureTable;
        /* 0x22A8 */ public NMSString0x10 DefaultAirCreatureTable;
        /* 0x22B8 */ public NMSString0x10 DefaultWaterCreatureTable;
        /* 0x22C8 */ public NMSString0x10 DefaultCaveCreatureTable;
        /* 0x22D8 */ public GcPlanetLife ForceCreatureLifeLevelTo;
        /* 0x22DC */ public GcPlanetLife ForceTerrainSettings;
        /* 0x22E0 */ public bool ForceTerrainType;
        /* 0x22E4 */ public TkVoxelGeneratorSettingsTypes ForceTerrainTypeTo;
        /* 0x22E8 */ public bool ForcePrimeTerrain;
        /* 0x22E9 */ public bool ForceBinaryStar;
        /* 0x22EA */ public bool ForceTernaryStar;
        /* 0x22EC */ public GcGalaxyStarAnomaly ForceAnomalyTo;
        /* 0x22F0 */ public bool ForcePlanetsToHaveWater;
        /* 0x22F4 */ public int ForceWaterObjectFileIndex;
        /* 0x22F8 */ public int ForceSkyColourIndex;
        /* 0x22FC */ public int ForceWaterColourIndex;
        /* 0x2300 */ public int ForceGrassColourIndex;
        /* 0x2304 */ public bool ModifyPlanetsInInitialSystems;
        /* 0x2305 */ public bool ForcePlanetsToHaveNoWater;
        /* 0x2306 */ public bool ForcePlanetsToHaveNoCaves;
        /* 0x2307 */ public bool ForcePlanetsToHaveNoNoiseLayers;
        /* 0x2308 */ public bool ForcePlanetsToHaveNoTerrainFeatures;
        /* 0x2309 */ public bool DisableLimits;
        /* 0x230A */ public bool LimitPerRegionInstances;
        /* 0x230B */ public bool LimitPerRegionBodies;
        /* 0x230C */ public bool LimitGlobalInstances;
        /* 0x230D */ public bool LimitGlobalBodies;
        /* 0x2310 */ public int GenerateFarLodBuildingDist;
        /* 0x2314 */ public bool DeferRegionBodies;
        /* 0x2318 */ public float GenerateCostDistance;
        /* 0x231C */ public float GenerateCostAngle;
        /* 0x2320 */ public float GenerateCostLOD;
        /* 0x2324 */ public float GenerateCostWait;
        /* 0x2328 */ public bool DChecksEnabled;
        /* 0x2329 */ public bool DChecksOutputJson;
        /* 0x232A */ public bool DChecksOutputBinary;
        /* 0x232B */ public bool DChecksOutputFileLine;
        /* 0x232C */ public int FrameFlipRateDefault;
        /* 0x2330 */ public int FrameFlipRateLoad;
        /* 0x2334 */ public int FrameFlipRateGame;
        /* 0x2338 */ public float MaxFrameRate;
        /* 0x233C */ public bool DisableBaseBuilding;
        /* 0x233D */ public bool DisableBaseBuildingLimits;
        /* 0x233E */ public bool AllowGlobalPartSnapping;
        /* 0x2340 */ public float BaseDownloadTimeout;
        /* 0x2344 */ public bool DisableBasePowerRequirements;
        /* 0x2345 */ public bool EnableBaseMovingOption;
        /* 0x2348 */ public int MoveBaseIndex;
        /* 0x234C */ public NMSString0x20 AutomaticPartSpawnID;
        /* 0x236C */ public GcBaseBuildingPartStyle AutomaticPartSpawnStyle;
        /* 0x2370 */ public bool AutomaticPartSpawnInactive;
        /* 0x2374 */ public int ProfilerPartIndexPhase;
        /* 0x2378 */ public int ProfilerPartIndexStride;
        /* 0x237C */ public int ProfilerPartIteration;
        /* 0x2380 */ public bool BaseAdmin;
        /* 0x2381 */ public NMSString0x20 BaseServerPlatform;       // "pc"
        /* 0x23A4 */ public uint BasePayloadMultiplier;
        /* 0x23A8 */ public bool CrossPlatformFeaturedBases;
        /* 0x23A9 */ public bool ShowMissionIdInTitle;
        /* 0x23AC */ public TkGlobals ToolkitGlobals;
    }
}
