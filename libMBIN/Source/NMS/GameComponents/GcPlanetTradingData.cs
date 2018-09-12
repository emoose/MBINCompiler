using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x9C7E079488671B73)]
    public class GcPlanetTradingData : NMSTemplate
    {
        public GcWealthClass WealthClass;
        public GcTradingClass TradingClass;
    }
}
