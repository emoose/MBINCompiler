namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBC55DE70E0662051, NameHash = 0xCC5A3F4F)]
    public class GcSettlementStatType : NMSTemplate
    {
        // size: 0x8
        public enum SettlementStatTypeEnum : uint {
            MaxPopulation,
            Happiness,
            Production,
            Upkeep,
            Sentinels,
            Debt,
            Alert,
            BugAttack,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public SettlementStatTypeEnum SettlementStatType;
    }
}
