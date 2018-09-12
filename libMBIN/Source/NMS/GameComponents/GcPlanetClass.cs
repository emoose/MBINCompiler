using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x853259960926BF67)]
    public class GcPlanetClass : NMSTemplate
    {
		public enum PlanetClassEnum { Default, Initial, InInitialSystem }
		public PlanetClassEnum PlanetClass;
    }
}
