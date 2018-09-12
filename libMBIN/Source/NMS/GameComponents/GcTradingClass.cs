namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x907C3AD8EF881E53)]
    public class GcTradingClass : NMSTemplate
    {
		public enum TradingClassEnum { Mining, HighTech, Trading, Manufacturing, Fusion, Scientific, PowerGeneration }
		public TradingClassEnum TradingClass;
    }
}
