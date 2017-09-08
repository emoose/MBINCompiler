namespace MBINCompiler.Models.Structs
{
    public class GcMissionSequenceWaitForWarps : NMSTemplate        // size: 0x104
    {
        [NMS(Size = 0x80)]
        /* 0x000 */ public string Message;
        /* 0x08 */ public int Amount;
        [NMS(Size = 0x80)]
        /* 0x084 */ public string DebugText;
    }
}
