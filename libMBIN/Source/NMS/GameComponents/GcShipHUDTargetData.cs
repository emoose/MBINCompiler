using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEBA3C048EB64D94A, NameHash = 0x24B6E7D6F92704D5)]
    public class GcShipHUDTargetData : NMSTemplate
    {
        /* 0x000 */ public GcShipHUDTargetIconData IconData;
        /* 0x300 */ public NMSString0x80 Arrow;
        /* 0x380 */ public float IconSizeIn;
        /* 0x384 */ public float IconMinSize;
        /* 0x388 */ public float IconMaxSize;
        /* 0x38C */ public float IconSizeScale;
        /* 0x390 */ public float ArrowScale;
        /* 0x394 */ public float ArrowOffset;
        /* 0x398 */ public float ArrowMinFadeDist;
        /* 0x39C */ public float ArrowFadeRange;
        /* 0x3A0 */ public float ArrowMinSize;
        /* 0x3A4 */ public float ArrowMaxSize;
        /* 0x3B0 */ public Colour BaseColour;
        /* 0x3C0 */ public float ActiveDistance;
        /* 0x3C4 */ public float ActivateTime;
        /* 0x3C8 */ public float GlowAlpha;
        /* 0x3CC */ public float HighlightTime;
        /* 0x3D0 */ public float HitPulse;
        /* 0x3D4 */ public float HitPulseTime;
        /* 0x3D8 */ public float HitWhiteOut;
        /* 0x3E0 */ public Colour LockColour;
        /* 0x3F0 */ public float PoliceColourFreq;
        /* 0x400 */ public Colour PoliceColour1;
        /* 0x410 */ public Colour PoliceColour2;
        /* 0x420 */ public Colour ThreatColour;
    }
}
