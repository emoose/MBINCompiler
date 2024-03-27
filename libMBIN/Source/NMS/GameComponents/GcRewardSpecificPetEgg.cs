using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE26D7BAEE3C6CDBD, NameHash = 0x227F6003863B9E93)]
    public class GcRewardSpecificPetEgg : NMSTemplate
    {
        /* 0x0 */ public bool ImmediatelyHatchable;
        /* 0x8 */ public GcPetData EggData;
    }
}
