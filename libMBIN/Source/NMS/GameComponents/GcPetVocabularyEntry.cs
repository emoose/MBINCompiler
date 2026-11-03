using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE2A6D9D39D149D24, NameHash = 0xE711E680)]
    public class GcPetVocabularyEntry : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A GenericFallback;
        [NMS(Index = 2)]
        /* 0x20 */ public List<GcPetVocabularyTraitEntry> Vocabulary;
        [NMS(Index = 1)]
        /* 0x30 */ public float OddsOfProcReplacement;
    }
}
