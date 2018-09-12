using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x40, GUID = 0x1C784EA9C0D6B06B)]
    public class GcFreighterBaseComponentData : NMSTemplate
    {
        [NMS(Size = 0x4)]
        public GcFreighterBaseOptions[] FreighterBaseOptions;
    }
}
