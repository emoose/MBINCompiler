using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x58, GUID = 0x38BECBB20B340F37, NameHash = 0xCF9FC45A7B70BB85)]
    public class GcRewardSpecificSpecial : NMSTemplate
    {
        public NMSString0x10 ID;
        public NMSString0x20A Message;
        public bool UseSpecialFormatting;
        public NMSString0x20A MilestoneRewardOverrideText;
    }
}