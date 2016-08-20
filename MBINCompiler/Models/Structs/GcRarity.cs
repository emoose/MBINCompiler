namespace MBINCompiler.Models.Structs
{
    public class GcRarity : NMSTemplate
    {
        public int Rarity;

        public string[] RarityValues()
        {
            return new[] { "Common", "Uncommon", "Rare", "Extraordinary", "None" };
        }
    }
}
