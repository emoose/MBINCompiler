using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x528, Alignment = 0x8, GUID = 0xF5AC6044BED8B32E, SubGUID = 0xDE1F17CE7E01A8C2)]
    public class GcAlienPuzzleEntry : NMSTemplate
    {
        /* 0x000 */ public int ProgressionIndex;
        /* 0x000 */ public int MinProgressionForSelection;
        [NMS(Size = 0x20, IDField = true)]
        /* 0x008 */ public string Id;

        /* 0x028 */ public GcAlienRace Race;
        /* 0x02C */ public GcInteractionType Type;
        /* 0x030 */ public GcAlienPuzzleCategory Category;

        public enum AdditionalOptionsEnum { None, LearnWord, SayWord }
        /* 0x034 */ public AdditionalOptionsEnum AdditionalOptions;

        [NMS(Size = 0x80)]
        /* 0x038 */ public string Title;

        [NMS(Size = 0x200)]
        /* 0x0B8 */ public string Text;

        [NMS(Size = 0x200)]
        /* 0x2B8 */ public string TextAlien;

        /* 0x4B8 */ public bool TranslateAlienText;
        /* 0x4B9 */ public bool TranslationBrackets;
        /* 0x4BA */ public bool ProgressiveDialogue;
        [NMS(Size = 0x5, Ignore = true)]
        /* 0x4BB */ public byte[] Padding4BB;
        [NMS(Size = 0x20)]
        /* 0x4C0 */ public string RequiresScanEvent;
        /* 0x4E0 */ public List<GcAlienPuzzleOption> Options;
        /* 0x4F0 */ public List<NMSString0x20> AdditionalText;
        /* 0x500 */ public List<NMSString0x20> AdditionalTextAlien;
        /* 0x510 */ public GcAlienMood Mood;
        /* 0x514 */ public GcNPCPropTypes Prop;
        /* 0x518 */ public List<GcPuzzleTextFlow> AdvancedInteractionFlow;
    }
}
