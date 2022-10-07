namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x9A55EA80BBEF4621, NameHash = 0x789352C972E7FBAA)]
    public class TkAnimPoseData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Anim;
        /* 0x10 */ public int FrameStart;
        /* 0x14 */ public int FrameEnd;
    }
}
