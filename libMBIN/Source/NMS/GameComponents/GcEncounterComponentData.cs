namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x0CEFF3F9DBB70238A)]
    public class GcEncounterComponentData : NMSTemplate
    {
		public enum EncounterTypeEnum { FactoryGuards, HarvesterGuards }
		public EncounterTypeEnum EncounterType;
    }
}
