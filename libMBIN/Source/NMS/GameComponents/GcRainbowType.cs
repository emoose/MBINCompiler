namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB9CF7DBD6666BED1, NameHash = 0x71FCE9DED22FE107)]
    public class GcRainbowType : NMSTemplate
    {
        // size: 0x4
        public enum RainbowTypeEnum {
            Always,
            Occasional,
            Storm,
            None
        }
        /* 0x0 */ public RainbowTypeEnum RainbowType;
    }
}
