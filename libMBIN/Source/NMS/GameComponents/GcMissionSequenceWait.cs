using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xF1BABCCA84CF0AD5)]
    public class GcMissionSequenceWait : NMSTemplate
    {
        /* 0x0 */ public float Time;
        [NMS(Size = 0x80)]
        /* 0x4 */ public string DebugText;
    }
}
