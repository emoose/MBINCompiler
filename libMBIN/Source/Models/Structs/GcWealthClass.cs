namespace libMBIN.Models.Structs
{
    public class GcWealthClass : NMSTemplate
    {
        public int WealthClass;
        public string[] WealthClassValues()
        {
            return new[]
            {
                "Poor", "Average", "Wealthy"
            };
        }
    }
}
