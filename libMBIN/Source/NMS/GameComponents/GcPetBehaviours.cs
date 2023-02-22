namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x45DC3E7CD69D865B, NameHash = 0x82204A5605D64063)]
    public class GcPetBehaviours : NMSTemplate
    {
        // size: 0x1C
        public enum PetBehaviourEnum {
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
        /* 0x0 */ public PetBehaviourEnum PetBehaviour;
    }
}
