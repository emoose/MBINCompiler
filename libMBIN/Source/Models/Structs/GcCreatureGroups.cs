namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x4BCB512A8DC618E2)]
    public class GcCreatureGroups : NMSTemplate
    {
		public enum CreatureGroupEnum { Solo, Couple, Group, Herd }
		public CreatureGroupEnum CreatureGroup;
    }
}
