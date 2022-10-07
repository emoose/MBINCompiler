using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA6532DABE5A58927, NameHash = 0xE63B46A8CA0EF245)]
    public class GcPetMoodStaminaModifier : NMSTemplate
    {
        /* 0x00 */ public GcCreaturePetMood Mood;
        /* 0x04 */ public float MoodMin;
        /* 0x08 */ public float MoodMax;
        /* 0x0C */ public float StaminaDrainModifierMin;
        /* 0x10 */ public float StaminaDrainModifierMax;
        /* 0x14 */ public float StaminaRechargeModifierMin;
        /* 0x18 */ public float StaminaRechargeModifierMax;
    }
}
