using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD217412102AD498, NameHash = 0x236F77EA3398AAC4)]
    public class GcCostDifficultyGroundCombat : NMSTemplate
    {
        /* 0x0 */ public TkEqualityEnum Test;
        /* 0x4 */ public GcCombatTimerDifficultyOption GroundCombatTimers;
        /* 0x8 */ public NMSString0x20A CostStringCantAfford;
    }
}
