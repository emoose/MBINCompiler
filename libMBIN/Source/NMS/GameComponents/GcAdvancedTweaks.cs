using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x28, GUID = 0xDEFE5CD36ADC2FCE, NameHash = 0x1C1691C0F8971C4A)]
    public class GcAdvancedTweaks : NMSTemplate
    {
        /* 0x00 */ public bool ApplyMoreGravityAtBottom;
        /* 0x04 */ public float EdgeMultiplierForTangentI;
        /* 0x08 */ public float EdgeMultiplierForTangentJ;
        /* 0x0C */ public float RenderNormalMultiplier;
        /* 0x10 */ public float GravityScaleAtBottom;
        /* 0x14 */ public float TransportWithFixedPoints;
        /* 0x18 */ public float TransportWithComponent;
        /* 0x1C */ public float TransportPointsInContact;
        /* 0x20 */ public float TransportPointsInContactVelocityBlend;
        /* 0x24 */ public float StretchUvsToHideTextureEdges;
    }
}
