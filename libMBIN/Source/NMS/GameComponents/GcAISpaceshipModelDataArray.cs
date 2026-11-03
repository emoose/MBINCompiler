using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x595097B7FECF4ACE, NameHash = 0x241CDC95)]
    public class GcAISpaceshipModelDataArray : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<NMSString0x20A> Spaceships;
    }
}
