using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x0E06E78532B6DAA85)]
    public class GcMissionSequenceWaitForShips : NMSTemplate        // size: 0x108
    {
        [NMS(Size = 0x80)]
        /* 0x000 */ public string Message;
        /* 0x080 */ public GcRealityCommonFactions Type;
        /* 0x084 */ public int Count;
        [NMS(Size = 0x80)]
        /* 0x088 */ public string DebugText;
    }
}
