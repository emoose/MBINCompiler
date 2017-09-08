namespace libMBIN.Models.Structs
{
    public class TkInOutCurve : NMSTemplate
    {
        /* 0x000 */ public float Midpoint;
		/* 0x004 */ public TkCurveType InCurve;
		/* 0x008 */ public TkCurveType OutCurve;
    }
}