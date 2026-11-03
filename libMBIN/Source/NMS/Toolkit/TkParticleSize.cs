using libMBIN.NMS.Toolkit;

namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xF810D68E01B20722, NameHash = 0xC1679FBE)]
    public class TkParticleSize : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x000 */ public TkEmitterFloatProperty GeneralSize;
        [NMS(Index = 5, Size = 0x10)]
        /* 0x038 */ public float[] PointAmplitudes;
        [NMS(Index = 7, Size = 0x10)]
        /* 0x078 */ public float[] PointRotations;
        [NMS(Index = 6, Size = 0x10)]
        /* 0x0B8 */ public float[] PointTimes;
        [NMS(Index = 9)]
        /* 0x0F8 */ public int CurvePointCount;
        [NMS(Index = 8)]
        /* 0x0FC */ public float CurveStrength;
        [NMS(Index = 4)]
        /* 0x100 */ public float Max;
        [NMS(Index = 3)]
        /* 0x104 */ public float Min;
        [NMS(Index = 2)]
        /* 0x108 */ public int SketchCurveIndex;
        [NMS(Index = 1)]
        /* 0x10C */ public bool ManualSketchCurve;
    }
}
