using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xAD3B260C6D0DB430)]
    public class GcMissionSequenceFinishSummonAnomaly : NMSTemplate      // size: 0x80
    {
        [NMS(Size = 0x80)]
        /* 0x190 */ public string DebugText;
    }
}
