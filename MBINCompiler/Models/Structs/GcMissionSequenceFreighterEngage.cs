namespace MBINCompiler.Models.Structs
{
    public class GcMissionSequenceFreighterEngage : NMSTemplate      // size: 0x180
    {
        [NMS(Size = 0x80)]
        /* 0x000 */ public string MessageGetToSpace;
        [NMS(Size = 0x80)]
        /* 0x080 */ public string Message;
        [NMS(Size = 0x80)]
        /* 0x190 */ public string DebugText;
    }
}
