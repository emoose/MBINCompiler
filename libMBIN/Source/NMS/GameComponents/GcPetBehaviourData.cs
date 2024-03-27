using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x285F130A426C7C92, NameHash = 0x309337FC0812738C)]
    public class GcPetBehaviourData : NMSTemplate
    {
        /* 0x00 */ public bool ReactiveBehaviour;
        /* 0x01 */ public bool UsefulBehaviour;
        /* 0x04 */ public float Weight;
        /* 0x08 */ public float MinPerformTime;
        /* 0x0C */ public float MaxPerformTime;
        /* 0x10 */ public float CooldownTime;
        /* 0x14 */ public float ChatChance;
        /* 0x18 */ public float ApproachPlayerDist;
        /* 0x1C */ public float SearchDist;
        // size: 0x2
        public enum PetBehaviourValidityEnum : uint {
            Everywhere,
            OnPlanet,
        }
        /* 0x20 */ public PetBehaviourValidityEnum PetBehaviourValidity;
        /* 0x28 */ public List<GcPetFollowUpBehaviour> FollowUpBehaviours;
        /* 0x38 */ public List<GcPetBehaviourTraitModifier> TraitBehaviourModifiers;
        /* 0x48 */ public List<GcPetBehaviourMoodModifier> MoodBehaviourModifiers;
        [NMS(Size = 0x2, EnumType = typeof(GcCreaturePetMood.PetMoodEnum))]
        /* 0x58 */ public float[] MoodModifyOnComplete;
        /* 0x60 */ public NMSString0x20A LabelText;
    }
}
