namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x65B2E92C356C3B73, NameHash = 0x9B6A014776B1F8BB)]
    public class GcSettlementJudgementType : NMSTemplate
    {
        // size: 0x7
        public enum SettlementJudgementTypeEnum {
            None,
            StrangerVisit,
            Policy,
            NewBuilding,
            BuildingChoice,
            Conflict,
            Request,
        }
        /* 0x0 */ public SettlementJudgementTypeEnum SettlementJudgementType;
    }
}
