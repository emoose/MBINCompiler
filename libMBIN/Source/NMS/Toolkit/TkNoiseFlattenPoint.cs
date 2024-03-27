using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xCD402697FFDFC91B, NameHash = 0xCE87D0159308C03A)]
    public class TkNoiseFlattenPoint : NMSTemplate
    {
        /* 0x00 */ public float Density;
        /* 0x04 */ public float FlattenRadius;
        /* 0x08 */ public float TurbulenceFrequency;
        /* 0x0C */ public float TurbulenceAmplitude;
        /* 0x10 */ public int TurbulenceOctaves;
        /* 0x14 */ public TkNoiseFlattenOptions FlattenType;
        /* 0x1C */ public int Classification;
        /* 0x20 */ public int Placement;
        /* 0x24 */ public bool AddWaypoint;
        /* 0x25 */ public bool AddShelter;
        /* 0x26 */ public bool AddLandingPad;
    }
}
