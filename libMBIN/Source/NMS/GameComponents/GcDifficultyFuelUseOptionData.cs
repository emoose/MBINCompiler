using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDDB5F6B408399220, NameHash = 0x15072D4E11178622)]
    public class GcDifficultyFuelUseOptionData : NMSTemplate
    {
        /* 0x0 */ public float Multiplier;
        /* 0x8 */ public List<GcDifficultyFuelUseTechOverride> TechOverrides;
    }
}
