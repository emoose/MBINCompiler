using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x13A70B3960977626, NameHash = 0xF3F4ABE3661F3779)]
    public class GcRewardSpecificSubstance : NMSTemplate
    {
        /* 0x00 */ public GcDefaultMissionSubstanceEnum Default;
        /* 0x08 */ public NMSString0x10 ID;
        /* 0x18 */ public int AmountMin;
        /* 0x1C */ public int AmountMax;
        /* 0x20 */ public bool DisableMultiplier;
        /* 0x21 */ public bool RewardAsBlobs;
        /* 0x22 */ public bool UseFuelMultiplier;
        /* 0x23 */ public bool Silent;
    }
}
