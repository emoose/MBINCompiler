namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x89216DFBD9B8BAAA, NameHash = 0x5A04D1F9)]
    public class TkHeavyAirSystem : NMSTemplate
    {
        [NMS(Index = 7, MxmlName = "Amplitude Max")]
        /* 0x00 */ public Vector3f AmplitudeMax;
        [NMS(Index = 6, MxmlName = "Amplitude Min")]
        /* 0x10 */ public Vector3f AmplitudeMin;
        [NMS(Index = 8, MxmlName = "Colour 1")]
        /* 0x20 */ public Colour Colour1;
        [NMS(Index = 10, MxmlName = "Colour 2")]
        /* 0x30 */ public Colour Colour2;
        [NMS(Index = 4, MxmlName = "Fade Speed Range")]
        /* 0x40 */ public Vector3f FadeSpeedRange;
        [NMS(Index = 1, MxmlName = "Major Direction")]
        /* 0x50 */ public Vector3f MajorDirection;
        [NMS(Index = 3, MxmlName = "Rotation Speed Range")]
        /* 0x60 */ public Vector3f RotationSpeedRange;
        [NMS(Index = 2, MxmlName = "Scale Range")]
        /* 0x70 */ public Vector3f ScaleRange;
        [NMS(Index = 5, MxmlName = "Twinkle Range")]
        /* 0x80 */ public Vector3f TwinkleRange;
        [NMS(Index = 0)]
        /* 0x90 */ public GcFilename Material;
        [NMS(Index = 9, MxmlName = "Colour 1 Alpha")]
        /* 0xA0 */ public float Colour1Alpha;
        [NMS(Index = 11, MxmlName = "Colour 2 Alpha")]
        /* 0xA4 */ public float Colour2Alpha;
    }
}
