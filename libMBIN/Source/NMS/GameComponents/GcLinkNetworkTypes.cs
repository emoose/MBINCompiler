using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x4, GUID = 0x47C94EB32E85A057, NameHash = 0xA2D103E3C1ECFE30)]
    public class GcLinkNetworkTypes : NMSTemplate
    {
		public enum LinkNetworkTypeEnum { Power, Resources, Fuel, Portals, PlantGrowth, ByteBeat }
		public LinkNetworkTypeEnum LinkNetworkType;
    }
}