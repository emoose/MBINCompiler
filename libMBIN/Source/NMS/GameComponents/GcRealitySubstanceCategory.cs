using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x0E94EBE3C24823966)]
    public class GcRealitySubstanceCategory : NMSTemplate
    {

		public enum SubstanceCategoryEnum { Fuel, Metal, Catalyst, Stellar, Flora, Earth, Exotic, Special, BuildingPart }
		public SubstanceCategoryEnum SubstanceCategory;
    }
}
