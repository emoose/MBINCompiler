namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB0C3876D5B99F9AB, NameHash = 0x197E91849165F7F4)]
    public class GcMissionSequenceWaitForStat : NMSTemplate
    {
        /* 0x00 */ public NMSString0x80 Message;
        /* 0x80 */ public NMSString0x10 Stat;
        /* 0x90 */ public NMSString0x10 StatGroup;
        /* 0xA0 */ public int Amount;
        /* 0xA4 */ public NMSString0x80 DebugText;
    }
}
