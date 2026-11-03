using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDDD37A082774A6A2, NameHash = 0xDB87E08)]
    public class GcCustomisationDescriptorVisualEffects : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A DescriptorId;
        [NMS(Index = 1)]
        /* 0x20 */ public List<GcCustomisationDescriptorVisualEffect> Effects;
    }
}
