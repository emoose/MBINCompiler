namespace libMBIN.Models.Structs
{
    public class GcMissionSequenceReward : NMSTemplate
    {
        [NMS(Size = 0x80)]
        /* 0x000 */ public string Message;
        [NMS(Size = 0x10)]
        /* 0x080 */ public string Reward;
        [NMS(Size = 0x80)]
        /* 0x090 */ public string DebugText;
    }
}
