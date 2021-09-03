using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x138, GUID = 0x1ECC9B8844AAF63C, NameHash = 0x601CD433A66F7318)]
    public class GcSettlementJudgementData : NMSTemplate
    {
        /* 0x000 */ public GcSettlementJudgementType JudgementType;
        /* 0x004 */ public float Weighting;
        /* 0x008 */ public NMSString0x20A Title;
        /* 0x028 */ public NMSString0x20A QuestionText;
        /* 0x048 */ public NMSString0x20A Dilemmatext;
        /* 0x068 */ public bool UseResearchLoc;
        /* 0x069 */ public bool UseAltResearchLoc;
        /* 0x070 */ public GcSettlementJudgementOption Option1;
        /* 0x0D0 */ public GcSettlementJudgementOption Option2;
        public enum NPCsEnum { None, One, Two }
        /* 0x130 */ public NPCsEnum NPCs;
    }
}
