using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x56D8FAD7802F5FF0, NameHash = 0x9FCCA94FCF253691)]
    public class GcCostDifficultySpaceCombat : NMSTemplate
    {
        /* 0x0 */ public TkEqualityEnum Test;
        /* 0x4 */ public GcCombatTimerDifficultyOption SpaceCombatTimers;
        /* 0x8 */ public NMSString0x20A CostStringCantAfford;
    }
}
