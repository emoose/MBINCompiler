using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4107D399F60FB690, NameHash = 0xCFE8C2198256BF63)]
    public class GcMissionSequenceWaitForScanEvent : NMSTemplate
    {
        /* 0x000 */ public NMSString0x80 Message;
        /* 0x080 */ public NMSString0x80 GalaxyMapMessage;
        /* 0x100 */ public NMSString0x80 GalaxyMapMessageNotSpace;
        /* 0x180 */ public NMSString0x20A NexusMessage;
        /* 0x1A0 */ public NMSString0x20A Event;
        /* 0x1C0 */ public float Timeout;
        /* 0x1C4 */ public bool DistanceTimeout;
        /* 0x1C5 */ public NMSString0x80 TimeoutOSD;
        /* 0x248 */ public GcScanEventGPSHint UseGPSInText;
        /* 0x24C */ public NMSString0x80 SurveyInactiveHint;
        /* 0x2CC */ public NMSString0x80 SurveySwapHint;
        /* 0x34C */ public NMSString0x80 SurveyHint;
        /* 0x3CC */ public NMSString0x80 SurveyVehicleHint;
        /* 0x44C */ public NMSString0x80 DebugText;
    }
}
