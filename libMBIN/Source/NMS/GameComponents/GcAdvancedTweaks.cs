namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6E9D7EAB573C6CD6, NameHash = 0x1C1691C0F8971C4A)]
    public class GcAdvancedTweaks : NMSTemplate
    {
        /* 0x00 */ public float ParticleKillSpeed;
        /* 0x04 */ public float ParticleKillSpeedWrtFixed;
        /* 0x08 */ public float EdgeMultiplierForTangentI;
        /* 0x0C */ public float EdgeMultiplierForTangentJ;
        /* 0x10 */ public float RenderNormalMultiplier;
        /* 0x14 */ public float StretchUvsToHideTextureEdges;
    }
}
