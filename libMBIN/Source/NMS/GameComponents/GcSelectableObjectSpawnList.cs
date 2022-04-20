﻿using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x20, GUID = 0x3504B7906EAE8BB7, NameHash = 0xA8FBF05C737FA4E2)]
    public class GcSelectableObjectSpawnList : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Name;
        /* 0x10 */ public List<GcSelectableObjectSpawnData> Objects;
    }
}
