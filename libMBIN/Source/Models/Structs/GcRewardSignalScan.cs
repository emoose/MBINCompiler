namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x0CA1A08C2974D9E1)]
    public class GcRewardSignalScan : NMSTemplate
    {
		public enum SignalScanTypeEnum { None, DropPod, Shelter, Search, Relic, Industrial, Alien, CrashedFreighter }
		public SignalScanTypeEnum SignalScanType;
    }
}
