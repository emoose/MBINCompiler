using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Alignment = 0x8, GUID = 0x0EBE52AC97B2A9766)]
    public class GcGenericRewardTableEntry : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Id;
        public GcRewardTableItemList Common;
    }
}
