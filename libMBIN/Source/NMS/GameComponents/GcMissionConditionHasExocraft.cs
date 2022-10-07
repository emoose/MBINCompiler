using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFA522E5E73F307A0, NameHash = 0xF738BB4CB0090E06)]
    public class GcMissionConditionHasExocraft : NMSTemplate
    {
        /* 0x0 */ public bool SpecificExocraft;
        /* 0x4 */ public GcVehicleType PrimaryExocraft;
    }
}
