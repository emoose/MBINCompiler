using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x52049EC71382D2EC)]
    public class GcEncounterComponentData : NMSTemplate
    {
		public enum EncounterTypeEnum { FactoryGuards, HarvesterGuards, ScrapHeap }
		public EncounterTypeEnum EncounterType;
    }
}
