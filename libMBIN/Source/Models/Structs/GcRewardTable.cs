using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    [NMS(Size = 0x90)]
    public class GcRewardTable : NMSTemplate
    {
        public List<GcRewardTableEntry> Table;
        public List<GcGenericRewardTableEntry> GenericTable;
        public List<GcGenericRewardTableEntry> InteractionTable;
        public List<GcGenericRewardTableEntry> OldInteractionTable;
        public List<GcGenericRewardTableEntry> SpecialRewardTable;
        public List<GcGenericRewardTableEntry> MissionBoardTable;
        public List<GcRewardTableEntitlementItem> EntitlementTable;
        public List<NMSString0x10> TechRewardOrder;
        public List<NMSString0x10> ProductRewardOrder;
    }
}
