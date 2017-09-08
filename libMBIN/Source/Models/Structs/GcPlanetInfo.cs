namespace libMBIN.Models.Structs
{
    public class GcPlanetInfo : NMSTemplate
    {
        [NMS(Size = 0x80)]
        public string PlanetDescription;
        [NMS(Size = 0x80)]
        public string PlanetType;
        [NMS(Size = 0x80)]
        public string Weather;
        [NMS(Size = 0x80)]
        public string Resources;
        [NMS(Size = 0x80)]
        public string Flora;
        [NMS(Size = 0x80)]
        public string Fauna;
        [NMS(Size = 0x80)]
        public string Sentinels;

        public bool IsWeatherExtreme;
        public bool AreSentinelsExtreme;
    }
}
