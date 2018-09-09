namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x3AEA123B35FF91D2)]
    public class TkInOutCurve : NMSTemplate
    {
        /* 0x000 */ public float Midpoint;
		/* 0x004 */ public TkCurveType InCurve;
		/* 0x008 */ public TkCurveType OutCurve;
    }
}