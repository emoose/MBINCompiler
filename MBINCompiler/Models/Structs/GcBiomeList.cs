namespace MBINCompiler.Models.Structs
{
    public class GcBiomeList : NMSTemplate
    {
        [NMS(Size = 9, EnumValue = new[] { "Lush", "Toxic", "Scorched", "Radioactive", "Frozen", "Barren", "Dead", "Test", "All" })]
        public float[] BiomeProbability;
    }
}
