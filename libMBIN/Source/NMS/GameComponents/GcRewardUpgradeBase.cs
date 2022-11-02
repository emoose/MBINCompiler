using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCF525E2347B05D57, NameHash = 0xE60E16C73CCFBAC0)]
    public class GcRewardUpgradeBase : NMSTemplate
    {
        // size: 0x2
        public enum UpgradeBaseTypeEnum {
            AllMatching,
            NearestMatching
        }
        /* 0x0 */ public UpgradeBaseTypeEnum UpgradeBaseType;
        /* 0x8 */ public List<GcPersistentBaseTypes> MatchingBaseTypes;
    }
}
