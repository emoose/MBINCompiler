using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x4, GUID = 0x712D6804118F3A87, NameHash = 0x7C5208D16FF2D5BF)]
    public class GcMissionConditionProductKnown : NMSTemplate
    {
        /* 0x0 */ public GcProductTableEnum Product;
    }
}
