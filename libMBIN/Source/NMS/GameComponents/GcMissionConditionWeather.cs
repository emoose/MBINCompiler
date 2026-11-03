using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x82392DC2966A2F1F, NameHash = 0x6D7B4B86)]
    public class GcMissionConditionWeather : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x0 */ public GcPlayerHazardType WeatherRequirement;
        [NMS(Index = 5)]
        /* 0x4 */ public bool AllowNonHazardExtremeIfNoStorms;
        [NMS(Index = 4)]
        /* 0x5 */ public bool IgnoreStormIfInShip;
        [NMS(Index = 0)]
        /* 0x6 */ public bool IsExtreme;
        [NMS(Index = 3)]
        /* 0x7 */ public bool StormActive;
        [NMS(Index = 1)]
        /* 0x8 */ public bool UseStrictSkyExtremeTest;
    }
}
