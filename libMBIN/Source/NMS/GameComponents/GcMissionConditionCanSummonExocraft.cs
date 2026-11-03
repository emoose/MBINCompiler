using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x27A314DCA444F4A3, NameHash = 0x31A11051)]
    public class GcMissionConditionCanSummonExocraft : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public GcVehicleType SummonableExocraft;
        [NMS(Index = 0)]
        /* 0x4 */ public bool SpecificExocraft;
    }
}
