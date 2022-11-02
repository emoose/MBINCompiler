namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8DB5B6D57D028632, NameHash = 0x1316C386517581C1)]
    public class GcRewardPlanetSubstance : NMSTemplate
    {
        /* 0x0 */ public int AmountMin;
        /* 0x4 */ public int AmountMax;
        /* 0x8 */ public bool DisableMultiplier;
        /* 0x9 */ public bool RewardAsBlobs;
        /* 0xA */ public bool UseFuelMultiplier;
    }
}
