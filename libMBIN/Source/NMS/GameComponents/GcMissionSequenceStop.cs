namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD54D7DA6069D59CF, NameHash = 0x114D3275)]
    public class GcMissionSequenceStop : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public VariableSizeString DebugText;
        [NMS(Index = 0)]
        /* 0x10 */ public VariableSizeString Message;
    }
}
