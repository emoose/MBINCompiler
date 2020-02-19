using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x230, Alignment = 0x8, GUID = 0xB1C47B378D57004, NameHash = 0xCFE8C2198256BF63)]
    public class GcMissionSequenceWaitForScanEvent : NMSTemplate
    {
        [NMS(Size = 0x80)]
        /* 0x000 */ public string Message;
        [NMS(Size = 0x80)]
        /* 0x080 */ public string GalaxyMapMessage;
        [NMS(Size = 0x20)]
        /* 0x100 */ public string Event;
        /* 0x120 */ public float Timeout;
        /* 0x124 */ public bool DistanceTimeout;
        [NMS(Size = 0x80)]
        /* 0x125 */ public string TimeoutOSD;
        /* 0x1A8 */ public GcScanEventGPSHint UseGPSInText;
        [NMS(Size = 0x80)]
        /* 0x1AC */ public string DebugText;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x22C */ public byte[] EndPadding;
    }
}
