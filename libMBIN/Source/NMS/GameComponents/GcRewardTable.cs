using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0xD0, GUID = 0xFBA26CA9ED88205D)]
    public class GcRewardTable : NMSTemplate
    {
        public List<GcGenericRewardTableEntry> GenericTable;
        public List<GcGenericRewardTableEntry> DestructionTable;
        public List<GcGenericRewardTableEntry> InteractionTable;
        public List<GcGenericRewardTableEntry> OldInteractionTable;
        public List<GcGenericRewardTableEntry> SpecialRewardTable;
        public List<GcGenericRewardTableEntry> MissionBoardTable;
        public List<GcGenericRewardTableEntry> FleetTable;
        public List<GcGenericRewardTableEntry> WikiProgressTable;
        public List<GcRewardTableEntitlementItem> EntitlementTable;
        public List<GcRewardTableEntry> Table;
        public List<NMSString0x10> TechRewardOrder;
        public List<NMSString0x10> ProductRewardOrder;
        public List<GcGenericRewardTableEntry> MixerRewardTable;

    }
}
