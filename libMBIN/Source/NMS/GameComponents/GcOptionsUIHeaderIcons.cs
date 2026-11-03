namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8B1AA27F7F927247, NameHash = 0x90014B83)]
    public class GcOptionsUIHeaderIcons : NMSTemplate
    {
        // size: 0x6
        public enum OptionsUIHeaderIconTypeEnum : uint {
            General,
            Ship,
            Cog,
            Scanner,
            Advanced,
            Cloud,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public OptionsUIHeaderIconTypeEnum OptionsUIHeaderIconType;
    }
}
