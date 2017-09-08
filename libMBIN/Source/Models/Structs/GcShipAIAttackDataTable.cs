using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    public class GcShipAIAttackDataTable : NMSTemplate       // size: 0x60
    {
        /* 0x00 */ public List<GcShipAICombatDefinition> Definitions;
        /* 0x10 */ public List<GcShipAIAttackData> BehaviourTable;
        /* 0x20 */ public List<GcSpaceshipTravelData> EngineTable;
        [NMS(Size = 3)]
        /* 0x30 */ public NMSString0x10[] TraderAttackLookup;
    }
}
