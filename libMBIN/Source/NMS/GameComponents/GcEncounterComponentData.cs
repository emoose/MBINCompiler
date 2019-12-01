using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x2674E9298A78C2F2, NameHash = 0x1BAD68301EABDA5C)]
    public class GcEncounterComponentData : NMSTemplate
    {
		public enum EncounterTypeEnum { FactoryGuards, HarvesterGuards, ScrapHeap, CorruptedDroneReward }
		public EncounterTypeEnum EncounterType;
    }
}
