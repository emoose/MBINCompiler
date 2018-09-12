using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x20, GUID = 0x0B53F95A9735E8282)]
    public class GcPlayerMissionParticipant : NMSTemplate
    {
        public ulong UA;
        public GcSeed BuildingSeed;
        public GcPlayerMissionParticipantType ParticipantType;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] EndPadding;
    }
}
