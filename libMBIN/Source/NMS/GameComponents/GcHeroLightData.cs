namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4CD17645B37BA896, NameHash = 0xB846B362)]
    public class GcHeroLightData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public Colour DayColour;
        [NMS(Index = 2)]
        /* 0x10 */ public Colour NightColour;
        [NMS(Index = 3)]
        /* 0x20 */ public float DayIntensityMultiplier;
        [NMS(Index = 5)]
        /* 0x24 */ public float FOVMultiplier;
        [NMS(Index = 4)]
        /* 0x28 */ public float NightIntensityMultiplier;
        [NMS(Index = 0)]
        /* 0x2C */ public NMSString0x80 LightName;
    }
}
