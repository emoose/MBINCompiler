using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x2B8, GUID = 0x16BB6B3CFABD286B, SubGUID = 0x3FE862FE8570BE69)]
    public class GcAlienPuzzleOption : NMSTemplate
    {
        [NMS(Size = 0x20)]
        /* 0x000 */ public string Name;

        [NMS(Size = 0x200)]
        /* 0x020 */ public string Text;

        /* 0x220 */ public bool IsAlien;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x221 */ public byte[] padding221;

        [NMS(Size = 0x10)]
        /* 0x228 */ public string Cost;

        /* 0x238 */ public List<NMSString0x10> Rewards;
		/* 0x248 */ public GcAlienMood Mood;
        /* 0x24C */ public GcNPCPropTypes Prop;
        /* 0x250 */ public bool KeepOpen;
        /* 0x251 */ public bool DisplayCost;
        /* 0x252 */ public bool TruncateCost;
        /* 0x253 */ public bool MarkInteractionComplete;
        [NMS(Size = 4, Ignore = true)]
        /* 0x254 */ public byte[] Padding254;
        [NMS(Size = 0x20)]
        /* 0x258 */ public string NextInteraction;
        /* 0x278 */ public GcAudioWwiseEvents AudioEvent;
        /* 0x27C */ public GcMissionConditionTest EnablingConditionTest;
        /* 0x280 */ public List<NMSTemplate> EnablingConditions;
        [NMS(Size = 0x20)]
        /* 0x290 */ public string EnablingConditionId;
        /* 0x2B0 */ public GcWordCategoryTableEnum WordCategory;
        [NMS(Size = 4, Ignore = true)]
        /* 0x2B4 */ public byte[] EndPadding;
    }
}
