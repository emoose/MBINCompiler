namespace libMBIN.Models.Structs
{
    public class GcRealityCommonFactions : NMSTemplate
    {
        public int AIFaction;
        public string[] AIFactionValues()
        {
            return new[] { "FactionA", "FactionB", "FactionC", "FactionD", "Pirate", "Police" };
        }
    }
}
