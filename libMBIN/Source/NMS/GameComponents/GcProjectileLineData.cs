using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x0E18B6A30E09DD03B)]
    public class GcProjectileLineData : NMSTemplate     // size: 0x28
    {
        /* 0x000 */ public float BulletLength;
        /* 0x004 */ public float BulletGlowWidthTime;
        /* 0x008 */ public float BulletGlowWidthMax;
        /* 0x00C */ public float BulletGlowWidthMin;
        /* 0x010 */ public TkCurveType BulletGlowWidthCurve;
        /* 0x014 */ public float BulletScaler;
        /* 0x018 */ public float BulletScalerMinDist;
        /* 0x01C */ public float BulletScalerMaxDist;
        /* 0x020 */ public float BulletMinScaleDistance;
        /* 0x024 */ public float BulletMaxScaleDistance;

    }
}
