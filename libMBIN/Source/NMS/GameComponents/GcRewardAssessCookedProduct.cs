namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x93EC6032E16C9265, NameHash = 0x904C594862FC894E)]
    public class GcRewardAssessCookedProduct : NMSTemplate
    {
        /* 0x00 */ public int AmountWorst;
        /* 0x04 */ public int AmountBad;
        /* 0x08 */ public int AmountAverage;
        /* 0x0C */ public int AmountGood;
        /* 0x10 */ public int AmountBest;
        /* 0x14 */ public int AmountBestUpper;
    }
}
