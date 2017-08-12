namespace MBINCompiler.Models.Structs
{
    public class GcMissionSequenceShowMessage : NMSTemplate     // size: 0x230
    {
        [NMS(Size = 0x80)]
        /* 0x000 */ public string DebugText;
        /* 0x080 */ public float Time;
        [NMS(Size = 0x80)]
        /* 0x084 */ public string Message;
    }
}
