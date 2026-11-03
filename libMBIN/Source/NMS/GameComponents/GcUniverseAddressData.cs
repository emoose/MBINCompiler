using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xADE746876A23AD3, NameHash = 0x3AB38D4F)]
    public class GcUniverseAddressData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public GcGalacticAddressData GalacticAddress;
        [NMS(Index = 0)]
        /* 0x14 */ public int RealityIndex;
    }
}
