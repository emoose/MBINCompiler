namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x797750263163EC35, NameHash = 0x9634E2763C4B5D4D)]
    public class GcWFCDecorationTheme : NMSTemplate
    {
        // size: 0x2
        public enum WFCDecorationThemeEnum {
            Default,
            Construction
        }
        /* 0x0 */ public WFCDecorationThemeEnum WFCDecorationTheme;
    }
}
