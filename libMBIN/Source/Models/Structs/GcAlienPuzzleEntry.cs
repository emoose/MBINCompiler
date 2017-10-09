using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x4E0, Alignment = 0x8)]
    public class GcAlienPuzzleEntry : NMSTemplate
    {
        [NMS(Size = 0x20)]
        /* 0x000 */ public string Id;

        /* 0x020 */ public GcAlienRace AlienRace;
        /* 0x024 */ public GcInteractionType Type;

        [NMS(Size = 0x80)]
        /* 0x028 */ public string Title;

        [NMS(Size = 0x200)]
        /* 0x0A8 */ public string Text;

        [NMS(Size = 0x200)]
        /* 0x2A8 */ public string TextAlien;

        /* 0x4A8 */ public bool TranslateAlienText;
        /* 0x4A9 */ public bool TranslationBrackets;
        /* 0x4AA */ public bool ProgressiveDialogue;
        [NMS(Size = 0x5, Ignore = true)]
        /* 0x4AB */ public byte[] Padding4AB;
        /* 0x4B0 */ public List<GcAlienPuzzleOption> Options;
        /* 0x4C0 */ public List<NMSString0x20> AdditionalText;
        /* 0x4D0 */ public List<NMSString0x20> AdditionalTextAlien;
    }
}
