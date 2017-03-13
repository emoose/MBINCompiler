namespace MBINCompiler.Models.Structs
{
    public class GcSolarGenerationGlobals : NMSTemplate
    {
        /* 0x0 */ public bool Unknown0;
        /* 0x4 */ public float Unknown4;
        /* 0x8 */ public float Unknown8;
        /* 0xC */ public float UnknownC;
        /* 0x10 */ public float Unknown10;
        /* 0x14 */ public float Unknown14;
        /* 0x18 */ public float Unknown18;
        /* 0x1C */ public float Unknown1C;
        /* 0x20 */ public float MinPlanetDistance;
        /* 0x24 */ public float MaxPlanetDistance;
        /* 0x28 */ public bool Unknown28;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x29 */ public byte[] Padding29;
        /* 0x2C */ public float Unknown2C;      // possibly meant to be 4 bytes as padding at end of struct?
        /* 0x30 */ public bool Unknown30;
        /* 0x34 */ public float Unknown34;
        /* 0x38 */ public float Unknown38;
        /* 0x3C */ public float Unknown3C;
        /* 0x40 */ public float Unknown40;
        /* 0x44 */ public float Unknown44;
        /* 0x48 */ public float Unknown48;
        /* 0x4C */ public float Unknown4C;
        /* 0x50 */ public float Unknown50;
        /* 0x54 */ public int UnknownInt54;
        /* 0x58 */ public int UnknownInt58;
        /* 0x5C */ public float Unknown5C;
        /* 0x60 */ public int UnknownInt60;
        /* 0x64 */ public int UnknownInt64;
        /* 0x68 */ public float Unknown68;
        /* 0x6C */ public float Unknown6C;
        /* 0x70 */ public float AsteroidMinDistanceFromPlanets;
        /* 0x74 */ public int UnknownInt74;
        /* 0x78 */ public float AsteroidNoiseDistribution;
        /* 0x7C */ public float AsteroidSpreadDistribution;
        /* 0x80 */ public int UnknownInt80;
        /* 0x84 */ public float Unknown84;
        /* 0x88 */ public float Unknown88;
        /* 0x8C */ public float AsteroidRotationXSpeed;
        /* 0x90 */ public float AsteroidRotationYSpeed;
        /* 0x94 */ public float SmallAsteroidScaleVariance;
        /* 0x98 */ public float Unknown98;
        /* 0x9C */ public float Unknown9C;
        /* 0xA0 */ public float UnknownA0;
        /* 0xA4 */ public float UnknownA4;
        /* 0xA8 */ public float UnknownA8;
        /* 0xAC */ public float UnknownAC;
        /* 0xB0 */ public float UnknownB0;
        /* 0xB4 */ public float UnknownB4;
        /* 0xB8 */ public float UnknownB8;
        /* 0xBC */ public float UnknownBC;
        /* 0xC0 */ public float UnknownC0;
        /* 0xC4 */  public float UnknownC4;
        /* 0xC8 */ public float UnknownC8;
        /* 0xCC */ public float UnknownCC;
        /* 0xD0 */ public float UnknownD0;
        /* 0xD4 */ public float UnknownD4;
        /* 0xD8 */ public float UnknownD8;
        /* 0xDC */ public float UnknownDC;
        /* 0xE0 */ public float UnknownE0;
        /* 0xE4 */ public int UnknownIntE4;
        /* 0xE8 */ public int UnknownIntE8;
        /* 0xEC */ public float UnknownEC;      // 4 bytes of padding?

        [NMS(Size = 0x10)]
        /* 0xF0 */ public string SpecialAsteroidDroppedItem;

        /* 0x100 */ public int UnknownInt100;
        /* 0x104 */ public float Unknown104;
        /* 0x108 */ public int UnknownInt108;
        /* 0x10C */ public int UnknownInt10C;

        [NMS(Size = 0x10)]
        /* 0x110 */ public string SmallAsteroid1DroppedItem;
        [NMS(Size = 0x10)]
        /* 0x120 */ public string SmallAsteroid2DroppedItem;

        /* 0x130 */ public float Unknown130;
        /* 0x134 */ public int UnknownInt134;
        /* 0x138 */ public float Unknown138;
        /* 0x13C */ public float Unknown13C;
        /* 0x140 */ public float Unknown140;
        /* 0x144 */ public float Unknown144;
        /* 0x148 */ public float Unknown148;
        /* 0x14C */ public int UnknownInt14C;
        /* 0x150 */ public float Unknown150;
        /* 0x154 */ public float Unknown154;
        /* 0x158 */ public float Unknown158;
        
        // totally hypothetical...
        [NMS(Size = 0x5)]
        /* 0x15C */ public GcGeneratedShipCounts[] Unknown15C;

        /*
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
        public float SmallAsteroidFadeIn;
        public float SmallAsteroidZoomIn;
        public float SmallAsteroidSpacing;

        public float SpecialAsteroidScale;
        public int SpecialAsteroidDropMin;
        public int SpecialAsteroidDropMax;
        public int UnknownEC;

        [NMS(Size = 0x10)]
        public string SpecialAsteroidDroppedItem;

        public int Unknown100;
        public float SmallAsteroidScale;
        public int SmallAsteroidDropMin;
        public int SmallAsteroidDropMax;

        [NMS(Size = 0x10)]
        public string SmallAsteroid1DroppedItem;

        [NMS(Size = 0x10)]
        public string SmallAsteroid2DroppedItem;

        public float Unknown130;
        public int Unknown134;
        public float LargeAsteroidSpacing;
        public float Unknown13C;

        public float LargeAsteroidZoomInner;
        public float LargeAsteroidZoomOuter;
        public float Unknown148;
        public int Unknown14C;

        public float AsteroidMinDistanceFromSpacestation; //?(minimum asteroid distance from space station?)
        public float Unknown154; //?(minimum asteroid distance from space station?)
        public float Unknown158; //?(minimum asteroid distance from anomaly or black hole?)


        [NMS(Size = 0xB)]
        public Vector3i[] Unknown15C;*/

    }
}
