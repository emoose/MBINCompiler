namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x0F1BABCCA84CF0AD5)]
    public class GcMissionSequenceWait : NMSTemplate
    {
        /* 0x0 */ public float Time;
        [NMS(Size = 0x80)]
        /* 0x4 */ public string DebugText;
    }
}
