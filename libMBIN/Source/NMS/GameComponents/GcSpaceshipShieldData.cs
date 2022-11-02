namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x80861571AB3690DF, NameHash = 0x715B2B315094E969)]
    public class GcSpaceshipShieldData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Id;
        /* 0x10 */ public int Health;
        /* 0x14 */ public int LevelledExtraHealth;
        /* 0x18 */ public float RechargeTime;
        /* 0x1C */ public float RechargeDelayTime;
    }
}
