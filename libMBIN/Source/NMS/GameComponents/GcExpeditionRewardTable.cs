using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x10, GUID = 0x9ACB4C2268914BB, NameHash = 0xDFC93B6F3652FDE5)]
    public class GcExpeditionRewardTable : NMSTemplate
    {
        public List<GcGenericRewardTableEntry> Table;
    }
}