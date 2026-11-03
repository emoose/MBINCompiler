namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8D7B850AED52E040, NameHash = 0x10AEB3EA)]
    public class GcMissionSequenceShowPodMessage : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public VariableSizeString DebugText;
        [NMS(Index = 0)]
        /* 0x10 */ public VariableSizeString Message;
    }
}
