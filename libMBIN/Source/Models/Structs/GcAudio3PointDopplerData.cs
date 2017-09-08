namespace libMBIN.Models.Structs
{
    [NMS(Size = 0xC)]
    public class GcAudio3PointDopplerData : NMSTemplate
    {
        /* 0x0 */ public float Front;
		/* 0x4 */ public float Mid;
		/* 0x8 */ public float Rear;
    }
}
