using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0xB00, GUID = 0xBE7FDC03159FE877, NameHash = 0x35FB9E28116A4F2A)]
    public class GcMissionSequenceCompleteSettlementJudgement : NMSTemplate
    {
        [NMS(Size = 0x7, EnumType = typeof(GcSettlementJudgementType.SettlementJudgementTypeEnum))]
        /* 0x000 */ public GcJudgementMessageOptions[] MessageOptions;
        /* 0xA80 */ public NMSString0x80 DebugText;
    }
}
