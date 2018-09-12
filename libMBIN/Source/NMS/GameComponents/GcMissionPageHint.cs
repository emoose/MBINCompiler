using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x10BF34C1048FA823)]
    public class GcMissionPageHint : NMSTemplate
    {
		public enum MissionPageHintEnum { None, Suit, Ship, Weapon, Vehicle, Freighter, Wiki, MissionLog, Discovery, Journey }
		public MissionPageHintEnum MissionPageHint;
    }
}
