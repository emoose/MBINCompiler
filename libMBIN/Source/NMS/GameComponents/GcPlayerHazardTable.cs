using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x26E4520AD82CB4BF, NameHash = 0xA6C1713F)]
    public class GcPlayerHazardTable : NMSTemplate
    {
        [NMS(Index = 0, Size = 0x7, EnumType = typeof(GcPlayerHazardType.HazardEnum))]
        /* 0x0 */ public GcPlayerHazardData[] Table;
    }
}
