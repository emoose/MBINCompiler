namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC03039583D8C0A14, NameHash = 0x210E5E8D593FFE)]
    public class GcMissionSequenceLeaveNexusMP : NMSTemplate
    {
        /* 0x000 */ public NMSString0x80 Message;
        /* 0x080 */ public NMSString0x80 MessageNoWarp;
        /* 0x100 */ public ulong Timeout;
        /* 0x108 */ public NMSString0x80 DebugText;
    }
}
