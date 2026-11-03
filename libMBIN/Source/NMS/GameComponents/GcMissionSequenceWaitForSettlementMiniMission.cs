namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD6C8A16E2B2286CF, NameHash = 0xE2ADDD61)]
    public class GcMissionSequenceWaitForSettlementMiniMission : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public VariableSizeString DebugText;
        [NMS(Index = 0)]
        /* 0x10 */ public VariableSizeString Message;
    }
}
