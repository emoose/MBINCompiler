using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4866C94377C9DA3, NameHash = 0xBEBEB02AB2408708)]
    public class GcMissionConditionCurrentSlope : NMSTemplate
    {
        /* 0x0 */ public float SlopeAngle;
        /* 0x4 */ public bool Abs;
        /* 0x8 */ public TkEqualityEnum Test;
    }
}
