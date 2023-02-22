namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5DCE73A49D1173FF, NameHash = 0x17AE5B83C6E9DF12)]
    public class GcCurrency : NMSTemplate
    {
        // size: 0x3
        public enum CurrencyEnum {
            Units,
            Nanites,
            Specials,
        }
        /* 0x0 */ public CurrencyEnum Currency;
    }
}
