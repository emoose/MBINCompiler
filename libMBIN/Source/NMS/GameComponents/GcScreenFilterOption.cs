using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD47B043E10E42D7B, NameHash = 0x6EB06F604A27BFB1)]
    public class GcScreenFilterOption : NMSTemplate
    {
        /* 0x0 */ public GcScreenFilters Filter;
        /* 0x4 */ public float Weight;
    }
}
