using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x4150DB7F9D5B8C28)]
    public class GcRewardTableItemList : NMSTemplate        // size: 0x18
    {
		public enum RewardChoiceEnum { GiveAll, Select, SelectAlways, TryEach, SelectSilent, TryFirst_ThenSelectAlways }
		public RewardChoiceEnum RewardChoice;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] Padding4;

        public List<GcRewardTableItem> List;
    }
}
