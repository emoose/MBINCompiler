using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE8AF5C28F3FF1837, NameHash = 0x389D6F3B)]
    public class GcMissionConditionHostileShipEncounterActive : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public GcSpaceBattleType RequireSpecificSpaceBattleType;
        [NMS(Index = 0)]
        /* 0x4 */ public GcHostileShipEncounterType Type;
    }
}
