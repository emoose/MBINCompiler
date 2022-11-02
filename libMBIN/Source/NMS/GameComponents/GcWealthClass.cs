namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC6714162CD207FCF, NameHash = 0xC0B928F5E2599F60)]
    public class GcWealthClass : NMSTemplate
    {
        // size: 0x4
        public enum WealthClassEnum {
            Poor,
            Average,
            Wealthy,
            Pirate
        }
        /* 0x0 */ public WealthClassEnum WealthClass;
    }
}
