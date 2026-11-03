using libMBIN.NMS.Toolkit;
using System.Collections.Generic;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x61BD99D9DCF228E3, NameHash = 0xCDF89FF7)]
    public class TkControllerList : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<TkControllerButtonLookup> Controllers;
    }
}
