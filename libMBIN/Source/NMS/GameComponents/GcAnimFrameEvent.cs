namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF7250736DB2AE576, NameHash = 0xC020B794)]
    public class GcAnimFrameEvent : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Anim;
        [NMS(Index = 1)]
        /* 0x10 */ public int FrameStart;
        [NMS(Index = 2)]
        /* 0x14 */ public bool StartFromEnd;
    }
}
