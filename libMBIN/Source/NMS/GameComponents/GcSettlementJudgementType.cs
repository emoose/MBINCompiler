namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB8DD1EC6D5CFED6, NameHash = 0x65DD91BC)]
    public class GcSettlementJudgementType : NMSTemplate
    {
        // size: 0xC
        public enum SettlementJudgementTypeEnum : uint {
            None,
            StrangerVisit,
            Policy,
            NewBuilding,
            BuildingChoice,
            Conflict,
            Request,
            BlessingPerkRelated,
            JobPerkRelated,
            ProcPerkRelated,
            UpgradeBuilding,
            UpgradeBuildingChoice,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public SettlementJudgementTypeEnum SettlementJudgementType;
    }
}
