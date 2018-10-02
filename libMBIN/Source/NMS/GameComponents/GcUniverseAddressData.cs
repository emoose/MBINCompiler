using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x18, GUID = 0xAF3FFA464A170D62)]
    public class GcUniverseAddressData : NMSTemplate
    {
        public int RealityIndex;

        public GcGalacticAddressData GalacticAddress;
    }
}
