namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x62A4DAA2DC5C33A2, NameHash = 0x79FB303D79E7B435)]
    public class GcMissionIDEpochPair : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 MissionID;
        /* 0x10 */ public ulong RecurrenceDeadline;
    }
}
