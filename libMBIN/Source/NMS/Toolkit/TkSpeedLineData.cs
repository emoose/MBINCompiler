namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xE445E4110EBDBDAC, NameHash = 0xEC9FF9AD5EDADEFF)]
    public class TkSpeedLineData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x80 Material;
        /* 0x80 */ public int NumberOfParticles;
        /* 0x84 */ public float Radius;
        /* 0x88 */ public float Length;
        /* 0x8C */ public float RemoveCylinderRadius;
        /* 0x90 */ public float Width;
        /* 0x94 */ public float Alpha;
        /* 0x98 */ public float FadeTime;
        /* 0x9C */ public float MinVisibleSpeed;
        /* 0xA0 */ public float MaxVisibleSpeed;
        /* 0xA4 */ public float Lifetime;
        /* 0xA8 */ public float Speed;
        /* 0xB0 */ public Colour ColourOrigin;
        /* 0xC0 */ public Colour ColourEnd;
        // size: 0x2
        public enum LinesPositionEnum : uint {
            Absolute,
            Relative,
        }
        /* 0xD0 */ public LinesPositionEnum LinesPosition;
    }
}
