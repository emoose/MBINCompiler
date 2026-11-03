using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF4E7D5A722F510DD, NameHash = 0xB03F2084)]
    public class GcCostDifficultySpaceCombat : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public NMSString0x20A CostStringCantAfford;
        [NMS(Index = 1)]
        /* 0x20 */ public GcCombatTimerDifficultyOption SpaceCombatTimers;
        [NMS(Index = 0)]
        /* 0x24 */ public TkEqualityEnum Test;
    }
}
