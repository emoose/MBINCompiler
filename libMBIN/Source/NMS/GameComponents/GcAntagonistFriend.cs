using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x911E3BAC97975B42, NameHash = 0xFDB6BBB2)]
    public class GcAntagonistFriend : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<NMSString0x10> Perceptions;
        [NMS(Index = 0)]
        /* 0x10 */ public float ArticulationFactor;
    }
}
