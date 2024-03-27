using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x14BCE7AB55AC06F0, NameHash = 0xDE1F17CE7E01A8C2)]
    public class GcAlienPuzzleEntry : NMSTemplate
    {
        /* 0x000 */ public int ProgressionIndex;
        /* 0x004 */ public int MinProgressionForSelection;
        /* 0x008 */ public NMSString0x20A Id;
        /* 0x028 */ public GcAlienRace Race;
        /* 0x02C */ public GcInteractionType Type;
        /* 0x030 */ public GcAlienPuzzleCategory Category;
        // size: 0x3
        public enum AdditionalOptionsEnum : uint {
            None,
            LearnWord,
            SayWord,
        }
        /* 0x034 */ public AdditionalOptionsEnum AdditionalOptions;
        /* 0x038 */ public NMSString0x20A Title;
        /* 0x058 */ public NMSString0x20A Text;
        /* 0x078 */ public NMSString0x20A TextAlien;
        /* 0x098 */ public bool TranslateAlienText;
        /* 0x099 */ public bool TranslationBrackets;
        /* 0x09A */ public bool ProgressiveDialogue;
        /* 0x0A0 */ public NMSString0x20A RequiresScanEvent;
        /* 0x0C0 */ public List<GcAlienPuzzleOption> Options;
        /* 0x0D0 */ public List<NMSString0x20A> AdditionalText;
        /* 0x0E0 */ public List<NMSString0x20A> AdditionalTextAlien;
        /* 0x0F0 */ public GcAlienMood Mood;
        /* 0x0F4 */ public GcNPCPropType Prop;
        /* 0x0F8 */ public List<GcPuzzleTextFlow> AdvancedInteractionFlow;
        // size: 0x3
        public enum PersistancyBufferOverrideEnum : uint {
            None,
            AlwaysPersonal,
            AlwaysFireteam,
        }
        /* 0x108 */ public PersistancyBufferOverrideEnum PersistancyBufferOverride;
        /* 0x10C */ public int CustomFreighterTextIndex;
        /* 0x110 */ public bool RadialInteraction;
        /* 0x111 */ public bool UseTitleOverrideInLabel;
        /* 0x114 */ public GcAudioWwiseEvents NextStageAudioEventOverride;
    }
}
