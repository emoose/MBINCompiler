namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7B2D9A6596FA27E7, NameHash = 0xF3305117)]
    public class GcCreatureSizeClasses : NMSTemplate
    {
        // size: 0x4
        public enum CreatureSizeClassEnum : uint {
            Small,
            Medium,
            Large,
            Huge,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public CreatureSizeClassEnum CreatureSizeClass;
    }
}
