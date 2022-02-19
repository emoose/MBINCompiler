using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x8, GUID = 0x6877360D0BF3916B, NameHash = 0xD755EBC8945CB867)]
    public class GcCombatEffectDamageMultiplier : NMSTemplate
    {
        /* 0x0 */ public GcCombatEffectType CombatEffectType;
        /* 0x4 */ public float DamageMultiplier;
    }
}
