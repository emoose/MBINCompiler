using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xB444741FDF06771E, NameHash = 0xEC73620F98D708BF)]
    public class TkAnimAnimNode : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 NodeId;
        /* 0x10 */ public NMSString0x10 AnimId;
        /* 0x20 */ public NMSString0x40 PhaseIn;
        /* 0x60 */ public TkCurveType PhaseCurve;
        /* 0x64 */ public float PhaseRangeBegin;
        /* 0x68 */ public float PhaseRangeEnd;
    }
}
