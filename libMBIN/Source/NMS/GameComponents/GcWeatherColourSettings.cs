using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4E16CA695C9D0E18, NameHash = 0x7B9648E8)]
    public class GcWeatherColourSettings : NMSTemplate
    {
        [NMS(Index = 2, Size = 0x11, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0x000 */ public GcWeatherColourSettingList[] PerBiomeSettings;
        [NMS(Index = 1)]
        /* 0x110 */ public GcWeatherColourSettingList DarkSettings;
        [NMS(Index = 0)]
        /* 0x120 */ public GcWeatherColourSettingList GenericSettings;
    }
}
