using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x100, GUID = 0x0ED2B35F7B82B96C, NameHash = 0x733D7A989F8B9969)]
    public class GcCombatEffectsTable : NMSTemplate
    {
        [NMS(Size = 0x4)]
        /* 0x0 */ public GcCombatEffectData[] EffectsData;
    }
}
