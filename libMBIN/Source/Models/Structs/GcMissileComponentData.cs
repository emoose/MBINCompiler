namespace libMBIN.Models.Structs
{
    public class GcMissileComponentData : NMSTemplate       // size: 0x28
    {
        [NMS(Size = 0x10)]
        /* 0x000 */ public string Explosion;
		/* 0x010 */ public float NoTargetLife;
        [NMS(Size = 0x10)]
		/* 0x018 */ public string Trail;
	}
}