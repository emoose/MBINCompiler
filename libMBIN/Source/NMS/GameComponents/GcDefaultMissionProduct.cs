using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x4, GUID = 0x95CC2D98F94CF778, NameHash = 0x1F78606838C7F310)]
    public class GcDefaultMissionProduct : NMSTemplate
    {
        /* 0x0 */ public GcProductTableEnum Product;
    }
}
