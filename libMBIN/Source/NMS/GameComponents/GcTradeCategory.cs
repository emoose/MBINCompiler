namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFA160E0C402E2DCA, NameHash = 0xABEDBCE191703616)]
    public class GcTradeCategory : NMSTemplate
    {
        // size: 0x9
        public enum TradeCategoryEnum : uint {
            Mineral,
            Tech,
            Commodity,
            Component,
            Alloy,
            Exotic,
            Energy,
            None,
            SpecialShop,
        }
        /* 0x0 */ public TradeCategoryEnum TradeCategory;
    }
}
