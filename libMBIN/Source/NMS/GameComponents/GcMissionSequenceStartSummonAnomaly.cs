using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB0ECCFBDAC455333, NameHash = 0x6AFB1C1263D2F6F3)]
    public class GcMissionSequenceStartSummonAnomaly : NMSTemplate
    {
        /* 0x0 */ public GcGalaxyStarAnomaly Anomaly;
        /* 0x4 */ public float SummonInFrontDistance;
        /* 0x8 */ public NMSString0x80 DebugText;
    }
}
