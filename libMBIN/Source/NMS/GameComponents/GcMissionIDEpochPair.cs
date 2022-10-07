namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD2B07B00F953DE26, NameHash = 0x79FB303D79E7B435)]
    public class GcMissionIDEpochPair : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 MissionID;
        /* 0x10 */ public ulong RecurrenceDeadline;
    }
}
