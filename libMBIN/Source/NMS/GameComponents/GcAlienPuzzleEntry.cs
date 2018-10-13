using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x500, Alignment = 0x8, GUID = 0x4A5D06C34000246A)]
    public class GcAlienPuzzleEntry : NMSTemplate
    {
        [NMS(Size = 0x20, IDField = true)]
        /* 0x000 */ public string Id;

        /* 0x020 */ public GcAlienRace Race;
        /* 0x024 */ public GcInteractionType Type;
        /* 0x028 */ public GcAlienPuzzleCategory Category;

        [NMS(Size = 0x80)]
        /* 0x02C */ public string Title;

        [NMS(Size = 0x200)]
        /* 0x0AC */ public string Text;

        [NMS(Size = 0x200)]
        /* 0x2AC */ public string TextAlien;

        /* 0x4AC */ public bool TranslateAlienText;
        /* 0x4AD */ public bool TranslationBrackets;
        /* 0x4AE */ public bool ProgressiveDialogue;
        [NMS(Size = 0x1, Ignore = true)]
        /* 0x4AF */ public byte[] Padding4AF;
        [NMS(Size = 0x20)]
        /* 0x4B0 */ public string RequiresScanEvent;
        /* 0x4D0 */ public List<GcAlienPuzzleOption> Options;
        /* 0x4E0 */ public List<NMSString0x20> AdditionalText;
        /* 0x4F0 */ public List<NMSString0x20> AdditionalTextAlien;
    }
}
