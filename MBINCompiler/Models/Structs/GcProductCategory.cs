namespace MBINCompiler.Models.Structs
{
    public class GcProductCategory : NMSTemplate
    {
        public int ProductCategory;

        public string[] ProductCategoryValues()
        {
            return new[] { "Component", "Device", "Consumable", "Curiousity", "Generic", "None" };
        }
    }
}
