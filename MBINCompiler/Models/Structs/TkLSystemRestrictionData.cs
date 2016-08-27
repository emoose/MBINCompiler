namespace MBINCompiler.Models.Structs
{
    public class TkLSystemRestrictionData : NMSTemplate
    {
        public int Amount;
        public int Restriction;
        public string[] RestrictionValues()
        {
            return new[] { "NoMoreThan", "AtLeast", "AtLeastIfICan" };
        }
    }
}
