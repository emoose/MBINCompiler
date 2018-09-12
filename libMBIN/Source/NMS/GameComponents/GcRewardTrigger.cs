using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x91D949875E632251)]
    // ACTIVATE in big letters above it?

    public class GcRewardTrigger : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Trigger;
    }
}
