namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x853259960926BF67)]
    public class GcPlanetClass : NMSTemplate
    {
		public enum PlanetClassEnum { Default, Initial, InInitialSystem }
		public PlanetClassEnum PlanetClass;
    }
}
