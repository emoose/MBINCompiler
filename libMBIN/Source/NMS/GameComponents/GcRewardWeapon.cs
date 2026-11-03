using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF090168785503C65, NameHash = 0x33B2477A)]
    public class GcRewardWeapon : NMSTemplate
    {
        [NMS(Index = 7, Size = 0x5, EnumType = typeof(GcMultitoolPoolType.MultiToolPoolTypeEnum))]
        /* 0x00 */ public float[] PoolTypeProbabilities;
        [NMS(Index = 0)]
        /* 0x14 */ public int ItemLevel;
        [NMS(Index = 8)]
        /* 0x18 */ public GcInteractionMissionState SetInteractionStateOnSuccess;
        [NMS(Index = 3)]
        /* 0x1C */ public bool ForceFixed;
        [NMS(Index = 1)]
        /* 0x1D */ public bool MarkInteractionComplete;
        [NMS(Index = 6)]
        /* 0x1E */ public bool OnlyUseNextInteractionOnSuccess;
        [NMS(Index = 5)]
        /* 0x1F */ public bool ReinteractOnDecline;
        [NMS(Index = 4)]
        /* 0x20 */ public bool RequeueInteraction;
        [NMS(Index = 2)]
        /* 0x21 */ public bool UsePlanetSeed;
    }
}
