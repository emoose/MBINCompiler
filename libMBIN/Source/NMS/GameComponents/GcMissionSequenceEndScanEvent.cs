namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x84B5B2A2C94672CD, NameHash = 0x4AEF809F)]
    public class GcMissionSequenceEndScanEvent : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A Event;
        [NMS(Index = 1)]
        /* 0x20 */ public VariableSizeString DebugText;
    }
}
