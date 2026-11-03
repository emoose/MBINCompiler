using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD35BCD77004563E7, NameHash = 0x439BD3BC)]
    public class GcMissionConditionHostileShipEncounterResolution : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public GcSpaceBattleType RequireSpecificSpaceBattleType;
        [NMS(Index = 2, Size = 0x6, EnumType = typeof(GcHostileShipEncounterResolution.HostileShipEncounterResolutionEnum))]
        /* 0x4 */ public bool[] Resolution;
        [NMS(Index = 0)]
        /* 0xA */ public GcHostileShipEncounterType Type;
    }
}
