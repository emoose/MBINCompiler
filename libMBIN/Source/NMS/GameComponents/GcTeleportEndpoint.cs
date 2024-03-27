using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEA4F0B98C8572FC, NameHash = 0x18CD621AAAB1F01D)]
    public class GcTeleportEndpoint : NMSTemplate
    {
        /* 0x00 */ public GcUniverseAddressData UniverseAddress;
        /* 0x20 */ public Vector3f Position;
        /* 0x30 */ public Vector3f Facing;
        // size: 0xB
        public enum TeleporterTypeEnum : uint {
            Base,
            Spacestation,
            Atlas,
            PlanetAwayFromShip,
            ExternalBase,
            EmergencyGalaxyFix,
            OnNexus,
            SpacestationFixPosition,
            Settlement,
            Freighter,
            Frigate,
        }
        /* 0x40 */ public TeleporterTypeEnum TeleporterType;
        /* 0x44 */ public NMSString0x40 Name;
        /* 0x84 */ public bool CalcWarpOffset;
        /* 0x85 */ public bool IsFeatured;
    }
}
