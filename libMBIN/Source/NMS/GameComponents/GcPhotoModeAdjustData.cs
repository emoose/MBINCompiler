using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x89656832E5D5FE94, NameHash = 0x6F5F53519B901CD4)]
    public class GcPhotoModeAdjustData : NMSTemplate
    {
        /* 0x00 */ public float AdjustMin;
        /* 0x04 */ public TkCurveType AdjustMinCurve;
        /* 0x08 */ public float AdjustMax;
        /* 0x0C */ public float AdjustMaxRange;
        /* 0x10 */ public TkCurveType AdjustMaxCurve;
        /* 0x11 */ public bool Inverted;
    }
}
