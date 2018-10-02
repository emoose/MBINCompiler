using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x190, GUID = 0x524A5E0775670390)]
    public class GcHotActionsSaveData : NMSTemplate
    {
        [NMS(Size = 0xA)]
        public GcQuickMenuActionSaveData[] KeyActions;
    }
}
