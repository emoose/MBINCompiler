using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x80, GUID = 0xB50D7797F39D2DF5, NameHash = 0x00C501980088063B)]
    public class GcShipAIAttackDataTable : NMSTemplate
    {
        /* 0x00 */ public List<GcShipAICombatDefinition> Definitions;
        /* 0x10 */ public List<GcShipAIAttackData> BehaviourTable;
        /* 0x20 */ public List<GcSpaceshipTravelData> EngineTable;
        [NMS(Size = 0x4)]
        /* 0x40 */ public NMSString0x10[] TraderAttackLookup;
    }
}
