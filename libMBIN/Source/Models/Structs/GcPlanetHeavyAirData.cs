namespace libMBIN.Models.Structs
{
	[NMS(Size = 0x120, GUID = 0x0DD82CD3A91965CEC)]
    public class GcPlanetHeavyAirData : NMSTemplate
    {
        [NMS(Size = 0x80)]
        public string Filename;
        [NMS(Size = 5)]
        public GcHeavyAirColourData[] Colours;
    }

}
