namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x1BC94BF642962D39, NameHash = 0x94AA3A9F)]
    public class GcCurrency : NMSTemplate
    {
        // size: 0x3
        public enum CurrencyEnum : uint {
            Units,
            Nanites,
            Specials,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public CurrencyEnum Currency;
    }
}
