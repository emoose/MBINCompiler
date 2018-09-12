using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x18, GUID = 0x869B1703BD6D8601)]
    public class GcRewardUpgradeBase : NMSTemplate
    {
		public enum UpgradeBaseTypeEnum { AllMatching, NearestMatching }
		public UpgradeBaseTypeEnum UpgradeBaseType;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] Padding4;
        public List<GcPersistentBaseTypes> MatchingBaseTypes;
    }
}
