namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x0EAA4DBFE9DCC9844)]
    public class GcRealityCommonFactions : NMSTemplate
    {
		public enum AIFactionEnum { FactionA, FactionB, FactionC, FactionD, Pirate, Police }
		public AIFactionEnum AIFaction;
    }
}
