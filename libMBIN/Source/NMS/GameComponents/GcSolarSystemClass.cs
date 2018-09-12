using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x5AC84A35CBFF4798)]
    public class GcSolarSystemClass : NMSTemplate
    {
		public enum SolarSystemClassEnum { Default, Initial, Anomaly, GameStart }
		public SolarSystemClassEnum SolarSystemClass;
    }
}
