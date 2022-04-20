using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x2A8, GUID = 0xFA76F7119E2C29EF, NameHash = 0xE1CDA71E5D51FD24)]
    public class GcSelectableObjectSpawnData : NMSTemplate
    {
        /* 0x0 */ public GcResourceElement Resource;
    }
}
