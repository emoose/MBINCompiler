using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Globals
{
    [NMS(Size = 0x2658, GUID = 0x87DAB6637DE673D8, NameHash = 0x013FED27DF728C38)]
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
        /* 0x0024 */ public bool SuperKillGuns;
        /* 0x0025 */ public bool AlwaysHaveFocus;
        /* 0x0026 */ public bool DisableVibration;
        /* 0x0027 */ public bool DebugGalaxyMapInQuickMenu;
        /* 0x0028 */ public bool MapWarpCheckIgnoreFuel;
        /* 0x0029 */ public bool MapWarpCheckIgnoreDrive;
        /* 0x002A */ public bool EverythingIsFree;
        /* 0x002B */ public bool EverythingIsKnown;
        /* 0x002C */ public bool EverythingIsStar;
        /* 0x002D */ public bool InfiniteStamina;
        /* 0x002E */ public bool DisableHazards;
        /* 0x002F */ public bool IgnoreMissionRank;
        /* 0x0030 */ public bool CanLeaveDialogs;
        /* 0x0031 */ public bool DisableOldMissions;
        /* 0x0032 */ public bool UseScreenEffects;
        /* 0x0033 */ public bool UseGunImpactEffect;
        /* 0x0034 */ public bool RenderCreatureDetails;
        /* 0x0035 */ public bool SkipTutorial;
        /* 0x0036 */ public bool IgnoreFreighterSpawnWarpRequirement;
        /* 0x0037 */ public bool MaximumFreighterSpawns;
        /* 0x0038 */ public bool DisableSaveSlotSorting;
        /* 0x0039 */ public bool DisableSaving;
        /* 0x003A */ public bool DisableStorms;
        /* 0x003B */ public bool ForceEnablePlayerClothComponent;
        /* 0x003C */ public bool ForceDisablePlayerClothComponent;
        /* 0x003D */ public bool AlternateControls;
        /* 0x003E */ public bool AlwaysShowURI;
        /* 0x003F */ public bool MPMissionsAlwaysEPIC;
        /* 0x0040 */ public bool ShowFireteamMembersUA;
        /* 0x0041 */ public bool RevealAllTitles;
        /* 0x0042 */ public bool UnlockAllTitles;
        /* 0x0043 */ public bool LockAllTitles;
        /* 0x0044 */ public bool AlwaysAllowShipOperations;
        /* 0x0045 */ public bool AlwaysAllowVehicleOperations;
        /* 0x0046 */ public bool AlwaysAllowFreighterInventoryAccess;
        /* 0x0047 */ public NMSString0x200 SeasonalDataOverrideFile;
        /* 0x0247 */ public bool UnlockAllSeasonRewards;
        /* 0x0248 */ public bool UnlockAllTwitchRewards;
        /* 0x0249 */ public NMSString0x400 DebugTwitchRewards;
        /* 0x0649 */ public bool AllowPause;
        /* 0x064A */ public bool AllSettlementsAreCompleted;
        /* 0x064B */ public bool DisableSettlements;
        /* 0x064C */ public bool PlaceOnGroundWhenLeavingDebugCamera;
        /* 0x064D */ public bool OctahedralImpostersEnable;
        /* 0x0650 */ public int OctahedralImpostersViewCount;
        /* 0x0654 */ public bool UseDebugScreenSettings;
        /* 0x0658 */ public int ScreenWidth;
        /* 0x065C */ public int ScreenHeight;
        /* 0x0660 */ public bool DisableVSync;
        // size: 0x3
        public enum GameWindowModeEnum { Bordered, Borderless, Fullscreen }
        /* 0x0664 */ public GameWindowModeEnum GameWindowMode;
        /* 0x0668 */ public int Monitor;
        /* 0x066C */ public int TiledWindowsSplitCount;
        /* 0x0670 */ public int TiledWindowsIndex;
        /* 0x0674 */ public NMSString0x100 ForceUniverseAddress;
        /* 0x0774 */ public NMSString0x100 ForcePlayerPosition;
        /* 0x0874 */ public bool ForceInitialShip;
        /* 0x0875 */ public bool ForceInitialWeapon;
        // size: 0x3
        public enum GameStateModeEnum { LoadPreset, UserStorage, FreshStart }
        /* 0x0878 */ public GameStateModeEnum GameStateMode;
        // size: 0x7
        public enum BootModeEnum { MinimalSolarSystem, SolarSystem, GalaxyMap, SmokeTest, SmokeTestGalaxyMap,
            Scratchpad, UnitTest
        }
        /* 0x087C */ public BootModeEnum BootMode;
        // size: 0x7
        public enum PlayerSpawnLocationOverrideEnum { None, FromSettings, Space, SpaceStation, RandomPlanet, GameStartPlanet, SpecificLocation
        }
        /* 0x0880 */ public PlayerSpawnLocationOverrideEnum PlayerSpawnLocationOverride;
        /* 0x0884 */ public NMSString0x80 SceneSettings;
        /* 0x0904 */ public NMSString0x100 WorkingDirectory;
        /* 0x0A04 */ public NMSString0x80 DebugScene;
        // size: 0x2
        public enum SolarSystemBootEnum { FromSettings, Generate }
        /* 0x0A84 */ public SolarSystemBootEnum SolarSystemBoot;
        // size: 0x2
        public enum ShaderPreloadEnum { Off, Full }
        /* 0x0A88 */ public ShaderPreloadEnum ShaderPreload;
        /* 0x0A8C */ public bool ShaderPreloadListExport;
        /* 0x0A8D */ public bool ShaderPreloadListImport;
        /* 0x0A8E */ public bool ShaderCaching;
        // size: 0x3
        public enum BootLoadDelayEnum { LoadAll, WaitForPlanet, WaitForNothing }
        /* 0x0A90 */ public BootLoadDelayEnum BootLoadDelay;
        /* 0x0A94 */ public bool MemCsv;
        /* 0x0A98 */ public float ForceTimeOfDay;
        /* 0x0A9C */ public float ForceInitialTimeOfDay;
        /* 0x0AA0 */ public bool ForceSunDirectionFromPhotoMode;
        /* 0x0AA4 */ public float ForceSunAngle;
        /* 0x0AA8 */ public bool ResetForcedSaveSlotOnLoad;
        /* 0x0AA9 */ public bool MissionMessageLoggingEnabled;
        /* 0x0AAA */ public bool UseParticles;
        /* 0x0AAB */ public bool UseHeavyAir;
        /* 0x0AAC */ public bool UseVolumetrics;
        /* 0x0AAD */ public bool UseClouds;
        /* 0x0AAE */ public bool EnableCloudAnimation;
        /* 0x0AAF */ public bool UseTerrain;
        /* 0x0AB0 */ public bool UseInstances;
        /* 0x0AB1 */ public bool UseObjects;
        /* 0x0AB2 */ public bool UseBuildings;
        /* 0x0AB3 */ public bool UseCreatures;
        /* 0x0AB4 */ public bool UseElevation;
        /* 0x0AB5 */ public bool UseLegacyFreighters;
        /* 0x0AB6 */ public bool UseLegacyBuildingTable;
        /* 0x0AB7 */ public bool EnableDayNightCycle;
        /* 0x0AB8 */ public bool SpawnPirates;
        /* 0x0AB9 */ public bool SpawnRobots;
        /* 0x0ABA */ public bool SpawnShips;
        /* 0x0ABB */ public bool SpawnPulseEncounters;
        /* 0x0ABC */ public bool InstanceCollision;
        /* 0x0ABD */ public bool LoadMissions;
        /* 0x0ABE */ public bool MPMissions;
        /* 0x0ABF */ public bool SpecialsShop;
        /* 0x0AC0 */ public bool MultiplePlayerFreightersInASystem;
        /* 0x0AC1 */ public bool ForceNexusInQuickMenu;
        /* 0x0AC2 */ public bool MissionSurveyEnabled;
        /* 0x0AC3 */ public bool AllSeasonMilestonesShowComplete;
        /* 0x0AC4 */ public bool EnableGalaxyRecolouring;
        /* 0x0AC5 */ public bool IgnoreSteamDev;
        /* 0x0AC6 */ public bool EnableBaseBuildingExpandables;
        /* 0x0AC7 */ public bool MouseLookEnabled;
        /* 0x0AC8 */ public bool StartPaused;
        /* 0x0AC9 */ public bool DisableDebugControls;
        /* 0x0ACA */ public bool FixedFramerate;
        /* 0x0ACB */ public bool ScreenshotMode;
        /* 0x0ACC */ public bool RenderHud;
        /* 0x0ACD */ public bool DisableDiscoveryNaming;
        /* 0x0ACE */ public bool DebugDrawPlayerInteract;
        /* 0x0ACF */ public bool ForceInteractionToSettings;
        /* 0x0AD0 */ public int ForceInteractionIndex;
        /* 0x0AD4 */ public bool InteractionsAllwaysGivesTech;
        /* 0x0AD5 */ public bool InfiniteInteractions;
        /* 0x0AD6 */ public bool StopSwitchingToSecondaryInteractions;
        /* 0x0AD8 */ public TkLanguages DebugLanguage;
        /* 0x0ADC */ public NMSString0x20 AllowedLanguagesFile;
        /* 0x0AFC */ public bool DoAlienLanguage;
        /* 0x0B00 */ public GcAlienRace ForceInteractionRaceTo;
        // size: 0x2
        public enum RealityModeEnum { LoadPreset, Generate }
        /* 0x0B04 */ public RealityModeEnum RealityMode;
        /* 0x0B08 */ public bool DebugPersistentInteractions;
        /* 0x0B09 */ public bool UseHighlightedOptionStyle;
        /* 0x0B0A */ public bool DisableMissionShop;
        /* 0x0B0B */ public NMSString0x80 RealityPresetFile;
        /* 0x0B8C */ public ushort RealityGenerationIteration;
        /* 0x0B90 */ public List<NMSString0x20> LocTableList;
        /* 0x0BA0 */ public NMSString0x80 DefaultSaveData;
        /* 0x0C20 */ public bool FormatDownloadStorageAreaOnBoot;
        /* 0x0C21 */ public bool ForceBasicLoadScreen;
        /* 0x0C24 */ public float BootLogoFadeRate;
        /* 0x0C28 */ public bool BootMusic;
        /* 0x0C2C */ public float WeaponScale3P;
        /* 0x0C30 */ public bool LogMissingLocalisedText;
        /* 0x0C31 */ public bool FleetDirectorAutoMode;
        /* 0x0C34 */ public float _3dTextDistance;
        /* 0x0C38 */ public float _3dTextMinScale;
        // size: 0x3
        public enum RecordSettingEnum { None, Record, Playback }
        /* 0x0C3C */ public RecordSettingEnum RecordSetting;
        /* 0x0C40 */ public bool DebugBuildingSpawns;
        /* 0x0C41 */ public bool StressTestLongNameDisplay;
        /* 0x0C42 */ public bool ShowLongestStrings;
        /* 0x0C43 */ public NMSString0x20 SaveTestingCommand;
        /* 0x0C63 */ public bool NeverUseBanks;
        /* 0x0C64 */ public bool DisableProfanityFilter;
        /* 0x0C65 */ public bool DisableFileWatcher;
        /* 0x0C66 */ public bool DisableShaderReload;
        /* 0x0C68 */ public int RecurrenceTimeOffset;
        /* 0x0C6C */ public NMSString0x80 CrashDumpPath;
        /* 0x0CEC */ public NMSString0x20 CrashDumpIdentifier;
        /* 0x0D0C */ public bool EnableLivePP;
        /* 0x0D0D */ public bool DebugThreatLevels;
        /* 0x0D0E */ public bool ShowDebugMessages;
        /* 0x0D0F */ public bool ShowFramerate;
        /* 0x0D10 */ public bool PrintAvgFrameTimes;
        /* 0x0D11 */ public bool ShowPositionDebug;
        /* 0x0D12 */ public bool ShowGPUMemory;
        /* 0x0D13 */ public bool ShowMempoolOverlay;
        /* 0x0D14 */ public bool ShowMouseSmoothing;
        /* 0x0D15 */ public NMSString0x100 ShowUniverseAddressOnGalaxyMap;
        /* 0x0E15 */ public bool ShowGraphs;
        /* 0x0E18 */ public int ShowSpecificGraph;
        /* 0x0E1C */ public bool GraphCommandBuffer;
        /* 0x0E1D */ public bool GraphGeneration;
        /* 0x0E1E */ public bool GraphFPS;
        /* 0x0E1F */ public bool GraphTexStreaming;
        /* 0x0E20 */ public bool SmokeTestDumpStatsMode;
        // size: 0x7
        public enum SmokeTestCycleModeEnum { None, TourPlanet, TourSolarSystem, TourGalaxy, TourUDAs, TourShortUDAs, TourRandomWarps
        }
        /* 0x0E24 */ public SmokeTestCycleModeEnum SmokeTestCycleMode;
        // size: 0x7
        public enum SmokeTestScenarioEnum { None, TerrainSnapShotFromAltitude, BelowCloudLayerSnapShot, Flying, UltraBiomeSnapShot,
            Walking, LeakDetector
        }
        /* 0x0E28 */ public SmokeTestScenarioEnum SmokeTestScenario;
        /* 0x0E2C */ public bool SmokeTestLegacyOutput;
        /* 0x0E30 */ public int SmokeTestConfigPlanetPositionCount;
        /* 0x0E34 */ public float SmokeTestConfigScenarioPreambleLength;
        /* 0x0E38 */ public float SmokeTestConfigScenarioLength;
        /* 0x0E3C */ public bool SmokeTestFastExit;
        /* 0x0E3D */ public bool SmokeTestCameraFly;
        /* 0x0E3E */ public bool SmokeTestOutputOnly;
        /* 0x0E3F */ public bool SmokeTestPureFlight;
        /* 0x0E40 */ public int SmokeTestConfigCaptureCycles;
        /* 0x0E44 */ public float SmokeTestConfigCaptureDurationInSeconds;
        /* 0x0E48 */ public int SmokeTestConfigCaptureFolderNameNumberOffset;
        /* 0x0E4C */ public bool SmokeTestConfigRandomizePlanetSeed;
        /* 0x0E4D */ public bool SmokeTestSmokeBotEnabled;
        /* 0x0E4E */ public bool SmokeTestSmokeBotAutoStart;
        /* 0x0E50 */ public int SmokeTestSmokeBotTargetWarps;
        /* 0x0E54 */ public bool SmokeTestPostBandwidthStats;
        /* 0x0E55 */ public NMSString0x20 SmokeTestForcePlanetDetail;
        /* 0x0E75 */ public NMSString0x20 SmokeTestRunFolder;
        /* 0x0E95 */ public bool CreatureChatter;
        /* 0x0E96 */ public bool CreatureErrors;
        /* 0x0E97 */ public bool CreatureDrawVocals;
        /* 0x0E98 */ public bool DrawCreaturesInRoutines;
        /* 0x0E99 */ public bool CompressTextures;
        /* 0x0E9A */ public bool DebugIBL;
        /* 0x0E9B */ public bool DebugTerrainTextures;
        /* 0x0E9C */ public bool DisableShadowSwitching;
        /* 0x0E9D */ public NMSString0x80 PipelineFile;
        /* 0x0F1D */ public NMSString0x80 PipelineFilePS4;
        /* 0x0F9D */ public NMSString0x80 PipelineFileXboxOne;
        /* 0x101D */ public NMSString0x80 PipelineFileVR;
        /* 0x109D */ public NMSString0x80 PipelineFileVRPS4;
        /* 0x111D */ public NMSString0x80 PipelineFileFrontend;
        /* 0x119D */ public NMSString0x80 PipelineFileEditor;
        /* 0x121D */ public bool RenderLowFramerate;
        /* 0x121E */ public bool EnableComputePost;
        /* 0x121F */ public bool EnableEvenOddRender;
        /* 0x1220 */ public bool MinGPUMode;
        /* 0x1221 */ public bool Proto2DevKit;
        /* 0x1222 */ public bool AlwaysIncludeLocalPlayerInChatMessage;
        /* 0x1223 */ public bool SimulateNoNetworkConnection;
        // size: 0x3
        public enum ProxyTypeEnum { None, ManualURI, InetProxy }
        /* 0x1224 */ public ProxyTypeEnum ProxyType;
        /* 0x1228 */ public NMSString0x80 ProxyURI;
        // size: 0x8
        public enum ServerEnvEnum { Default, dev, qa, prodqa, prod, custom, pentest, merged }
        /* 0x12A8 */ public ServerEnvEnum ServerEnv;
        /* 0x12AC */ public NMSString0x80 AuthBaseUrl;
        /* 0x132C */ public bool CertificateSecurityBypass;
        /* 0x132D */ public NMSString0x20 OverrideUsernameForDev;
        /* 0x1350 */ public int DiscoveryAutoSyncIntervalSeconds;
        /* 0x1354 */ public bool DisableSpaceStationSpawnOnJoin;
        /* 0x1355 */ public bool AutoJoinUserEnabled;
        /* 0x1356 */ public NMSString0x800 AutoJoinUserNames;
        /* 0x1B56 */ public bool AlwaysSaveGameAsClient;
        /* 0x1B57 */ public bool DisableMonumentDownloads;
        /* 0x1B58 */ public bool UsePadOnUnfocusedWindow;
        /* 0x1B5C */ public int OverrideMatchmakingVersion;
        /* 0x1B60 */ public NMSString0x200 LoadToBase;
        /* 0x1D60 */ public bool IgnoreTransactionTimeouts;
        /* 0x1D61 */ public bool AutoJoinRandomGames;
        /* 0x1D62 */ public NMSString0x100 GOGLogin;
        /* 0x1E62 */ public bool RecordNetworkStatsOnBoot;
        /* 0x1E63 */ public bool FakeHandsInMultiplayer;
        /* 0x1E64 */ public bool ForceSmallLobby;
        /* 0x1E68 */ public int OverrideServerSeasonNumber;
        /* 0x1E6C */ public int OverrideServerSeasonEndTime;
        /* 0x1E70 */ public bool EnableSynergy;
        /* 0x1E71 */ public NMSString0x20 SynergyServer;
        /* 0x1E94 */ public int SynergyPort;
        /* 0x1E98 */ public bool ShowEditorPlacementPreview;
        /* 0x1E9C */ public int MaxNumDebugMessages;
        /* 0x1EA0 */ public bool PreloadToolbox;
        /* 0x1EA4 */ public int DebugTextureSize;
        /* 0x1EA8 */ public bool UseProcTextureDebugger;
        /* 0x1EAC */ public int ProceduralModelsShown;
        /* 0x1EB0 */ public int ProceduralModelBatchSize;
        /* 0x1EB4 */ public int ProceduralModelFilterMatchretryCount;
        /* 0x1EB8 */ public bool ProceduralModelsDeterministicSequence;
        /* 0x1EBC */ public int ProceduralModelsThumbnailSize;
        /* 0x1EC0 */ public NMSString0x80 DebugFont;
        /* 0x1F40 */ public NMSString0x80 DebugFontTexture;
        /* 0x1FC0 */ public NMSString0x80 CursorTexture;
        /* 0x2040 */ public NMSString0x80 PauseTexture;
        /* 0x20C0 */ public NMSString0x80 PlayTexture;
        /* 0x2140 */ public NMSString0x80 StepTexture;
        /* 0x21C0 */ public NMSString0x80 RenderToTexture;
        /* 0x2240 */ public bool HmdEnable;
        /* 0x2244 */ public int HmdPreviewScale;
        /* 0x2248 */ public bool HmdTracking;
        /* 0x2249 */ public bool HmdStereoRender;
        /* 0x224A */ public bool HmdDistortionPassthru;
        /* 0x224C */ public int HmdMonitor;
        /* 0x2250 */ public int HmdEyeBufferWidth;
        /* 0x2254 */ public int HmdEyeBufferHeight;
        /* 0x2258 */ public float HmdEyeScalePos;
        /* 0x225C */ public float HmdHeadScalePos;
        /* 0x2260 */ public bool HmdFrameShiftEnabled;
        /* 0x2261 */ public bool HmdUseSolidGuiPointer;
        /* 0x2262 */ public bool BodyTurning;
        /* 0x2264 */ public float HmdImmersionFactor;
        /* 0x2268 */ public bool ShowHmdHandControllers;
        /* 0x2269 */ public bool ShowTeleportEffectLocally;
        /* 0x226A */ public bool DisableLeftHand;
        /* 0x226B */ public bool DisableHeadConstraints;
        /* 0x226C */ public bool EnablePhotomodeVR;
        /* 0x226D */ public bool AllowNGuiVR;
        /* 0x226E */ public bool ForceExtremeWeather;
        /* 0x226F */ public bool ForceExtremeSentinels;
        /* 0x2270 */ public bool ForceStarType;
        /* 0x2271 */ public bool ForceLoadAllWeather;
        /* 0x2274 */ public GcGalaxyStarTypes ForceStarTypeTo;
        /* 0x2278 */ public bool ForceBiome;
        /* 0x227C */ public GcBiomeType ForceBiomeTo;
        /* 0x2280 */ public bool ForceScreenFilter;
        /* 0x2284 */ public GcScreenFilters ForceScreenFilterTo;
        /* 0x2288 */ public GcBiomeSubType ForceBiomeSubTypeTo;
        /* 0x228C */ public bool ForceBuildingRace;
        /* 0x2290 */ public GcAlienRace ForceBuildingRaceTo;
        /* 0x2294 */ public bool ForceLifeLevel;
        /* 0x2298 */ public GcPlanetLife ForceLifeLevelTo;
        /* 0x229C */ public bool ForceCreatureLifeLevel;
        /* 0x229D */ public bool ForceDefaultCreatureFile;
        /* 0x22A0 */ public NMSString0x10 DefaultGroundCreatureTable;
        /* 0x22B0 */ public NMSString0x10 DefaultAirCreatureTable;
        /* 0x22C0 */ public NMSString0x10 DefaultWaterCreatureTable;
        /* 0x22D0 */ public NMSString0x10 DefaultCaveCreatureTable;
        /* 0x22E0 */ public GcPlanetLife ForceCreatureLifeLevelTo;
        /* 0x22E4 */ public GcPlanetLife ForceTerrainSettings;
        /* 0x22E8 */ public bool ForceTerrainType;
        /* 0x22EC */ public TkVoxelGeneratorSettingsTypes ForceTerrainTypeTo;
        /* 0x22F0 */ public bool ForcePirateSystem;
        /* 0x22F1 */ public bool ForcePrimeTerrain;
        /* 0x22F2 */ public bool ForceBinaryStar;
        /* 0x22F3 */ public bool ForceTernaryStar;
        /* 0x22F4 */ public GcGalaxyStarAnomaly ForceAnomalyTo;
        /* 0x22F8 */ public bool ForcePlanetsToHaveWater;
        /* 0x22FC */ public int ForceWaterObjectFileIndex;
        /* 0x2300 */ public int ForceSkyColourIndex;
        /* 0x2304 */ public int ForceWaterColourIndex;
        /* 0x2308 */ public int ForceGrassColourIndex;
        /* 0x230C */ public bool ModifyPlanetsInInitialSystems;
        /* 0x230D */ public bool ForcePlanetsToHaveNoWater;
        /* 0x230E */ public bool ForcePlanetsToHaveNoCaves;
        /* 0x230F */ public bool ForcePlanetsToHaveNoNoiseLayers;
        /* 0x2310 */ public bool ForcePlanetsToHaveNoTerrainFeatures;
        /* 0x2311 */ public bool DisableLimits;
        /* 0x2312 */ public bool LimitPerRegionInstances;
        /* 0x2313 */ public bool LimitPerRegionBodies;
        /* 0x2314 */ public bool LimitGlobalInstances;
        /* 0x2315 */ public bool LimitGlobalBodies;
        /* 0x2318 */ public int GenerateFarLodBuildingDist;
        /* 0x231C */ public bool DeferRegionBodies;
        /* 0x2320 */ public float GenerateCostDistance;
        /* 0x2324 */ public float GenerateCostAngle;
        /* 0x2328 */ public float GenerateCostLOD;
        /* 0x232C */ public float GenerateCostWait;
        /* 0x2330 */ public bool DChecksEnabled;
        /* 0x2331 */ public bool DChecksOutputJson;
        /* 0x2332 */ public bool DChecksOutputBinary;
        /* 0x2333 */ public bool DChecksOutputFileLine;
        /* 0x2334 */ public int FrameFlipRateDefault;
        /* 0x2338 */ public int FrameFlipRateLoad;
        /* 0x233C */ public int FrameFlipRateGame;
        /* 0x2340 */ public float MaxFrameRate;
        /* 0x2344 */ public bool DisableBaseBuilding;
        /* 0x2345 */ public bool DisableBaseBuildingLimits;
        /* 0x2346 */ public bool AllowGlobalPartSnapping;
        /* 0x2348 */ public float BaseDownloadTimeout;
        /* 0x234C */ public bool DisableBasePowerRequirements;
        /* 0x234D */ public bool EnableBaseMovingOption;
        /* 0x2350 */ public int MoveBaseIndex;
        /* 0x2354 */ public NMSString0x20 AutomaticPartSpawnID;
        /* 0x2374 */ public GcBaseBuildingPartStyle AutomaticPartSpawnStyle;
        /* 0x2378 */ public bool AutomaticPartSpawnInactive;
        /* 0x237C */ public int ProfilerPartIndexPhase;
        /* 0x2380 */ public int ProfilerPartIndexStride;
        /* 0x2384 */ public int ProfilerPartIteration;
        /* 0x2388 */ public bool BaseAdmin;
        /* 0x2389 */ public NMSString0x20 BaseServerPlatform;       // "pc"
        /* 0x23AC */ public uint BasePayloadMultiplier;
        /* 0x23B0 */ public bool CrossPlatformFeaturedBases;
        /* 0x23B1 */ public bool ShowMissionIdInTitle;
        /* 0x23B4 */ public TkGlobals ToolkitGlobals;
        /* 0x25D4 */ public bool AllowOverrideSettlementOwnership;
        /* 0x25D5 */ public NMSString0x40 OverrideSettlementOwnershipUsername;
        /* 0x2615 */ public NMSString0x40 OverrideSettlementOwnershipOnlineId;
        /* 0x2655 */ public bool BlockSettlementsNetwork;
        /* 0x2656 */ public bool EnableAccessibleUI;
    }
}
