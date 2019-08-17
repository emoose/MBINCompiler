using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x10BF34C1048FA823, SubGUID = 0xBC45706D394C0853)]
    public class GcMissionPageHint : NMSTemplate
    {
		public enum MissionPageHintEnum { None, Suit, Ship, Weapon, Vehicle, Freighter, Wiki, MissionLog, Discovery, Journey }
		public MissionPageHintEnum MissionPageHint;
    }
}
