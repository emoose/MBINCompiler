namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6FC375CAF89DF08C, NameHash = 0xF401654236F18FA9)]
    public class GcAsteroidGenerationData : NMSTemplate
    {
        /* 0x00 */ public float Scale;
        /* 0x04 */ public Vector2f ScaleVariance;
        /* 0x0C */ public int Health;
        /* 0x10 */ public float Spacing;
        /* 0x14 */ public Vector2f NoiseRange;
        /* 0x1C */ public float FadeRange;
        /* 0x20 */ public float NoiseScale;
    }
}
