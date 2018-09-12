using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x70, GUID = 0x8EE38D16655115FC)]
    public class GcNPCAnimationSetData : NMSTemplate
    {
        public List<GcNPCProbabilityAnimationData> IdleAnimations;
        public List<GcNPCProbabilityAnimationData> IdleFlavourAnimations;
        public List<GcNPCProbabilityAnimationData> ChatterAnimations;
        public List<GcNPCProbabilityAnimationData> GreetAnimations;
        public List<GcNPCProbabilityAnimationData> HappyAnimations;
        public List<GcNPCProbabilityAnimationData> AngryAnimations;
        public List<GcNPCProbabilityAnimationData> NeutralAnimations;
    }
}
