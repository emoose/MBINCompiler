using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAA3C2FF9F1A84FB1, NameHash = 0xDC747992)]
    public class GcBoneFollowerComponentData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public List<GcLocalLimitFollowerEntry> LocalLimitFollowers;
        [NMS(Index = 0)]
        /* 0x10 */ public List<GcModelSpaceFollowerEntry> ModelSpaceFollowers;
    }
}
