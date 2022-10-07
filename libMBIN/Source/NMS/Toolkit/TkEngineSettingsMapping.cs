namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xB3029E8E98933199, NameHash = 0xC02F1D19584B44D)]
    public class TkEngineSettingsMapping : NMSTemplate
    {
        // size: 0x4
        public enum ShadowMultiplierEnum {
            Low,
            Medium,
            High,
            Ultra
        }
        [NMS(Size = 0x4, EnumType = typeof(ShadowMultiplierEnum))]
        /* 0x00 */ public float[] ShadowMultiplier;
        // size: 0x4
        public enum ReflectionMultiplierEnum {
            Low,
            Medium,
            High,
            Ultra
        }
        [NMS(Size = 0x4, EnumType = typeof(ReflectionMultiplierEnum))]
        /* 0x10 */ public float[] ReflectionMultiplier;
        // size: 0x4
        public enum ReflectionProbesMultiplierEnum {
            Low,
            Medium,
            High,
            Ultra
        }
        [NMS(Size = 0x4, EnumType = typeof(ReflectionProbesMultiplierEnum))]
        /* 0x20 */ public float[] ReflectionProbesMultiplier;
        // size: 0x4
        public enum IKFullBodyIterationsEnum {
            Low,
            Medium,
            High,
            Ultra
        }
        [NMS(Size = 0x4, EnumType = typeof(IKFullBodyIterationsEnum))]
        /* 0x30 */ public float[] IKFullBodyIterations;
        // size: 0x4
        public enum CloudsResolutionScaleEnum {
            Low,
            Medium,
            High,
            Ultra
        }
        [NMS(Size = 0x4, EnumType = typeof(CloudsResolutionScaleEnum))]
        /* 0x40 */ public float[] CloudsResolutionScale;
        // size: 0x4
        public enum CloudsMaxIterationsEnum {
            Low,
            Medium,
            High,
            Ultra
        }
        [NMS(Size = 0x4, EnumType = typeof(CloudsMaxIterationsEnum))]
        /* 0x50 */ public int[] CloudsMaxIterations;
        // size: 0x31
        public enum NeedsGameRestartEnum {
            FullScreen,
            Borderless,
            ResolutionWidth,
            ResolutionHeight,
            ResolutionScale,
            Monitor,
            FoVOnFoot,
            FoVInShip,
            VSync,
            TextureQuality,
            AnimationQuality,
            ShadowQuality,
            ReflectionsMultiplier,
            ReflectionProbesMultiplier,
            ReflectionProbes,
            ScreenSpaceReflections,
            ReflectionsQuality,
            PostProcessingEffects,
            VolumetricsQuality,
            TerrainTessellation,
            PlanetQuality,
            BaseQuality,
            UIQuality,
            DLSSQuality,
            FFXSRQuality,
            FFXSR2Quality,
            XESSQuality,
            EnableTessellation,
            AntiAliasing,
            AnisotropyLevel,
            Brightness,
            VignetteAndScanlines,
            AvailableMonitors,
            MaxFrameRate,
            NumLowThreads,
            NumHighThreads,
            NumGraphicsThreads,
            TextureStreaming,
            TexturePageSizeKb,
            MotionBlurStrength,
            ShowRequirementsWarnings,
            AmbientOcclusion,
            MaxTextureMemoryMb,
            FixedTextureMemory,
            UseArbSparseTexture,
            UseTerrainTextureCache,
            AdapterIndex,
            UseHDR,
            MinGPUMode
        }
        [NMS(Size = 0x31, EnumType = typeof(NeedsGameRestartEnum))]
        /* 0x60 */ public bool[] NeedsGameRestart;
    }
}
