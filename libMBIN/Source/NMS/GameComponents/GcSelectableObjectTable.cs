using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x52E360F0EF0B1133, NameHash = 0xCE1983E849879238)]
    public class GcSelectableObjectTable : NMSTemplate
    {
        /* 0x0 */ public List<GcSelectableObjectList> Lists;
    }
}
