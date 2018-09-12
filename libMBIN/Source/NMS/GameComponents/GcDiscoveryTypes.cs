namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x0A7ED10ECEA3158A)]
    public class GcDiscoveryTypes : NMSTemplate
    {
		public enum DiscoveryTypeEnum { Unknown, SolarSystem, Planet, Animal, Flora, Mineral, Sector, Building, Interactable, Sentinel, Starship, Artifact, Mystery, Treasure, Control }
		public DiscoveryTypeEnum DiscoveryType;
    }
}
