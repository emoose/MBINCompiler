namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x9B379844F50F9B9A)]
    public class GcPlanetHazardData : NMSTemplate
    {
        [NMS(Size = 5)]
        public float[] Temperature;

        [NMS(Size = 5)]
        public float[] Toxicity;

        [NMS(Size = 5)]
        public float[] Radiation;

        [NMS(Size = 5)]
        public float[] LifeSupportDrain;
    }
}
