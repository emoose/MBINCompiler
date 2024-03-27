namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7CB27A10AF35501, NameHash = 0x6D7E63CBE4F67CF0)]
    public class GcAnimFrameEvent : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Anim;
        /* 0x10 */ public int FrameStart;
        /* 0x14 */ public bool StartFromEnd;
    }
}
