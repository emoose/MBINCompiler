using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6E1D4A06924711BB, NameHash = 0xF28D85CB)]
    public class GcCustomisationDescriptorGroups : NMSTemplate
    {
        [NMS(Index = 2, KeyField = "DescriptorId")]
        /* 0x00 */ public HashMap<GcCustomisationDescriptorVisualEffects> DescriptorVisualEffects;
        [NMS(Index = 0)]
        /* 0x30 */ public List<GcCustomisationDescriptorGroupSet> DescriptorGroupSets;
        [NMS(Index = 1)]
        /* 0x40 */ public List<GcCustomisationHeadToRace> HeadRaces;
    }
}
