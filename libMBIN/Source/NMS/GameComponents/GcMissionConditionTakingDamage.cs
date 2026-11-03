namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9448DCCA51089AB8, NameHash = 0x2672130)]
    public class GcMissionConditionTakingDamage : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x10 DamageID;
        [NMS(Index = 0)]
        /* 0x10 */ public bool RequireShieldDown;
    }
}
