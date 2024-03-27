namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x2BAB61256BF5B670, NameHash = 0x9564BC3EDB74BBA1)]
    public class TkHeavyAirSystem : NMSTemplate
    {
        /* 0x000 */ public NMSString0x80 Material;
        /* 0x080 */ public Vector3f MajorDirection;
        /* 0x090 */ public Vector3f ScaleRange;
        /* 0x0A0 */ public Vector3f RotationSpeedRange;
        /* 0x0B0 */ public Vector3f FadeSpeedRange;
        /* 0x0C0 */ public Vector3f TwinkleRange;
        /* 0x0D0 */ public Vector3f AmplitudeMin;
        /* 0x0E0 */ public Vector3f AmplitudeMax;
        /* 0x0F0 */ public Colour Colour1;
        /* 0x100 */ public float Colour1Alpha;
        /* 0x110 */ public Colour Colour2;
        /* 0x120 */ public float Colour2Alpha;
    }
}
