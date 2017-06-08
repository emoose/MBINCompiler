namespace MBINCompiler.Models.Structs
{
    public class GcMessageProjectileImpact: NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Id;
        public int Damage;
        public int Hit;
        public string[] HitValues()
        {
            return new[]
            {"Shootable", "Terrain", "Generic"};
        }
        public Vector4f PosLocal;
        public Vector4f PosOffset;
    }
}
