namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x876E811586284FF, NameHash = 0x32B3DC82536846ED)]
    public class GcMissionSequenceWaitRealTime : NMSTemplate
    {
        /* 0x00 */ public NMSString0x80 Message;
        /* 0x80 */ public ulong Time;
        /* 0x88 */ public float Randomness;
        /* 0x90 */ public NMSString0x10 DisplayStat;
        /* 0xA0 */ public bool StatFromNow;
        /* 0xA1 */ public NMSString0x80 DebugText;
    }
}
