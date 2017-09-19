namespace libMBIN.Models.Structs
{
    public class GcTradingClass : NMSTemplate
    {
        public int TradingClass;
        public string[] TradingClassValues()
        {
            return new[] { "Mining", "HighTech", "Trading", "Manufacturing", "Fusion", "Scientific", "PowerGeneration"};
        }
    }
}
