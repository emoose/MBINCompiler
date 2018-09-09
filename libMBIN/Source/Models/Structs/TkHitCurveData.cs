namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x1B43A3BABC81D6E8)]
    public class TkHitCurveData : NMSTemplate
    {
        /* 0x000 */ public float Time;
		/* 0x004 */ public TkInOutCurve Curve;
    }
}