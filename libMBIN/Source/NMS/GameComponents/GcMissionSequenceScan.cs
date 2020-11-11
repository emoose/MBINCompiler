using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x108, GUID = 0xB3B0E9C5F3659571, NameHash = 0x828E03CA6A18781E)]
    public class GcMissionSequenceScan : NMSTemplate
    {
        [NMS(Size = 0x80)]
        /* 0x000 */ public string Message;
        /* 0x080 */ public float WaitTime;
        /* 0x084 */ public bool BlockTimedScans;
        /* 0x085 */ public bool RequiresMissionActive;
        [NMS(Size = 0x80)]
        /* 0x086 */ public string DebugText;
        [NMS(Size = 0x2, Ignore = true)]
        /* 0x106 */ public byte[] EndPadding;
    }
}