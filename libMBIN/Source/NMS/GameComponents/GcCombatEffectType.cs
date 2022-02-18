using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x4, GUID = 0x3AF1EFFFD3D8DC60, NameHash = 0x0CC36FE8AD202DF8)]
    public class GcCombatEffectType : NMSTemplate
    {
        // size: 0x3
        public enum CombatEffectTypeEnum { None, Fire, Stun }
        /* 0x0 */ public CombatEffectTypeEnum CombatEffectType;
    }
}
