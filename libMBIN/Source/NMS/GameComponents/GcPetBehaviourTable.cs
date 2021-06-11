using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x1008, GUID = 0x27F11C8E2215E0EB, NameHash = 0x39BD1ED2FC8D7524)]
    public class GcPetBehaviourTable : NMSTemplate
    {
        [NMS(Size = 0x1C, EnumType = typeof(GcPetBehaviours.PetBehaviourEnum))]
        /* 0x000 */ public GcPetBehaviourData[] Behaviours;
        /* 0xE00 */ public float GlobalCooldownModifier;
        /* 0xE04 */ public float UsefulBehaviourLinkedCooldownAmount;
        /* 0xE08 */ public float PlayerActivityIncreaseTime;
        /* 0xE0C */ public float PlayerActivityDecreaseTime;
        [NMS(Size = 0x2, EnumType = typeof(GcCreaturePetMood.PetMoodEnum))]
        /* 0xE10 */ public float[] MoodIncreaseTime;
        [NMS(Size = 0x3, EnumType = typeof(GcCreaturePetTraits.PetTraitsEnum))]
        /* 0xE18 */ public GcPetTraitMoodModifierList[] TraitMoodModifiers;
        [NMS(Size = 0x8, EnumType = typeof(GcCreaturePetRewardActions.PetActionEnum))]
        /* 0xE78 */ public GcPetActionMoodModifier[] RewardMoodModifier;
        [NMS(Size = 0xB, EnumType = typeof(GcCreatureRoles.CreatureRoleEnum))]
        /* 0xEB8 */ public GcCreaturePetTraitRanges[] TraitRanges;
        [NMS(Size = 0x2, EnumType = typeof(GcCreaturePetMood.PetMoodEnum))]
        /* 0xFC0 */ public float[] MoodValuesOnAdopt;
        [NMS(Size = 0x2, EnumType = typeof(GcCreaturePetMood.PetMoodEnum))]
        /* 0xFC8 */ public float[] MoodValuesOnHatch;
        /* 0xFD0 */ public List<GcPetTraitStaminaModifier> TraitStaminaModifiers;
        /* 0xFE0 */ public List<GcPetMoodStaminaModifier> MoodStaminaModifiers;
        /* 0xFF0 */ public float AccessoryGyroFollowMotionStrength;
        /* 0xFF4 */ public float AccessoryGyroToNeutralStrength;
        /* 0xFF8 */ public float AccessoryGyroDamping;
        /* 0xFFC */ public float AccessoryGyroStrength;
        /* 0x1000 */ public bool AccessoryGyroActive;
    }
}
