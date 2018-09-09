namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x0AF3FFA464A170D62)]
    public class GcUniverseAddressData : NMSTemplate // 0x18 bytes
    {
        public int RealityIndex;

        public GcGalacticAddressData GalacticAddress;
    }
}
