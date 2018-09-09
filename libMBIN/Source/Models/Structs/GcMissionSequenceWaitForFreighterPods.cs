namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x1B655E6ECEF95A07)]
    public class GcMissionSequenceWaitForFreighterPods : NMSTemplate        // size: 0x104
    {
        [NMS(Size = 0x80)]
        /* 0x000 */ public string Message;
        /* 0x080 */ public int Amount;
        [NMS(Size = 0x80)]
        /* 0x084 */ public string DebugText;
    }
}
