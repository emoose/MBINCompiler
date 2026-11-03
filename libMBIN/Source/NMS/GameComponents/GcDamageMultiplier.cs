using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x880DB5D2C31C319E, NameHash = 0x814EEACD)]
    public class GcDamageMultiplier : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public float Multiplier;
        [NMS(Index = 0)]
        /* 0x4 */ public GcDamageType Type;
    }
}
