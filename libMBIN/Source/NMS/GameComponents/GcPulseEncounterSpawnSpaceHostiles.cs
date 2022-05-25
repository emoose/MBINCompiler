using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x2C0, GUID = 0xD5108A36B91C178, NameHash = 0x203F104657EA616)]
    public class GcPulseEncounterSpawnSpaceHostiles : NMSTemplate
    {
        /* 0x000 */ public GcResourceElement CustomShipResource;
        /* 0x2A8 */ public int NumberOfShips;   // Not sure if I am blind, but I can't see the actual type for this. Seems reasonable though.
        /* 0x2B0 */ public NMSString0x10 AttackDefinition;
    }
}
