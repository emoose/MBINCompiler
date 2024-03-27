using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x679339A701CBDB74, NameHash = 0x49FD8C968D7B338D)]
    public class GcUniverseAddressData : NMSTemplate
    {
        /* 0x0 */ public int RealityIndex;
        /* 0x4 */ public GcGalacticAddressData GalacticAddress;
    }
}
