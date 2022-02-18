using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x40, GUID = 0x6D432EBD4189D8D2, NameHash = 0x3183C2CA4E0D9600)]
    public class GcClothCollisionBone : NMSTemplate
    {
        /* 0x00 */ public bool Enabled;
        /* 0x01 */ public NMSString0x20 BoneName;
        /* 0x24 */ public float CapsuleCentreX;
        /* 0x28 */ public float CapsuleCentreY;
        /* 0x2C */ public float CapsuleCentreZ;
        /* 0x30 */ public int CapsuleAxisIndex;
        /* 0x34 */ public float CapsuleRadius;
        /* 0x38 */ public float CapsuleLength;
        /* 0x3C */ public bool ExtractPointPairs;
    }
}
