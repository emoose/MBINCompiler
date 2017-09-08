namespace MBINCompiler.Models.Structs
{
    public class GcMissionSequenceBuild : NMSTemplate       // size: 0x118
    {
        [NMS(Size = 0x80)]
        /* 0x000 */ public string Message;
        [NMS(Size = 0x10)]
        /* 0x080 */ public string Part;
        /* 0x090 */ public GcPersistentBaseTypes Base;
        [NMS(Size = 0x80)]
        /* 0x094 */ public string DebugText;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] EndPadding;
    }
}
