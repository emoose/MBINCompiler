using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x41A82B0955D1FC4C, NameHash = 0x3542E107D9C3C98)]
    public class TkControllerList : NMSTemplate
    {
        /* 0x0 */ public List<TkControllerButtonLookup> Controllers;
    }
}
