namespace libMBIN.Models.Structs
{
    public class GcBountySpawnInfo : NMSTemplate      // size: 0x188
    {
        [NMS(Size = 0x10)]
	    /* 0x000 */ public string Id;
        /* 0x010 */ public GcAIShipSpawnData Data;
        [NMS(Size = 0x10)]
        /* 0x0B8 */ public string AttackData;
        /* 0x0C8 */ public TkTextureResource Icon;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x14C */ public byte[] Padding14C;
        [NMS(Size = 0x20)]
        /* 0x150 */ public string Label;
        /* 0x170 */ public int Health;
        /* 0x174 */ public int LaserDamage;
        [NMS(Size = 0x10)]
        /* 0x178 */ public string Gun;
    }
}
