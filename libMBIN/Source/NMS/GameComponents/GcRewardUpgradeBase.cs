using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x18, GUID = 0x2C0A86A9CA4188B3, NameHash = 0xE60E16C73CCFBAC0)]
    public class GcRewardUpgradeBase : NMSTemplate
    {
		public enum UpgradeBaseTypeEnum { AllMatching, NearestMatching }
		public UpgradeBaseTypeEnum UpgradeBaseType;
        public List<GcPersistentBaseTypes> MatchingBaseTypes;
    }
}
