using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x37B99E437E20CA24, NameHash = 0x39BD1ED2FC8D7524)]
    public class GcPetBehaviourTable : NMSTemplate
    {
        // size: 0x1C
        public enum BehavioursEnum {
            None,
            Idle,
            Eat,
            Poop,
            LayEgg,
            FollowPlayer,
            AdoptedFollowPlayer,
            ScanForResource,
            FindResource,
            FindHazards,
            AttackHazard,
            FindBuilding,
            Fetch,
            Explore,
            Emote,
            GestureReact,
            OrderedToPos,
            ComeHere,
            Mine,
            Summoned,
            Adopted,
            Hatched,
            PostInteract,
            Rest,
            Attack,
            Watch,
            Greet,
            TeleportToPlayer
        }
        [NMS(Size = 0x1C, EnumType = typeof(BehavioursEnum))]
        /* 0x0000 */ public GcPetBehaviourData[] Behaviours;
        /* 0x0E00 */ public float GlobalCooldownModifier;
        /* 0x0E04 */ public float UsefulBehaviourLinkedCooldownAmount;
        /* 0x0E08 */ public float PlayerActivityIncreaseTime;
        /* 0x0E0C */ public float PlayerActivityDecreaseTime;
        // size: 0x2
        public enum MoodIncreaseTimeEnum {
            Hungry,
            Lonely
        }
        [NMS(Size = 0x2, EnumType = typeof(MoodIncreaseTimeEnum))]
        /* 0x0E10 */ public float[] MoodIncreaseTime;
        // size: 0x3
        public enum TraitMoodModifiersEnum {
            Helpfulness,
            Aggression,
            Independence
        }
        [NMS(Size = 0x3, EnumType = typeof(TraitMoodModifiersEnum))]
        /* 0x0E18 */ public GcPetTraitMoodModifierList[] TraitMoodModifiers;
        // size: 0x9
        public enum RewardMoodModifierEnum {
            Tickle,
            Treat,
            Ride,
            Customise,
            Abandon,
            LayEgg,
            Adopt,
            Milk,
            HarvestSpecial
        }
        [NMS(Size = 0x9, EnumType = typeof(RewardMoodModifierEnum))]
        /* 0x0E78 */ public GcPetActionMoodModifier[] RewardMoodModifier;
        // size: 0xB
        public enum TraitRangesEnum {
            None,
            Predator,
            PlayerPredator,
            Prey,
            Passive,
            Bird,
            FishPrey,
            FishPredator,
            Butterfly,
            Robot,
            Pet
        }
        [NMS(Size = 0xB, EnumType = typeof(TraitRangesEnum))]
        /* 0x0EC0 */ public GcCreaturePetTraitRanges[] TraitRanges;
        // size: 0x2
        public enum MoodValuesOnAdoptEnum {
            Hungry,
            Lonely
        }
        [NMS(Size = 0x2, EnumType = typeof(MoodValuesOnAdoptEnum))]
        /* 0x0FC8 */ public float[] MoodValuesOnAdopt;
        // size: 0x2
        public enum MoodValuesOnHatchEnum {
            Hungry,
            Lonely
        }
        [NMS(Size = 0x2, EnumType = typeof(MoodValuesOnHatchEnum))]
        /* 0x0FD0 */ public float[] MoodValuesOnHatch;
        /* 0x0FD8 */ public List<GcPetTraitStaminaModifier> TraitStaminaModifiers;
        /* 0x0FE8 */ public List<GcPetMoodStaminaModifier> MoodStaminaModifiers;
        /* 0x0FF8 */ public float AccessoryGyroFollowMotionStrength;
        /* 0x0FFC */ public float AccessoryGyroToNeutralStrength;
        /* 0x1000 */ public float AccessoryGyroDamping;
        /* 0x1004 */ public float AccessoryGyroStrength;
        /* 0x1008 */ public bool AccessoryGyroActive;
    }
}
