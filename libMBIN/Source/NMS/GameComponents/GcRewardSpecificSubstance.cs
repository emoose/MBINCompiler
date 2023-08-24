using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAFB451007B628183, NameHash = 0xF3F4ABE3661F3779)]
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
        /* 0x24 */ public bool UseMissionBoardDifficultyScale;
    }
}
