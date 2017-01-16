namespace MBINCompiler.Models.Structs
{
    public class GcSolarGenerationGlobals : NMSTemplate
    {
        public bool Unknown0;    //?(if false player spawns in space)

        [NMS(Size = 0xF, Ignore = true)]
        public byte[] Padding1;

        public float Unknown10;
        public float Unknown14;
        public float Unknown18; // unused? 
        public float Unknown1C; // unused? 

        public float MinPlanetDistance;
        public float MaxPlanetDistance;
        public bool Unknown28; // unused?
        public float Unknown2C; // unused?

        public bool Unknown30;
        public float Unknown34; // unused?
        public float Unknown38; // unused?
        public float Unknown3C;

        public float Unknown40; // unused?
        public float Unknown44;
        public float Unknown48;
        public float Unknown4C;

        public float Unknown50;
        public int Unknown54;
        public int Unknown58;
        public float Unknown5C;

        public int Unknown60;
        public int Unknown64;
        public float Unknown68;
        public float Unknown6C;

        public float AsteroidMinDistanceFromPlanets;  //0x70
        public int Unknown74;	//?(no asteroids if false) // was bool, now value=0x00000101 //may be several bools in DWORD
        public float AsteroidNoiseDistribution; //0x78 (lower values increase spread)
        public float AsteroidSpreadDistribution; //0x7C (lower values increase spread)

        public int Unknown80;   //?(500 creates large asteroids everywhere, 50 no asteroids)
        public float Unknown84; // unused?
        public float Unknown88; // unused?
        public float AsteroidRotationXSpeed; //0x8C

        public float AsteroidRotationYSpeed; //0x90
        public float SmallAsteroidScaleVariance; //0x94

        public float Unknown98;
        public float Unknown9C;

        public float UnknownA0;
        public float UnknownA4;
        public float UnknownA8;
        public float UnknownAC;

        public float UnknownB0;
        public float UnknownB4;
        public float UnknownB8;
        public float UnknownBC;

        public float UnknownC0;
        public float UnknownC4;
        public float UnknownC8;
        public float UnknownCC;

        public float UnknownD0;
        public float UnknownD4;
        public float UnknownD8;
        public float UnknownDC;

        public float UnknownE0;
        public int UnknownE4;
        public int UnknownE8;
        public int UnknownEC;

        [NMS(Size = 0x10)]
        public string UnknownAsteroidDroppedItem;

        public int Unknown100;
        public float Unknown104;
        public int Unknown108;
        public int Unknown10C;

        [NMS(Size = 0x10)]
        public string SmallAsteroidDroppedItem;

        [NMS(Size = 0x10)]
        public string OtherAsteroidDroppedItem;

        public float Unknown130;
        public int Unknown134;
        public float Unknown138;
        public float Unknown13C;

        public float Unknown140;
        public float Unknown144;
        public float Unknown148;
        public int Unknown14C;

        public float Unknown150; //?(minimum asteroid distance from space station?)
        public float Unknown154; //?(minimum asteroid distance from space station?)
        public float Unknown158; //?(minimum asteroid distance from anomaly or black hole?)


        [NMS(Size = 0xB)]
        public Vector3i[] Unknown15C;

    }
}
