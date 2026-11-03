namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD799D8454EC319A9, NameHash = 0x9DDD3EFC)]
    public class GcRainbowType : NMSTemplate
    {
        // size: 0x4
        public enum RainbowTypeEnum : uint {
            Always,
            Occasional,
            Storm,
            None,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public RainbowTypeEnum RainbowType;
    }
}
