namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEF4E401F1B22979B, NameHash = 0x5BB97397B6B70C3A)]
    public class GcDiscoveryType : NMSTemplate
    {
        // size: 0x11
        public enum DiscoveryTypeEnum {
            Unknown,
            SolarSystem,
            Planet,
            Animal,
            Flora,
            Mineral,
            Sector,
            Building,
            Interactable,
            Sentinel,
            Starship,
            Artifact,
            Mystery,
            Treasure,
            Control,
            HarvestPlant,
            FriendlyDrone
        }
        /* 0x0 */ public DiscoveryTypeEnum DiscoveryType;
    }
}
