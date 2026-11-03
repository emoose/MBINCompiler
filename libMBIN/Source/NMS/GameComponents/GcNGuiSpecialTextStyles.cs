using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xCCBCB111753DC1EB, NameHash = 0xD6BF3EB3)]
    public class GcNGuiSpecialTextStyles : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public List<GcNGuiSpecialTextStyleData> SpecialStyles;
    }
}
