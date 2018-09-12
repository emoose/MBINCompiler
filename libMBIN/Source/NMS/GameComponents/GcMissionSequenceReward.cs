using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Alignment = 0x8, GUID = 0x2042164FB63BCC6C)]
    public class GcMissionSequenceReward : NMSTemplate
    {
        [NMS(Size = 0x80)]
        /* 0x000 */ public string Message;
        [NMS(Size = 0x10)]
        /* 0x080 */ public string Reward;
        [NMS(Size = 0x80)]
        /* 0x090 */ public string DebugText;
    }
}
