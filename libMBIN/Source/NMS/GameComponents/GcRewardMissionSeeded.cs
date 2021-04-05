using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x28, GUID = 0x0, NameHash = 0x71B9EA7C3B789C6B)]
    public class GcRewardMissionSeeded : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Mission;
        [NMS(Size = 0x10)]
        public string MissionCreative;
        public bool InheritActiveMultiplayerMissionSeed;
        [NMS(Size = 0x7, Ignore = true)]
        public byte[] EndPadding;
    }
}
