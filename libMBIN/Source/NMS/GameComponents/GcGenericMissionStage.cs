using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEF4C7B5C7E6409F3, NameHash = 0xE8F2F4C4A2F01AD1)]
    public class GcGenericMissionStage : NMSTemplate
    {
        /* 0x00 */ public List<GcGenericMissionVersionProgress> Versions;
        /* 0x10 */ public NMSTemplate Stage;
    }
}
