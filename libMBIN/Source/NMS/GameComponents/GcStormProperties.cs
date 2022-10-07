using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8BF232BB98512763, NameHash = 0x82B1B19A1A57F975)]
    public class GcStormProperties : NMSTemplate
    {
        /* 0x000 */ public float Weighting;
        /* 0x004 */ public GcFogProperties Fog;
        /* 0x0F0 */ public GcWeatherColourModifiers ColourModifiers;
        // size: 0x5
        public enum HazardModifiersEnum {
            Temperature,
            Toxicity,
            Radiation,
            LifeSupportDrain,
            Gravity
        }
        [NMS(Size = 0x5, EnumType = typeof(HazardModifiersEnum))]
        /* 0x390 */ public Vector2f[] HazardModifiers;
    }
}
