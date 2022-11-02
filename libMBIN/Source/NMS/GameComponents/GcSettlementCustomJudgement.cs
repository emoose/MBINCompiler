using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3BF33091584CACC1, NameHash = 0xD0AB76328A1D707)]
    public class GcSettlementCustomJudgement : NMSTemplate
    {
        /* 0x000 */ public NMSString0x10 ID;
        /* 0x010 */ public GcSettlementJudgementData Data;
        /* 0x228 */ public NMSString0x20A CustomCostText;
    }
}
