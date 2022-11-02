using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x269C433C5328032F, NameHash = 0xB387E3560FAA5681)]
    public class GcDamageMultiplier : NMSTemplate
    {
        /* 0x0 */ public GcDamageType Type;
        /* 0x4 */ public float Multiplier;
    }
}
