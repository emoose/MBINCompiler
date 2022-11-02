using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x4256E703FE75E2D6, NameHash = 0xE9525144C4F949EB)]
    public class TkParticleData : NMSTemplate
    {
        /* 0x000 */ public uint AudioEvent;
        /* 0x004 */ public bool StartEnabled;
        /* 0x005 */ public bool Oneshot;
        /* 0x008 */ public int MaxCount;
        /* 0x010 */ public TkParticleBurstData BurstData;
        /* 0x118 */ public TkEmitterFloatProperty EmissionRate;
        /* 0x198 */ public float Delay;
        /* 0x19C */ public TkEmitFromParticleInfo EmitFromParticleInfo;
        /* 0x1A8 */ public TkEmitterFloatProperty ParticleLife;
        /* 0x228 */ public TkEmitterFloatProperty EmitterLife;
        /* 0x2A8 */ public float EmitterMidLifeRatio;
        /* 0x2AC */ public TkCurveType EmitterLifeCurve1;
        /* 0x2B0 */ public TkCurveType EmitterLifeCurve2;
        /* 0x2B4 */ public float EmitterSpreadAngle;
        /* 0x2B8 */ public float EmitterSpreadAngleMin;
        /* 0x2C0 */ public Vector3f EmitterDirection;
        /* 0x2D0 */ public TkEmitterFloatProperty ParticleSpeedMultiplier;
        /* 0x350 */ public TkEmitterFloatProperty ParticleGravity;
        /* 0x3D0 */ public TkEmitterFloatProperty ParticleDamping;
        /* 0x450 */ public TkEmitterFloatProperty ParticleDrag;
        // size: 0x3
        public enum DragTypeEnum {
            IgnoreGravity,
            PhysicallyBased,
            ApplyWind
        }
        /* 0x4D0 */ public DragTypeEnum DragType;
        /* 0x4D4 */ public float Variation;
        /* 0x4D8 */ public float StartOffset;
        // size: 0x6
        public enum SpawnOffsetTypeEnum {
            Sphere,
            Box,
            Disc,
            Cone,
            Donut,
            Point
        }
        /* 0x4DC */ public SpawnOffsetTypeEnum SpawnOffsetType;
        /* 0x4E0 */ public Vector3f SpawnOffsetParams;
        /* 0x4F0 */ public TkEmitterFloatProperty ParticleSize;
        /* 0x570 */ public TkEmitterFloatProperty ParticleSizeY;
        /* 0x5F0 */ public float StartRotationVariation;
        /* 0x5F8 */ public TkEmitterFloatProperty Rotation;
        // size: 0x3
        public enum AlignmentEnum {
            Rotation,
            Velocity,
            VelocityScreenSpace
        }
        /* 0x678 */ public AlignmentEnum Alignment;
        // size: 0x8
        public enum BillboardAlignmentEnum {
            Screen,
            XLocal,
            YLocal,
            ZLocal,
            NegativeXLocal,
            NegativeYLocal,
            NegativeZLocal,
            ScreenWorld
        }
        /* 0x67C */ public BillboardAlignmentEnum BillboardAlignment;
        /* 0x680 */ public Vector3f RotationPivot;
        /* 0x690 */ public TkCoordinateOrientation UCoordinate;
        /* 0x694 */ public TkCoordinateOrientation VCoordinate;
        /* 0x698 */ public float VelocityInheritance;
        /* 0x69C */ public float TrackEmitterPosition;
        /* 0x6A0 */ public float RotateAroundEmitter;
        /* 0x6B0 */ public Vector3f RotateAroundEmitterAxis;
        // size: 0x4
        public enum FlipbookPlaybackRateEnum {
            Absolute,
            RelativeToMax,
            OnceToCompletion,
            Random
        }
        /* 0x6C0 */ public FlipbookPlaybackRateEnum FlipbookPlaybackRate;
        /* 0x6C4 */ public float HueVariance;
        /* 0x6C8 */ public float SaturationVariance;
        /* 0x6CC */ public float LightnessVariance;
        /* 0x6D0 */ public float AlphaVariance;
        /* 0x6E0 */ public Colour ColourStart;
        /* 0x6F0 */ public Colour ColourMiddle;
        /* 0x700 */ public Colour ColourEnd;
        /* 0x710 */ public TkEmitterFloatProperty AlphaThreshold;
        // size: 0x2
        public enum OnRefractionsDisabledEnum {
            Hide,
            AlphaBlend
        }
        /* 0x790 */ public OnRefractionsDisabledEnum OnRefractionsDisabled;
        /* 0x794 */ public bool FadeRefractionsAtScreenEdge;
        /* 0x798 */ public NMSString0x10 UserColour;
        /* 0x7A8 */ public float MaxRenderDistance;
        /* 0x7AC */ public float MaxSpawnDistance;
        /* 0x7B0 */ public float SoftFadeStrength;
        /* 0x7B4 */ public TkFloatRange CameraDistanceFade;
    }
}
