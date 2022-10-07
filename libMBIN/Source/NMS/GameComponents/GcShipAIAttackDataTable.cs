using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5CDB2F86CA575723, NameHash = 0xC501980088063B)]
    public class GcShipAIAttackDataTable : NMSTemplate
    {
        /* 0x00 */ public List<GcShipAICombatDefinition> Definitions;
        /* 0x10 */ public List<GcShipAIAttackData> BehaviourTable;
        /* 0x20 */ public List<GcSpaceshipTravelData> EngineTable;
        /* 0x30 */ public List<GcSpaceshipShieldData> ShieldTable;
        // size: 0x4
        public enum TraderAttackLookupEnum {
            Poor,
            Average,
            Wealthy,
            Pirate
        }
        [NMS(Size = 0x4, EnumType = typeof(TraderAttackLookupEnum))]
        /* 0x40 */ public NMSString0x10[] TraderAttackLookup;
    }
}
