namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x48959E8D8B7150F7, NameHash = 0x79FB303D79E7B435)]
    public class GcMissionIDEpochPair : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 MissionID;
        /* 0x10 */ public ulong RecurrenceDeadline;
    }
}
