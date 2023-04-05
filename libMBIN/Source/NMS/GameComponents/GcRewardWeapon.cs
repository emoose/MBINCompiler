namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x258D16F407B02A00, NameHash = 0xDF91F2B5F746FB61)]
    public class GcRewardWeapon : NMSTemplate
    {
        /* 0x00 */ public int ItemLevel;
        /* 0x04 */ public bool MarkInteractionComplete;
        /* 0x05 */ public bool UsePlanetSeed;
        /* 0x06 */ public bool ForceFixed;
        /* 0x07 */ public bool RequeueInteraction;
        /* 0x08 */ public bool ReinteractOnDecline;
        /* 0x09 */ public bool OnlyUseNextInteractionOnSuccess;
        /* 0x0C */ public float SecretPoolChance;
        /* 0x10 */ public float SentinelPoolChance;
    }
}
