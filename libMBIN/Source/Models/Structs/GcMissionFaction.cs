using System.Collections.Generic;

namespace libMBIN.Models.Structs
{
    public class GcMissionFaction : NMSTemplate
    {
        public int MissionFaction;
        public string[] MissionFactionValues()
        {
            return new[] { "Gek", "Korvax", "Vykeen", "TradeGuild", "WarriorGuild", "ExplorerGuild", "None" };
        }
    }
}
