namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3ACB8436BFB28746, NameHash = 0xF4DB71F6)]
    public class GcCameraShakeComponentData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 ShakeID;
        [NMS(Index = 2)]
        /* 0x10 */ public float FalloffDistanceMax;
        [NMS(Index = 1)]
        /* 0x14 */ public float FalloffDistanceMin;
    }
}
