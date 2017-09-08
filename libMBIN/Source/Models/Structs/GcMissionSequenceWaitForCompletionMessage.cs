namespace MBINCompiler.Models.Structs
{
    public class GcMissionSequenceWaitForCompletionMessage : NMSTemplate
    {
        [NMS(Size = 0x80)]
        /* 0x000 */ public string Message;
        [NMS(Size = 0x80)]
        /* 0x080 */ public string DebugText;
    }
}
