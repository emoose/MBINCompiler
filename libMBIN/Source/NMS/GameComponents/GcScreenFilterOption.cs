using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4821339A8DAE4938, NameHash = 0x4F0CAB14)]
    public class GcScreenFilterOption : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcScreenFilters Filter;
        [NMS(Index = 1)]
        /* 0x4 */ public float Weight;
    }
}
