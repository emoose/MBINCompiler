using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBAC99872D8E1DCFB, NameHash = 0xB52FD92EE85259A)]
    public class GcRewardTeachSpecificWords : NMSTemplate
    {
        /* 0x00 */ public GcAlienRace Race;
        /* 0x08 */ public List<NMSString0x20A> SpecificWordGroups;
        /* 0x18 */ public float OSDMessageTime;
        /* 0x20 */ public NMSString0x20A CustomOSDMessage;
        /* 0x40 */ public bool SuppressOSDMessage;
    }
}
