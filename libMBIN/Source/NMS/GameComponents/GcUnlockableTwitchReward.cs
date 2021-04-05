using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x30, GUID = 0x0000000000000000, NameHash = 0xE9EC3242091011CC)]
    public class GcUnlockableTwitchReward : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string TwitchId;
        [NMS(Size = 0x10)]
        public string ProductId;
        [NMS(Size = 0x10)]
        public string LinkedGroupId;
    }
}
