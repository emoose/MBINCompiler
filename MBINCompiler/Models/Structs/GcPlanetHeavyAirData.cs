namespace MBINCompiler.Models.Structs
{
    [NMS(Size = 0x120)]
    public class GcPlanetHeavyAirData : NMSTemplate
    {
        [NMS(Size = 0x80)]
        public string Filename;
        [NMS(Size = 5)]
        public GcHeavyAirColourData[] Colours;
    }

}
