using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xDD2C2FEF2620F1E2, NameHash = 0x6341093281E2ADC1)]
    public class GcDifficultyOptionUIGroup : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A HeadingLocID;
        /* 0x20 */ public List<GcDifficultySettingUIOption> DifficultyOptions;
    }
}
