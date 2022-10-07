using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9E9ACDD766194347, NameHash = 0x434379BF90DDF679)]
    public class GcStatusMessageDefinitions : NMSTemplate
    {
        /* 0x000 */ public List<GcStatusMessageDefinition> Messages;
        /* 0x010 */ public Colour MissionMarkupColour;
        // size: 0xF
        public enum PetVocabularyEnum {
            Attack,
            Dislike,
            Cute,
            Good,
            Happy,
            Hostile,
            Like,
            Lonely,
            Loved,
            Noise,
            OwnerLove,
            SummonedTrait,
            Hungry,
            Tickles,
            Yummy
        }
        [NMS(Size = 0xF, EnumType = typeof(PetVocabularyEnum))]
        /* 0x020 */ public GcPetVocabularyEntry[] PetVocabulary;
        // size: 0x15
        public enum PetChatTemplatesEnum {
            Adopted,
            Hatched,
            Summoned,
            Greeting,
            Hazard,
            Scanning,
            PositiveEmote,
            HungryEmote,
            LonelyEmote,
            Go_There,
            Come_Here,
            Planet,
            Mine,
            Attack,
            Chase,
            ReceivedTreat,
            Tickled,
            Ride,
            Egg_Laid,
            Customise,
            Unsummoned
        }
        [NMS(Size = 0x15, EnumType = typeof(PetChatTemplatesEnum))]
        /* 0x368 */ public GcPetVocabularyEntry[] PetChatTemplates;
        // size: 0x5
        public enum FriendlyDroneChatTemplatesEnum {
            Summoned,
            Unsummoned,
            BecomeWanted,
            LoseWanted,
            Idle
        }
        [NMS(Size = 0x5, EnumType = typeof(FriendlyDroneChatTemplatesEnum))]
        /* 0x800 */ public GcFriendlyDroneVocabularyEntry[] FriendlyDroneChatTemplates;
    }
}
