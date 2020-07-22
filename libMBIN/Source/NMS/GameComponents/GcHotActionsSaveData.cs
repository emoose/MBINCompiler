using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x190, GUID = 0xD96A4D97B645D3D0, NameHash = 0xE6D4EE849D2F9101)]
    public class GcHotActionsSaveData : NMSTemplate
    {
        [NMS(Size = 0xA)]
        public GcQuickMenuActionSaveData[] KeyActions;
    }
}
