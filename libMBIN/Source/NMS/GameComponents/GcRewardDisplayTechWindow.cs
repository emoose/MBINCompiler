using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x3E9B7B304DFC301C)]
    public class GcRewardDisplayTechWindow : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string TechID;
        public bool Damaged;
        public bool FullBox;
        [NMS(Size = 0x6)]
        public byte[] EndPadding;
    }
}
