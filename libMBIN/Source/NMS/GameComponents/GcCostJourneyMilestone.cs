using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x29E751108FE47283)]
    public class GcCostJourneyMilestone : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string RequiredMilestone;
    }
}
