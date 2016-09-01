namespace MBINCompiler.Models.Structs
{
    public class GcShootableComponentData : NMSTemplate
    {
        public int Health;
        public bool AutoAimTarget;
        public bool PlayerOnly;
        public bool ImpactShake;
        [NMS(Size = 1, Ignore = true)]
        public byte[] Padding7;
        [NMS(Size = 0x10)]
        public string ImpactShakeEffect;

        public GcProjectileImpactType ImpactType;
        public int IncreaseWanted;
        public float IncreaseWantedThresholdTime;
        public bool UseMiningDamage;
        public int MinDamage;
        public bool StaticUntilShot;
    }
}
