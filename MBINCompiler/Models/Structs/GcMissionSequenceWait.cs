namespace MBINCompiler.Models.Structs
{
    public class GcMissionSequenceWait : NMSTemplate
    {
        /* 0x0 */ public float Time;
        [NMS(Size = 0x80)]
        /* 0x4 */ public string DebugText;
    }
}
