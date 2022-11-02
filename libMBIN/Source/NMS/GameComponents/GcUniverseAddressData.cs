using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA89F2E8ED5D0325E, NameHash = 0x49FD8C968D7B338D)]
    public class GcUniverseAddressData : NMSTemplate
    {
        /* 0x0 */ public int RealityIndex;
        /* 0x4 */ public GcGalacticAddressData GalacticAddress;
    }
}
