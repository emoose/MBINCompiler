using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x10, GUID = 0x98428F3B214A42E2, NameHash = 0x324956CF456BD3E1)]
    public class GcTechnologyTypes : NMSTemplate
    {
        /* 0x0 */ public List<GcTechnology> Technology;
    }
}
