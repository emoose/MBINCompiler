namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC1DE051EA1E74532, NameHash = 0x90F94257)]
    public class GcSeasonalRingData : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x0 */ public float CoreOpacity;
        [NMS(Index = 1)]
        /* 0x4 */ public float RingOpacity;
        [NMS(Index = 0)]
        /* 0x8 */ public float RingSize;
    }
}
