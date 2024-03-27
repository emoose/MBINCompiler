using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x43CF4109122236CC, NameHash = 0x3FE862FE8570BE69)]
    public class GcAlienPuzzleOption : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A Name;
        /* 0x20 */ public NMSString0x20A Text;
        /* 0x40 */ public bool IsAlien;
        /* 0x48 */ public NMSString0x10 Cost;
        /* 0x58 */ public List<NMSString0x10> Rewards;
        /* 0x68 */ public GcAlienMood Mood;
        /* 0x6C */ public GcNPCPropType Prop;
        /* 0x70 */ public bool OverrideWithAlienWord;
        /* 0x71 */ public bool ReseedInteractionOnUse;
        /* 0x72 */ public bool KeepOpen;
        /* 0x73 */ public bool DisplayCost;
        /* 0x74 */ public bool TruncateCost;
        /* 0x75 */ public bool MarkInteractionComplete;
        /* 0x78 */ public NMSString0x20A NextInteraction;
        /* 0x98 */ public bool SelectedOnBackOut;
        /* 0x9C */ public GcAudioWwiseEvents AudioEvent;
        /* 0xA0 */ public NMSString0x20A TitleOverride;
        /* 0xC0 */ public GcMissionConditionTest EnablingConditionTest;
        /* 0xC8 */ public List<NMSTemplate> EnablingConditions;
        /* 0xD8 */ public NMSString0x20A EnablingConditionId;
        /* 0xF8 */ public GcWordCategoryTableEnum WordCategory;
    }
}
