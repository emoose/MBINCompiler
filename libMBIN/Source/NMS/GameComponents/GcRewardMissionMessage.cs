using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Alignment = 0x8, GUID = 0x0F4171603FA4303CD)]
    public class GcRewardMissionMessage : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string MessageID;
        public bool BroadcastInMultiplayer;
        [NMS(Size = 0x7, Ignore = true)]
        public byte[] Endpadding;
    }
}
