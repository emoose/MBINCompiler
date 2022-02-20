using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    [NMS(Size = 0x310, GUID = 0xFEF93F5114521A4D, NameHash = 0xE9525144C4F949EB)]
    public class TkParticleData : NMSTemplate
    {
        /* 0x000 */ public bool StartEnabled;
        /* 0x001 */ public bool Oneshot;
        /* 0x004 */ public int MaxCount;
        /* 0x008 */ public int Burst;
        /* 0x00C */ public TkEmitterFloatProperty EmissionRate;
        /* 0x038 */ public float Delay;
        /* 0x03C */ public TkEmitFromParticleInfo EmitFromParticleInfo;
        /* 0x044 */ public TkEmitterFloatProperty ParticleLife;
        /* 0x070 */ public TkEmitterFloatProperty EmitterLife;
        /* 0x09C */ public float EmitterMidLifeRatio;
        /* 0x0A0 */ public TkCurveType EmitterLifeCurve1;
        /* 0x0A4 */ public TkCurveType EmitterLifeCurve2;
        /* 0x0A8 */ public float EmitterSpreadAngle;
        /* 0x0AC */ public float EmitterSpreadAngleMin;
        /* 0x0B0 */ public Vector3f EmitterDirection;
        /* 0x0C0 */ public TkEmitterFloatProperty ParticleSpeedMultiplier;
        /* 0x0EC */ public TkEmitterFloatProperty ParticleGravity;
        /* 0x118 */ public TkEmitterFloatProperty ParticleDamping;
        /* 0x144 */ public TkEmitterFloatProperty ParticleDrag;
        // size: 0x3
        public enum DragTypeEnum { IgnoreGravity, PhysicallyBased, ApplyWind }
        /* 0x170 */ public DragTypeEnum DragType;
        /* 0x174 */ public float Variation;
        /* 0x178 */ public float StartOffset;
        // size: 0x6
        public enum SpawnOffsetTypeEnum { Sphere, Box, Disc, Cone, Donut, Point }
        /* 0x17C */ public SpawnOffsetTypeEnum SpawnOffsetType;
        /* 0x180 */ public Vector3f SpawnOffsetParams;
        /* 0x190 */ public TkEmitterFloatProperty ParticleSize;
        /* 0x1BC */ public TkEmitterFloatProperty ParticleSizeY;
        /* 0x1E8 */ public float StartRotationVariation;
        /* 0x1EC */ public TkEmitterFloatProperty Rotation;
        // size: 0x3
        public enum AlignmentEnum { Rotation, Velocity, VelocityScreenSpace }
        /* 0x218 */ public AlignmentEnum Alignment;
        // size: 0x4
        public enum BillboardAlignmentEnum { Screen, XLocal, YLocal, ZLocal }
        /* 0x21C */ public BillboardAlignmentEnum BillboardAlignment;
        /* 0x220 */ public Vector3f RotationPivot;
        /* 0x230 */ public TkCoordinateOrientation UCoordinate;
        /* 0x234 */ public TkCoordinateOrientation VCoordinate;
        /* 0x238 */ public float VelocityInheritance;
        /* 0x23C */ public float TrackEmitterPosition;
        /* 0x240 */ public float RotateAroundEmitter;
        /* 0x250 */ public Vector3f RotateAroundEmitterAxis;
        // size: 0x4
        public enum FlipbookPlaybackRateEnum { Absolute, RelativeToMax, OnceToCompletion, Random }
        /* 0x260 */ public FlipbookPlaybackRateEnum FlipbookPlaybackRate;
        /* 0x264 */ public float HueVariance;
        /* 0x268 */ public float SaturationVariance;
        /* 0x26C */ public float LightnessVariance;
        /* 0x270 */ public float AlphaVariance;
        /* 0x280 */ public Colour ColourStart;
        /* 0x290 */ public Colour ColourMiddle;
        /* 0x2A0 */ public Colour ColourEnd;
        /* 0x2B0 */ public TkEmitterFloatProperty AlphaThreshold;
        /* 0x2E0 */ public NMSString0x10 UserColour;
        /* 0x2F0 */ public float MaxRenderDistance;
        /* 0x2F4 */ public float MaxSpawnDistance;
        /* 0x2F8 */ public float SoftFadeStrength;
        /* 0x2FC */ public TkFloatRange CameraDistanceFade;
    }
}
