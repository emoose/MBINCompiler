namespace MBINCompiler.Models.Structs
{
    public class GcInventoryClass : NMSTemplate
    {
        public int InventoryClass;
        public string[] InventoryValues()
        {
            return new[] { "C", "Unnamed1", "Unnamed2", "S" };
        }
    }
}
