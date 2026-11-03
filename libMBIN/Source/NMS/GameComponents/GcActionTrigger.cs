using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA6841C89EB7731E4, NameHash = 0x8EB09A83)]
    public class GcActionTrigger : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<NMSTemplate> Action;
        [NMS(Index = 0)]
        /* 0x10 */ public NMSTemplate Event;
    }
}
