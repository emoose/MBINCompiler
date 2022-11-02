using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xA3DB8AB8BEEF030F, NameHash = 0xED10CD4D4540B757)]
    public class TkNGuiRectanglePulseEffect : NMSTemplate
    {
        /* 0x00 */ public float PulseWidth;
        /* 0x04 */ public float PulseOffset;
        /* 0x08 */ public float PulseRate;
        /* 0x0C */ public TkCurveType PulseAlphaCurve;
        /* 0x10 */ public TkCurveType PulseSizeCurve;
    }
}
