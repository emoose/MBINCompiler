namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x79F10B99D743866F, NameHash = 0x7F9EFB9A)]
    public class GcAudio3PointDopplerData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x0 */ public float Front;
        [NMS(Index = 1)]
        /* 0x4 */ public float Mid;
        [NMS(Index = 2)]
        /* 0x8 */ public float Rear;
    }
}
