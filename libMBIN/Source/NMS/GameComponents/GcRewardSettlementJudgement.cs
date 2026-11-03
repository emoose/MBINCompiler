using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x97BF0F2D1A65C1C3, NameHash = 0xD9554ADD)]
    public class GcRewardSettlementJudgement : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public List<GcSettlementJudgementType> JudgementTypes;
        [NMS(Index = 1)]
        /* 0x10 */ public bool Silent;
    }
}
