using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x800, GUID = 0xE559207CECEA2E9B, NameHash = 0x434379BF90DDF679)]
    public class GcStatusMessageDefinitions : NMSTemplate
    {
        /* 0x000 */ public List<GcStatusMessageDefinition> Messages;
        /* 0x010 */ public Colour MissionMarkupColour;
        [NMS(Size = 0xF, EnumType = typeof(GcPetVocabularyWords.PetVocabularyWordEnum))]
        /* 0x020 */ public GcPetVocabularyEntry[] PetVocabulary;
        [NMS(Size = 0x15, EnumType = typeof(GcPetChatType.PetChatTypeEnum))]
        /* 0x368 */ public GcPetVocabularyEntry[] PetChatTemplates;
    }
}