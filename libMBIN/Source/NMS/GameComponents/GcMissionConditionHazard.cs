using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x957042D51940CA26, NameHash = 0xA2A54269)]
    public class GcMissionConditionHazard : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcPlayerHazardType Hazard;
    }
}
