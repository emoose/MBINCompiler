using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x28, GUID = 0x10C585B2B173985A, NameHash = 0xB1B9570C76B5EA49)]
    public class GcFrigateFlybyLayout : NMSTemplate
    {
        /* 0x00 */ public GcFrigateFlybyType FlybyType;
        /* 0x04 */ public float InitialSpeed;
        /* 0x08 */ public float TargetSpeed;
        /* 0x0C */ public float InterestTime;
        /* 0x10 */ public float InterestDistance;
        /* 0x18 */ public List<GcFrigateFlybyOption> Frigates;
    }
}
