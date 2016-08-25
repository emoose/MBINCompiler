using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MBINCompiler.Models.Structs
{
    public class TkHeavyAirData : NMSTemplate
    {
        [NMS(Size = 0x80)]
        public string Material;
        public int NumberOfParticles;
        public float Radius;
        public float RadiusY;
        public float MinParticleLifetime;
        public float MaxParticleLifetime;
        public float FadeTime;
        public float SpeedFadeInTime;
        public float MinVisibleSpeed;
        public float SpeedFadeOutTime;
        public float MaxVisibleSpeed;
        public float SpawnRotationRange;
        public Vector4f MajorDirection;
        public Vector4f ScaleRange;
        public Vector4f RotationSpeedRange;
        public Vector4f TwinkleRange;
        public Vector4f AmplitudeMin;
        public Vector4f AmplitudeMax;
        public Colour Colour1;
        public Colour Colour2;
        public int EmitterShape;
        public string[] EmitterShapeValues()
        {
            return new[] { "Sphere", "UpperHalfSphere", "BottomHalfSphere" };
        }
    }
}
