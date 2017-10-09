namespace libMBIN.Models.Structs
{
    public class GcDebugOptions : NMSTemplate           // locations at start of lines will be wrong in parts
    {
        /* 0x00 */ public bool SkipIntro;                   // confirmed 1.3
        /* 0x01 */ public bool VideoCaptureMode;
        public bool Unknown2;
        /* 0x03 */ public bool GodMode;                     // confirmed 1.3
		/* 0x04	*/ public bool AlwaysHaveFocus;
        /* 0x05 */ public bool DisableVibration;
        /* 0x06 */ public bool MapWarpCheckIgnoreFuel;
        /* 0x07 */ public bool MapWarpCheckIgnoreDrive;
        public bool Unknown8;
        /* 0x09 */ public bool EverythingIsFree;            // confirmed 1.3
        /* 0x0A */ public bool EverythingIsKnown;           // confirmed 1.3
        /* 0x0B */ public bool EverythingIsStar;
        public bool UnknownC;
        public bool UnknownD;
        public bool UnknownE;
        /* 0x0F */ public bool UseScreenEffects;
        /* 0x10 */ public bool UseGunImpactEffect;
        /* 0x11 */ public bool RenderCreatureDetails;
		/* 0x12 */ public bool UseDebugScreenSettings;      // confirmed 1.3
        
        /* 0x14 */ public int ScreenWidth;
        /* 0x18 */ public int ScreenHeight;
        /* 0x1C */ public bool DisableVSync;
        /* 0x20 */ public int GameWindowMode;       // only a byte used??
        public string[] GameWindowModeValues()
        {
            return new[] { "Bordered", "Borderless", "Fullscreen" };        // this and GameStateModeValues below swapped in exe
        }

        /* 0x24 */ public int Monitor;
        [NMS(Size = 0x100)]
        /* 0x028 */ public string ForceUniverseAddress; // 0x100
        [NMS(Size = 0x100)]
        /* 0x128 */ public string ForcePlayerPosition; // 0x100

        /* 0x228 */ public bool ForceInitialShip;
        /* 0x229 */ public bool ForceInitialWeapon;
        [NMS(Size = 0x2, Ignore = true)]
        public byte[] Padding22A;
        /* 0x22C */ public int GameStateMode;
        public string[] GameStateModeValues()
        {
            return new[] { "LoadPreset", "UserStorage", "FreshStart" };     // this and GameWindowModeValues above swapped in exe
        }

        /* 0x230 */ public int BootMode;
        public string[] BootModeValues()
        {
            return new[] {"MinimalSolarSystem", "SolarSystem", "GalaxyMap", "SmokeTest",
                          "SmokeTestGalaxyMap", "Scratchpad", "UnitTest" };
        }
        /* 0x234 */ public int PlayerSpawnLocationOverride;
        public string[] PlayerSpawnLocationOverrideValues()
        {
            return new[] { "None", "FromSettings", "Space", "SpaceStation", "RandomPlanet", "GameStartPlanet" };
        }

        [NMS(Size = 0x80)]
        /* 0x238 */ public string SceneSettings; // 0x80
        [NMS(Size = 0x100)]
        /* 0x2B8 */ public string WorkingDirectory; // 0x100

        /* 0x3B4 */ public int SolarSystemBoot;
        public string[] SolarSystemBootValues()
        {
            return new[] { "FromSettings", "Generate" };
        }
        /* 0x3B8 */ public int ShaderPreload;
        public string[] ShaderPreloadValues()
        {
            return new[] { "Off", "Full" };     // this and BootLoadDelayValues swapped order in exe?
        }
		/* Unsure of whats going on with PresetGameMode, I added it but its way shorter than everything else  Check address 1401BC1D2 */
		/* 0x3BC?*/ public int PresetGameMode; // Looks just like DebugLanguages below which had unused note
        /* 0x3C0 */ public bool ShaderPreloadListExport;
        /* 0x3C1 */ public bool ShaderPreloadListImport;
        /* 0x3C2 */ public bool ShaderCaching;
		/* 2 bit int? this seems weird should this be a short instead of int?*/
        /* 0x3C4 */ public int BootLoadDelay;
        public string[] BootLoadDelayValues()
        {
            return new[] { "LoadAll", "WaitForPlanet", "WaitForNothing" };      // this and ShaderPreloadValues order swapped in exe?
        }
        /* 0x3C8 */ public bool UseParticles;
        /* 0x3C9 */ public bool UseVolumetrics;
        /* 0x3CA */ public bool UseClouds;
        /* 0x3CB */ public bool UseTerrain;
        /* 0x3CC */ public bool UseInstances;
        /* 0x3CD */ public bool UseObjects;
        /* 0x3CE */ public bool UseBuildings;
        /* 0x3CF */ public bool UseCreatures;
        /* 0x3D0 */ public bool UseElevation;
        /* 0x3D1 */ public bool SpawnPirates;
        /* 0x3D2 */ public bool SpawnRobots;
        /* 0x3D3 */ public bool SpawnShips;
        /* 0x3D4 */ public bool InstanceCollision;
        /* 0x3D5 */ public bool MouseLookEnabled;
        /* 0x3D6 */ public bool StartPaused;
        /* 0x3D7 */ public bool DisableDebugControls;
        /* 0x3D8 */ public bool DisableAsserts;
        /* 0x3D9 */ public bool FixedFramerate;
        /* 0x3DA */ public bool ScreenshotMode;
        /* 0x3DB */ public bool RenderHud;
		/* 0x3DC */ public bool DisableDiscoveryNaming;
        /* 0x3DD */ public bool DebugDrawPlayerInteract;
        /* 0x3DE */ public bool ForceInteractionToSettings;
        /* 0x3E0 */ public int ForceInteractionIndex;
        /* 0x3E4 */ public bool InteractionsAllwaysGivesTech; // (sic)
        /* 0x3E5 */ public bool InfiniteInteractions;
        /* 0x3E6 */ public bool StopSwitchingToSecondaryInteractions;
        /* 0x3E7 */ public int DebugLanguages; // unused?

        [NMS(Size = 0x20)]
        /* 0x40B */ public string AllowedLanguagesFile;
        /* 0x40C */ public bool DoAlienLanguage;
        /* 0x410 */ public int ForceInteractionRaceTo; // unused?
        /* 0x414 */ public int RealityMode;
        public string[] RealityModeValues()
        {
            return new[] { "LoadPreset", "Generate" };      // this and RecordSettingValues swapped order in exe?
        }

        /* 0x418 */ public bool DebugPersistentInteractions;

        [NMS(Size = 0x80)]
        /* 0x498 */ public string RealityPresetFile; // 0x80
        /* 0x49A */ public short RealityGenerationIteration;
        [NMS(Size = 0x20)]
        /* 0x4A0 */ public string MainTextbankPrefix;
        [NMS(Size = 0x20)]
        /* 0x4C0 */ public string UpdateTextBankPrefix;

        [NMS(Size = 0x80)]
        /* 0x4E0 */ public string DefaultSaveData; // 0x80
        /* 0x560 */ public bool FormatDownloadStorageAreaOnBoot;
        /* 0x561 */ public bool ForceBasicLoadScreen;
        /* 0x564 */ public float BootLogoFadeRate;
        /* 0x568 */ public bool BootMusic;
        /* 0x569 */ public bool LogMissingLocalisedText;
        /* 0x56A */ public bool FleetDirectorAutoMode;
        /* 0x56C */ public float _3dTextDistance;
        /* 0x570 */ public float _3dTextMinScale;
        /* 0x574 */ public int RecordSetting;
        public string[] RecordSettingValues()
        {
            return new[] { "None", "Record", "Playback" };      // this and RealityModeValues swapped order in exe?
        }
        /* 0x578 */ public bool Unknown578;
        /* 0x579 */ public bool Unknown579;
        [NMS(Size = 0x20)]
        /* 0x57A */ public string Unknown57A;
        /* 0x59A */ public bool DebugBuildingSpawns;
        /* 0x59B */ public bool StressTestLongNameDisplay;
        /* 0x59C */ public bool ShowFramerate;
        /* 0x59D */ public bool ShowPositionDebug;
        /* 0x59E */ public bool ShowGPUMemory;
        /* 0x59F */ public bool ShowMempoolOverlay;

        [NMS(Size = 0x100)]
        /* 0x5A0 */ public string ShowUniverseAddressOnGalaxyMap; // 0x100
        /* 0x6A0 */ public bool ShowGraphs;
        /* 0x6A1 */ public bool GraphCommandBuffer;
        /* 0x6A2 */ public bool GraphGeneration;
        /* 0x6A3 */ public bool GraphFPS;
        /* 0x6A4 */ public bool SmokeTestDumpStatsMode;
        /* 0x6A5 */ public bool Unknown6A5;
        /* 0x6A8 */ public int SmokeTestCycleMode;
        public string[] SmokeTestCycleModeValues()
        {
            return new[] { "None", "TourSolarSystem", "RegeneratePlanet" };
        }
        /* 0x6AC */ public bool SmokeTestCameraFly;
        /* 0x6B0 */ public int SmokeTestConfigCaptureCycles;
        /* 0x6B4 */ public float SmokeTestConfigCaptureDurationInSeconds;
        /* 0x6B8 */ public int SmokeTestConfigCaptureFolderNameNumberOffset;
        /* 0x6BC */ public bool SmokeTestConfigRandomizePlanetSeed;
        /* 0x6BD */ public bool CreatureChatter;
        /* 0x6BE */ public bool CreatureErrors;
        /* 0x6BF */ public bool CreatureDrawVocals;
        /* 0x6C0 */ public bool DrawCreaturesInRoutines;
        /* 0x6C1 */ public bool CompressTextures;
        /* 0x6C2 */ public bool DebugIBL;
        /* 0x6C3 */ public bool DisableShadowSwitching;
        [NMS(Size = 0x80)]
        /* 0x6C4 */ public string PipelineFile; // 0x80
        [NMS(Size = 0x80)]
        /* 0x744 */ public string PipelineFilePS4; // 0x80
        /* 0x7C4 */ public bool RenderLowFramerate;
        /* 0x7C5 */ public bool SimulateNoNetworkConnection;
        /* 0x7C6 */ public bool Unknown7C6;     // possibly before previous bool
        /* 0x7C8 */ public int ProxyType;
        public string[] ProxyTypeValues()
        {
            return new[] { "None", "ManualURI", "InetProxy" };      // this and ServerEnvValues swapped order in exe?
        }
        [NMS(Size = 0x80)]
        /* 0x7CC */ public string ProxyURI; // 0x80
        /* 0x84C */ public int ServerEnv;
        public string[] ServerEnvValues()
        {
            return new[] { "default", "dev", "qa", "prodqa", "prod", "custom", "pentest" };     // this and ProxyTypeValues swapped order in exe? 
        }
        [NMS(Size = 0x80)]
        /* 0x850 */ public string AuthBaseUrl; // 0x80
        /* 0x8D0 */ public bool CertificateSecurityBypass;
        [NMS(Size = 0x20)]
        /* 0x8D1 */ public string OverrideUsernameForDev; // 0x20
        /* 0x8F4 */ public int DiscoveryAutoSyncIntervalSeconds;
        /* 0x8F8 */ public float Unknown8F8;
        [NMS(Size = 0x20)]
        /* 0x8FC */ public string Unknown8FC;
        /* 0x888 */ //public int DiscoveryTrimLimitOverride; // Looks like both these
        /* 0x88C */ //public int DiscoveryTrimTriggerOverride; // lines have been removed in exe
        /* 0x91C */ public bool EnableSynergy;
        [NMS(Size = 0x20)]
        /* 0x91D */ public string SynergyServer; // 0x20
        /* 0x940 */ public int SynergyPort;
        /* 0x944 */ public bool Unknown944;
        /* 0x948 */ public int MaxNumDebugMessages;
        /* 0x94C */ public bool PreloadToolbox;
        /* 0x950 */ public int DebugTextureSize;
        /* 0x954 */ public bool UseProcTextureDebugger;
        /* 0x958 */ public int ProceduralModelsShown;
        /* 0x95C */ public int ProceduralModelBatchSize;
        [NMS(Size = 0x80)]
        /* 0x960 */ public string DebugFont; // 0x80
        [NMS(Size = 0x80)]
        /* 0x9E0 */ public string DebugFontTexture; // 0x80
        [NMS(Size = 0x80)]
        /* 0xA60 */ public string CursorTexture; // 0x80
        [NMS(Size = 0x80)]
        /* 0xAE0 */ public string PauseTexture; // 0x80
        [NMS(Size = 0x80)]
        /* 0xB60 */ public string PlayTexture; // 0x80
        [NMS(Size = 0x80)]
        /* 0xBE0 */ public string StepTexture; // 0x80
        [NMS(Size = 0x80)]
        /* 0xC60 */ public string RenderToTexture; // 0x80
        /* 0xCE0 */ public bool HmdEnable;
        /* 0xCE1 */ public bool HmdOutput;
        /* 0xCE2 */ public bool HmdTracking;
        /* 0xCE3 */ public bool HmdStereoRender;
        /* 0xCE4 */ public bool HmdDistortionPassthru;
        /* 0xCE8 */ public int HmdMonitor;
        /* 0xCEC */ public int HmdEyeBufferWidth;
        /* 0xCF0 */ public int HmdEyeBufferHeight;
        /* 0xCF4 */ public float HmdEyeScalePos;
        /* 0xCF8 */ public float HmdHeadScalePos;
        /* 0xCFC */ public float HmdImmersionFactor;
        /* 0xD00 */ public bool ForceExtremeWeather;
        /* 0xD01 */ public bool ForceExtremeSentinels;
		/* 0xD02 */ public bool ForceStarType;
		/* 0xD04 */ public int ForceStarTypeTo;
        /* 0xD08 */ public bool ForceBiome;
        /* 0xD0C */ public int ForceBiomeTo;
        /* 0xD10 */ public int BadValue;

        /* 0xD14 */ public bool ForceBuildingRace;
        /* 0xD18 */ public int ForceBuildingRaceTo;

        /* 0xD1C */ public bool ForceLifeLevel;
        /* 0xD20 */ public int ForceLifeLevelTo;

        /* 0xD24 */ public bool ForceAnomaly;
        /* 0xD28 */ public int UnknownIntD28;

        /* 0xD2C */ public int ForceAnomalyTo;
        public string[] ForceAnomalyToValues()
        {
            return new[] { "None", "AtlasType1", "AtlasType2", "Blackhole", "Anomaly", "Spacewalk" };
        }
        /* 0xD30 */
        public bool UnknownD30;
        /* 0xD31 */ public bool DisableLimits;
        /* 0xD32 */ public bool LimitPerRegionInstances;
        /* 0xD33 */ public bool LimitPerRegionBodies;
        /* 0xD34 */ public bool LimitGlobalInstances;
        /* 0xD35 */ public bool LimitGlobalBodies;

        /* 0xD38 */ public int GenerateFarLodBuildingDist;
        /* 0xD3C */ public bool DeferRegionBodies;
        /* 0xD40 */ public float GenerateCostDistance;
        /* 0xD44 */ public float GenerateCostAngle;
        /* 0xD48 */ public float GenerateCostLOD;
        /* 0xD4C */ public float GenerateCostWait;
        /* 0xD50 */ public bool DChecksEnabled;
        /* 0xD51 */ public bool DChecksOutputJson;
        /* 0xD52 */ public bool DChecksOutputBinary;
        /* 0xD53 */ public bool DChecksOutputFileLine;
        /* 0xD54 */ public int FrameFlipRateDefault;
        /* 0xD58 */ public int FrameFlipRateLoad;
        /* 0xD5C */ public int FrameFlipRateGame;
        /* 0xD60 */ public float MaxFrameRate;
		/* 0xD64 */ public bool DisableBaseBuilding;
		/* 0xD65 */ public bool DisableBaseBuildingLimits;
        /* 0xD68 */ public float UnknownD68;

        // ["None", "Server", "Client"] enum somewhere here??
    }
}
