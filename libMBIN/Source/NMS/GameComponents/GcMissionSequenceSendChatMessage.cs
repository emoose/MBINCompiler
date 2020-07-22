using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x30, GUID = 0x77C46ACC6C1F9835, NameHash = 0xFE8960194373227E)]
    public class GcMissionSequenceSendChatMessage : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string StatusMessageId;
        [NMS(Size = 0x20)]
        public string CustomText;
    }
}
