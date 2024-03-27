using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xC462D4F8119851CF, NameHash = 0xB9B8ADD8C9FFC2D8)]
    public class TkShearWindData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Name;
        /* 0x10 */ public float OverallWindStrength;
        /* 0x14 */ public float LdsWindStrength;
        /* 0x18 */ public float LdsWindSpeed;
        /* 0x1C */ public float ShearWindSpeed;
        /* 0x20 */ public float WindShearVertpushStrength;
        /* 0x24 */ public float WindShearGradientStrength;
        /* 0x28 */ public float WindShearToDotLdsFactor;
        /* 0x2C */ public float WindStrengthToVertpush;
        /* 0x30 */ public TkShearWindOctaveData Octave0;
        /* 0x44 */ public TkShearWindOctaveData Octave1;
        /* 0x58 */ public TkShearWindOctaveData Octave2;
        /* 0x6C */ public TkShearWindOctaveData Octave3;
    }
}
