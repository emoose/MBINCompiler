namespace MBINCompiler.Models.Structs
{
    public class GcBiomeListPerStarType : NMSTemplate
    {
        [NMS(Size = 4)]
        public GcBiomeList[] StarType;

        [NMS(Size = 4)]
        public float[] LifeChance;
    }
}
