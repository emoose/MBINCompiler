using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE8D8F0C9A4D20C4C, NameHash = 0x7219E3FF7006060F)]
    public class GcFrigateFlybyOption : NMSTemplate
    {
        /* 0x0 */ public GcFrigateClass FrigateClass;
        /* 0x4 */ public int MinCount;
        /* 0x8 */ public int MaxCount;
        /* 0xC */ public float Weight;
    }
}
