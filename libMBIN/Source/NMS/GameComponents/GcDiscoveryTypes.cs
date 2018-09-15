using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xA7ED10ECEA3158A)]
    public class GcDiscoveryTypes : NMSTemplate
    {
		public enum DiscoveryTypeEnum { Unknown, SolarSystem, Planet, Animal, Flora, Mineral, Sector, Building, Interactable, Sentinel, Starship, Artifact, Mystery, Treasure, Control }
		public DiscoveryTypeEnum DiscoveryType;
    }
}
