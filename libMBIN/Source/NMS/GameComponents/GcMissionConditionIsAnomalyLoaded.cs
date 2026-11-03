using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE5C0AB0F82798923, NameHash = 0xD6FAC380)]
    public class GcMissionConditionIsAnomalyLoaded : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcGalaxyStarAnomaly Anomaly;
        [NMS(Index = 1)]
        /* 0x4 */ public bool RequireCurrentlyInWorld;
    }
}
