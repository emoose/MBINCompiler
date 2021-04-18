using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x18, GUID = 0x0000000000000000, NameHash = 0x81F6791F9BCCAB59)]
    public class GcAtlasSendRemoveFeaturedBases : NMSTemplate
    {
        /* 0x00 */ public ulong ClientUserdata;
        /* 0x08 */ public List<GcAtlasFeaturedBaseStateChange> BaseList;
    }
}
