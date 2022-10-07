using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA2F30B60FEF51D51, NameHash = 0x3454C9AB7AAC46D9)]
    public class GcGalaxySolarSystemParams : NMSTemplate
    {
        /* 0x00 */ public GcGalaxySolarSystemOrbitParams PlanetParameters;
        /* 0x1C */ public GcGalaxySolarSystemOrbitParams MoonParameters;
        // size: 0x4
        public enum PlanetRadiiEnum {
            Large,
            Medium,
            Small,
            Moon
        }
        [NMS(Size = 0x4, EnumType = typeof(PlanetRadiiEnum))]
        /* 0x38 */ public float[] PlanetRadii;
        /* 0x48 */ public float SystemTilt;
        /* 0x4C */ public float DefaultDistance;
        /* 0x50 */ public float VisitedPlanetAlpha;
        /* 0x54 */ public float NonVisitedPlanetAlpha;
    }
}
