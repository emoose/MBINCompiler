namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x80830D4B25903A21, NameHash = 0x71FCE9DED22FE107)]
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
