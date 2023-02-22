namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE5A63220EF7B73B5, NameHash = 0x7FE7156AA587561F)]
    public class GcCreatureVocalSoundData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Id;
        // size: 0xA
        public enum VocalEmoteEnum {
            EmoteIdle,
            EmoteFlee,
            EmoteAggression,
            EmoteRoar,
            EmotePain,
            EmoteAttack,
            EmoteDie,
            EmoteMiniRoarNeutral,
            EmoteMiniRoarHappy,
            EmoteMiniRoarAngry,
        }
        /* 0x10 */ public VocalEmoteEnum VocalEmote;
        /* 0x14 */ public float PlayFrequency;
        /* 0x18 */ public float MinCooldown;
        /* 0x1C */ public float MaxCooldown;
        /* 0x20 */ public bool PlayImmediately;
        /* 0x21 */ public bool PlayOnlyOnce;
    }
}
