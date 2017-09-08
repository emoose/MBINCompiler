namespace MBINCompiler.Models.Structs
{
    [NMS(Size = 0x88)]
    public class GcMissionSequenceShowMissionUpdateMessage : NMSTemplate
    {
        /* 0x0 */ public int MissionUpdateMessage;
        public string[] MissionUpdateMessageValues()
        {
            return new[] { "Start", "End" };
        }
        /* 0x4 */ public bool SetMissionSelected;
        [NMS(Size = 0x80)]
        /* 0x5 */ public string DebugText;
        [NMS(Size = 0x3, Ignore = true)]
        public byte[] EndPadding;
    }
}
