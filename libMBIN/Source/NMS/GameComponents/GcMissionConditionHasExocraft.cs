using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8C13EA6F080C7130, NameHash = 0xA4DAB190)]
    public class GcMissionConditionHasExocraft : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public GcVehicleType ExocraftType;
        [NMS(Index = 0)]
        /* 0x4 */ public bool SpecificExocraft;
    }
}
