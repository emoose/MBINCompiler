namespace MBINCompiler.Models.Structs
{
    public class GcTradeCategory : NMSTemplate
    {
        public int TradingClass;
        public string[] TradingClassValues()
        {
            return new[]
            {
                "Mineral", "Tech", "Commodity", "Component", "Alloy", "Exotic", "Energy", "None"
            };
        }
    }
}
