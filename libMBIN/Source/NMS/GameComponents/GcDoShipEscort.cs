using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x122643798D35042D, NameHash = 0x68C0F45A086C1EB)]
    public class GcDoShipEscort : NMSTemplate
    {
        /* 0x00 */ public bool MatchRole;
        /* 0x04 */ public GcAISpaceshipRoles EscortTargetShipRole;
        /* 0x08 */ public bool MatchFaction;
        /* 0x0C */ public GcRealityCommonFactions EscortTargetShipFaction;
        /* 0x10 */ public bool MatchType;
        /* 0x14 */ public GcAISpaceshipTypes EscortTargetShipType;
        /* 0x18 */ public float MaxSearchDistance;
    }
}
