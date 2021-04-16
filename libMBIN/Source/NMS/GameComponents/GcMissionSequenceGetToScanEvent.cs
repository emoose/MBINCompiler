using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x3B8, Alignment = 0x8, GUID = 0x6F9CCC867A54ED73, NameHash = 0x4FB6689285BFE7DE)]
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
        /* 0x1B4 */ public string SurveyInactiveHint;
        [NMS(Size = 0x80)]
        /* 0x234 */ public string SurveySwapHint;
        [NMS(Size = 0x80)]
        /* 0x2B4 */ public string SurveyHint;
        [NMS(Size = 0x80)]
        /* 0x334 */ public string DebugText;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x3B4 */ public byte[] EndPadding;
    }
}
