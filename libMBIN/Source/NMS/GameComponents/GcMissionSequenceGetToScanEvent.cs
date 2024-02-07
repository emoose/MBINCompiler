using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8FC863F1FDCDA1C5, NameHash = 0x4FB6689285BFE7DE)]
    public class GcMissionSequenceGetToScanEvent : NMSTemplate
    {
        /* 0x000 */ public NMSString0x80 Message;
        /* 0x080 */ public NMSString0x80 GalaxyMapMessage;
        /* 0x100 */ public NMSString0x80 GalaxyMapMessageNotSpace;
        /* 0x180 */ public NMSString0x20A Event;
        /* 0x1A0 */ public float Distance;
        /* 0x1A4 */ public bool EndEventWhenReached;
        /* 0x1A8 */ public float Timeout;
        /* 0x1AC */ public bool DistanceTimeout;
        /* 0x1AD */ public NMSString0x80 TimeoutOSD;
        /* 0x230 */ public GcScanEventGPSHint UseGPSInText;
        /* 0x234 */ public bool CanFormatObjectives;
        /* 0x235 */ public bool AlwaysAllowInShip;
        /* 0x236 */ public NMSString0x80 SurveyInactiveHint;
        /* 0x2B6 */ public NMSString0x80 SurveySwapHint;
        /* 0x336 */ public NMSString0x80 SurveyHint;
        /* 0x3B6 */ public NMSString0x80 SurveyVehicleHint;
        /* 0x436 */ public NMSString0x80 DebugText;
    }
}
