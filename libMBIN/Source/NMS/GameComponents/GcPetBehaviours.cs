namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCD77462CB50E896D, NameHash = 0x24A858F2)]
    public class GcPetBehaviours : NMSTemplate
    {
        // size: 0x1C
        public enum PetBehaviourEnum : uint {
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
            TeleportToPlayer,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public PetBehaviourEnum PetBehaviour;
    }
}
