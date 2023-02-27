namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x295C0C71FB3CCFD1, NameHash = 0xB497A82E7D25F7C4)]
    public class GcMissionSequenceWaitRealTimeCombat : NMSTemplate
    {
        /* 0x000 */ public NMSString0x80 Message;
        /* 0x080 */ public NMSString0x80 MessageCombat;
        /* 0x100 */ public ulong Time;
        /* 0x108 */ public float Randomness;
        /* 0x110 */ public NMSString0x10 DisplayStat;
        /* 0x120 */ public bool StatFromNow;
        /* 0x121 */ public NMSString0x80 DebugText;
    }
}
