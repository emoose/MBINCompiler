namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x889FB5A8997BCAF4, NameHash = 0x884D78C2)]
    public class GcMissionConditionUnderwaterDepth : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public float Depth;
        [NMS(Index = 3)]
        /* 0x4 */ public bool InBaseCanCountAsUnderwater;
        [NMS(Index = 1)]
        /* 0x5 */ public bool ReturnTrueIfWaterBelowIsAtDepth;
        [NMS(Index = 2)]
        /* 0x6 */ public bool TakeAmountFromSeasonData;
    }
}
