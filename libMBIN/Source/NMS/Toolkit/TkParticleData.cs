using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    [NMS(Size = 0x370, GUID = 0xD2B8CF555917027C, NameHash = 0xE9525144C4F949EB)]
    public class TkParticleData : NMSTemplate
    {
        /* 0x000 */ public bool StartEnabled;
        /* 0x001 */ public bool Oneshot;
        /* 0x004 */ public int MaxCount;
        /* 0x008 */ public TkParticleBurstData BurstData;
        /* 0x064 */ public TkEmitterFloatProperty EmissionRate;
        /* 0x090 */ public float Delay;
        /* 0x094 */ public TkEmitFromParticleInfo EmitFromParticleInfo;
        /* 0x09C */ public TkEmitterFloatProperty ParticleLife;
        /* 0x0C8 */ public TkEmitterFloatProperty EmitterLife;
        /* 0x0F4 */ public float EmitterMidLifeRatio;
        /* 0x0F8 */ public TkCurveType EmitterLifeCurve1;
        /* 0x0FC */ public TkCurveType EmitterLifeCurve2;
        /* 0x100 */ public float EmitterSpreadAngle;
        /* 0x104 */ public float EmitterSpreadAngleMin;
        /* 0x110 */ public Vector3f EmitterDirection;
        /* 0x120 */ public TkEmitterFloatProperty ParticleSpeedMultiplier;
        /* 0x14C */ public TkEmitterFloatProperty ParticleGravity;
        /* 0x178 */ public TkEmitterFloatProperty ParticleDamping;
        /* 0x1A4 */ public TkEmitterFloatProperty ParticleDrag;
        // size: 0x3
        public enum DragTypeEnum { IgnoreGravity, PhysicallyBased, ApplyWind }
        /* 0x1D0 */ public DragTypeEnum DragType;
        /* 0x1D4 */ public float Variation;
        /* 0x1D8 */ public float StartOffset;
        // size: 0x6
        public enum SpawnOffsetTypeEnum { Sphere, Box, Disc, Cone, Donut, Point }
        /* 0x1DC */ public SpawnOffsetTypeEnum SpawnOffsetType;
        /* 0x1E0 */ public Vector3f SpawnOffsetParams;
        /* 0x1F0 */ public TkEmitterFloatProperty ParticleSize;
        /* 0x21C */ public TkEmitterFloatProperty ParticleSizeY;
        /* 0x248 */ public float StartRotationVariation;
        /* 0x24C */ public TkEmitterFloatProperty Rotation;
        // size: 0x3
        public enum AlignmentEnum { Rotation, Velocity, VelocityScreenSpace }
        /* 0x278 */ public AlignmentEnum Alignment;
        // size: 0x7
        public enum BillboardAlignmentEnum { Screen, XLocal, YLocal, ZLocal, NegativeXLocal, NegativeYLocal, NegativeZLocal
        }
        /* 0x27C */ public BillboardAlignmentEnum BillboardAlignment;
        /* 0x280 */ public Vector3f RotationPivot;
        /* 0x290 */ public TkCoordinateOrientation UCoordinate;
        /* 0x294 */ public TkCoordinateOrientation VCoordinate;
        /* 0x298 */ public float VelocityInheritance;
        /* 0x29C */ public float TrackEmitterPosition;
        /* 0x2A0 */ public float RotateAroundEmitter;
        /* 0x2B0 */ public Vector3f RotateAroundEmitterAxis;
        // size: 0x4
        public enum FlipbookPlaybackRateEnum { Absolute, RelativeToMax, OnceToCompletion, Random }
        /* 0x2C0 */ public FlipbookPlaybackRateEnum FlipbookPlaybackRate;
        /* 0x2C4 */ public float HueVariance;
        /* 0x2C8 */ public float SaturationVariance;
        /* 0x2CC */ public float LightnessVariance;
        /* 0x2D0 */ public float AlphaVariance;
        /* 0x2E0 */ public Colour ColourStart;
        /* 0x2F0 */ public Colour ColourMiddle;
        /* 0x300 */ public Colour ColourEnd;
        /* 0x310 */ public TkEmitterFloatProperty AlphaThreshold;
        /* 0x340 */ public NMSString0x10 UserColour;
        /* 0x350 */ public float MaxRenderDistance;
        /* 0x354 */ public float MaxSpawnDistance;
        /* 0x358 */ public float SoftFadeStrength;
        /* 0x35C */ public TkFloatRange CameraDistanceFade;
    }
}
