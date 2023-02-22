using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC6BEB0DF9D15CFF8, NameHash = 0x89CF360B576FF51D)]
    public class GcFrigateStatsByClass : NMSTemplate
    {
        [NMS(Size = 0x8, EnumType = typeof(GcFrigateClass.FrigateClassEnum))]
        /* 0x0 */ public GcFrigateStats[] FrigateClass;
    }
}
