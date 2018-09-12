using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Alignment = 0x4, GUID = 0x8C38200C128F8196)]
    public class GcMissionFaction : NMSTemplate
    {
		public enum MissionFactionEnum { Gek, Korvax, Vykeen, TradeGuild, WarriorGuild, ExplorerGuild, None }
		public MissionFactionEnum MissionFaction;
    }
}
