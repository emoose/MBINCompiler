using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x573B7F5B56DC5AD3, NameHash = 0x156BFFBB5A2228FA)]
    public class GcWeatherColourSettings : NMSTemplate
    {
        /* 0x00 */ public GcWeatherColourSettingList GenericSettings;
        // size: 0x10
        public enum PerBiomeSettingsEnum {
            Lush,
            Toxic,
            Scorched,
            Radioactive,
            Frozen,
            Barren,
            Dead,
            Weird,
            Red,
            Green,
            Blue,
            Test,
            Swamp,
            Lava,
            Waterworld,
            All
        }
        [NMS(Size = 0x10, EnumType = typeof(PerBiomeSettingsEnum))]
        /* 0x10 */ public GcWeatherColourSettingList[] PerBiomeSettings;
    }
}
