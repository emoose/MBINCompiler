namespace libMBIN.Models.Structs
{
    public class GcMissionSequenceWaitForPortalWarp : NMSTemplate       // size: 0x101
    {
        [NMS(Size = 0x80)]
        /* 0x000 */ public string Message;
        [NMS(Size = 0x80)]
        /* 0x080 */ public string DebugText;
        /* 0x100 */ public bool WarpToSpace;
    }
}
