using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xC4A5912184E05885, NameHash = 0xE39CB7AA4D818260)]
    public class TkMaterialMetaData : NMSTemplate
    {
        /* 0x000 */ public NMSString0x80 ExternalMaterial;
        // size: 0x7
        public enum ShaderEnum : uint {
            UberShader,
            Sky,
            Screen,
            UberHack,
            UIScreen,
            ShaderMillParticle,
            ShaderMillUber,
        }
        /* 0x080 */ public ShaderEnum Shader;
        /* 0x084 */ public bool Transparent;
        /* 0x088 */ public int TransparencyLayerID;
        /* 0x08C */ public bool Additive;
        /* 0x08D */ public bool VertexColour;
        /* 0x08E */ public bool DisableZTest;
        /* 0x08F */ public bool Unlit;
        /* 0x090 */ public bool ReceiveShadow;
        /* 0x091 */ public bool CastShadow;
        /* 0x092 */ public bool ShadowOnly;
        /* 0x093 */ public bool UISurface;
        /* 0x094 */ public float Roughness;
        /* 0x098 */ public bool RoughnessMask;
        /* 0x099 */ public bool ImageBasedLighting;
        /* 0x09C */ public float IBLWeight;
        /* 0x0A0 */ public bool Metallic;
        /* 0x0A1 */ public bool MetallicMask;
        /* 0x0A2 */ public bool SubsurfaceMask;
        /* 0x0A4 */ public float SubsurfaceWeight;
        /* 0x0A8 */ public NMSString0x20 MaterialClass;
        /* 0x0C8 */ public NMSString0x80 ForceDiffuse;
        /* 0x148 */ public NMSString0x80 ForceNormal;
        /* 0x1C8 */ public NMSString0x80 ForceMask;
        /* 0x248 */ public NMSString0x80 ForceFeature;
        /* 0x2C8 */ public NMSString0x80 DetailDiffuse;
        /* 0x348 */ public NMSString0x80 DetailNormal;
        /* 0x3C8 */ public float DetailTiling;
        /* 0x3CC */ public float MultiplyDetailTiling;
        /* 0x3D0 */ public int DetailImages;
        /* 0x3D4 */ public int MultiplyDetailImages;
        /* 0x3D8 */ public bool AOMap;
        /* 0x3D9 */ public bool MultiplySecondUVSet;
        /* 0x3DA */ public bool VertexDetailBlend;
        /* 0x3DC */ public float DetailHeightBlend;
        /* 0x3E0 */ public float NormalTiling;
        /* 0x3E4 */ public bool SpaceObject;
        /* 0x3E8 */ public float Glow;
        /* 0x3EC */ public bool GlowMask;
        /* 0x3ED */ public bool BrightEdge;
        /* 0x3EE */ public bool CameraRelative;
        /* 0x3EF */ public bool Colourisable;
        /* 0x3F0 */ public bool ColourMask;
        /* 0x3F1 */ public bool Multitexture;
        /* 0x3F2 */ public bool FeatureMap;
        /* 0x3F3 */ public bool AlphaCutout;
        /* 0x3F4 */ public bool DetailedAlphaCutout;
        /* 0x3F5 */ public bool Wind;
        /* 0x3F6 */ public bool EnvironmentalOverlay;
        /* 0x3F7 */ public bool MatchGroundColour;
        /* 0x3F8 */ public float TerrainNormalFactor;
        /* 0x3FC */ public float SoftFadeStrength;
        /* 0x400 */ public bool AcuteAngleFadeOut;
        /* 0x401 */ public bool ClampAmbientLight;
        /* 0x402 */ public bool DoubleSided;
        /* 0x403 */ public bool DecalDiffuse;
        /* 0x404 */ public bool DecalTerrainOnly;
        // size: 0x3
        public enum DecalNormalEnum : uint {
            None,
            Decal,
            Vertex,
        }
        /* 0x408 */ public DecalNormalEnum DecalNormal;
        /* 0x40C */ public bool Billboard;
        /* 0x40D */ public bool RotateAroundAt;
        /* 0x40E */ public bool MergedMeshBillboard;
        /* 0x410 */ public float BillboardSphereFactor;
        /* 0x414 */ public bool Imposter;
        /* 0x415 */ public bool ScanEffect;
        /* 0x416 */ public bool WriteLogZ;
        /* 0x417 */ public bool DisableAmbient;
        /* 0x418 */ public bool DisablePostProcess;
        /* 0x419 */ public bool WarpedDiffuseLighting;
        /* 0x41A */ public bool AnisotropicFilter;
        /* 0x41C */ public float TessellationHeight;
        /* 0x420 */ public bool Dissolve;
        /* 0x421 */ public bool InvertAlpha;
        /* 0x422 */ public bool BeforeUI;
        /* 0x423 */ public bool DepthMaskUI;
        /* 0x424 */ public bool AlwaysOnTopUI;
        /* 0x425 */ public bool ScreenSpaceReflections;
        /* 0x426 */ public bool ReflectionProbe;
        /* 0x427 */ public bool DrawToBloom;
        /* 0x428 */ public bool DrawToLensFlare;
        /* 0x429 */ public bool DoubleBufferGeometry;
        /* 0x42C */ public float ReactivityBias;
        /* 0x430 */ public bool SimulatedCloth;
        /* 0x431 */ public bool CreateFur;
        /* 0x434 */ public float ShellsHeight;
        /* 0x438 */ public float FurNoiseScale;
        /* 0x43C */ public float FurNoiseThickness;
        /* 0x440 */ public float FurNoiseTurbulence;
        /* 0x444 */ public float FurTurbulenceScale;
        /* 0x448 */ public bool HighQualityParticle;
        /* 0x449 */ public bool UVScrolling;
        /* 0x44C */ public float UVScrollX;
        /* 0x450 */ public float UVScrollY;
        /* 0x454 */ public float UVScrollNormalX;
        /* 0x458 */ public float UVScrollNormalY;
        /* 0x45C */ public float UVFrameTime;
        /* 0x460 */ public bool UVAnimation;
        /* 0x461 */ public bool UVTileAlts;
        /* 0x464 */ public float UVNumTilesX;
        /* 0x468 */ public float UVNumTilesY;
        /* 0x46C */ public float Refraction;
        /* 0x470 */ public float RefractionIndex;
        /* 0x474 */ public bool RefractionMask;
        /* 0x478 */ public float ParticleRefractionStrengthX;
        /* 0x47C */ public float ParticleRefractionStrengthY;
        /* 0x480 */ public float ParticleRefractionBrightnessMultiplier;
        /* 0x484 */ public float ParticleRefractionTint;
        /* 0x488 */ public bool ParallaxMapped;
        /* 0x48C */ public float ParallaxDepth;
        /* 0x490 */ public int NumSteps;
        /* 0x494 */ public bool SelfShadow;
        /* 0x498 */ public float ShadowFactor;
        /* 0x49C */ public bool DisplacementWave;
        /* 0x49D */ public bool DisplacementPositionOffset;
        /* 0x4A0 */ public float WaveOneSpeed;
        /* 0x4B0 */ public Vector3f WaveOneAmplitude;
        /* 0x4C0 */ public Vector3f WaveOneFrequency;
        /* 0x4D0 */ public Vector3f WaveOneFallOff;
        /* 0x4E0 */ public float WaveTwoSpeed;
        /* 0x4F0 */ public Vector3f WaveTwoAmplitude;
        /* 0x500 */ public Vector3f WaveTwoFrequency;
        /* 0x510 */ public Vector3f WaveTwoFallOff;
        /* 0x520 */ public TkMaterialShaderMillData ShaderMillData;
    }
}
