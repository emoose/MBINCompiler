using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x4, GUID = 0xC2D7998D47E03F8E, NameHash = 0xECE6F42F8A522B34)]
    public class GcTeleporterType : NMSTemplate
    {
        // size: 0x9
		public enum TeleporterDestinationTypeEnum { Base, Spacestation, Atlas, PlanetAwayFromShip, ExternalBase, EmergencyGalaxyFix, OnNexus, SpacestationFixPosition, Settlement }
		public TeleporterDestinationTypeEnum TeleporterDestinationType;
    }
}
