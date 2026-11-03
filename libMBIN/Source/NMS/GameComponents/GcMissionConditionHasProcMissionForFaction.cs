using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9D62513F4AE6C2B2, NameHash = 0x8E70BA89)]
    public class GcMissionConditionHasProcMissionForFaction : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public GcMissionFaction Faction;
    }
}
