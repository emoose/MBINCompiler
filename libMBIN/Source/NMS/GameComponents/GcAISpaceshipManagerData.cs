using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x50, GUID = 0x78F86525698EC5A3, NameHash = 0x785665CB6C017B4C)]
    public class GcAISpaceshipManagerData : NMSTemplate
    {
        [NMS(Size = 0x5, EnumType = typeof(GcRealityCommonFactions.AIFactionEnum))]
        /* 0x0 */ public GcAISpaceshipModelDataArray[] SystemSpaceships;
    }
}
