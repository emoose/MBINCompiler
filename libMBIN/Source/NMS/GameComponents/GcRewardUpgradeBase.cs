using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFD2AF4A7805E60BD, NameHash = 0xE60E16C73CCFBAC0)]
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
