using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3E3DD7E6C60BCBF1, NameHash = 0x33B54D6)]
    public class GcMissionConditionIsPlayerWanted : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public int Level;
        [NMS(Index = 1)]
        /* 0x4 */ public TkEqualityEnum Test;
    }
}
