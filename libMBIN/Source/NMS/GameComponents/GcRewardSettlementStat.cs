using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7D155785ED017360, NameHash = 0x83BEB92)]
    public class GcRewardSettlementStat : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcSettlementStatChange StatToAward;
        [NMS(Index = 1)]
        /* 0xC */ public bool Silent;
    }
}
