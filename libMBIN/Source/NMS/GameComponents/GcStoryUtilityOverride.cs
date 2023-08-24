using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6861D62B6EEFAF58, NameHash = 0xE1C7E19E0F5C0C48)]
    public class GcStoryUtilityOverride : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A Name;
        /* 0x20 */ public NMSString0x10 Reward;
        /* 0x30 */ public List<GcRewardMissionOverride> SpecificRewardOverrideTable;
    }
}
