using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x49916E75AC6E9D46, NameHash = 0x156BFFBB5A2228FA)]
    public class GcWeatherColourSettings : NMSTemplate
    {
        /* 0x00 */ public GcWeatherColourSettingList GenericSettings;
        [NMS(Size = 0x10, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0x10 */ public GcWeatherColourSettingList[] PerBiomeSettings;
    }
}
