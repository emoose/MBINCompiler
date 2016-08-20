namespace MBINCompiler.Models.Structs
{
    public class GcRealitySubstanceCategory : NMSTemplate
    {
        public int SubstanceCategory;

        public string[] SubstanceCategoryValues()
        {
            return new[] { "Commodity", "Technology", "Fuel", "Tradeable", "Special", "None" };
        }
    }
}
