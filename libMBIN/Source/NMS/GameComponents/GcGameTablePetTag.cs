namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1A1EE2ED70E6457C, NameHash = 0xC1625EFC)]
    public class GcGameTablePetTag : NMSTemplate
    {
        // size: 0x20
        public enum PetTagEnum : uint {
            None = 0x0,
            Arachnid = 0x1,
            Arthropod = 0x2,
            Biped = 0x4,
            Blob = 0x8,
            Bone = 0x10,
            Building = 0x20,
            Carnivore = 0x40,
            Claws = 0x80,
            Detritivore = 0x100,
            Eye = 0x200,
            Feline = 0x400,
            Flying = 0x800,
            Glowing = 0x1000,
            Ground = 0x2000,
            HasTail = 0x4000,
            Herbivore = 0x8000,
            Hexapod = 0x10000,
            Pincers = 0x20000,
            Plant = 0x40000,
            Pollinator = 0x80000,
            Quadruped = 0x100000,
            Reptile = 0x200000,
            Robotic = 0x400000,
            Roller = 0x800000,
            Saurian = 0x1000000,
            Shell = 0x2000000,
            Spike = 0x4000000,
            Stinger = 0x8000000,
            Stone = 0x10000000,
            Weird = 0x20000000,
            Worm = 0x40000000,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public PetTagEnum PetTag;
    }
}
