using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xE0FD0D253EF45E76)]
    public class GcRewardNetworkPlayer : NMSTemplate
    {
        [NMS(Size = 0x40)]
        public string RewardWord;
    }
}
