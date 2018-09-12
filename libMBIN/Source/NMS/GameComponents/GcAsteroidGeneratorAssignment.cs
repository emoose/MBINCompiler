namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x0EC29C33F72A89F71)]
    public class GcAsteroidGeneratorAssignment : NMSTemplate // 0x48 bytes
    {
        /* 0x00 */ public int PlanetIndex;
        /* 0x04 */ public GcSolarSystemLocatorChoice Locator;
        /* 0x30 */ public GcSeed Seed;
        /* 0x40 */ public int AsteroidCount;

        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding44;
    }
}
