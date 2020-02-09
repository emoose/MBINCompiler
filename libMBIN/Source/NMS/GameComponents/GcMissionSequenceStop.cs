using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x100, GUID = 0x6E9A343B43BE870A, NameHash = 0x9B3472E4293AC465)]
    public class GcMissionSequenceStop : NMSTemplate
    {
        [NMS(Size = 0x80)]
        /* 0x00 */ public string Message;
        [NMS(Size = 0x80)]
        /* 0x80 */ public string DebugText;
    }
}
