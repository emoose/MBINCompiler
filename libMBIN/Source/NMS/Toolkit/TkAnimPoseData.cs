namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x6BF9E288A7749149, NameHash = 0x6ABBA097)]
    public class TkAnimPoseData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Anim;
        [NMS(Index = 1)]
        /* 0x10 */ public GcFilename Filename;
        [NMS(Index = 3)]
        /* 0x20 */ public int FrameEnd;
        [NMS(Index = 2)]
        /* 0x24 */ public int FrameStart;
    }
}
