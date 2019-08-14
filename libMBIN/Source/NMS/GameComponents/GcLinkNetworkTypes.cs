using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xED49E3AD3DF42E36)]
    public class GcLinkNetworkTypes : NMSTemplate
    {
		public enum LinkNetworkTypeEnum { Power, Resources, Fuel, Portals, PlantGrowth }
		public LinkNetworkTypeEnum LinkNetworkType;
    }
}
