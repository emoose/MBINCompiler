namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x29029AF7F48B0B91, NameHash = 0x5DD36840)]
    public class GcFossilCategory : NMSTemplate
    {
        // size: 0x5
        public enum FossilCategoryEnum : uint {
            None,
            Head,
            Body,
            Limb,
            Tail,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public FossilCategoryEnum FossilCategory;
    }
}
