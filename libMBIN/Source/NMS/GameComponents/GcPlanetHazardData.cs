namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9B379844F50F9B9A, NameHash = 0x3DB976BCF84F474B)]
    public class GcPlanetHazardData : NMSTemplate
    {
        // size: 0x5
        public enum TemperatureEnum {
            Ambient,
            Water,
            Cave,
            Storm,
            Night
        }
        [NMS(Size = 0x5, EnumType = typeof(TemperatureEnum))]
        /* 0x00 */ public float[] Temperature;
        // size: 0x5
        public enum ToxicityEnum {
            Ambient,
            Water,
            Cave,
            Storm,
            Night
        }
        [NMS(Size = 0x5, EnumType = typeof(ToxicityEnum))]
        /* 0x14 */ public float[] Toxicity;
        // size: 0x5
        public enum RadiationEnum {
            Ambient,
            Water,
            Cave,
            Storm,
            Night
        }
        [NMS(Size = 0x5, EnumType = typeof(RadiationEnum))]
        /* 0x28 */ public float[] Radiation;
        // size: 0x5
        public enum LifeSupportDrainEnum {
            Ambient,
            Water,
            Cave,
            Storm,
            Night
        }
        [NMS(Size = 0x5, EnumType = typeof(LifeSupportDrainEnum))]
        /* 0x3C */ public float[] LifeSupportDrain;
    }
}
