using System.Collections.Generic;

namespace MBINCompiler.Models.Structs
{
    public class GcRewardTableItemList : NMSTemplate
    {
        public bool EntitlementLinked;
        [NMS(Size = 0x20)]
        public string EntitlementId;
        public GcRewardTableChoice RewardChoice;
        public List<GcRewardTableItem> List;
    }
}
