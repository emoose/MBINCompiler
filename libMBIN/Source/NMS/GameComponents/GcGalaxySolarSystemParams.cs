using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x46D508F9992D3331, NameHash = 0x3454C9AB7AAC46D9)]
    public class GcGalaxySolarSystemParams : NMSTemplate
    {
        /* 0x00 */ public GcGalaxySolarSystemOrbitParams PlanetParameters;
        /* 0x1C */ public GcGalaxySolarSystemOrbitParams MoonParameters;
        [NMS(Size = 0x4, EnumType = typeof(GcPlanetSize.PlanetSizeEnum))]
        /* 0x38 */ public float[] PlanetRadii;
        /* 0x48 */ public float SystemTilt;
        /* 0x4C */ public float DefaultDistance;
        /* 0x50 */ public float VisitedPlanetAlpha;
        /* 0x54 */ public float NonVisitedPlanetAlpha;
    }
}
