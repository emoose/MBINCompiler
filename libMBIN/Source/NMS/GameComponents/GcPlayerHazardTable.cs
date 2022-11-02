using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA0E88479C3899F4D, NameHash = 0xCC978CCE3CFE915B)]
    public class GcPlayerHazardTable : NMSTemplate
    {
        [NMS(Size = 0x6, EnumType = typeof(GcPlayerHazardType.HazardEnum))]
        /* 0x0 */ public GcPlayerHazardData[] Table;
    }
}
