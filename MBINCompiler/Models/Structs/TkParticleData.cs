using System.Runtime.InteropServices;

namespace MBINCompiler.Models.Structs
{
    public class TkParticleData : NMSTemplate
    {
        public bool StartEnabled;
        public bool Oneshot;
        public int MaxCount;
        public float EmissionRate;
        public float Delay;
        public float ParticleLife;
        public float EmitterLife;
        public float EmitterMidLifeRatio;
        public TkCurveType Curve1;
        public TkCurveType Curve2;
        public float EmitterSpreadAngle;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        [NMSAttribute(Ignore = true)]
        public byte[] Padding28;

        public Vector4f EmitterDirection;
        public float EmitterGravity;
        public float EmitterDamping;
        public float Variation;
        public float StartOffset;
        public float SizeStart;
        public float SizeMiddle;
        public float SizeEnd;
        public float Rotation;
        public float VelocityInheritance;
        public float Bounce;
        public float HueVariance;
        public float SaturationVariance;
        public float LightnessVariance;
        public float AlphaVariance;
        public Colour ColourStart;
        public Colour ColourMiddle;
        public Colour ColourEnd;

        public float MaxRenderDistance;
        public float MaxSpawnDistance;

        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        [NMSAttribute(Ignore = true)]
        public byte[] PaddingB8;
    }
}
