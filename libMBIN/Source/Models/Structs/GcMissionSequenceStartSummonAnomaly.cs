namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x8723C02E06E012CC)]
    public class GcMissionSequenceStartSummonAnomaly : NMSTemplate      // size: 0x88
    {
        /* 0x000 */ public GcGalaxyStarAnomaly Anomaly;
        /* 0x004 */ public float SummonInFrontDistance;
        [NMS(Size = 0x80)]
        /* 0x008 */ public string DebugText;
    }
}
