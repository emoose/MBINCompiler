using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBC4CACE8A7310A2F, NameHash = 0xC08D0836890AA2D6)]
    public class GcInventorySlotActionData : NMSTemplate
    {
        /* 0x00 */ public bool Loops;
        /* 0x01 */ public bool Glows;
        /* 0x02 */ public bool Disabled;
        /* 0x03 */ public bool Scales;
        /* 0x04 */ public float Time;
        /* 0x08 */ public float ScaleAtMin;
        /* 0x0C */ public float ScaleAtMax;
        /* 0x10 */ public TkCurveType AnimCurve;
        /* 0x14 */ public GcAudioWwiseEvents SuitAudio;
        /* 0x18 */ public GcAudioWwiseEvents ActionAudio;
    }
}
