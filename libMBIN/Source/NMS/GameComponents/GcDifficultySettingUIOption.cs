using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAC1ABBB8E6438925, NameHash = 0x44DB3EF040C4347F)]
    public class GcDifficultySettingUIOption : NMSTemplate
    {
        /* 0x0 */ public GcDifficultySettingEnum MainOption;
        /* 0x8 */ public List<GcDifficultySettingEnum> AlsoChangeOptions;
    }
}
