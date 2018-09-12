using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x0F0196F209D21EB12)]
    public class GcRewardJourneyThroughCentre : NMSTemplate
    {
		public enum CentreJourneyDestinationEnum { Next, Abandoned, Vicious, Lush, Balanced }
		public CentreJourneyDestinationEnum CentreJourneyDestination;
    }
}
