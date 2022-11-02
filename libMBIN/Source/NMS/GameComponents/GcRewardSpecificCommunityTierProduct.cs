using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDB05FAF682119876, NameHash = 0xA0372351D829A5B0)]
    public class GcRewardSpecificCommunityTierProduct : NMSTemplate
    {
        /* 0x00 */ public List<NMSString0x10> ProductList;
        /* 0x10 */ public int AmountMin;
        /* 0x14 */ public int AmountMax;
        /* 0x18 */ public bool ForceSpecialMessage;
        /* 0x20 */ public NMSString0x10 RequiresTech;
    }
}
