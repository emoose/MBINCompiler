using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7537C0789888A6DC, NameHash = 0xDF91F2B5F746FB61)]
    public class GcRewardWeapon : NMSTemplate
    {
        /* 0x00 */ public int ItemLevel;
        /* 0x04 */ public bool MarkInteractionComplete;
        /* 0x05 */ public bool UsePlanetSeed;
        /* 0x06 */ public bool ForceFixed;
        /* 0x07 */ public bool RequeueInteraction;
        /* 0x08 */ public bool ReinteractOnDecline;
        /* 0x09 */ public bool OnlyUseNextInteractionOnSuccess;
        [NMS(Size = 0x4, EnumType = typeof(GcMultitoolPoolType.MultiToolPoolTypeEnum))]
        /* 0x0C */ public float[] PoolTypeProbabilities;
        /* 0x1C */ public GcInteractionMissionState SetInteractionStateOnSuccess;
    }
}
