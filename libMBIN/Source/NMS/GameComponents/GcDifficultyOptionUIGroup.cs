using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC3AAC4BF0E2D3B2F, NameHash = 0x50F5884F)]
    public class GcDifficultyOptionUIGroup : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A HeadingLocID;
        [NMS(Index = 1)]
        /* 0x20 */ public List<GcDifficultySettingUIOption> DifficultyOptions;
    }
}
