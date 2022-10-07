namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA772B6C83888BE82, NameHash = 0x3C7F32FAD34D5752)]
    public class GcOutpostLSystemPair : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20 Locator;
        // size: 0x8
        public enum LSystemsEnum {
            Traders,
            Warriors,
            Explorers,
            Robots,
            Atlas,
            Diplomats,
            Exotics,
            None
        }
        [NMS(Size = 0x8, EnumType = typeof(LSystemsEnum))]
        /* 0x20 */ public NMSString0x80[] LSystems;
    }
}
