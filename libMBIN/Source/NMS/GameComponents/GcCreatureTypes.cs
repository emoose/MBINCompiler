namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3D4825D78C2A288A, NameHash = 0xF848BA9A5DFC4197)]
    public class GcCreatureTypes : NMSTemplate
    {
        // size: 0x2F
        public enum CreatureTypeEnum {
            None,
            Bird,
            FlyingLizard,
            FlyingSnake,
            Butterfly,
            FlyingBeetle,
            Beetle,
            Fish,
            Shark,
            Crab,
            Snake,
            Dino,
            Antelope,
            Rodent,
            Cat,
            Fiend,
            Drone,
            Quad,
            Walker,
            Predator,
            PlayerPredator,
            Prey,
            Passive,
            FishPredator,
            FishPrey,
            FiendFishSmall,
            FiendFishBig,
            Jellyfish,
            LandJellyfish,
            RockCreature,
            MiniFiend,
            Floater,
            Scuttler,
            Slug,
            MiniDrone,
            SpaceFloater,
            Weird,
            SeaSnake,
            SandWorm,
            ProtoRoller,
            ProtoFlyer,
            ProtoDigger,
            Plough,
            Digger,
            Drill,
            Brainless,
            Pet,
        }
        /* 0x0 */ public CreatureTypeEnum CreatureType;
    }
}
