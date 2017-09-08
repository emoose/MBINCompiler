namespace libMBIN.Models.Structs
{
    [NMS(Size = 0xF0)]
    public class GcCloudProperties : NMSTemplate
    {
        /* 0x00 */ public Vector2f CoverageOffset;
        /* 0x08 */ public float HorizonCoverageStart;
        /* 0x0C */ public float HorizonCoverageEnd;
        /* 0x10 */ public Colour CloudBaseColour;
        /* 0x20 */ public Colour CloudTopColour;
        /* 0x30 */ public float LightScalar;
        /* 0x34 */ public float AmbientScalar;
        /* 0x38 */ public float SunRayLength;
        /* 0x3C */ public float ConeRadius;
        /* 0x40 */ public float Density;
        /* 0x44 */ public float ForwardScatteringG;
        /* 0x48 */ public float BackwardScatteringG;
        /* 0x4C */ public float DarkOutlineScalar;
        /* 0x50 */ public float AnimationScale;
        [NMS(Size = 0xC, Ignore = true)]
        /* 0x54 */ public byte[] Padding54;
        /* 0x60 */ public Vector4f BaseOffset;
        /* 0x70 */ public Vector4f DetailOffset;
        /* 0x80 */ public float BaseScale;
        /* 0x84 */ public float SampleScalar;
        /* 0x88 */ public float SampleThreshold;
        /* 0x8C */ public float CloudBottomFade;
        /* 0x90 */ public Vector4f CloudHeightGradient1;
        /* 0xA0 */ public Vector4f CloudHeightGradient2;
        /* 0xB0 */ public Vector4f CloudHeightGradient3;
        /* 0xC0 */ public float DetailScale;
        /* 0xC4 */ public float ErosionEdgeSize;
        /* 0xC8 */ public float CloudDistortion;
        /* 0xCC */ public float CloudDistortionScale;
        /* 0xD0 */ public float MaxIterations;
        /* 0xD4 */ public float RayMinimumY;
        /* 0xD8 */ public float LODDistance;
        /* 0xDC */ public float HorizonFadeStartAlpha;
        /* 0xE0 */ public float HorizonFadeScalar;
        /* 0xE4 */ public float HorizonDistance;
        /* 0xE8 */ public float AtmosphereStartHeight;
        /* 0xEC */ public float AtmosphereEndHeight;
    }
}
