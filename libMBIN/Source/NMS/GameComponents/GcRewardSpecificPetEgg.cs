using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x228, GUID = 0x839B824CE749DD49, NameHash = 0x227F6003863B9E93)]
    public class GcRewardSpecificPetEgg : NMSTemplate
    {
        /* 0x0 */ public bool ImmediatelyHatchable;
        /* 0x8 */ public GcPetData EggData;
    }
}
