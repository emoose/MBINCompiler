namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8C899F6753122857, NameHash = 0xB113E9A825921723)]
    public class GcCreatureSizeClasses : NMSTemplate
    {
        // size: 0x4
        public enum CreatureSizeClassEnum {
            Small,
            Medium,
            Large,
            Huge,
        }
        /* 0x0 */ public CreatureSizeClassEnum CreatureSizeClass;
    }
}
