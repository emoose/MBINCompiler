namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6F05B981CD4D2764, NameHash = 0x6D7E63CBE4F67CF0)]
    public class GcAnimFrameEvent : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Anim;
        /* 0x10 */ public int FrameStart;
        /* 0x14 */ public bool StartFromEnd;
    }
}
