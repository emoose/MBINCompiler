namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x3B5321EFAE0A2CF2, NameHash = 0xB5545483)]
    public class TkAnimPoseExampleElement : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Anim;
        [NMS(Index = 1)]
        /* 0x10 */ public float Value;
    }
}
