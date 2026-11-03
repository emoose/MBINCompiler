namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x391F5A1BA3ECB53F, NameHash = 0x459CBCAF)]
    public class GcMissionConditionHasAnySettlementBuildingInProgress : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public bool IgnoreIfTimerActive;
    }
}
