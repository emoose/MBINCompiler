using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    public class GcRewardTable : NMSTemplate        // size: 0x70
    {
        public List<GcRewardTableEntry> Table;
        public List<GcGenericRewardTableEntry> GenericTable;
        public List<GcGenericRewardTableEntry> InteractionTable;
        public List<GcGenericRewardTableEntry> MissionBoardTable;
        public List<GcRewardTableEntitlementItem> EntitlementTable;
        public List<NMSString0x10> TechRewardOrder;
        public List<NMSString0x10> ProductRewardOrder;
    }
}
