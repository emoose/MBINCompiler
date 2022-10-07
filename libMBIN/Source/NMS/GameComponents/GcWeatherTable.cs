using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEB1DFB8AFF12B189, NameHash = 0x4452780AB55C81D6)]
    public class GcWeatherTable : NMSTemplate
    {
        // size: 0x10
        public enum TableEnum {
            Clear,
            Dust,
            Humid,
            Snow,
            Toxic,
            Scorched,
            Radioactive,
            RedWeather,
            GreenWeather,
            BlueWeather,
            Swamp,
            Lava,
            Bubble,
            Weird,
            Fire,
            ClearCold
        }
        [NMS(Size = 0x10, EnumType = typeof(TableEnum))]
        /* 0x000 */ public NMSString0x80[] Table;
        // size: 0x5
        public enum DefaultTemperatureEnum {
            Ambient,
            Water,
            Cave,
            Storm,
            Night
        }
        [NMS(Size = 0x5, EnumType = typeof(DefaultTemperatureEnum))]
        /* 0x800 */ public GcHazardValues[] DefaultTemperature;
        // size: 0x5
        public enum DefaultToxicityEnum {
            Ambient,
            Water,
            Cave,
            Storm,
            Night
        }
        [NMS(Size = 0x5, EnumType = typeof(DefaultToxicityEnum))]
        /* 0x828 */ public GcHazardValues[] DefaultToxicity;
        // size: 0x5
        public enum DefaultRadiationEnum {
            Ambient,
            Water,
            Cave,
            Storm,
            Night
        }
        [NMS(Size = 0x5, EnumType = typeof(DefaultRadiationEnum))]
        /* 0x850 */ public GcHazardValues[] DefaultRadiation;
    }
}
