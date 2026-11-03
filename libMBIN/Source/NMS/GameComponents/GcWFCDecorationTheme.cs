namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBD710352AF708FBB, NameHash = 0xDE0BB566)]
    public class GcWFCDecorationTheme : NMSTemplate
    {
        // size: 0x5
        public enum WFCDecorationThemeEnum : uint {
            Default,
            Construction,
            Upgrade1,
            Upgrade2,
            Upgrade3,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public WFCDecorationThemeEnum WFCDecorationTheme;
    }
}
