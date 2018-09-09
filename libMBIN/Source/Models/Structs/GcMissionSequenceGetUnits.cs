namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x0F54F66C4367F1536)]
    public class GcMissionSequenceGetUnits : NMSTemplate
    {
        [NMS(Size = 0x80)]
        /* 0x000 */ public string Message;
        /* 0x080 */ public int Amount;
        [NMS(Size = 0x80)]
        /* 0x084 */ public string DebugText;
    }
}
