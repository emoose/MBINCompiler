using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2E4673F3CB91C6D0, NameHash = 0x15072D4E11178622)]
    public class GcDifficultyFuelUseOptionData : NMSTemplate
    {
        /* 0x0 */ public float Multiplier;
        /* 0x8 */ public List<GcDifficultyFuelUseTechOverride> TechOverrides;
    }
}
