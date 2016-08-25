namespace MBINCompiler.Models.Structs
{
    public class GcProjectileImpactData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Effect;
        public GcProjectileImpactType ImpactType;
        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding14;
    }
}
