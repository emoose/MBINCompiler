using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x135A33E156FC104A, NameHash = 0xDFC93B6F3652FDE5)]
    public class GcExpeditionRewardTable : NMSTemplate
    {
        /* 0x0 */ public List<GcGenericRewardTableEntry> Table;
    }
}
