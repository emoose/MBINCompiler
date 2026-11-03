namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB7A05886579ACA56, NameHash = 0x9038B3CD)]
    public class GcMissionConditionMissionMessage : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Message;
        [NMS(Index = 1)]
        /* 0x10 */ public VariableSizeString MessageToFormatSeasonalIDInto;
    }
}
