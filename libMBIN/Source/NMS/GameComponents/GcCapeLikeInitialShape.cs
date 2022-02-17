using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x34, GUID = 0x280A471E28BB8F8C, NameHash = 0xEEACA2899046E3A1)]
    public class GcCapeLikeInitialShape : NMSTemplate
    {
        /* 0x00 */ public float TopRadius;
        /* 0x04 */ public float TopInnerRadius;
        /* 0x08 */ public float BottomRadius;
        /* 0x0C */ public float TopDropOffHeight;
        /* 0x10 */ public float ForwardSquash;
        /* 0x14 */ public float TopX;
        /* 0x18 */ public float TopY;
        /* 0x1C */ public float TopZ;
        /* 0x20 */ public int RightAxisIndex;
        /* 0x24 */ public int ForwardAxisIndex;
        /* 0x28 */ public float CircleStartAngle;
        /* 0x2C */ public float CircleEndAngle;
        /* 0x30 */ public bool WrapIAround;
        /* 0x31 */ public bool WrapJAround;
    }
}
