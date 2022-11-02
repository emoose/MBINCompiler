using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xB14D5F2B950EC115, NameHash = 0x67009714D686CB9F)]
    public class TkHeavyAirCollection : NMSTemplate
    {
        /* 0x0 */ public List<TkHeavyAirData> HeavyAirSystems;
    }
}
