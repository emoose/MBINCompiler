using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x0CEFF3F9DBB70238A)]
    public class GcEncounterComponentData : NMSTemplate
    {
		public enum EncounterTypeEnum { FactoryGuards, HarvesterGuards }
		public EncounterTypeEnum EncounterType;
    }
}
