using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0xC0, GUID = 0xF2C9D9A9CCAFB1FE, NameHash = 0x733D7A989F8B9969)]
    public class GcCombatEffectsTable : NMSTemplate
    {
        [NMS(Size = 0x3)]
        /* 0x0 */ public GcCombatEffectData[] EffectsData;
    }
}
