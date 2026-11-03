using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB9F96AC232EA89A5, NameHash = 0x34BE918E)]
    public class GcPetBattlerMovePayloadItem : NMSTemplate
    {
        [NMS(Index = 8)]
        /* 0x00 */ public NMSTemplate Payload;
        [NMS(Index = 5)]
        /* 0x10 */ public float BalancingOverride;
        [NMS(Index = 0)]
        /* 0x14 */ public GcPetBattlerPayloadBenefit Benefit;
        [NMS(Index = 6)]
        /* 0x18 */ public GcPetBattlerMoveEffect PlaySimpleEffectOnTarget;
        [NMS(Index = 1)]
        /* 0x1C */ public GcPetBattlerPayloadStrength Strength;
        [NMS(Index = 7)]
        /* 0x20 */ public bool IsSilent;
        [NMS(Index = 4)]
        /* 0x21 */ public bool ShouldOverrideBalancing;
        [NMS(Index = 2)]
        /* 0x22 */ public bool ShouldOverrideTarget;
        [NMS(Index = 3)]
        /* 0x23 */ public GcPetBattlerTarget TargetOverride;
    }
}
