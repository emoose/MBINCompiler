using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x39DD19F8C3BC9D2, NameHash = 0x5525EF02)]
    public class GcFrigateStatsByClass : NMSTemplate
    {
        [NMS(Index = 0, Size = 0xB, EnumType = typeof(GcFrigateClass.FrigateClassEnum))]
        /* 0x0 */ public GcFrigateStats[] FrigateClass;
    }
}
