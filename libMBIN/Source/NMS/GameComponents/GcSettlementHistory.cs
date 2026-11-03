namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD563F794C8C82F3, NameHash = 0xD319BD27)]
    public class GcSettlementHistory : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public ulong SeedValue;
        [NMS(Index = 9)]
        /* 0x08 */ public int BugAttackCount;
        [NMS(Index = 11)]
        /* 0x0C */ public int GiftsRecieved;
        [NMS(Index = 6)]
        /* 0x10 */ public int InitialBuildingCount;
        [NMS(Index = 3)]
        /* 0x14 */ public int InitialHappiness;
        [NMS(Index = 2)]
        /* 0x18 */ public int InitialPopulation;
        [NMS(Index = 4)]
        /* 0x1C */ public int InitialProductivity;
        [NMS(Index = 5)]
        /* 0x20 */ public int InitialUpkeepCost;
        [NMS(Index = 16)]
        /* 0x24 */ public int JudgementsSettled;
        [NMS(Index = 12)]
        /* 0x28 */ public float LastWentIntoDebtTime;
        [NMS(Index = 13)]
        /* 0x2C */ public float LastWentIntoProfitTime;
        [NMS(Index = 14)]
        /* 0x30 */ public float LongestDebtStretch;
        [NMS(Index = 15)]
        /* 0x34 */ public float LongestProfitStretch;
        [NMS(Index = 1)]
        /* 0x38 */ public float PlayerClaimedTime;
        [NMS(Index = 10)]
        /* 0x3C */ public int PlayerKillCount;
        [NMS(Index = 8)]
        /* 0x40 */ public int SentinelAttackCount;
        [NMS(Index = 7)]
        /* 0x44 */ public int SettlerDeathCount;
    }
}
