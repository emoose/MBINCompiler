namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB98C55A6C56654A5, NameHash = 0x17AE5B83C6E9DF12)]
    public class GcCurrency : NMSTemplate
    {
        // size: 0x3
        public enum CurrencyEnum {
            Units,
            Nanites,
            Specials
        }
        /* 0x0 */ public CurrencyEnum Currency;
    }
}
