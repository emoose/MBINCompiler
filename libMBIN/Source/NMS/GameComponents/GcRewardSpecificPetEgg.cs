using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3F389F77A5AB5D50, NameHash = 0x227F6003863B9E93)]
    public class GcRewardSpecificPetEgg : NMSTemplate
    {
        /* 0x0 */ public bool ImmediatelyHatchable;
        /* 0x8 */ public GcPetData EggData;
    }
}
