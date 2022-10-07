namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x27E0D4AB08937C59, NameHash = 0x5A9334071F34CD7A)]
    public class GcRewardHealth : NMSTemplate
    {
        /* 0x0 */ public int AmountMin;
        /* 0x4 */ public int AmountMax;
        /* 0x8 */ public bool SilentUnlessShieldAtMax;
    }
}
