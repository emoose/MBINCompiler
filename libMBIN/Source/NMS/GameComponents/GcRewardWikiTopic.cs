using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x4ADB6398A852FD7B)]
    public class GcRewardWikiTopic : NMSTemplate
    {
        [NMS(Size = 0x20)]
        public string Topic;
        public bool CentreMessage;
        [NMS(Size = 0x7, Ignore = true)]
        public byte[] EndPadding;
    }
}
