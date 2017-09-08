namespace MBINCompiler.Models.Structs
{
    public class GcCreatureRoleFilename : NMSTemplate // 0x90 bytes
    {
        [NMS(Size = 0x80)]
        public string File;

        [NMS(Size = 4, EnumValue = new[] { "Dead", "Low", "Mid", "Full" })]
        public float[] BiomeProbability;
    }
}
