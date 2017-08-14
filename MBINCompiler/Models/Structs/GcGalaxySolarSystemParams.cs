namespace MBINCompiler.Models.Structs
{
    public class GcGalaxySolarSystemParams : NMSTemplate       // size: 0x58        // used in global? cf. 0000000140258EAA in 1.30 exe
    {
        /* 0x00 */ public GcGalaxySolarSystemOrbitParams PlanetParameters;
        /* 0x1C */ public GcGalaxySolarSystemOrbitParams MoonParameters;
        [NMS(Size = 0x4, EnumValue = new[] { "Large", "Medium", "Small", "Moon" })]
        /* 0x38 */ public float[] PlanetRadii;
        /* 0x48 */ public float SystemTilt;                 // 41700000h
        /* 0x4C */ public float DefaultDistance;            // 41200000h
        /* 0x50 */ public float VisitedPlanetAlpha;         // 3F800000h
        /* 0x54 */ public float NonVisitedPlanetAlpha;      // 3ECCCCCDh
    }
}
