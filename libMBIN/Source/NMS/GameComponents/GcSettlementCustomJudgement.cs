using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7C547D2F9C1A8FC3, NameHash = 0xDE31ED3D)]
    public class GcSettlementCustomJudgement : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x000 */ public GcSettlementJudgementData Data;
        [NMS(Index = 2)]
        /* 0x170 */ public NMSString0x20A CustomCostText;
        [NMS(Index = 3)]
        /* 0x190 */ public NMSString0x20A CustomMissionObjectiveText;
        [NMS(Index = 0)]
        /* 0x1B0 */ public NMSString0x10 ID;
    }
}
