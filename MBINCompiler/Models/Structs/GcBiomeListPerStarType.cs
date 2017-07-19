namespace MBINCompiler.Models.Structs
{
    public class GcBiomeListPerStarType : NMSTemplate
    {
        [NMS(Size = 4, EnumValue = new[] { "Yellow", "Green", "Blue", "Red" })]
        public GcBiomeList[] StarType;

        [NMS(Size = 4, EnumValue = new[] { "Yellow", "Green", "Blue", "Red" })]
        public float[] LifeChance;
    }
}
