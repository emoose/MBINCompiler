using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x33796ABA4375B448, NameHash = 0x9A051A6D204FA9F2)]
    public class GcNGuiStyleAnimationKeyframeData : NMSTemplate
    {
        /* 0x0 */ public float Position;
        /* 0x8 */ public List<NMSTemplate> StyleProperties;
    }
}
