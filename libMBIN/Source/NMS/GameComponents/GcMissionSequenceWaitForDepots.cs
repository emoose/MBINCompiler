namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x84148783106D2CB8, NameHash = 0x79D85DCF556B9E6B)]
    public class GcMissionSequenceWaitForDepots : NMSTemplate
    {
        /* 0x00 */ public NMSString0x80 Message;
        /* 0x80 */ public int AmountMin;
        /* 0x84 */ public int AmountMax;
        /* 0x88 */ public NMSString0x80 DebugText;
    }
}
