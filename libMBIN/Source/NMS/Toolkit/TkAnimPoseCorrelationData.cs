namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x718C816522FE6662, NameHash = 0x36EF2564DBF81DFA)]
    public class TkAnimPoseCorrelationData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 ItemA;
        /* 0x10 */ public NMSString0x10 ItemB;
        /* 0x20 */ public float Correlation;
    }
}
