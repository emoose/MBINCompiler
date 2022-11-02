using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x63CF64D66F5DB96, NameHash = 0x3FD1F99F13543A98)]
    public class GcPassiveFrigateIncome : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 IncomeId;
        /* 0x10 */ public GcInventoryType IncomeType;
        /* 0x14 */ public int AmountOfIncomeRewarded;
        /* 0x18 */ public int ForEveryXAmountOfTheStat;
    }
}
