using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.Toolkit
{
	[NMS(Size = 0x4, GUID = 0x91F4745D4236E2DB, NameHash = 0x291E526240E013CC)]
    public class TkProbability : NMSTemplate
    {
		public enum ProbabilityEnum { Common, Uncommon, Rare, Extraordinary }
		public ProbabilityEnum Probability;
    }
}