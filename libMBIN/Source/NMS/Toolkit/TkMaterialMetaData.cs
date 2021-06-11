using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    [NMS(Size = 0x4D0, GUID = 0xA0C736D9CAD33B0D, NameHash = 0xE39CB7AA4D818260)]
    public class TkMaterialMetaData : NMSTemplate
    {
        /* 0x000 */ public NMSString0x80 ExternalMaterial;
		// size: 0x7
        public enum ShaderEnum { UberShader, Sky, Screen, UberHack, UIScreen, ShaderMillParticle, ShaderMillUber }
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
        /* 0x099 */ public bool Metallic;
        /* 0x09A */ public bool MetallicMask;
        /* 0x09B */ public bool SubsurfaceMask;
        /* 0x09C */ public NMSString0x80 ForceDiffuse;
        /* 0x11C */ public NMSString0x80 ForceNormal;
        /* 0x19C */ public NMSString0x80 ForceMask;
        /* 0x21C */ public NMSString0x80 DetailDiffuse;
        /* 0x29C */ public NMSString0x80 DetailNormal;
        /* 0x31C */ public float DetailTiling;
        /* 0x320 */ public float MultiplyDetailTiling;
        /* 0x324 */ public int DetailImages;
        /* 0x328 */ public int MultiplyDetailImages;
        /* 0x32C */ public bool AOMap;
        /* 0x32D */ public bool MultiplySecondUVSet;
        /* 0x32E */ public bool VertexDetailBlend;
        /* 0x330 */ public float DetailHeightBlend;
        /* 0x334 */ public float NormalTiling;
        /* 0x338 */ public bool SpaceObject;
        /* 0x33C */ public float Glow;
        /* 0x340 */ public bool GlowMask;
        /* 0x341 */ public bool BrightEdge;
        /* 0x342 */ public bool CameraRelative;
        /* 0x343 */ public bool Colourisable;
        /* 0x344 */ public bool ColourMask;
        /* 0x345 */ public bool Multitexture;
        /* 0x346 */ public bool AlphaCutout;
        /* 0x347 */ public bool DetailedAlphaCutout;
        /* 0x348 */ public bool Wind;
        /* 0x349 */ public bool DetailOverlay;
        /* 0x34A */ public bool MatchGroundColour;
        /* 0x34C */ public float TerrainNormalFactor;
        /* 0x350 */ public bool ScreenSpaceFade;
        /* 0x351 */ public bool AcuteAngleFadeOut;
        /* 0x352 */ public bool ClampAmbientLight;
        /* 0x353 */ public bool DoubleSided;
        /* 0x354 */ public bool DecalDiffuse;
		public enum DecalNormalEnum { None, Decal, Vertex }
		/* 0x358 */ public DecalNormalEnum DecalNormal;
        /* 0x35C */ public bool Billboard;
        /* 0x35D */ public bool RotateAroundAt;
        /* 0x35E */ public bool MergedMeshBillboard;
        /* 0x360 */ public float BillboardSphereFactor;
        /* 0x364 */ public bool Imposter;
        /* 0x365 */ public bool ScanEffect;
        /* 0x366 */ public bool WriteLogZ;
        /* 0x367 */ public bool DisableAmbient;
        /* 0x368 */ public bool DisablePostProcess;
        /* 0x369 */ public bool WarpedDiffuseLighting;
        /* 0x36A */ public NMSString0x20 MaterialClass;
        /* 0x38A */ public bool AnisotropicFilter;
        /* 0x38C */ public float TessellationHeight;
        /* 0x390 */ public bool Dissolve;
        /* 0x391 */ public bool InvertAlpha;
        /* 0x392 */ public bool BeforeUI;
        /* 0x393 */ public bool DepthMaskUI;
        /* 0x394 */ public bool AlwaysOnTopUI;
        /* 0x395 */ public bool ScreenSpaceReflections;
        /* 0x396 */ public bool ReflectionProbe;
        /* 0x397 */ public bool CreateFur;
        /* 0x398 */ public float ShellsHeight;
        /* 0x39C */ public float FurNoiseScale;
        /* 0x3A0 */ public float FurNoiseThickness;
        /* 0x3A4 */ public float FurNoiseTurbulence;
        /* 0x3A8 */ public float FurTurbulenceScale;
        /* 0x3AC */ public bool StretchyParticle;
        /* 0x3AD */ public bool UVScrolling;
        /* 0x3B0 */ public float UVScrollX;
        /* 0x3B4 */ public float UVScrollY;
        /* 0x3B8 */ public float UVScrollNormalX;
        /* 0x3BC */ public float UVScrollNormalY;
        /* 0x3C0 */ public float UVFrameTime;
        /* 0x3C4 */ public bool UVAnimation;
        /* 0x3C5 */ public bool UVTileAlts;
        /* 0x3C8 */ public float UVNumTilesX;
        /* 0x3CC */ public float UVNumTilesY;
        /* 0x3D0 */ public float Refraction;
        /* 0x3D4 */ public float RefractionIndex;
        /* 0x3D8 */ public bool RefractionMask;
        /* 0x3D9 */ public bool ParallaxMapped;
        /* 0x3DC */ public float ParallaxDepth;
        /* 0x3E0 */ public int NumSteps;
        /* 0x3E4 */ public bool SelfShadow;
        /* 0x3E8 */ public float ShadowFactor;
        /* 0x3EC */ public bool DisplacementWave;
        /* 0x3ED */ public bool DisplacementPositionOffset;
        /* 0x3F0 */ public float WaveOneSpeed;
        /* 0x400 */ public Vector3f WaveOneAmplitude;
        /* 0x410 */ public Vector3f WaveOneFrequency;
        /* 0x420 */ public Vector3f WaveOneFallOff;
        /* 0x430 */ public float WaveTwoSpeed;
        /* 0x440 */ public Vector3f WaveTwoAmplitude;
        /* 0x450 */ public Vector3f WaveTwoFrequency;
        /* 0x460 */ public Vector3f WaveTwoFallOff;
        /* 0x470 */ public TkMaterialShaderMillData ShaderMillData;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x4C8 */ public byte[] EndPadding;
    }
}
