namespace libMBIN.Models.Structs
{
    public class GcBiomeList : NMSTemplate
    {
        [NMS(Size = 0xA, EnumValue = new[] { "Lush", "Toxic", "Scorched", "Radioactive", "Frozen", "Barren", "Dead", "Weird", "Test", "All" })]
        public float[] BiomeProbability;
    }
}
