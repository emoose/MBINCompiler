using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x28CC15073F1FA524)]
    public class GcCreatureTypes : NMSTemplate
    {
		public enum CreatureTypeEnum { None, Bird, FlyingLizard, FlyingSnake, Butterfly, Beetle, Fish, Shark, Crab, Snake, Dino, Antelope, Rodent,
            Cat, Fiend, Drone, Quad, Walker, Predator, PlayerPredator, Prey, Passive, FishPredator, FishPrey, FiendFishSmall, FiendFishBig, Jellyfish,
            Brainless
        }
		public CreatureTypeEnum CreatureType;
    }
}
