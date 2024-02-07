using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6DA7841BE1EEF278, NameHash = 0x14A4B002ACBE8F35)]
    public class GcCostDiscovery : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A CostString;
        /* 0x20 */ public GcDiscoveryType DiscoveryType;
        /* 0x24 */ public int Index;
    }
}
