using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x18, GUID = 0x0000000000000000, NameHash = 0x9688A6EC7C08672F)]
    public class GcRewardMissionMessageToMatchingSeeds : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string MessageID;
        public bool BroadcastInMultiplayer;
        [NMS(Size = 0x7, Ignore = true)]
        public byte[] EndPadding;
    }
}
