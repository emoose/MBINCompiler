using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6FB2E2B112C03148, NameHash = 0xC501980088063B)]
    public class GcShipAIAttackDataTable : NMSTemplate
    {
        /* 0x00 */ public List<GcShipAICombatDefinition> Definitions;
        /* 0x10 */ public List<GcShipAIAttackData> BehaviourTable;
        /* 0x20 */ public List<GcSpaceshipTravelData> EngineTable;
        /* 0x30 */ public List<GcSpaceshipShieldData> ShieldTable;
        [NMS(Size = 0x4, EnumType = typeof(GcWealthClass.WealthClassEnum))]
        /* 0x40 */ public NMSString0x10[] TraderAttackLookup;
    }
}
