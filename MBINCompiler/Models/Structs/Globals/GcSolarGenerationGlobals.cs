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
        /* 0x20 */ public float MinSolarSystemScale;        // ??
        /* 0x24 */ public float MaxSolarSystemScale;        // ??
        /* 0x28 */ public bool Unknown28;
        [NMS(Size = 0x3, Ignore = true)]
        /* 0x29 */ public byte[] Padding29;
        /* 0x2C */ public float Unknown2C;      // possibly meant to be 4 bytes as padding at end of struct? or padding before start??
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
        /* 0x74 */ public bool Unknown74;
        /* 0x75 */ public bool Unknown75;
        [NMS(Size = 0x2, Ignore = true)]
        /* 0x76 */ public byte[] Padding76;
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
        /* 0xD4 */ public float SmallAsteroidFadeIn;
        /* 0xD8 */ public float SmallAsteroidZoomIn;
        /* 0xDC */ public float SmallAsteroidSpacing;
        /* 0xE0 */ public float SpecialAsteroidScale;
        /* 0xE4 */ public int SpecialAsteroidDropMin;
        /* 0xE8 */ public int SpecialAsteroidDropMax;
        /* 0xEC */ public float UnknownEC;      // 4 bytes of padding?

        [NMS(Size = 0x10)]
        /* 0xF0 */ public string SpecialAsteroidDroppedItem;

        /* 0x100 */ public int UnknownInt100;
        /* 0x104 */ public float SmallAsteroidScale;
        /* 0x108 */ public int SmallAsteroidDropMin;
        /* 0x10C */ public int SmallAsteroidDropMax;

        [NMS(Size = 0x10)]
        /* 0x110 */ public string SmallAsteroid1DroppedItem;
        [NMS(Size = 0x10)]
        /* 0x120 */ public string SmallAsteroid2DroppedItem;

        /* 0x130 */ public float Unknown130;
        /* 0x134 */ public int UnknownInt134;
        /* 0x138 */ public float LargeAsteroidSpacing;
        /* 0x13C */ public float Unknown13C;
        /* 0x140 */ public float LargeAsteroidZoomInner;
        /* 0x144 */ public float LargeAsteroidZoomOuter;
        /* 0x148 */ public float Unknown148;
        /* 0x14C */ public int UnknownInt14C;
        /* 0x150 */ public float AsteroidMinDistanceFromSpacestation;
        /* 0x154 */ public float Unknown154;
        /* 0x158 */ public float Unknown158;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x15C */ public byte[] Padding15C;
        /* 0x160 */ public float Unknown160;
        /* 0x164 */ public float Unknown164;
        /* 0x168 */ public float Unknown168;
        /* 0x16C */ public float Unknown16C;
        /* 0x170 */ public float Unknown170;
        /* 0x174 */ public float Unknown174;
        /* 0x178 */ public float Unknown178;
        /* 0x17C */ public int ShipVariationsPerSystem;
        /* 0x180 */ public float Unknown180;
        /* 0x184 */ public float Unknown184;
        /* 0x188 */ public float Unknown188;

        [NMS(Size = 0x7)]
        /* 0x18C */ public GcAISpaceshipWeightingData[] Unknown18C;
    }
}
