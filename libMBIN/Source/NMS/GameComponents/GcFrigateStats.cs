using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB77D0A7047860881, NameHash = 0xDA87138A)]
    public class GcFrigateStats : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x10 InitialTrait;
        [NMS(Index = 0, Size = 0xB, EnumType = typeof(GcFrigateStatType.FrigateStatTypeEnum))]
        /* 0x10 */ public GcFrigateStatRange[] Stats;
    }
}
