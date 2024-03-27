using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x193FC11F040913E9, NameHash = 0xE9525144C4F949EB)]
    public class TkParticleData : NMSTemplate
    {
        // size: 0x3
        public enum EmitterQualityLevelEnum : uint {
            All,
            Low,
            High,
        }
        /* 0x000 */ public EmitterQualityLevelEnum EmitterQualityLevel;
        /* 0x004 */ public uint AudioEvent;
        /* 0x008 */ public bool StartEnabled;
        /* 0x009 */ public bool Oneshot;
        /* 0x00C */ public int MaxCount;
        /* 0x010 */ public TkParticleBurstData BurstData;
        /* 0x108 */ public TkEmitterFloatProperty EmissionRate;
        /* 0x180 */ public float Delay;
        /* 0x184 */ public TkEmitFromParticleInfo EmitFromParticleInfo;
        /* 0x190 */ public TkEmitterFloatProperty ParticleLife;
        /* 0x208 */ public TkEmitterFloatProperty EmitterLife;
        /* 0x280 */ public float EmitterMidLifeRatio;
        /* 0x284 */ public TkCurveType EmitterLifeCurve1;
        /* 0x285 */ public TkCurveType EmitterLifeCurve2;
        /* 0x288 */ public float EmitterSpreadAngle;
        /* 0x28C */ public float EmitterSpreadAngleMin;
        /* 0x290 */ public Vector3f EmitterDirection;
        /* 0x2A0 */ public TkEmitterFloatProperty ParticleSpeedMultiplier;
        /* 0x318 */ public TkEmitterFloatProperty ParticleGravity;
        /* 0x390 */ public TkEmitterFloatProperty ParticleDamping;
        /* 0x408 */ public TkEmitterFloatProperty ParticleDrag;
        // size: 0x3
        public enum DragTypeEnum : uint {
            IgnoreGravity,
            PhysicallyBased,
            ApplyWind,
        }
        /* 0x480 */ public DragTypeEnum DragType;
        /* 0x484 */ public float Variation;
        /* 0x488 */ public float StartOffset;
        // size: 0x6
        public enum SpawnOffsetTypeEnum : uint {
            Sphere,
            Box,
            Disc,
            Cone,
            Donut,
            Point,
        }
        /* 0x48C */ public SpawnOffsetTypeEnum SpawnOffsetType;
        /* 0x490 */ public Vector3f SpawnOffsetParams;
        /* 0x4A0 */ public TkEmitterFloatProperty ParticleSize;
        /* 0x518 */ public TkEmitterFloatProperty ParticleSizeY;
        /* 0x590 */ public float StartRotationVariation;
        /* 0x598 */ public TkEmitterFloatProperty Rotation;
        // size: 0x3
        public enum AlignmentEnum : uint {
            Rotation,
            Velocity,
            VelocityScreenSpace,
        }
        /* 0x610 */ public AlignmentEnum Alignment;
        // size: 0x8
        public enum BillboardAlignmentEnum : uint {
            Screen,
            XLocal,
            YLocal,
            ZLocal,
            NegativeXLocal,
            NegativeYLocal,
            NegativeZLocal,
            ScreenWorld,
        }
        /* 0x614 */ public BillboardAlignmentEnum BillboardAlignment;
        /* 0x620 */ public Vector3f RotationPivot;
        /* 0x630 */ public TkCoordinateOrientation UCoordinate;
        /* 0x634 */ public TkCoordinateOrientation VCoordinate;
        /* 0x638 */ public float VelocityInheritance;
        /* 0x63C */ public float TrackEmitterPosition;
        /* 0x640 */ public float RotateAroundEmitter;
        /* 0x650 */ public Vector3f RotateAroundEmitterAxis;
        // size: 0x4
        public enum FlipbookPlaybackRateEnum : uint {
            Absolute,
            RelativeToMax,
            OnceToCompletion,
            Random,
        }
        /* 0x660 */ public FlipbookPlaybackRateEnum FlipbookPlaybackRate;
        /* 0x664 */ public float HueVariance;
        /* 0x668 */ public float SaturationVariance;
        /* 0x66C */ public float LightnessVariance;
        /* 0x670 */ public float AlphaVariance;
        /* 0x680 */ public Colour ColourStart;
        /* 0x690 */ public Colour ColourMiddle;
        /* 0x6A0 */ public Colour ColourEnd;
        /* 0x6B0 */ public TkEmitterFloatProperty AlphaThreshold;
        // size: 0x2
        public enum OnRefractionsDisabledEnum : uint {
            Hide,
            AlphaBlend,
        }
        /* 0x728 */ public OnRefractionsDisabledEnum OnRefractionsDisabled;
        /* 0x72C */ public bool FadeRefractionsAtScreenEdge;
        /* 0x730 */ public NMSString0x10 UserColour;
        /* 0x740 */ public float MaxRenderDistance;
        /* 0x744 */ public float MaxSpawnDistance;
        /* 0x748 */ public float SoftFadeStrength;
        /* 0x74C */ public float SurfaceDistanceFadeStrength;
        /* 0x750 */ public TkFloatRange CameraDistanceFade;
    }
}
