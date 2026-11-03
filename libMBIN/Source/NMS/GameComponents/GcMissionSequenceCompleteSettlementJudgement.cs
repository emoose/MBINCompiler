using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1FA49FCEC1BFBE5C, NameHash = 0xE6CB9CDC)]
    public class GcMissionSequenceCompleteSettlementJudgement : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x0000 */ public VariableSizeString DebugText;
        [NMS(Index = 0, Size = 0xC, EnumType = typeof(GcSettlementJudgementType.SettlementJudgementTypeEnum))]
        /* 0x0010 */ public GcJudgementMessageOptions[] MessageOptions;
        [NMS(Index = 1)]
        /* 0x1210 */ public GcJudgementMessageOptions MessageNoOffice;
        [NMS(Index = 3)]
        /* 0x1390 */ public bool FormatObjectives;
    }
}
