using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x18, GUID = 0xC752D221F93C0596)]
    public class GcRewardTableItemList : NMSTemplate
    {
		public enum RewardChoiceEnum { GiveAll, Select, SelectAlways, TryEach, SelectSilent, TryFirst_ThenSelectAlways }
		public RewardChoiceEnum RewardChoice;
        public bool OverrideZeroSeed;
        [NMS(Size = 0x3, Ignore = true)]
        public byte[] Padding5;

        public List<GcRewardTableItem> List;
    }
}
