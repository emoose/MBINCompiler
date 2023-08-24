using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9C824D1D76FB05A6, NameHash = 0x1C1691C0F8971C4A)]
    public class GcAdvancedTweaks : NMSTemplate
    {
        /* 0x00 */ public float ParticleKillSpeed;
        /* 0x04 */ public float ParticleKillSpeedWrtFixed;
        /* 0x08 */ public float EdgeMultiplierForTangentI;
        /* 0x0C */ public float EdgeMultiplierForTangentJ;
        /* 0x10 */ public float RenderNormalMultiplier;
        /* 0x18 */ public List<NMSString0x40> NodesThatMustBePresent;
        /* 0x28 */ public List<NMSString0x40> NodesToHide;
        /* 0x38 */ public float StretchUvsToHideTextureEdges;
        /* 0x3C */ public bool LeaveRenderedTrianglesUnaffected;
    }
}
