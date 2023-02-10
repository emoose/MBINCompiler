namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA6C2BFDC5CB8D8D4, NameHash = 0x9E3AE80CF84700A6)]
    public class GcTradingClass : NMSTemplate
    {
        // size: 0x7
        public enum TradingClassEnum {
            Mining,
            HighTech,
            Trading,
            Manufacturing,
            Fusion,
            Scientific,
            PowerGeneration,
        }
        /* 0x0 */ public TradingClassEnum TradingClass;
    }
}
