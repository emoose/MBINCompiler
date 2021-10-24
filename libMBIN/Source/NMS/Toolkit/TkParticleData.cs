using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    [NMS(Size = 0x2C0, GUID = 0x620376E8715B3267, NameHash = 0xE9525144C4F949EB)]
    public class TkParticleData : NMSTemplate
    {
        /* 0x000 */ public bool StartEnabled;
        /* 0x001 */ public bool Oneshot;
        /* 0x004 */ public int MaxCount;
        /* 0x008 */ public float EmissionRate;
        /* 0x00C */ public float Delay;
        /* 0x010 */ public TkEmitFromParticleInfo EmitFromParticleInfo;
        /* 0x018 */ public TkEmitterFloatProperty ParticleLife;
        /* 0x044 */ public TkEmitterFloatProperty EmitterLife;
        /* 0x070 */ public float EmitterMidLifeRatio;
        /* 0x074 */ public TkCurveType EmitterLifeCurve1;
        /* 0x078 */ public TkCurveType EmitterLifeCurve2;
        /* 0x07C */ public float EmitterSpreadAngle;
        /* 0x080 */ public float EmitterSpreadAngleMin;
        /* 0x090 */ public Vector3f EmitterDirection;
        /* 0x0A0 */ public TkEmitterFloatProperty ParticleSpeedMultiplier;
        /* 0x0CC */ public TkEmitterFloatProperty ParticleGravity;
        /* 0x0F8 */ public TkEmitterFloatProperty ParticleDamping;
        /* 0x124 */ public TkEmitterFloatProperty ParticleDrag;
        /* 0x150 */ public float Variation;
        /* 0x154 */ public float StartOffset;
        public enum SpawnOffsetTypeEnum { Sphere, Box, Disc, Cone, Donut }
        /* 0x158 */ public SpawnOffsetTypeEnum SpawnOffsetType;
        /* 0x160 */ public Vector3f SpawnOffsetParams;
        /* 0x170 */ public TkEmitterFloatProperty ParticleSize;
        /* 0x19C */ public TkEmitterFloatProperty ParticleSizeY;
        /* 0x1C8 */ public float StartRotationVariation;
        /* 0x1CC */ public TkEmitterFloatProperty Rotation;
        public enum AlignmentEnum { Rotation, Velocity, VelocityScreenSpace }
        /* 0x1F8 */ public AlignmentEnum Alignment;
        /* 0x200 */ public Vector3f RotationPivot;
        /* 0x210 */ public TkCoordinateOrientation UCoordinate;
        /* 0x214 */ public TkCoordinateOrientation VCoordinate;
        /* 0x218 */ public float VelocityInheritance;
        /* 0x21C */ public float TrackEmitterPosition;
        /* 0x220 */ public float RotateAroundEmitter;
        /* 0x230 */ public Vector3f RotateAroundEmitterAxis;
        public enum FlipbookPlaybackRateEnum { Absolute, RelativeToMax, OnceToCompletion }
        /* 0x240 */ public FlipbookPlaybackRateEnum FlipbookPlaybackRate;
        /* 0x244 */ public float HueVariance;
        /* 0x248 */ public float SaturationVariance;
        /* 0x24C */ public float LightnessVariance;
        /* 0x250 */ public float AlphaVariance;
        /* 0x260 */ public Colour ColourStart;
        /* 0x270 */ public Colour ColourMiddle;
        /* 0x280 */ public Colour ColourEnd;
        /* 0x290 */ public NMSString0x10 UserColour;
        /* 0x2A0 */ public float MaxRenderDistance;
        /* 0x2A4 */ public float MaxSpawnDistance;
        /* 0x2A8 */ public float SoftFadeStrength;
        /* 0x2AC */ public TkFloatRange CameraDistanceFade;
    }
}
