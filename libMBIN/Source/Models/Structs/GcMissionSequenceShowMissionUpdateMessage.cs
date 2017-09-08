namespace libMBIN.Models.Structs
{
    public class GcMissionSequenceShowMissionUpdateMessage : NMSTemplate
    {
        /* 0x0 */ public int MissionUpdateMessage;
        public string[] MissionUpdateMessageValues()
        {
            return new[] { "Start", "End" };
        }
        [NMS(Size = 0x80)]
        /* 0x4 */ public string DebugText;
    }
}
