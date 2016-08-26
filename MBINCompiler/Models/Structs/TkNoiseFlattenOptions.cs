namespace MBINCompiler.Models.Structs
{
    public class TkNoiseFlattenOptions : NMSTemplate
    {
        public int Flattening;
        public string[] FlatteningOptions()
        {
            return new[] { "None", "Natural", "Artificial", "AddResource" };
        }

        public int WaterPlacement;
        public string[] WaterPlacementOptions()
        {
            return new[] { "None", "Underwater" };
        }
    }
}
