namespace MBINCompiler.Models.Structs
{
    public class GcMissionSequenceGoToGalacticPoint : NMSTemplate      // size: 0x104
    {
        [NMS(Size = 0x80)]
        /* 0x000 */ public string MessageGetToSpace;
        [NMS(Size = 0x80)]
        /* 0x080 */ public GcMissionGalacticPoint Target;
        [NMS(Size = 0x80)]
        /* 0x084 */ public string DebugText;
    }
}
