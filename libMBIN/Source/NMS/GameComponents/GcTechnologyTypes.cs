using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x10, GUID = 0xD74E8CF1FB315A65, NameHash = 0x324956CF456BD3E1)]
    public class GcTechnologyTypes : NMSTemplate
    {
        /* 0x0 */ public List<GcTechnology> Technology;
    }
}
