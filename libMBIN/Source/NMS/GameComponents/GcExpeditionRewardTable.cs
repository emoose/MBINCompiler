using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD886EBB84CD77C93, NameHash = 0xDFC93B6F3652FDE5)]
    public class GcExpeditionRewardTable : NMSTemplate
    {
        /* 0x0 */ public List<GcGenericRewardTableEntry> Table;
    }
}
