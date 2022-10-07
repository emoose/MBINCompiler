namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xE39536D6A25C5F9, NameHash = 0x36EF2564DBF81DFA)]
    public class TkAnimPoseCorrelationData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 ItemA;
        /* 0x10 */ public NMSString0x10 ItemB;
        /* 0x20 */ public float Correlation;
    }
}
