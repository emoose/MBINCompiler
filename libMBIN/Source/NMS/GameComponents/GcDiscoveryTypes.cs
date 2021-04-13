using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x4, GUID = 0x0000000000000000, NameHash = 0x822DDBC250BAB267)]
    public class GcDiscoveryTypes : NMSTemplate
    {
        // 0x10 entries
        public enum DiscoveryTypeEnum {
            Unknown, SolarSystem, Planet, Animal, Flora, Mineral, Sector, Building, Interactable,
            Sentinel, Starship, Artifact, Mystery, Treasure, Control, HarvestPlant
        }
        public DiscoveryTypeEnum DiscoveryType;
    }
}