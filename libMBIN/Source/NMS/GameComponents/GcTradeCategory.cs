namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x20E6BAB72D11127C, NameHash = 0xABEDBCE191703616)]
    public class GcTradeCategory : NMSTemplate
    {
        // size: 0x9
        public enum TradeCategoryEnum {
            Mineral,
            Tech,
            Commodity,
            Component,
            Alloy,
            Exotic,
            Energy,
            None,
            SpecialShop
        }
        /* 0x0 */ public TradeCategoryEnum TradeCategory;
    }
}
