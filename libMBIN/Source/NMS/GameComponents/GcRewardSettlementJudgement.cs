using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x68DB8B4085796014, NameHash = 0x7A92D278225AF4A9)]
    public class GcRewardSettlementJudgement : NMSTemplate
    {
        /* 0x00 */ public List<GcSettlementJudgementType> JudgementTypes;
        /* 0x10 */ public bool Silent;
    }
}
