using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x18, GUID = 0x9E7E604CAD11ADB8, NameHash = 0x2F2FAFA4A7023B71)]
    public class GcProjectileImpactData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Effect;
        /* 0x10 */ public GcProjectileImpactType Impact;
        // size: 0x2
        public enum ImpactAlignmentEnum { ImpactNormal, GravityUp }
        /* 0x10 */ public ImpactAlignmentEnum ImpactAlignment;
    }
}
