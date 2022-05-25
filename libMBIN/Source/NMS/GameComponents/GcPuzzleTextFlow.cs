using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x58, GUID = 0x94B36BC72B00E86F, NameHash = 0x44CB81CE83D73B16)]
    public class GcPuzzleTextFlow : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A Text;
        /* 0x20 */ public bool IsAlien;
        /* 0x28 */ public NMSString0x20A Title;
        /* 0x48 */ public GcAlienMood Mood;
        // size: 0x3
        public enum TranslateAlienTextOverrideEnum { None, Translate, DoNotTranslate }
        /* 0x4C */ public TranslateAlienTextOverrideEnum TranslateAlienTextOverride;
        // size: 0x3
        public enum BracketsOverrideEnum { None, Brackets, NoBrackets }
        /* 0x50 */ public BracketsOverrideEnum BracketsOverride;
        /* 0x54 */ public GcAudioWwiseEvents AudioEvent;
    }
}
