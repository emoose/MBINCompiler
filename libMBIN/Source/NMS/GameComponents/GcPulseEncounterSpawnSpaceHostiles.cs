using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC3E5374D9775B0A6, NameHash = 0x203F104657EA616)]
    public class GcPulseEncounterSpawnSpaceHostiles : NMSTemplate
    {
        /* 0x000 */ public GcResourceElement CustomShipResource;
        /* 0x2A8 */ public int NumberOfShips;
        /* 0x2B0 */ public NMSString0x10 AttackDefinition;
    }
}
