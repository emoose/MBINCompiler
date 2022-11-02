using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x25B191C2C6C38EFB, NameHash = 0x9E6CDA34B604CC21)]
    public class GcMissionConditionCanSummonExocraft : NMSTemplate
    {
        /* 0x0 */ public bool SpecificExocraft;
        /* 0x4 */ public GcVehicleType SummonableExocraft;
    }
}
