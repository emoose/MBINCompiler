namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xDEBAF7F07732068B, NameHash = 0x537216694166E761)]
    public class TkAudioAnimTrigger : NMSTemplate
    {
        /* 0x00 */ public NMSString0x80 Sound;
        /* 0x80 */ public NMSString0x10 Anim;
        /* 0x90 */ public int FrameStart;
    }
}
