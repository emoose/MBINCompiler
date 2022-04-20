using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x30, GUID = 0x82CBA07F9A9EC6C2, NameHash = 0x74FCF5B2A55D262B)]
    public class GcCombatEffectsComponentData : NMSTemplate
    {
        [NMS(Size = 0x4)]
        /* 0x0 */ public GcCombatEffectsProperties[] EffectsProperties;
    }
}
