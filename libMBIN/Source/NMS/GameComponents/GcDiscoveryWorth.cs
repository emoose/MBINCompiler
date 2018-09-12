namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x7C02623F66277A41)]
    public class GcDiscoveryWorth : NMSTemplate     // size: 0x1C
    {
        [NMS(Size = 0x3)]
        public int[] Record;
        [NMS(Size = 0x3)]
        public int[] OnScan;
        public int Mission;
    }
}
