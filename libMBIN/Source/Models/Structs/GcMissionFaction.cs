using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    [NMS(Alignment = 0x4)]
    public class GcMissionFaction : NMSTemplate
    {
        public int MissionFaction;
        public string[] MissionFactionValues()
        {
            return new[] { "Gek", "Korvax", "Vykeen", "TradeGuild", "WarriorGuild", "ExplorerGuild", "None" };
        }
    }
}
