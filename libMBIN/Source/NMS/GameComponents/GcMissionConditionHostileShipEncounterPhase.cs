using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD75008F6C2C7122D, NameHash = 0x671FAFA5)]
    public class GcMissionConditionHostileShipEncounterPhase : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public GcSpaceBattleType RequireSpecificSpaceBattleType;
        [NMS(Index = 2, Size = 0x7, EnumType = typeof(GcHostileShipEncounterPhase.HostileShipEncounterPhaseEnum))]
        /* 0x4 */ public bool[] Phase;
        [NMS(Index = 0)]
        /* 0xB */ public GcHostileShipEncounterType Type;
    }
}
