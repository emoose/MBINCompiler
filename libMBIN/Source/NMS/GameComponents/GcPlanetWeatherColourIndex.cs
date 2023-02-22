namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x8B954AFB7658126B, NameHash = 0x8F4800F7EA8399A7)]
    public class GcPlanetWeatherColourIndex : NMSTemplate
    {
        // size: 0x2
        public enum WeatherColourSetEnum {
            Common,
            Rare,
        }
        /* 0x0 */ public WeatherColourSetEnum WeatherColourSet;
        /* 0x4 */ public int Index;
    }
}
