namespace MBINCompiler.Models.Structs
{
    public class GcTechnologyCategory : NMSTemplate
    {
        public int Category;

        public string[] CategoryValues()
        {
            return new[] { "Ship", "Weapon", "Suit", "Personal", "All" };
        }
    }
}
