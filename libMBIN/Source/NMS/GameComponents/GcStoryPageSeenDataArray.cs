using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDFD06D2077F7EAFD, NameHash = 0xFCD71DCE44349CB6)]
    public class GcStoryPageSeenDataArray : NMSTemplate
    {
        /* 0x0 */ public List<GcStoryPageSeenData> PagesData;
    }
}
