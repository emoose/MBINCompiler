namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x208C750E2351B660, NameHash = 0xABEDBCE191703616)]
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
