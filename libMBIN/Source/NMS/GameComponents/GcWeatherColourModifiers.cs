using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x72BB5E0229EA0E0C, NameHash = 0x63BA6E198CA6237E)]
    public class GcWeatherColourModifiers : NMSTemplate
    {
        /* 0x000 */ public GcColourModifier SkyColour;
        /* 0x030 */ public GcColourModifier SkyUpperColour;
        /* 0x060 */ public GcColourModifier HorizonColour;
        /* 0x090 */ public GcColourModifier SunColour;
        /* 0x0C0 */ public GcColourModifier FogColour;
        /* 0x0F0 */ public GcColourModifier HeightFogColour;
        /* 0x120 */ public GcColourModifier LightColour;
        /* 0x150 */ public GcColourModifier CloudColour1;
        /* 0x180 */ public GcColourModifier CloudColour2;
        [NMS(Size = 0x5)]
        /* 0x1B0 */ public GcColourModifier[] HeavyAirColour;
    }
}
