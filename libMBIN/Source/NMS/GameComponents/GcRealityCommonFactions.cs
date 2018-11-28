using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xEAA4DBFE9DCC9844)]
    public class GcRealityCommonFactions : NMSTemplate
    {
		public enum AIFactionEnum { Player, Civilian, Pirate, Police, Creature }
		public AIFactionEnum AIFaction;
    }
}
