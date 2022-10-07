using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEE3E83945AA9195A, NameHash = 0x3DDFD92393C0D347)]
    public class GcRewardSubstance : NMSTemplate
    {
        /* 0x00 */ public GcRealitySubstanceCategory ItemCatagory;
        /* 0x04 */ public GcRarity ItemRarity;
        /* 0x08 */ public int ItemLevel;
        /* 0x0C */ public int AmountMin;
        /* 0x10 */ public int AmountMax;
        /* 0x14 */ public bool DisableMultiplier;
        /* 0x15 */ public bool RewardAsBlobs;
        /* 0x16 */ public bool UseFuelMultiplier;
    }
}
