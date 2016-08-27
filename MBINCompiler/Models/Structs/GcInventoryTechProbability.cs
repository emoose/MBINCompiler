namespace MBINCompiler.Models.Structs
{
    public class GcInventoryTechProbability : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Tech;
        public int DesiredTechProbability;
        public string[] DesiredTechProbabilityValues()
        {
            return new[] { "Never", "Rare", "Common", "Always" };
        }
        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding14;
    }
}
