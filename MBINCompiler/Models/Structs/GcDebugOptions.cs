namespace MBINCompiler.Models.Structs
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
        public bool Unknown13;
        /* 0x10 */ public int ScreenWidth;
        /* 0x14 */ public int ScreenHeight;
        /* 0x18 */ public bool DisableVSync;
        /* 0x1C */ public int GameWindowMode;       // only a byte used??
        public string[] GameWindowModeValues()
        {
            return new[] { "Bordered", "Borderless", "Fullscreen" };        // this and GameStateModeValues below swapped in exe
        }

        /* 0x20 */ public int Monitor;
		/* should there be padding here? */
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
        /* 0x534 */ public bool DebugBuildingSpawns;
        /* 0x535 */ public bool StressTestLongNameDisplay;
        public bool Unknown535;
        /* 0x536 */public bool ShowFramerate;
        /* 0x537 */ public bool ShowPositionDebug;
        /* 0x538 */public bool ShowGPUMemory;
        public bool Unknown538;
        /* 0x539 */ public bool ShowMempoolOverlay;

        [NMS(Size = 0x100)]
        /* 0x540 */ public string ShowUniverseAddressOnGalaxyMap; // 0x100
        /* 0x640 */ public bool ShowGraphs;
        /* 0x63B */ public bool GraphCommandBuffer;
        /* 0x63C */ public bool GraphGeneration;
        /* 0x63D */ public bool GraphFPS;
        /* 0x63E */ public bool SmokeTestDumpStatsMode;
        /* 0x640 */ public int SmokeTestCycleMode;
        public string[] SmokeTestCycleModeValues()
        {
            return new[] { "None", "TourSolarSystem", "RegeneratePlanet" };
        }
        /* 0x644 */ public bool SmokeTestCameraFly;
        public bool Unknown645;
        public bool Unknown646;
        /* 0x648 */ public int SmokeTestConfigCaptureCycles;
        /* 0x64C */ public float SmokeTestConfigCaptureDurationInSeconds;
        /* 0x650 */ public int SmokeTestConfigCaptureFolderNameNumberOffset;
        /* 0x654 */ public bool SmokeTestConfigRandomizePlanetSeed;
        /* 0x655 */ public bool CreatureChatter;
        /* 0x656 */ public bool CreatureErrors;
        /* 0x657 */ public bool CreatureDrawVocals;
        /* 0x658 */ public bool DrawCreaturesInRoutines;
        /* 0x659 */ public bool CompressTextures;
        /* 0x65A */ public bool DebugIBL;
        /* 0x65B */ public bool DisableShadowSwitching;
        [NMS(Size = 0x80)]
        /* 0x65C */ public string PipelineFile; // 0x80
        [NMS(Size = 0x80)]
        /* 0x6DC */ public string PipelineFilePS4; // 0x80
        /* 0x75C */ public bool RenderLowFramerate;
        /* 0x75D */ public bool SimulateNoNetworkConnection;
        /* 0x760 */ public int ProxyType;
        public string[] ProxyTypeValues()
        {
            return new[] { "None", "ManualURI", "InetProxy" };      // this and ServerEnvValues swapped order in exe?
        }
        [NMS(Size = 0x80)]
        /* 0x764 */ public string ProxyURI; // 0x80
        /* 0x7E4 */ public int ServerEnv;
        public string[] ServerEnvValues()
        {
            return new[] { "default", "dev", "qa", "prodqa", "prod", "custom", "pentest" };     // this and ProxyTypeValues swapped order in exe? 
        }
        [NMS(Size = 0x80)]
        /* 0x830 */ public string AuthBaseUrl; // 0x80
        /* 0x868 */ public bool CertificateSecurityBypass;
        [NMS(Size = 0x20)]
        /* 0x869 */ public string OverrideUsernameForDev; // 0x20
        /* 0x88C */ public int DiscoveryAutoSyncIntervalSeconds;
        [NMS(Size = 0x20)]
        public string DummyString;
        public int DummyInt;
        /* 0x888 */ //public int DiscoveryTrimLimitOverride; // Looks like both these
        /* 0x88C */ //public int DiscoveryTrimTriggerOverride; // lines have been removed in exe
        /* 0x890 */ public bool EnableSynergy;
        [NMS(Size = 0x20)]
        /* 0x891 */ public string SynergyServer; // 0x20
        /* 0x8B4 */ public int SynergyPort;
        public int Something;
        /* 0x8B8 */ public int MaxNumDebugMessages;
        /* 0x8BC */ public bool PreloadToolbox;
        /* 0x8C0 */ public int DebugTextureSize;
        /* 0x8C4 */ public bool UseProcTextureDebugger;
        /* 0x8C8 */ public int ProceduralModelsShown;
        /* 0x8CC */ public int ProceduralModelBatchSize;
        [NMS(Size = 0x80)]
        /* 0x8D0 */ public string DebugFont; // 0x80
        [NMS(Size = 0x80)]
        /* 0x950 */ public string DebugFontTexture; // 0x80
        [NMS(Size = 0x80)]
        /* 0x9D0 */ public string CursorTexture; // 0x80
        [NMS(Size = 0x80)]
        /* 0xA50 */ public string PauseTexture; // 0x80
        [NMS(Size = 0x80)]
        /* 0xAD0 */ public string PlayTexture; // 0x80
        [NMS(Size = 0x80)]
        /* 0xB50 */ public string StepTexture; // 0x80
        [NMS(Size = 0x80)]
        /* 0xBD0 */ public string RenderToTexture; // 0x80
        /* 0xC50 */ public bool HmdEnable;
        /* 0xC51 */ public bool HmdOutput;
        /* 0xC52 */ public bool HmdTracking;
        /* 0xC53 */ public bool HmdStereoRender;
        /* 0xC54 */ public bool HmdDistortionPassthru;
        /* 0xC58 */ public int HmdMonitor;
        /* 0xC5C */ public int HmdEyeBufferWidth;
        /* 0xC60 */ public int HmdEyeBufferHeight;
        /* 0xC64 */ public float HmdEyeScalePos;
        /* 0xC68 */ public float HmdHeadScalePos;

        /* 0xCDC */ public float HmdImmersionFactor;
        /* 0xCE0 */ public bool ForceExtremeWeather;
        /* 0xCE1 */ public bool ForceExtremeSentinels;
		/* 0xCE2 */ public bool ForceStarType;
		/* 0xCE4 */ public int ForceStarTypeTo;
        /* 0xCE8 */ public bool ForceBiome;
        /* 0xCEC */ public int ForceBiomeTo;
        /* 0xCF0 */ public int BadValue;

        /* 0xCF4 */ public bool ForceBuildingRace;
        /* 0xCF8 */ public int ForceBuildingRaceTo;
        /* 0xCFC */ public bool ForceLifeLevel;
        /* 0xD00 */ public int ForceLifeLevelTo;
        /* 0xD04 */ public bool ForceAnomaly;
        /* 0xD08 */ public int ForceAnomalyTo;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0xD0C */ public byte[] PaddingD0C;
        /* 0xD10 */ public bool UnknownBool;
        /* 0xD11 */ public bool DisableLimits;
        /* 0xD12 */ public bool LimitPerRegionInstances;
        /* 0xD13 */ public bool LimitPerRegionBodies;
        /* 0xD14 */ public bool LimitGlobalInstances;
        /* 0xD15 */ public bool LimitGlobalBodies;

        /* 0xD18 */ public int GenerateFarLodBuildingDist;
        /* 0xD1C */ public bool DeferRegionBodies;
        /* 0xD20 */ public float GenerateCostDistance;
        /* 0xD24 */ public float GenerateCostAngle;
        /* 0xD28 */ public float GenerateCostLOD;
        /* 0xD2C */ public float GenerateCostWait;
        /* 0xD30 */ public bool DChecksEnabled;
        /* 0xD31 */ public bool DChecksOutputJson;
        /* 0xD32 */ public bool DChecksOutputBinary;
        /* 0xD33 */ public bool DChecksOutputFileLine;
        /* 0xD34 */ public int FrameFlipRateDefault;
        /* 0xD38 */ public int FrameFlipRateLoad;
        /* 0xD3C */ public int FrameFlipRateGame;
        /* 0xD40 */ public float MaxFrameRate;
		/* 0xD44 */ public bool DisableBaseBuilding;
		/* 0xD45 */ public bool DisableBaseBuildingLimits;
        /* 0xD48 */ public float UnknownCD4;

        // ["None", "Server", "Client"] enum somewhere here??
    }
}
