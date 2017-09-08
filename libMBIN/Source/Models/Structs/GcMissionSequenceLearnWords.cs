namespace MBINCompiler.Models.Structs
{
    public class GcMissionSequenceLearnWords : NMSTemplate      // size: 0x104
    {
        [NMS(Size = 0x80)]
        /* 0x000 */ public string Message;
        [NMS(Size = 0x80)]
        /* 0x080 */ public int Amount;
        [NMS(Size = 0x80)]
        /* 0x084 */ public string DebugText;
    }
}
