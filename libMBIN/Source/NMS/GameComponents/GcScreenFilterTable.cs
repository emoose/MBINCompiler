using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB948329A7E854289, NameHash = 0xDDA2C2271A6ACA0B)]
    public class GcScreenFilterTable : NMSTemplate
    {
        [NMS(Size = 0x52, EnumType = typeof(GcScreenFilters.ScreenFilterEnum))]
        /* 0x0 */ public GcScreenFilterData[] Filters;
    }
}
