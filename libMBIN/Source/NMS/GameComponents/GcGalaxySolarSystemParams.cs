using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD84274E8C5D76E8E, NameHash = 0x61193394)]
    public class GcGalaxySolarSystemParams : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public GcGalaxySolarSystemOrbitParams MoonParameters;
        [NMS(Index = 0)]
        /* 0x1C */ public GcGalaxySolarSystemOrbitParams PlanetParameters;
        [NMS(Index = 2, Size = 0x5, EnumType = typeof(GcPlanetSize.PlanetSizeEnum))]
        /* 0x38 */ public float[] PlanetRadii;
        [NMS(Index = 4)]
        /* 0x4C */ public float DefaultDistance;
        [NMS(Index = 6)]
        /* 0x50 */ public float NonVisitedPlanetAlpha;
        [NMS(Index = 3)]
        /* 0x54 */ public float SystemTilt;
        [NMS(Index = 5)]
        /* 0x58 */ public float VisitedPlanetAlpha;
    }
}
