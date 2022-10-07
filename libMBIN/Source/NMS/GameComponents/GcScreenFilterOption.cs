using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBEBBE4C04ED4FE52, NameHash = 0x6EB06F604A27BFB1)]
    public class GcScreenFilterOption : NMSTemplate
    {
        /* 0x0 */ public GcScreenFilters Filter;
        /* 0x4 */ public float Weight;
    }
}
