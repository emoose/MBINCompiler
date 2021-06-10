using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x140, GUID = 0xB55476A1D9E0E509, NameHash = 0xCB25F378CA730AFC)]
    public class TkHeavyAirData : NMSTemplate
    {
        public NMSString0x80 Material;
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
        public Vector3f MajorDirection;
        public Vector3f ScaleRange;
        public Vector3f RotationSpeedRange;
        public Vector3f TwinkleRange;
        public Vector3f AmplitudeMin;
        public Vector3f AmplitudeMax;
        public Colour Colour1;
        public Colour Colour2;
		public enum EmitterShapeEnum { Sphere, UpperHalfSphere, BottomHalfSphere }
		public EmitterShapeEnum EmitterShape;

        [NMS(Size = 0xC, Ignore = true)]
        public byte[] Padding134;
    }
}