namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5935DE699C60F675, NameHash = 0x1AAA578F)]
    public class GcCameraShakeAction : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x10 Shake;
        [NMS(Index = 2)]
        /* 0x10 */ public float FalloffMax;
        [NMS(Index = 1)]
        /* 0x14 */ public float FalloffMin;
    }
}
