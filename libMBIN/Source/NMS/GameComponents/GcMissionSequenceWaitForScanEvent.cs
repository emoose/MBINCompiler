using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x42BCAE879664511B, NameHash = 0xCFE8C2198256BF63)]
    public class GcMissionSequenceWaitForScanEvent : NMSTemplate
    {
        /* 0x000 */ public NMSString0x80 Message;
        /* 0x080 */ public NMSString0x80 GalaxyMapMessage;
        /* 0x100 */ public NMSString0x20A NexusMessage;
        /* 0x120 */ public NMSString0x20A Event;
        /* 0x140 */ public float Timeout;
        /* 0x144 */ public bool DistanceTimeout;
        /* 0x145 */ public NMSString0x80 TimeoutOSD;
        /* 0x1C8 */ public GcScanEventGPSHint UseGPSInText;
        /* 0x1CC */ public NMSString0x80 SurveyInactiveHint;
        /* 0x24C */ public NMSString0x80 SurveySwapHint;
        /* 0x2CC */ public NMSString0x80 SurveyHint;
        /* 0x34C */ public NMSString0x80 SurveyVehicleHint;
        /* 0x3CC */ public NMSString0x80 DebugText;
    }
}
