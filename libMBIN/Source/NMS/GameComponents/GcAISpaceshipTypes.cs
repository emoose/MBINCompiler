using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x3334A797FE1A52A6)]
    public class GcAISpaceshipTypes : NMSTemplate
    {
		public enum ShipTypeEnum { None, Pirate, Police, Trader, Freighter }
		public ShipTypeEnum ShipType;
    }
}
