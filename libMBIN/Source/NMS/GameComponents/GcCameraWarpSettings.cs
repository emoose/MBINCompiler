using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2134F28E3C1FC07E, NameHash = 0x72EE2F7B202E1811)]
    public class GcCameraWarpSettings : NMSTemplate
    {
        /* 0x00 */ public float FocusPointDist;
        /* 0x04 */ public float OffsetZFrequency_1;
        /* 0x08 */ public float OffsetZFrequency_2;
        /* 0x0C */ public float OffsetZPhase_1;
        /* 0x10 */ public float OffsetZPhase_2;
        /* 0x14 */ public float OffsetZStartBias;
        /* 0x18 */ public float OffsetZBias;
        /* 0x1C */ public float OffsetZRange;
        /* 0x20 */ public float OffsetYFrequency_1;
        /* 0x24 */ public float OffsetYFrequency_2;
        /* 0x28 */ public float OffsetYPhase_1;
        /* 0x2C */ public float OffsetYPhase_2;
        /* 0x30 */ public float OffsetYStartBias;
        /* 0x34 */ public float OffsetYBias;
        /* 0x38 */ public float OffsetYRange;
        /* 0x3C */ public float OffsetXFrequency;
        /* 0x40 */ public float OffsetXPhase;
        /* 0x44 */ public float OffsetXRange;
        /* 0x48 */ public TkCurveType OffsetXCurve;
        /* 0x4C */ public float RollRange;
        /* 0x50 */ public float YawnRange;
    }
}
