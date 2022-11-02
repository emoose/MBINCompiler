namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4D497D5A7B049376, NameHash = 0x51175DF2E4A2F863)]
    public class GcPetChatType : NMSTemplate
    {
        // size: 0x15
        public enum PetChatTypeEnum {
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
        /* 0x0 */ public PetChatTypeEnum PetChatType;
    }
}
