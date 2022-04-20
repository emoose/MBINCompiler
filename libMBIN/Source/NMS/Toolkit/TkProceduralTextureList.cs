﻿using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
    [NMS(Size = 0x200, GUID = 0xECEAC32925156DF1, NameHash = 0xBEE79269D7359654)]
    public class TkProceduralTextureList : NMSTemplate
    {
        [NMS(Size = 0x8)]
        /* 0x0 */ public TkProceduralTextureLayer[] Layers;
    }
}
