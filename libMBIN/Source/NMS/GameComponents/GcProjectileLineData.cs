using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA065C08AD05D6180, NameHash = 0xF7D92F84640D5A1D)]
    public class GcProjectileLineData : NMSTemplate
    {
        /* 0x00 */ public float BulletLength;
        /* 0x04 */ public float BulletGlowWidthTime;
        /* 0x08 */ public float BulletGlowWidthMax;
        /* 0x0C */ public float BulletGlowWidthMin;
        /* 0x10 */ public TkCurveType BulletGlowWidthCurve;
        /* 0x14 */ public float BulletScaler;
        /* 0x18 */ public float BulletScalerMinDist;
        /* 0x1C */ public float BulletScalerMaxDist;
        /* 0x20 */ public float BulletMinScaleDistance;
        /* 0x24 */ public float BulletMaxScaleDistance;
    }
}
