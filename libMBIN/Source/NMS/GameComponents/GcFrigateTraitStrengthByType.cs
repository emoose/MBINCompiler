using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDC23CE27CCA5C65, NameHash = 0x648038E6)]
    public class GcFrigateTraitStrengthByType : NMSTemplate
    {
        [NMS(Index = 0, Size = 0xB, EnumType = typeof(GcFrigateStatType.FrigateStatTypeEnum))]
        /* 0x0 */ public GcFrigateTraitStrengthValues[] FrigateStatType;
    }
}
