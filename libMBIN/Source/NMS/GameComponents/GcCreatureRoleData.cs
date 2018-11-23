using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x550, GUID = 0xBD1B2070692ABD58)]
    public class GcCreatureRoleData : NMSTemplate
    {
        /* 0x000 */ public GcSeed Seed;
        /* 0x010 */ public GcCreatureTypes CreatureType;
        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding14;

        [NMS(Size = 0x10)]
        /* 0x018 */ public string CreatureId;
        /* 0x028 */ public GcCreatureRoleDescription Description;
        /* 0x088 */ public GcCreatureInfo Info;
        /* 0x520 */ public GcTerrainTileType TileType;
		public enum DietEnum { Carnivore, Omnivore, Herbivore }
		/* 0x524 */ public DietEnum Diet;
        /* 0x528 */ public float BaseScale;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x52C */ public byte[] Padding52C;
        [NMS(Size = 0x20)]
        /* 0x530 */ public string Filter;
    }
}
