namespace MBINCompiler.Models.Structs
{
    public class GcShootableComponentData : NMSTemplate
    {
        /* 0x00 */ 	public int Health;
		/* 0x04 */	public bool AutoAimTarget;
		/* 0x05 */ 	public bool PlayerOnly;
		/* 0x06 */ 	public bool ImpactShake;
					[NMS(Size = 1, Ignore = true)]
		/* 0x07 */	public byte[] Padding7;
					[NMS(Size = 0x10)]
		/* 0x08 */	public string ImpactShakeEffect;

		/* 0x18 */	public GcProjectileImpactType ForceImpactType;
		/* 0x1C */	public int IncreaseWanted;
		/* 0x20 */	public float IncreaseWantedThresholdTime;
		/* 0x24 */	public bool UseMiningDamage;
		/* 0x28 */	public int MinDamage;
		/* 0x2C */	public bool StaticUntilShot;

					[NMS(Size = 3, Ignore = true)]
					public byte[] Padding2D;

					[NMS(Size = 0x10)]
		/* 0x30 */	public string RequiredTech;

    }
}
