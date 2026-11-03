namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA329D1601A19A108, NameHash = 0x15BBE80A)]
    public class GcLandingHelperComponentData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x0 */ public float ActiveDistanceMax;
        [NMS(Index = 0)]
        /* 0x4 */ public float ActiveDistanceMin;
        [NMS(Index = 2)]
        /* 0x8 */ public bool LandPoint;
    }
}
