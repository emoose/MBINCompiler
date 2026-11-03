using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3F5C44673A1BA17E, NameHash = 0xAA198AAA)]
    public class GcDroneGun : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x10 Anim;
        [NMS(Index = 4)]
        /* 0x10 */ public List<NMSString0x20> RequiredDestructibles;
        [NMS(Index = 0)]
        /* 0x20 */ public NMSString0x20 Locator;
        [NMS(Index = 2)]
        /* 0x40 */ public bool LaunchDuringAnim;
        [NMS(Index = 3)]
        /* 0x41 */ public bool MirrorAnim;
    }
}
