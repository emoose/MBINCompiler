using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7F6367646A6A53F, NameHash = 0x4C3D7B42)]
    public class GcSettlementJudgementData : NMSTemplate
    {
        [NMS(Index = 6)]
        /* 0x000 */ public NMSString0x20A DilemmaText;
        [NMS(Index = 2)]
        /* 0x020 */ public NMSString0x20A HeaderOverride;
        [NMS(Index = 16)]
        /* 0x040 */ public NMSString0x20A NPC1CustomName;
        [NMS(Index = 17)]
        /* 0x060 */ public NMSString0x20A NPC2CustomName;
        [NMS(Index = 4)]
        /* 0x080 */ public NMSString0x20A NPCTitle;
        [NMS(Index = 5)]
        /* 0x0A0 */ public NMSString0x20A QuestionText;
        [NMS(Index = 3)]
        /* 0x0C0 */ public NMSString0x20A Title;
        [NMS(Index = 14)]
        /* 0x0E0 */ public NMSString0x10 NPC1CustomId;
        [NMS(Index = 18)]
        /* 0x0F0 */ public NMSString0x10 NPC1HoloEffect;
        [NMS(Index = 15)]
        /* 0x100 */ public NMSString0x10 NPC2CustomId;
        [NMS(Index = 19)]
        /* 0x110 */ public NMSString0x10 NPC2HoloEffect;
        [NMS(Index = 10)]
        /* 0x120 */ public List<GcSettlementJudgementOption> Option1List;
        [NMS(Index = 11)]
        /* 0x130 */ public List<GcSettlementJudgementOption> Option2List;
        [NMS(Index = 12)]
        /* 0x140 */ public List<GcSettlementJudgementOption> Option3List;
        [NMS(Index = 13)]
        /* 0x150 */ public List<GcSettlementJudgementOption> Option4List;
        [NMS(Index = 0)]
        /* 0x160 */ public GcSettlementJudgementType JudgementType;
        // size: 0x4
        public enum NPCsEnum : uint {
            None,
            One,
            Two,
            ExistingPerkJob,
        }
        [NMS(Index = 20)]
        /* 0x164 */ public NPCsEnum NPCs;
        [NMS(Index = 1)]
        /* 0x168 */ public float Weighting;
        [NMS(Index = 7)]
        /* 0x16C */ public bool DilemmaTextIsAlien;
        [NMS(Index = 9)]
        /* 0x16D */ public bool UseAltResearchLoc;
        [NMS(Index = 8)]
        /* 0x16E */ public bool UseResearchLoc;
    }
}
