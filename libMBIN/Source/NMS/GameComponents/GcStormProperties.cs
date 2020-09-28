using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x3B0, GUID = 0x8C7644C1690C9F82, NameHash = 0x82B1B19A1A57F975)]
    public class GcStormProperties : NMSTemplate
    {
        /* 0x000 */ public float Weighting;
        /* 0x004 */ public GcFogProperties Fog;
        /* 0x0E0 */ public GcWeatherColourModifiers ColourModifiers;
        [NMS(Size = 0x5, EnumType = typeof(GcHazardModifiers.HazardModifierEnum))]
        /* 0x380 */ public GcHazardValues[] HazardModifiers;        // meant to be a Vector2f. This looks nicer though in exml
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x3A8 */ public byte[] EndPadding;
    }
}
