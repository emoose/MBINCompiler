using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x238, Alignment = 0x8, GUID = 0x172A5E650D502F46, NameHash = 0x4FB6689285BFE7DE)]
    public class GcMissionSequenceGetToScanEvent : NMSTemplate
    {
        [NMS(Size = 0x80)]
        /* 0x000 */ public string Message;
        [NMS(Size = 0x80)]
        /* 0x080 */ public string GalaxyMapMessage;
        [NMS(Size = 0x20)]
        /* 0x100 */ public string Event;
        /* 0x120 */ public float Distance;
        /* 0x124 */ public bool EndEventWhenReached;
        /* 0x128 */ public float Timeout;
        /* 0x12C */ public bool DistanceTimeout;
        [NMS(Size = 0x80)]
        /* 0x12D */ public string TimeoutOSD;
        /* 0x1B0 */ public GcScanEventGPSHint UseGPSInText;
        [NMS(Size = 0x80)]
        /* 0x1B4 */ public string DebugText;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x234 */ public byte[] EndPadding;
    }
}
