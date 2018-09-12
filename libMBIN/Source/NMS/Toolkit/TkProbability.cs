using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(GUID = 0x91F4745D4236E2DB)]
    public class TkProbability : NMSTemplate
    {
		public enum ProbabilityEnum { Common, Uncommon, Rare, Extraordinary }
		public ProbabilityEnum Probability;
    }
}
