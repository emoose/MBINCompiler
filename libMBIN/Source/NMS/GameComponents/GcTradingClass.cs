namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6AC640EA2C57ED71, NameHash = 0x5E67C2D5)]
    public class GcTradingClass : NMSTemplate
    {
        // size: 0x7
        public enum TradingClassEnum : uint {
            Mining,
            HighTech,
            Trading,
            Manufacturing,
            Fusion,
            Scientific,
            PowerGeneration,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public TradingClassEnum TradingClass;
    }
}
