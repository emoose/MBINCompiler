using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x188, GUID = 0xD5ABFA48F371C2F1, NameHash = 0x210E5E8D593FFE)]
    public class GcMissionSequenceLeaveNexusMP : NMSTemplate
    {
        [NMS(Size = 0x80)]
        public string Message;
        [NMS(Size = 0x80)]
        public string MessageNoWarp;
        public ulong Timeout;
        [NMS(Size = 0x80)]
        public string DebugText;
    }
}
