namespace MBINCompiler.Models.Structs
{
    public class GcMissionSequenceWaitForBuild : NMSTemplate
    {
        [NMS(Size = 0x80)]
        /* 0x000 */ public string Message;
        [NMS(Size = 0x10)]
        /* 0x080 */ public string TargetTech;
        [NMS(Size = 0x80)]
        /* 0x090 */ public string DebugText;
    }
}
