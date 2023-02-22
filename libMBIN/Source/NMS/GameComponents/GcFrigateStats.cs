using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x59270EF7B973C889, NameHash = 0x38BD9FF11F2B46AB)]
    public class GcFrigateStats : NMSTemplate
    {
        [NMS(Size = 0xB, EnumType = typeof(GcFrigateStatType.FrigateStatTypeEnum))]
        /* 0x00 */ public GcFrigateStatRange[] Stats;
        /* 0x58 */ public NMSString0x10 InitialTrait;
    }
}
