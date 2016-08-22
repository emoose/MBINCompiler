namespace MBINCompiler.Models.Structs
{
    public class GcProductTypes : NMSTemplate
    {
        public int Type;

        public string[] TypeValues()
        {
            return new[] { "Component", "Device", "Consumable", "Curiosity" };
        }
    }
}
