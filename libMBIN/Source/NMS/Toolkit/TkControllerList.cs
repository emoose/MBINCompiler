using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xD33AC9B9ADD17756, NameHash = 0x3542E107D9C3C98)]
    public class TkControllerList : NMSTemplate
    {
        /* 0x0 */ public List<TkControllerButtonLookup> Controllers;
    }
}
