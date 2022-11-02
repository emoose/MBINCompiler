namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xD171262A3C736618, NameHash = 0xE0F2CCB358CDA3EE)]
    public class TkTrailData : NMSTemplate
    {
        /* 0x00 */ public float Width;
        /* 0x04 */ public int Points;
        /* 0x08 */ public int MaxPointsPerFrame;
        /* 0x0C */ public float DistanceThreshold;
        /* 0x10 */ public float PointLife;
        /* 0x14 */ public int FrontPoints;
        /* 0x18 */ public float FrontUvEnd;
    }
}
