namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x0BCC12AC4DCFC035C)]
    public class GcTradeCategory : NMSTemplate
    {
		public enum TradingClassEnum { Mineral, Tech, Commodity, Component, Alloy, Exotic, Energy, None }
		public TradingClassEnum TradingClass;
    }
}
