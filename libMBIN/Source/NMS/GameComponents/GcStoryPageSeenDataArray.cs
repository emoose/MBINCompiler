using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEC3F8B143511EF4D, NameHash = 0x7D0EF698)]
    public class GcStoryPageSeenDataArray : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcStoryPageSeenData> PagesData;
    }
}
