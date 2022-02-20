using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    [NMS(Size = 0x4, GUID = 0x33ACB2E2772C5A82, NameHash = 0x943946549DEC2216)]
    public class TkEngineSettingTypes : NMSTemplate
    {
        // size: 0x2F
        public enum EngineSettingEnum { FullScreen, Borderless, ResolutionWidth, ResolutionHeight, ResolutionScale,
            Monitor, FoVOnFoot, FoVInShip, VSync, TextureQuality, AnimationQuality,
            ShadowQuality, ReflectionsMultiplier, ReflectionProbesMultiplier,
            ReflectionProbes, ScreenSpaceReflections, ReflectionsQuality, PostProcessingEffects,
            VolumetricsQuality, TerrainTessellation, PlanetQuality,
            BaseQuality, UIQuality, DLSSQuality, FFXSRQuality, EnableTessellation,
            AntiAliasing, AnisotropyLevel, Brightness, VignetteAndScanlines, AvailableMonitors,
            MaxFrameRate, NumLowThreads, NumHighThreads, NumGraphicsThreads,
            TextureStreaming, TexturePageSizeKb, MotionBlurStrength, ShowRequirementsWarnings,
            AmbientOcclusion, MaxTextureMemoryMb, FixedTextureMemory,
            UseArbSparseTexture, UseTerrainTextureCache, AdapterIndex,
            UseHDR, MinGPUMode
        }
        /* 0x0 */ public EngineSettingEnum EngineSetting;
    }
}
